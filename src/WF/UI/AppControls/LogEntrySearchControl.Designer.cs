namespace LogReader.UI.AppControls {
    partial class LogEntrySearchControl : ILogEntrySearchControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (this.components != null)) {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gvResults = new System.Windows.Forms.GroupBox();
            this.searchResults = new LogEntryGridViewControl();
            this.gbSerarch = new System.Windows.Forms.GroupBox();
            this.tbMethod = new System.Windows.Forms.TextBox();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.tbThread = new System.Windows.Forms.TextBox();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.tbException = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.lblException = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.gvResults.SuspendLayout();
            this.gbSerarch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvResults
            // 
            this.gvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                           | System.Windows.Forms.AnchorStyles.Left)
                                                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.gvResults.Controls.Add(this.searchResults);
            this.gvResults.Location = new System.Drawing.Point(1, 325);
            this.gvResults.Name = "gvResults";
            this.gvResults.Size = new System.Drawing.Size(214, 334);
            this.gvResults.TabIndex = 5;
            this.gvResults.TabStop = false;
            this.gvResults.Text = "Results";
            // 
            // searchResults
            // 
            this.searchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResults.Location = new System.Drawing.Point(3, 16);
            this.searchResults.Margin = new System.Windows.Forms.Padding(0);
            this.searchResults.Name = "searchResults";
            this.searchResults.Size = new System.Drawing.Size(208, 315);
            this.searchResults.TabIndex = 0;
            // 
            // gbSerarch
            // 
            this.gbSerarch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSerarch.Controls.Add(this.tbMethod);
            this.gbSerarch.Controls.Add(this.tbHostname);
            this.gbSerarch.Controls.Add(this.tbLine);
            this.gbSerarch.Controls.Add(this.tbUserName);
            this.gbSerarch.Controls.Add(this.tbApp);
            this.gbSerarch.Controls.Add(this.tbThread);
            this.gbSerarch.Controls.Add(this.tbMachineName);
            this.gbSerarch.Controls.Add(this.tbException);
            this.gbSerarch.Controls.Add(this.tbMessage);
            this.gbSerarch.Controls.Add(this.tbFile);
            this.gbSerarch.Controls.Add(this.tbClass);
            this.gbSerarch.Controls.Add(this.lblException);
            this.gbSerarch.Controls.Add(this.tbItem);
            this.gbSerarch.Controls.Add(this.lblMessage);
            this.gbSerarch.Controls.Add(this.tbLevel);
            this.gbSerarch.Controls.Add(this.lblFile);
            this.gbSerarch.Controls.Add(this.lblLevel);
            this.gbSerarch.Controls.Add(this.lblClass);
            this.gbSerarch.Controls.Add(this.lblItem);
            this.gbSerarch.Controls.Add(this.lblHostName);
            this.gbSerarch.Controls.Add(this.lblLine);
            this.gbSerarch.Controls.Add(this.lblMethod);
            this.gbSerarch.Controls.Add(this.lblApp);
            this.gbSerarch.Controls.Add(this.lblUserName);
            this.gbSerarch.Controls.Add(this.lblThread);
            this.gbSerarch.Controls.Add(this.lblMachineName);
            this.gbSerarch.Controls.Add(this.btnCancel);
            this.gbSerarch.Location = new System.Drawing.Point(2, 0);
            this.gbSerarch.Name = "gbSerarch";
            this.gbSerarch.Size = new System.Drawing.Size(213, 300);
            this.gbSerarch.TabIndex = 4;
            this.gbSerarch.TabStop = false;
            this.gbSerarch.Text = "Search criteria";
            // 
            // tbMethod
            // 
            this.tbMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMethod.Location = new System.Drawing.Point(80, 208);
            this.tbMethod.Name = "tbMethod";
            this.tbMethod.Size = new System.Drawing.Size(120, 20);
            this.tbMethod.TabIndex = 20;
            // 
            // tbHostname
            // 
            this.tbHostname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHostname.Location = new System.Drawing.Point(80, 61);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(120, 20);
            this.tbHostname.TabIndex = 21;
            // 
            // tbLine
            // 
            this.tbLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLine.Location = new System.Drawing.Point(80, 187);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(120, 20);
            this.tbLine.TabIndex = 19;
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                           | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(80, 103);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(120, 20);
            this.tbUserName.TabIndex = 17;
            // 
            // tbApp
            // 
            this.tbApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                      | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApp.Location = new System.Drawing.Point(80, 145);
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(120, 20);
            this.tbApp.TabIndex = 18;
            // 
            // tbThread
            // 
            this.tbThread.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                         | System.Windows.Forms.AnchorStyles.Right)));
            this.tbThread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbThread.Location = new System.Drawing.Point(80, 124);
            this.tbThread.Name = "tbThread";
            this.tbThread.Size = new System.Drawing.Size(120, 20);
            this.tbThread.TabIndex = 22;
            // 
            // tbMachineName
            // 
            this.tbMachineName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                              | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMachineName.Location = new System.Drawing.Point(80, 82);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(120, 20);
            this.tbMachineName.TabIndex = 26;
            // 
            // tbException
            // 
            this.tbException.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbException.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbException.Location = new System.Drawing.Point(80, 271);
            this.tbException.Name = "tbException";
            this.tbException.Size = new System.Drawing.Size(120, 20);
            this.tbException.TabIndex = 25;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                          | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessage.Location = new System.Drawing.Point(80, 250);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(120, 20);
            this.tbMessage.TabIndex = 25;
            // 
            // tbFile
            // 
            this.tbFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFile.Location = new System.Drawing.Point(80, 229);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(120, 20);
            this.tbFile.TabIndex = 25;
            // 
            // tbClass
            // 
            this.tbClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClass.Location = new System.Drawing.Point(80, 166);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(120, 20);
            this.tbClass.TabIndex = 23;
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(26, 273);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(54, 13);
            this.lblException.TabIndex = 7;
            this.lblException.Text = "Exception";
            // 
            // tbItem
            // 
            this.tbItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                       | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItem.Location = new System.Drawing.Point(80, 40);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(120, 20);
            this.tbItem.TabIndex = 24;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(30, 252);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Message";
            // 
            // tbLevel
            // 
            this.tbLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevel.Location = new System.Drawing.Point(80, 19);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(120, 20);
            this.tbLevel.TabIndex = 16;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(53, 231);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 7;
            this.lblFile.Text = "File";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(47, 21);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(44, 168);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Class";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(53, 42);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 5;
            this.lblItem.Text = "Item";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(22, 63);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(58, 13);
            this.lblHostName.TabIndex = 6;
            this.lblHostName.Text = "Host name";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(49, 189);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(27, 13);
            this.lblLine.TabIndex = 13;
            this.lblLine.Text = "Line";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(37, 210);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 14;
            this.lblMethod.Text = "Method";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(54, 147);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(26, 13);
            this.lblApp.TabIndex = 15;
            this.lblApp.Text = "App";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(22, 105);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "User name";
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(39, 126);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(41, 13);
            this.lblThread.TabIndex = 11;
            this.lblThread.Text = "Thread";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(3, 84);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(77, 13);
            this.lblMachineName.TabIndex = 12;
            this.lblMachineName.Text = "Machine name";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(321, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(128, 302);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Search";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // LogEntrySearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gvResults);
            this.Controls.Add(this.gbSerarch);
            this.Controls.Add(this.btnOK);
            this.Name = "LogEntrySearchControl";
            this.Size = new System.Drawing.Size(215, 659);
            this.gvResults.ResumeLayout(false);
            this.gbSerarch.ResumeLayout(false);
            this.gbSerarch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gvResults;
        private LogEntryGridViewControl searchResults;
        private System.Windows.Forms.GroupBox gbSerarch;
        private System.Windows.Forms.TextBox tbMethod;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbApp;
        private System.Windows.Forms.TextBox tbThread;
        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.TextBox tbException;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
    }
}