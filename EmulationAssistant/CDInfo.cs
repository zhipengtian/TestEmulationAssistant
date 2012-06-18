using System;
using System.Net;
using System.Text;
using System.IO;
using System.Xml;
using System.Collections.Generic;

public class CDInfo {
	public String Isbn;
	public String Name;
	public String Description;
	public String Author;
	public String Year;
	public Dictionary<String, String> AdditionalIsos;

	private enum State { EMPTY, SOFTWARE, CD, ADD_ISO };

	public CDInfo() {
		this.Isbn = null;
		this.Name = null;
		this.Description = null;
		this.Author = null;
		this.Year = null;
		AdditionalIsos = new Dictionary<String, String>();
	}

	public void AddIso(String drive, String path) {
		this.AdditionalIsos.Add(drive, path);
	}
	
	public override String ToString() {
		String str = "isbn: " + this.Isbn + "\n";
		if (this.Name != null) {
			str += "name: " + this.Name + "\n";
		}
		if (this.Description != null) {
			str += "desc: " + this.Description + "\n";
		}
		if (this.Author != null) {
			str += "author: " + this.Author + "\n";
		}
		if (this.Year != null) {
			str += "year: " + this.Year + "\n";
		}
		foreach (String key in this.AdditionalIsos.Keys) {
			str += key + ": " + this.AdditionalIsos[key] + "\n";
		}
		return str;
	}

	public static List<CDInfo> GetCDInfo(String uri) {
		
		HttpWebRequest webrequest = null;
		HttpWebResponse webresponse = null;
		XmlTextReader xmlreader = null;
		CDInfo cd = null;
		List<CDInfo> cds = null;
		State xmlstate = State.EMPTY;
		String driveletter = null;
		String tmp = null;
		
		webrequest = (HttpWebRequest)WebRequest.Create(uri);
		webrequest.Credentials = CredentialCache.DefaultCredentials;
		webresponse = (HttpWebResponse) webrequest.GetResponse();
		xmlreader = new XmlTextReader(webresponse.GetResponseStream());

		while (xmlreader.Read()) {
			switch (xmlreader.NodeType) {
				case XmlNodeType.Element:
					if (xmlreader.Name.Equals("software") && xmlstate == State.EMPTY) {
						cds = new List<CDInfo>();
						xmlstate = State.SOFTWARE;
					}
					else if (xmlreader.Name.Equals("cd") && xmlstate == State.SOFTWARE) {
						cd = new CDInfo();
						tmp = xmlreader.GetAttribute("isbn");
						if (tmp == null)
						{
							throw new XmlException("Expected Attribute 'isbn'");
						}
						else { cd.Isbn = new String(tmp.ToCharArray()); }
						if ((tmp = xmlreader.GetAttribute("name")) == null)
						{
							cd.Name = String.Empty;
						}
						else { cd.Name = new String(tmp.ToCharArray()); }
						if ((tmp = xmlreader.GetAttribute("desc")) == null)
						{
							cd.Description = String.Empty;
						}
						else { cd.Description = new String(tmp.ToCharArray()); }
						if ((tmp = xmlreader.GetAttribute("author")) == null)
						{
							cd.Author = String.Empty;
						}
						else { cd.Author = new String(tmp.ToCharArray()); }
						if ((tmp = xmlreader.GetAttribute("year")) == null)
						{
							cd.Year = String.Empty;
						}
						else { cd.Year = new String(tmp.ToCharArray()); }
						xmlstate = State.CD;
					}
					else if (xmlreader.Name.Equals("addiso") && xmlstate == State.CD) {
						driveletter = xmlreader.GetAttribute("drive");
						if (driveletter == null) {
							throw new XmlException("missing drive letter or iso path");
						}
						xmlstate = State.ADD_ISO;
					}
					else {
						throw new XmlException("Improperly constructed XML file");
					}
					break; //XmlNodeType.Element
				case XmlNodeType.EndElement:
					if (xmlreader.Name.Equals("software") && xmlstate == State.SOFTWARE) {
						xmlstate = State.EMPTY;
					}
					else if (xmlreader.Name.Equals("cd") && xmlstate == State.CD) {
						cds.Add(cd);
						cd = null;
						xmlstate = State.SOFTWARE;
					}
					else if (xmlreader.Name.Equals("addiso") && xmlstate == State.ADD_ISO) {
						xmlstate = State.CD;
					}
					else {
						throw new XmlException("Improperly constructed XML file");
					}
					break; //XmlNodeType.EndElement
				case XmlNodeType.Text:
					if (xmlstate == State.ADD_ISO) {
						String isopath = xmlreader.Value;
						cd.AddIso(driveletter, isopath);
					}
					break;
			}
		}
		xmlreader.Close();
		webresponse.Close();
		return cds;
	}
}