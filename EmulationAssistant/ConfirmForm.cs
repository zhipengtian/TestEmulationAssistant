/*
Copyright 2007 Indiana University Research and Technology Corporation Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0 Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License. 
*/

//=====================================
//_________ - Mitchell Lutz - _________
//            Summer 2009             
//=====================================

using System.Windows.Forms;
using System.IO;
using System;
using System.Diagnostics;

namespace AFSBrowser {
    public partial class ConfirmForm: Form {
        private PathsForm myParent;

        //-------------------------------------------------------------
        // ConfirmForm Constructor
        //-------------------------------------------------------------
        public ConfirmForm(PathsForm parent) {
            InitializeComponent();

            this.myParent = parent;

            this.txtBoxISOpath.Text = parent.getISOpath(); // Set file or image path in text box
            //this.isoID = Path.GetFileNameWithoutExtension(this.txtBoxISOpath.Text); // isoID Example: 30000038669341

            // installScriptPath Example: \\afs\iu.edu\public\sudoc\volumes\04\30000038669341\30000038669341_install.exe
            //this.installScriptPath = Path.Combine(Path.GetDirectoryName(this.txtBoxISOpath.Text), this.isoID + "_install.exe");

            if(parent.getServiceProvider() == 1)
                this.txtBoxProvider.Text = "Workstation";
            else 
                this.txtBoxProvider.Text = "Server";
        }

        //-------------------------------------------------------------
        // Open button event
        //-------------------------------------------------------------
        private void btnContinue_Click(object sender, System.EventArgs e) {
            this.TopMost = false;
            this.myParent.TopMost = true;
            this.myParent.SetPassword(this.txtPassword.Text);
            this.myParent.StartSetup();
            this.myParent.btnCancel_SetEnabled(true);
        }

        //---------------------------------------------------------------
        // Cancel button event
        //---------------------------------------------------------------
        // Closes this.ConfirmForm, goes back to PathsForm.
        private void btnCancel_Click(object sender, System.EventArgs e) {
            this.TopMost = false;
            this.myParent.TopMost = true;
            this.Dispose();
            this.Close();
        }
    }
}