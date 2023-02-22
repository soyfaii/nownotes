namespace NowNotes_Windows
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonMenu = new System.Windows.Forms.ToolStripButton();
			this.toolStripDropDownButtonNoteOptions = new System.Windows.Forms.ToolStripDropDownButton();
			this.renameNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.focusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showNotesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripLabelTitle = new System.Windows.Forms.ToolStripLabel();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.panelSideMenu = new System.Windows.Forms.Panel();
			this.listBoxMenu = new System.Windows.Forms.ListBox();
			this.panelSideMenuTitle = new System.Windows.Forms.Panel();
			this.labelSideMenuTitle = new System.Windows.Forms.Label();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.labelInfo = new System.Windows.Forms.Label();
			this.roundButtonNewNote = new NowNotes_Windows.RoundButton();
			this.toolBar = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.timerScrolling = new System.Windows.Forms.Timer(this.components);
			this.toolStrip.SuspendLayout();
			this.panelSideMenu.SuspendLayout();
			this.panelSideMenuTitle.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.toolBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			resources.ApplyResources(this.toolStrip, "toolStrip");
			this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMenu,
            this.toolStripDropDownButtonNoteOptions,
            this.toolStripLabelTitle});
			this.toolStrip.Name = "toolStrip";
			// 
			// toolStripButtonMenu
			// 
			resources.ApplyResources(this.toolStripButtonMenu, "toolStripButtonMenu");
			this.toolStripButtonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonMenu.Name = "toolStripButtonMenu";
			this.toolStripButtonMenu.Click += new System.EventHandler(this.toolStripButtonMenu_Click);
			// 
			// toolStripDropDownButtonNoteOptions
			// 
			this.toolStripDropDownButtonNoteOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			resources.ApplyResources(this.toolStripDropDownButtonNoteOptions, "toolStripDropDownButtonNoteOptions");
			this.toolStripDropDownButtonNoteOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButtonNoteOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem,
            this.toolStripSeparator2,
            this.focusToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.toolStripDropDownButtonNoteOptions.Name = "toolStripDropDownButtonNoteOptions";
			this.toolStripDropDownButtonNoteOptions.ShowDropDownArrow = false;
			// 
			// renameNoteToolStripMenuItem
			// 
			this.renameNoteToolStripMenuItem.Name = "renameNoteToolStripMenuItem";
			resources.ApplyResources(this.renameNoteToolStripMenuItem, "renameNoteToolStripMenuItem");
			this.renameNoteToolStripMenuItem.Click += new System.EventHandler(this.renameNoteToolStripMenuItem_Click);
			// 
			// deleteNoteToolStripMenuItem
			// 
			this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
			resources.ApplyResources(this.deleteNoteToolStripMenuItem, "deleteNoteToolStripMenuItem");
			this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
			// 
			// focusToolStripMenuItem
			// 
			this.focusToolStripMenuItem.Name = "focusToolStripMenuItem";
			resources.ApplyResources(this.focusToolStripMenuItem, "focusToolStripMenuItem");
			this.focusToolStripMenuItem.Click += new System.EventHandler(this.focusToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// debugToolStripMenuItem
			// 
			this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNotesFolderToolStripMenuItem});
			this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
			// 
			// showNotesFolderToolStripMenuItem
			// 
			this.showNotesFolderToolStripMenuItem.Name = "showNotesFolderToolStripMenuItem";
			resources.ApplyResources(this.showNotesFolderToolStripMenuItem, "showNotesFolderToolStripMenuItem");
			this.showNotesFolderToolStripMenuItem.Click += new System.EventHandler(this.showNotesFolderToolStripMenuItem_Click);
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
			// 
			// toolStripLabelTitle
			// 
			resources.ApplyResources(this.toolStripLabelTitle, "toolStripLabelTitle");
			this.toolStripLabelTitle.Name = "toolStripLabelTitle";
			// 
			// notifyIcon
			// 
			resources.ApplyResources(this.notifyIcon, "notifyIcon");
			this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
			// 
			// richTextBox
			// 
			this.richTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.richTextBox, "richTextBox");
			this.richTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(22)))));
			this.richTextBox.Name = "richTextBox";
			// 
			// panelSideMenu
			// 
			this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
			this.panelSideMenu.Controls.Add(this.listBoxMenu);
			this.panelSideMenu.Controls.Add(this.panelSideMenuTitle);
			resources.ApplyResources(this.panelSideMenu, "panelSideMenu");
			this.panelSideMenu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panelSideMenu.Name = "panelSideMenu";
			// 
			// listBoxMenu
			// 
			this.listBoxMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
			this.listBoxMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
			resources.ApplyResources(this.listBoxMenu, "listBoxMenu");
			this.listBoxMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.listBoxMenu.FormattingEnabled = true;
			this.listBoxMenu.Name = "listBoxMenu";
			this.listBoxMenu.SelectedValueChanged += new System.EventHandler(this.listBoxMenu_SelectedValueChanged);
			// 
			// panelSideMenuTitle
			// 
			this.panelSideMenuTitle.Controls.Add(this.labelSideMenuTitle);
			resources.ApplyResources(this.panelSideMenuTitle, "panelSideMenuTitle");
			this.panelSideMenuTitle.Name = "panelSideMenuTitle";
			// 
			// labelSideMenuTitle
			// 
			resources.ApplyResources(this.labelSideMenuTitle, "labelSideMenuTitle");
			this.labelSideMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.labelSideMenuTitle.Name = "labelSideMenuTitle";
			// 
			// panelInfo
			// 
			resources.ApplyResources(this.panelInfo, "panelInfo");
			this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
			this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelInfo.Controls.Add(this.labelInfo);
			this.panelInfo.Name = "panelInfo";
			// 
			// labelInfo
			// 
			this.labelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(4)))), ((int)(((byte)(0)))));
			this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(233)))));
			resources.ApplyResources(this.labelInfo, "labelInfo");
			this.labelInfo.Name = "labelInfo";
			// 
			// roundButtonNewNote
			// 
			this.roundButtonNewNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(227)))), ((int)(((byte)(101)))));
			this.roundButtonNewNote.Cursor = System.Windows.Forms.Cursors.Hand;
			this.roundButtonNewNote.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(this.roundButtonNewNote, "roundButtonNewNote");
			this.roundButtonNewNote.Image = global::NowNotes_Windows.Properties.Resources.add;
			this.roundButtonNewNote.Name = "roundButtonNewNote";
			this.roundButtonNewNote.UseVisualStyleBackColor = false;
			this.roundButtonNewNote.Click += new System.EventHandler(this.buttonNewNote_Click);
			// 
			// toolBar
			// 
			resources.ApplyResources(this.toolBar, "toolBar");
			this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(226)))), ((int)(((byte)(208)))));
			this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNormal,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButton2});
			this.toolBar.Name = "toolBar";
			// 
			// toolStripButtonNormal
			// 
			resources.ApplyResources(this.toolStripButtonNormal, "toolStripButtonNormal");
			this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.toolStripButtonNormal.Margin = new System.Windows.Forms.Padding(4, 1, 0, 2);
			this.toolStripButtonNormal.Name = "toolStripButtonNormal";
			this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
			// 
			// toolStripButtonBold
			// 
			resources.ApplyResources(this.toolStripButtonBold, "toolStripButtonBold");
			this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonBold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.toolStripButtonBold.Name = "toolStripButtonBold";
			this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
			// 
			// toolStripButtonItalic
			// 
			resources.ApplyResources(this.toolStripButtonItalic, "toolStripButtonItalic");
			this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonItalic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.toolStripButtonItalic.Name = "toolStripButtonItalic";
			this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
			// 
			// toolStripButtonUnderline
			// 
			resources.ApplyResources(this.toolStripButtonUnderline, "toolStripButtonUnderline");
			this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonUnderline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
			this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
			// 
			// toolStripButton2
			// 
			resources.ApplyResources(this.toolStripButton2, "toolStripButton2");
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(71)))), ((int)(((byte)(57)))));
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// timerScrolling
			// 
			this.timerScrolling.Interval = 10;
			this.timerScrolling.Tick += new System.EventHandler(this.timerScrolling_Tick);
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ControlBox = false;
			this.Controls.Add(this.richTextBox);
			this.Controls.Add(this.roundButtonNewNote);
			this.Controls.Add(this.panelInfo);
			this.Controls.Add(this.toolBar);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelSideMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "FormMain";
			this.Opacity = 0D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.Resize += new System.EventHandler(this.FormMain_Resize);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panelSideMenu.ResumeLayout(false);
			this.panelSideMenuTitle.ResumeLayout(false);
			this.panelSideMenuTitle.PerformLayout();
			this.panelInfo.ResumeLayout(false);
			this.toolBar.ResumeLayout(false);
			this.toolBar.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private ToolStrip toolStrip;
        private NotifyIcon notifyIcon;
        private RichTextBox richTextBox;
        private Panel panelSideMenu;
        private ListBox listBoxMenu;
        private Panel panelInfo;
        private Label labelInfo;
        private ToolStripDropDownButton toolStripDropDownButtonNoteOptions;
        private ToolStripMenuItem renameNoteToolStripMenuItem;
        private ToolStripMenuItem deleteNoteToolStripMenuItem;
        private Label labelSideMenuTitle;
        private ToolStripButton toolStripButtonMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem showNotesFolderToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStrip toolBar;
        private ToolStripButton toolStripButtonNormal;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private ToolStripButton toolStripButton2;
        private RoundButton roundButtonNewNote;
        private Panel panelSideMenuTitle;
        private System.Windows.Forms.Timer timerScrolling;
        private ToolStripLabel toolStripLabelTitle;
        private ToolStripMenuItem focusToolStripMenuItem;
    }
}