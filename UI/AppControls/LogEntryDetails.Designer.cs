namespace LogReader.UI.AppControls {
    partial class LogEntryDetails {
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
            this.gbEntry = new System.Windows.Forms.GroupBox();
            this.tbMethod = new System.Windows.Forms.TextBox();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbApp = new System.Windows.Forms.TextBox();
            this.tbThread = new System.Windows.Forms.TextBox();
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.tbTimeStamp = new System.Windows.Forms.TextBox();
            this.tbFile = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.tbLevel = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbThrowable = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblTimeStamp = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblThread = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.gbEntry.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEntry
            // 
            this.gbEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                         | System.Windows.Forms.AnchorStyles.Left)
                                                                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbEntry.Controls.Add(this.tbMethod);
            this.gbEntry.Controls.Add(this.tbHostname);
            this.gbEntry.Controls.Add(this.tbLine);
            this.gbEntry.Controls.Add(this.tbUserName);
            this.gbEntry.Controls.Add(this.tbApp);
            this.gbEntry.Controls.Add(this.tbThread);
            this.gbEntry.Controls.Add(this.tbMachineName);
            this.gbEntry.Controls.Add(this.tbTimeStamp);
            this.gbEntry.Controls.Add(this.tbFile);
            this.gbEntry.Controls.Add(this.tbClass);
            this.gbEntry.Controls.Add(this.tbItem);
            this.gbEntry.Controls.Add(this.tbLevel);
            this.gbEntry.Controls.Add(this.lblFile);
            this.gbEntry.Controls.Add(this.tabControl1);
            this.gbEntry.Controls.Add(this.lblLevel);
            this.gbEntry.Controls.Add(this.lblClass);
            this.gbEntry.Controls.Add(this.lblTimeStamp);
            this.gbEntry.Controls.Add(this.lblItem);
            this.gbEntry.Controls.Add(this.lblHostName);
            this.gbEntry.Controls.Add(this.lblLine);
            this.gbEntry.Controls.Add(this.lblMethod);
            this.gbEntry.Controls.Add(this.lblApp);
            this.gbEntry.Controls.Add(this.lblUserName);
            this.gbEntry.Controls.Add(this.lblThread);
            this.gbEntry.Controls.Add(this.lblMachineName);
            this.gbEntry.Location = new System.Drawing.Point(0, 0);
            this.gbEntry.Name = "gbEntry";
            this.gbEntry.Size = new System.Drawing.Size(820, 323);
            this.gbEntry.TabIndex = 4;
            this.gbEntry.TabStop = false;
            this.gbEntry.Text = "Log entry";
            // 
            // tbMethod
            // 
            this.tbMethod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMethod.Location = new System.Drawing.Point(59, 93);
            this.tbMethod.Name = "tbMethod";
            this.tbMethod.Size = new System.Drawing.Size(605, 20);
            this.tbMethod.TabIndex = 3;
            // 
            // tbHostname
            // 
            this.tbHostname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbHostname.Location = new System.Drawing.Point(242, 43);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(100, 20);
            this.tbHostname.TabIndex = 3;
            // 
            // tbLine
            // 
            this.tbLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLine.Location = new System.Drawing.Point(703, 93);
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(100, 20);
            this.tbLine.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUserName.Location = new System.Drawing.Point(454, 43);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 3;
            // 
            // tbApp
            // 
            this.tbApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbApp.Location = new System.Drawing.Point(626, 43);
            this.tbApp.Name = "tbApp";
            this.tbApp.Size = new System.Drawing.Size(177, 20);
            this.tbApp.TabIndex = 3;
            // 
            // tbThread
            // 
            this.tbThread.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbThread.Location = new System.Drawing.Point(703, 19);
            this.tbThread.Name = "tbThread";
            this.tbThread.Size = new System.Drawing.Size(100, 20);
            this.tbThread.TabIndex = 3;
            // 
            // tbMachineName
            // 
            this.tbMachineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMachineName.Location = new System.Drawing.Point(454, 19);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(100, 20);
            this.tbMachineName.TabIndex = 3;
            // 
            // tbTimeStamp
            // 
            this.tbTimeStamp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTimeStamp.Location = new System.Drawing.Point(242, 19);
            this.tbTimeStamp.Name = "tbTimeStamp";
            this.tbTimeStamp.Size = new System.Drawing.Size(100, 20);
            this.tbTimeStamp.TabIndex = 3;
            // 
            // tbFile
            // 
            this.tbFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFile.Location = new System.Drawing.Point(59, 120);
            this.tbFile.Name = "tbFile";
            this.tbFile.Size = new System.Drawing.Size(744, 20);
            this.tbFile.TabIndex = 3;
            // 
            // tbClass
            // 
            this.tbClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbClass.Location = new System.Drawing.Point(59, 68);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(744, 20);
            this.tbClass.TabIndex = 3;
            // 
            // tbItem
            // 
            this.tbItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbItem.Location = new System.Drawing.Point(59, 43);
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(100, 20);
            this.tbItem.TabIndex = 3;
            // 
            // tbLevel
            // 
            this.tbLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLevel.Location = new System.Drawing.Point(59, 18);
            this.tbLevel.Name = "tbLevel";
            this.tbLevel.Size = new System.Drawing.Size(100, 20);
            this.tbLevel.TabIndex = 2;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(10, 122);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                                                             | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 153);
            this.tabControl1.MinimumSize = new System.Drawing.Size(0, 160);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(817, 167);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbMessage);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbMessage
            // 
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMessage.Location = new System.Drawing.Point(3, 3);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(803, 132);
            this.tbMessage.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbThrowable);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Throwable";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbThrowable
            // 
            this.tbThrowable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbThrowable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbThrowable.Location = new System.Drawing.Point(3, 3);
            this.tbThrowable.Multiline = true;
            this.tbThrowable.Name = "tbThrowable";
            this.tbThrowable.Size = new System.Drawing.Size(803, 132);
            this.tbThrowable.TabIndex = 1;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(10, 21);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Level";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(11, 70);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // lblTimeStamp
            // 
            this.lblTimeStamp.AutoSize = true;
            this.lblTimeStamp.Location = new System.Drawing.Point(175, 21);
            this.lblTimeStamp.Name = "lblTimeStamp";
            this.lblTimeStamp.Size = new System.Drawing.Size(61, 13);
            this.lblTimeStamp.TabIndex = 0;
            this.lblTimeStamp.Text = "Time stamp";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(10, 45);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(27, 13);
            this.lblItem.TabIndex = 0;
            this.lblItem.Text = "Item";
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(175, 45);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(58, 13);
            this.lblHostName.TabIndex = 0;
            this.lblHostName.Text = "Host name";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Location = new System.Drawing.Point(670, 95);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(27, 13);
            this.lblLine.TabIndex = 0;
            this.lblLine.Text = "Line";
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(10, 95);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(43, 13);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "Method";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(580, 45);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(26, 13);
            this.lblApp.TabIndex = 0;
            this.lblApp.Text = "App";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(371, 45);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(58, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User name";
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Location = new System.Drawing.Point(656, 21);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(41, 13);
            this.lblThread.TabIndex = 0;
            this.lblThread.Text = "Thread";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Location = new System.Drawing.Point(371, 21);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(77, 13);
            this.lblMachineName.TabIndex = 0;
            this.lblMachineName.Text = "Machine name";
            // 
            // LogEntryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbEntry);
            this.Name = "LogEntryDetails";
            this.Size = new System.Drawing.Size(820, 323);
            this.gbEntry.ResumeLayout(false);
            this.gbEntry.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEntry;
        private System.Windows.Forms.TextBox tbMethod;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbApp;
        private System.Windows.Forms.TextBox tbThread;
        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.TextBox tbTimeStamp;
        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.TextBox tbLevel;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbThrowable;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblTimeStamp;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Label lblMachineName;
    }
}