using LogReader.UI.AppControls;

namespace LogReader.UI.Shell {
    partial class ShellView {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellView));
            this.contentEntriesDetails = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbLoad = new System.Windows.Forms.ToolStripButton();
            this.tsbStart = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.tbSearch = new System.Windows.Forms.ToolStripButton();
            this.lblTotal = new System.Windows.Forms.ToolStripLabel();
            this.btnGoToPage = new System.Windows.Forms.ToolStripButton();
            this.tbGotoPage = new System.Windows.Forms.ToolStripTextBox();
            this.tsbInfo = new System.Windows.Forms.ToolStripButton();
            this.mainContiner = new System.Windows.Forms.SplitContainer();
            this.ni = new System.Windows.Forms.NotifyIcon(this.components);
            this.logEntrySearchControl = new global::LogReader.UI.AppControls.LogEntrySearchControl();
            this.logEntries = new global::LogReader.UI.AppControls.LogEntryGridViewControl();
            this.entryDetails = new global::LogReader.UI.AppControls.LogEntryDetails();
            this.contentEntriesDetails.Panel1.SuspendLayout();
            this.contentEntriesDetails.Panel2.SuspendLayout();
            this.contentEntriesDetails.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.mainContiner.Panel1.SuspendLayout();
            this.mainContiner.Panel2.SuspendLayout();
            this.mainContiner.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentEntriesDetails
            // 
            this.contentEntriesDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentEntriesDetails.Location = new System.Drawing.Point(0, 0);
            this.contentEntriesDetails.Name = "contentEntriesDetails";
            this.contentEntriesDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // contentEntriesDetails.Panel1
            // 
            this.contentEntriesDetails.Panel1.Controls.Add(this.logEntries);
            this.contentEntriesDetails.Panel1.Margin = new System.Windows.Forms.Padding(3);
            // 
            // contentEntriesDetails.Panel2
            // 
            this.contentEntriesDetails.Panel2.Controls.Add(this.entryDetails);
            this.contentEntriesDetails.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.contentEntriesDetails.Size = new System.Drawing.Size(811, 683);
            this.contentEntriesDetails.SplitterDistance = 140;
            this.contentEntriesDetails.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoad,
            this.tsbStart,
            this.tsbStop,
            this.btnPrev,
            this.btnNext,
            this.tbSearch,
            this.lblTotal,
            this.btnGoToPage,
            this.tbGotoPage,
            this.tsbInfo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1026, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbLoad
            // 
            this.tsbLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLoad.Image = global::LogReader.Properties.Resources.folder_database;
            this.tsbLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoad.Name = "tsbLoad";
            this.tsbLoad.Size = new System.Drawing.Size(23, 22);
            this.tsbLoad.Text = "Open log file";
            this.tsbLoad.Click += new System.EventHandler(this.tsbLoad_Click);
            // 
            // tsbStart
            // 
            this.tsbStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStart.Image = global::LogReader.Properties.Resources.control_play_blue;
            this.tsbStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStart.Name = "tsbStart";
            this.tsbStart.Size = new System.Drawing.Size(23, 22);
            this.tsbStart.Text = "Start listening";
            this.tsbStart.Click += new System.EventHandler(this.tsbStart_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbStop.Image = ((System.Drawing.Image)(resources.GetObject("tsbStop.Image")));
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(23, 22);
            this.tsbStop.Text = "Stop listening";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Image = global::LogReader.Properties.Resources.control_rewind_blue;
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 22);
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = global::LogReader.Properties.Resources.control_fastforward_blue;
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.CheckOnClick = true;
            this.tbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSearch.Image = global::LogReader.Properties.Resources.find;
            this.tbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(23, 22);
            this.tbSearch.Text = "Search";
            this.tbSearch.CheckedChanged += new System.EventHandler(this.tbSearch_CheckedChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 22);
            this.lblTotal.Tag = "Pages:";
            this.lblTotal.Text = "Pages:";
            // 
            // btnGoToPage
            // 
            this.btnGoToPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnGoToPage.Image = ((System.Drawing.Image)(resources.GetObject("btnGoToPage.Image")));
            this.btnGoToPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoToPage.Name = "btnGoToPage";
            this.btnGoToPage.Size = new System.Drawing.Size(64, 22);
            this.btnGoToPage.Text = "Go to page";
            this.btnGoToPage.Click += new System.EventHandler(this.btnGoToPage_Click);
            // 
            // tbGotoPage
            // 
            this.tbGotoPage.Name = "tbGotoPage";
            this.tbGotoPage.Size = new System.Drawing.Size(35, 25);
            // 
            // tsbInfo
            // 
            this.tsbInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInfo.Image = global::LogReader.Properties.Resources.script;
            this.tsbInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInfo.Name = "tsbInfo";
            this.tsbInfo.Size = new System.Drawing.Size(23, 22);
            this.tsbInfo.Text = "Target app config";
            this.tsbInfo.Click += new System.EventHandler(this.tsbInfo_Click);
            // 
            // mainContiner
            // 
            this.mainContiner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContiner.Location = new System.Drawing.Point(0, 25);
            this.mainContiner.Name = "mainContiner";
            // 
            // mainContiner.Panel1
            // 
            this.mainContiner.Panel1.Controls.Add(this.logEntrySearchControl);
            this.mainContiner.Panel1MinSize = 0;
            // 
            // mainContiner.Panel2
            // 
            this.mainContiner.Panel2.Controls.Add(this.contentEntriesDetails);
            this.mainContiner.Size = new System.Drawing.Size(1026, 683);
            this.mainContiner.SplitterDistance = 211;
            this.mainContiner.TabIndex = 7;
            // 
            // ni
            // 
            this.ni.Icon = ((System.Drawing.Icon)(resources.GetObject("ni.Icon")));
            this.ni.Text = "Log reader";
            this.ni.Visible = true;
            // 
            // logEntrySearchControl
            // 
            this.logEntrySearchControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logEntrySearchControl.Location = new System.Drawing.Point(0, 0);
            this.logEntrySearchControl.Name = "logEntrySearchControl";
            this.logEntrySearchControl.OnLogEntrySelected = null;
            this.logEntrySearchControl.OnSearchByExample = null;
            this.logEntrySearchControl.Size = new System.Drawing.Size(211, 683);
            this.logEntrySearchControl.TabIndex = 0;
            // 
            // logEntries
            // 
            this.logEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logEntries.Location = new System.Drawing.Point(0, 0);
            this.logEntries.Margin = new System.Windows.Forms.Padding(0);
            this.logEntries.Name = "logEntries";
            this.logEntries.Size = new System.Drawing.Size(811, 140);
            this.logEntries.TabIndex = 0;
            // 
            // entryDetails
            // 
            this.entryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryDetails.Location = new System.Drawing.Point(0, 0);
            this.entryDetails.Name = "entryDetails";
            this.entryDetails.Size = new System.Drawing.Size(811, 539);
            this.entryDetails.TabIndex = 0;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 708);
            this.Controls.Add(this.mainContiner);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShellView";
            this.ShowInTaskbar = false;
            this.Text = "Log reader";
            this.contentEntriesDetails.Panel1.ResumeLayout(false);
            this.contentEntriesDetails.Panel2.ResumeLayout(false);
            this.contentEntriesDetails.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainContiner.Panel1.ResumeLayout(false);
            this.mainContiner.Panel2.ResumeLayout(false);
            this.mainContiner.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer contentEntriesDetails;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbLoad;
        private System.Windows.Forms.ToolStripButton tsbStart;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton tbSearch;
        private System.Windows.Forms.ToolStripLabel lblTotal;
        private System.Windows.Forms.ToolStripTextBox tbGotoPage;
        private System.Windows.Forms.ToolStripButton btnGoToPage;
        private System.Windows.Forms.ToolStripButton tsbInfo;
        private LogEntryGridViewControl logEntries;
        private LogEntryDetails entryDetails;
        private System.Windows.Forms.SplitContainer mainContiner;
        private LogEntrySearchControl logEntrySearchControl;
        internal System.Windows.Forms.NotifyIcon ni;
    }
}