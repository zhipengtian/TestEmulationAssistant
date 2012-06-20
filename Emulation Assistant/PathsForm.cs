/*
Copyright 2007 Indiana University Research and Technology Corporation Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/

//=====================================
//_________ - Mitchell Lutz - _________

//            Summer 2009             
//=====================================

using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;

namespace AFSBrowser {
    public partial class PathsForm : Form {
        private string isoPath;
        private string vmxPath;
        private string vmDesk = "C:\\Documents and Settings\\iucs\\Desktop";
        private string installScriptPath = "";
        private ConfirmForm confirmForm;
        private BackgroundWorker worker1;
        private string pass = "";
        private List<String> discks;

        //-------------------------------------------------------------
        // First Page Constructor
        //-------------------------------------------------------------
        public PathsForm(string webPath) {
            InitializeComponent();
            if(webPath != "") {
                this.txtBoxISOpath.Text = webPath;
            }
            else {
                //this.txtBxISOpath.Text = "";
            }
            worker1 = new System.ComponentModel.BackgroundWorker();
            worker1.WorkerSupportsCancellation = true; 
            worker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Setup);
            worker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Finished);
        }

        public void btnCancel_SetEnabled(bool e) {
            btnCancel.Enabled = e;
        }

        public void SetPassword(string password) {
            this.pass = password;
            this.pass = "Informatics2011";
        }

        //-------------------------------------------------------------
        // Next button Event
        //-------------------------------------------------------------
        private void btnContinue_Click(object sender, EventArgs e) {
            string pathError = ""; // Error from isFileValid. Is empty if not error.
            // Set vmxPath and isoPath for ConfirmForm to use
            this.vmxPath = this.txtBxConfig.Text;
            this.isoPath = this.txtBoxISOpath.Text;

            // pathError equals the error for vmxPath, if there is one.
            // If there is no error, pathError should = ""
            pathError = isFileValid(this.vmxPath, ".vmx");

            // Check to see if there was a problem with vmxPath
            if(pathError.Equals("")) {
                // If there is no error with vmxPath, now do the same error check with isoPath.
                if (this.isoPath.EndsWith(".iso")) {
                    pathError = isFileValid(this.isoPath, ".iso");
                }
                else if (this.isoPath.EndsWith(".img")) {
                    pathError = isFileValid(this.isoPath, ".img");
                }
                else {
                    pathError = "The file: \n\n " + this.isoPath + "\n\nis not a supported file format (.iso or .img)";
                }
                // Check to see if there was an error with isoPath.
                if(pathError.Equals("")) { 
                    //If there was not an error, make a confirmation page and show it.
                    DirectoryInfo di = new DirectoryInfo(Path.GetDirectoryName(this.isoPath));
                    FileInfo[] disckFiles = di.GetFiles("*" + Path.GetExtension(this.isoPath));
                    discks = new List<string>();
                    foreach (FileInfo iso in disckFiles)
                    {
                        //MessageBox.Show(iso.Name);
                        discks.Add(iso.Name);
                    }

                    discks.Sort();

                    this.installScriptPath = Path.Combine(Path.GetDirectoryName(this.isoPath), Path.GetFileNameWithoutExtension(discks[0]) + "_install.exe");
                    
                    confirmForm = new ConfirmForm(this);
                    this.TopMost = false;
                    confirmForm.ShowDialog();
                    confirmForm.TopMost = true;
                }
                // Else there was an error from isoPath, Message is displayed.
                else { 
                    MessageBox.Show(pathError, "Error!");
                }
            }
            // Else there was an error from vmxPath, Message is displayed.
            else {
                MessageBox.Show(pathError, "Error!");
            }
        }
        
        // ifFileValid(...) takes path and ext (extension), and returns an error string. If the file located 
        // at 'path' is valid and of the file type 'ext', no error is thrown, and isFileValid returns the empty 
        // string. If the file is invalid, isFileValid return a string which tells why the error is thrown. This 
        // allows the caller of isFileValid can display the error string in a MessageBox.
        private string isFileValid(string path, string ext) {
            string error;
            if(path != "") {
                // If file in string 'path' ends with ext, file is still valid. (Just validates the string path with string ext, no files checked yet)
                if(path.EndsWith(ext)) {
                    // If File located at path exists, file is still valid.
                    if(File.Exists(path)) {
                        // If we get here, file ends with ext and does exist at the location provided. No error thrown.
                        error = "";
                    }
                    // Else file does not exist.
                    else {
                        error = "The file: \n\n  " + path + "\n\ndoes not exist.";
                    }
                }
                // Else file is not of the proper extension
                else {
                    error = "The file: \n " + path + "\n\nis not of the proper file type (" + ext + ").";
                }
            }
            // Else the path for this file is empty.
            else {
                error = "The field for the " + ext + " file is blank, please enter a valid path.";
            }
            return error;
        }

        //-------------------------------------------------------------
        // Browse button Event
        //-------------------------------------------------------------
        private void btnBrowse_Click(object sender, EventArgs e) {
            this.openAfsFD.FileName = ""; // Make the file textBox initially empty
            
            if(Directory.Exists("\\\\afs\\iu.edu\\public\\sudoc\\volumes")) {
                // Set the directory for the OpenFileDialog to start at
                this.openAfsFD.InitialDirectory = "\\\\afs\\iu.edu\\public\\sudoc\\volumes";
                //this.openAfsFD.InitialDirectory = "\\\\afs\\iu.edu\\public\\sudoc\\volumes";
                this.openAfsFD.Filter = ".ISO|*.iso|.IMG|*.img";//Only allow .ISO and .IMG files to be opened/mounted.
            }
            else {
                MessageBox.Show("Could not access the AFS. \n\nPlease make sure that you are allowed access to the AFS.", "Note!");
                this.openAfsFD.InitialDirectory = "C:\\";
            }
            this.openAfsFD.ShowDialog(); //Show the OpenFileDialog.
        
            // This check makes it so the text box is not reset if the user has not selected anything.
            // Example: The user types something in then clicks browse button but does not find what
            // they are looking for, so they click cancel. This check makes it so what they typed
            // is not cleared.
            if(this.openAfsFD.FileName != "") {
                this.txtBoxISOpath.Text = this.openAfsFD.FileName; // Set texbox's text to the ISO the user has chose to open.
            }
        }

        //--------------------------------------------------------------
        // Config Browse button Event
        //--------------------------------------------------------------
        private void btnConfigBrowse_Click(object sender, EventArgs e) {
            this.openConfigFD.FileName = "";

            // Check if a Virtual Machines Directory exists.
            if(Directory.Exists("C:\\Virtual Machines\\")) {
                this.openConfigFD.InitialDirectory = "C:\\Virtual Machines\\";
            }
            else {
                openConfigFD.InitialDirectory = "C:\\";
            }

            this.openConfigFD.Filter = ".vmx|*.vmx";
            this.openConfigFD.ShowDialog();

            // This check makes it so the text box is not reset if the user has not selected anything.
            // Example: The user types something in then clicks browse button but does not find what
            // they are looking for, so they click cancel. This check makes it so what they typed
            // is not cleared.
            if(this.openConfigFD.FileName != "") {
                this.txtBxConfig.Text = this.openConfigFD.FileName; // Set texbox's text to the .VMX the user has specified.
            }
        }

        //-------------------------------------------------------------
        // Return if user chose: Workstation, Console or Nothing yet.
        //-------------------------------------------------------------
        public int getServiceProvider() {
            // 0 = none
            // 1 = Workstation
            // 2 = Server Console
            if (cmbServiceProvider.SelectedIndex == 1) {
                return 1;
            }
            else if (cmbServiceProvider.SelectedIndex == 0) {
                return 2;
            }
            else {
                return 0;
            }
        }

        //---------------------------------------------------------
        // Returns isoPath
        //---------------------------------------------------------
        public string getISOpath() {
            return this.isoPath;
        }

        //---------------------------------------------------------
        // Returns vmxPath
        //---------------------------------------------------------
        public string getVMXpath() {
            return this.vmxPath;
        }

        private void PathsForm_Load(object sender, EventArgs e) {
            cmbServiceProvider.SelectedIndex = 0;
        }

        private bool Check(BackgroundWorker bw, VixWrapper vix, DoWorkEventArgs e) {
            if (bw.CancellationPending) {
                this.txtStatusBar.Text = "Canceling. . .";
                vix.PowerOff();
                vix.Disconnect();
                e.Cancel = true;
                return true;
            }
            else {
                return false;
            }
        }

        // ______________________________________________________________
        // |                                                             |
        // V                                                             |
        public void Setup(object sender, DoWorkEventArgs e) { //best solution possible // <--- worst comment ever
            string[] configVars;
            string[] configVals;
            string vmxPath = this.getVMXpath();
            string userName = "iucs";
            string virtualPassword = "vmware";
            int provider = (int)e.Argument;
            BackgroundWorker bw = sender as BackgroundWorker;

            int result = 0;

            // Create a VixWrapper to automate the VM.
            VixWrapper vix = new VixWrapper();

            // vix.Connect(hostname, username, password) You can use specific values for these,
            // however its not necessary. I figure null will be more compatible.
            this.txtStatusBar.Text = "Connecting with VMware. . .";
            
            // Begin the VMware automation
            if (vix.Connect(null, null, this.pass, provider))
            {
                this.txtStatusBar.Text = "Opening the .VMX file. . ."; // Update status bar.
                if (provider == 2)
                {
                    MessageBox.Show(PathByDatastore(vmxPath));
                    vix.Open(PathByDatastore(vmxPath));
                }
                else if (provider == 1)
                {
                    vix.Open(vmxPath); // Open the .vmx file.
                }

                //MessageBox.Show("Test");

                if (Check(bw, vix, e)) return;

                this.txtStatusBar.Text = "Reverting to the most recent snapshot. . ."; // Update status bar.
                vix.RevertToLastSnapshot();  // Revert to most recent snapshot.

                if (Check(bw, vix, e)) return;

                this.txtStatusBar.Text = "Editing the virtual machine's configuration file. . ."; // Update status bar.

                // Check if we're mounting an .iso image (CD).
                if (this.isoPath.EndsWith(".iso"))
                {

                    // Create array for configuation (.vmx file) VARIABLES (to mount CD).
                    configVars = new string[14] { "ide1:0.fileName = ", "ide1:0.deviceType = ", "ide1:0.startConnected = ", "ide1:0.present = ",
                                                  "ide0:1.fileName = ", "ide0:1.deviceType = ", "ide0:1.startConnected = ", "ide0:1.present = ",
                                                  "ide1:1.fileName = ", "ide1:1.deviceType = ", "ide1:1.startConnected = ", "ide1:1.present = ",
                                                  "floppy0.fileName = ", "floppy0.startConnected = "};

                    // Create array for configuation (.vmx file) VALUES (to mount CD).
                    configVals = new string[14] { "", "cdrom-image", "TRUE", "FALSE",
                                                  "", "cdrom-image", "TRUE", "FALSE",
                                                  "", "cdrom-image", "TRUE", "FALSE",
                                                  "A:", "FALSE"};

                    for (int i = 0; (i / 4) < discks.Count; i += 4)
                    {
                        configVals[i] = Path.GetDirectoryName(this.isoPath) + "\\" + discks[i / 4];
                        configVals[i + 3] = "TRUE";
                    }

                    // Edit VM configuration file so .ISO is mounted as the VM's D: drive.
                    editConfigFile(vmxPath, configVars, configVals);
                }
                // Check if we're mounting an .img file (Floppy Disc).
                else if (this.isoPath.EndsWith(".img"))
                {
                    // Create array for configuation (.vmx file) VARIABLES (to mount floppy).
                    configVars = new string[6] { "floppy0.fileName = ", "floppy0.fileType = ", "floppy0.clientDevice = ", "floppy0.startConnected = ", "ide1:0.fileName = ", "ide1:0.startConnected = " };
                    // Create array for configuation (.vmx file) VALUES (to mount floppy). 
                    configVals = new string[6] { this.isoPath, "file", "FALSE", "TRUE", "D:", "FALSE" };
                    // Edit VM configuration file so floppy is mounted as the VM's A: drive.
                    editConfigFile(vmxPath, configVars, configVals);
                }
                // We should never get here because of checks in pathForm.
                // Getting here would be the result of an invalid file format, shouldn't be possible.
                else
                {
                    // Error.
                }

                if (Check(bw, vix, e)) return;

                this.txtStatusBar.Text = "Powering on the virtual machine. . ."; // Update status bar.
                vix.PowerOn(); // Power on the virtual machine.

                if (Check(bw, vix, e)) return;

                this.txtStatusBar.Text = "Logging in to the virtual machine as " + userName + ". . ."; // Update status bar.
                vix.LogIn(userName, virtualPassword); // Log in to the virtual machine.

                if (Check(bw, vix, e)) return;

                // Check to see if there is an install script for the file or image.
                this.txtStatusBar.Text = "Checking for an install script. . .";  // Update status bar.
                if (File.Exists(this.installScriptPath))
                {
                    vix.LogIn(userName, virtualPassword);  // CopyFileToVm does not work without this second log in, I am not sure why.

                    this.txtStatusBar.Text = "Copying install script to: " + this.vmDesk + " . . ."; // Update status bar.
                    // Copy the install script to the desktop of the VM.
                    vix.CopyFileToVm(this.installScriptPath, Path.Combine(this.vmDesk, Path.GetFileName(this.installScriptPath)));

                    if (Check(bw, vix, e)) return;

                    vix.LogIn(userName, virtualPassword); // Log-in to the VM.

                    this.txtStatusBar.Text = "Installing the programs that are required to utilize this .ISO image. . .";  // Update status bar.
                    
                    /*
                     * If the autoit script doens't complete successfully the program cannot be stopped.
                     */
                    vix.RunProgram(Path.Combine(this.vmDesk, Path.GetFileName(this.installScriptPath)), "", out result); // Run install script in the virtual machine.
                    MessageBox.Show("Result 1 = " + result);
                    vix.RunProgram("C:\\Program Files\\PuTTY\\putty.exe", "", out result);
                    MessageBox.Show("Result 2 = " + result);
                    //vix.RunProgram("C:\\Program Files\\Adobe\\Reader 10.0\\Reader\\AcroRd32.exe", "D:\\1st_page.pdf", out result);

                    this.txtStatusBar.Text = "Finishing up. . ."; // Update status bar.
                }
                else
                {
                    // Show Message if there is not an install script.\
                    e.Cancel = true;
                    MessageBox.Show("This file or image does not have an install script! Program will exit.");
                }
            }
            else
            {
                // Show Message if we cannot connect to the VM.
                MessageBox.Show("Could not connect to VMware. \n\nPlease check your service provider and password.", "Error 1415926535897932384626433832795028841971 :(");
                e.Cancel = true;
            }
        }

        //-------------------------------------------------------------
        // Edit VM config file (Mount .ISO image as the cd drive)
        //-------------------------------------------------------------
        private bool editConfigFile(string file, String[] configVars, String[] configVals)
        {
            StreamWriter sw = null;
            FileStream fs = new FileStream(file, FileMode.Open);
            StreamReader sr = new StreamReader(fs);

            string line = "";
            string lineBuffer = "";

            bool lineFound = false; // lineFound is in case "ide1:0.fileName =" appears more than once so only 1 line is changed.

            // Read every line, one line at a time, until the EOF.
            while ((line = sr.ReadLine()) != null)
            {
                // for each each variable in configVars check to see if matches line read
                for (int i = 0; i < configVars.Length; i++)
                {
                    if (!(configVars[i].Equals("")) && line.Contains(configVars[i]))
                    {
                        lineBuffer += configVars[i] + "\"" + configVals[i] + "\"" + "\r\n";
                        configVars[i] = "";
                        lineFound = true;
                    }
                }
                // If have not found what the wanted line, line remains the same and is added to lineBuffer.
                if (lineFound == false)
                {
                    lineBuffer += (line + "\r\n");
                }
                // Else we did find the line
                // Set lineFound to false so we can look for remaining lines.
                else
                {
                    lineFound = false;
                }
            }

            for (int i = 0; i < configVars.Length; i++) {
                if (!(configVars[i].Equals("")))
                {
                    lineBuffer += configVars[i] + configVals[i] + "\r\n";
                }
            }

            sr.Close(); // Close StreamReader
            fs.Close(); // Close FileStream so it can be used to create (replace) the config file

            fs = new FileStream(file, FileMode.Create);
            sw = new StreamWriter(fs);
            sw.Write(lineBuffer); // Write lineBuffer, which is the entire config file with our .ISO mounted, to the new config file.

            sw.Close();  // Close StreamWriter.
            fs.Close(); // Close FileStream.
            // Return lineFound (bool), this will tell whether "ide1:0.fileName =" was found or not. 
            return lineFound;
        }

        private string PathByDatastore(string vmPath) {
            System.Xml.XmlReader xmlData = System.Xml.XmlReader.Create("C:\\ProgramData\\VMware\\VMware Server\\hostd\\datastores.xml");
            KeyValuePair<string, string>[] datastores = new KeyValuePair<string, string>[100];
            int i = 0;
            string name, path;

            while (xmlData.ReadToFollowing("name") && (i < 100)) {
                xmlData.Read();
                name = xmlData.Value;
                xmlData.ReadToFollowing("path");
                xmlData.Read();
                path = xmlData.Value;
                if (!path.EndsWith("\\"))
                {
                    path += "\\";
                }
                datastores[i++] = new KeyValuePair<string, string>(name, path);
            }

            for (int j = 0; j < i; j++) {
                if (vmPath.Contains(datastores[j].Value)) {
                    return "[" + datastores[j].Key + "] " + vmPath.Substring(datastores[j].Value.Length);
                }
            }

            return null;
        }

        public void StartSetup() {
            confirmForm.Dispose();
            confirmForm.Close();
            this.TopMost = false;

            this.worker1.RunWorkerAsync(this.getServiceProvider());
            this.btnContinue.Enabled = false;
        }

        public void Finished(object sender, RunWorkerCompletedEventArgs e) {
            if (!e.Cancelled) {
                this.Dispose();
                this.Close();
                Application.Exit();
            }
            this.btnCancel_SetEnabled(false);
            this.btnContinue.Enabled = true;
            this.txtStatusBar.Text = "";
        }

        //--------------------------------------------------------
        // Quit button Event
        //--------------------------------------------------------
        // Terminates application
        private void btnQuit_Click(object sender, EventArgs e) {
            this.Dispose();
            // Close the application.
            Application.Exit();
        }

        //--------------------------------------------------------
        // Cancel button Event
        //--------------------------------------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.worker1.CancelAsync();
            this.btnCancel.Enabled = false;
        }

        private void txtBoxISOpath_TextChanged(object sender, EventArgs e)
        {
            // Check to see if there is a help file.
            // If there is a button is added to the form so the user can view the help file.
            try
            {
                if (File.Exists(Path.Combine(Path.GetDirectoryName(this.txtBoxISOpath.Text), "index.html")))
                    this.btnHelp.Visible = true;
                else
                    this.btnHelp.Visible = false;
            }
            catch (ArgumentException)
            {
                this.btnHelp.Visible = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Process.Start(Path.Combine(Path.GetDirectoryName(this.txtBoxISOpath.Text), "index.html"));
        }

        private void txtStatusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}