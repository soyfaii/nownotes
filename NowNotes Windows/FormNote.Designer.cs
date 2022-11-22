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
            this.toolStripButtonMenu = new System.Windows.Forms.ToolStripSplitButton();
            this.allNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNotesFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonNormal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonNoteOptions = new System.Windows.Forms.ToolStripDropDownButton();
            this.renameNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMenu,
            this.toolStripSeparator1,
            this.toolStripButtonNormal,
            this.toolStripButtonBold,
            this.toolStripButtonItalic,
            this.toolStripButtonUnderline,
            this.toolStripButton2,
            this.toolStripDropDownButtonNoteOptions});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(450, 30);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonMenu
            // 
            this.toolStripButtonMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allNotesToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripButtonMenu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMenu.Image")));
            this.toolStripButtonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMenu.Name = "toolStripButtonMenu";
            this.toolStripButtonMenu.Size = new System.Drawing.Size(85, 27);
            this.toolStripButtonMenu.Text = "Menu";
            this.toolStripButtonMenu.ButtonClick += new System.EventHandler(this.toolStripButtonMenu_ButtonClick);
            this.toolStripButtonMenu.Click += new System.EventHandler(this.toolStripButtonMenu_Click);
            // 
            // allNotesToolStripMenuItem
            // 
            this.allNotesToolStripMenuItem.Name = "allNotesToolStripMenuItem";
            this.allNotesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.allNotesToolStripMenuItem.Text = "All Notes";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNotesFolderToolStripMenuItem});
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            // 
            // showNotesFolderToolStripMenuItem
            // 
            this.showNotesFolderToolStripMenuItem.Name = "showNotesFolderToolStripMenuItem";
            this.showNotesFolderToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.showNotesFolderToolStripMenuItem.Text = "Show Notes Folder";
            this.showNotesFolderToolStripMenuItem.Click += new System.EventHandler(this.showNotesFolderToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripButtonNormal
            // 
            this.toolStripButtonNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNormal.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNormal.Image")));
            this.toolStripButtonNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNormal.Name = "toolStripButtonNormal";
            this.toolStripButtonNormal.Size = new System.Drawing.Size(63, 27);
            this.toolStripButtonNormal.Text = "Normal";
            this.toolStripButtonNormal.Click += new System.EventHandler(this.toolStripButtonNormal_Click);
            // 
            // toolStripButtonBold
            // 
            this.toolStripButtonBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBold.Image")));
            this.toolStripButtonBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBold.Name = "toolStripButtonBold";
            this.toolStripButtonBold.Size = new System.Drawing.Size(29, 27);
            this.toolStripButtonBold.Text = "B";
            this.toolStripButtonBold.ToolTipText = "Bold";
            this.toolStripButtonBold.Click += new System.EventHandler(this.toolStripButtonBold_Click);
            // 
            // toolStripButtonItalic
            // 
            this.toolStripButtonItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonItalic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonItalic.Image")));
            this.toolStripButtonItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonItalic.Name = "toolStripButtonItalic";
            this.toolStripButtonItalic.Size = new System.Drawing.Size(29, 27);
            this.toolStripButtonItalic.Text = "I";
            this.toolStripButtonItalic.ToolTipText = "Italic";
            this.toolStripButtonItalic.Click += new System.EventHandler(this.toolStripButtonItalic_Click);
            // 
            // toolStripButtonUnderline
            // 
            this.toolStripButtonUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUnderline.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.toolStripButtonUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUnderline.Image")));
            this.toolStripButtonUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUnderline.Name = "toolStripButtonUnderline";
            this.toolStripButtonUnderline.Size = new System.Drawing.Size(29, 27);
            this.toolStripButtonUnderline.Text = "U";
            this.toolStripButtonUnderline.ToolTipText = "Underline";
            this.toolStripButtonUnderline.Click += new System.EventHandler(this.toolStripButtonUnderline_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 27);
            this.toolStripButton2.Text = "Title";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripDropDownButtonNoteOptions
            // 
            this.toolStripDropDownButtonNoteOptions.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButtonNoteOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButtonNoteOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameNoteToolStripMenuItem,
            this.deleteNoteToolStripMenuItem});
            this.toolStripDropDownButtonNoteOptions.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonNoteOptions.Image")));
            this.toolStripDropDownButtonNoteOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonNoteOptions.Name = "toolStripDropDownButtonNoteOptions";
            this.toolStripDropDownButtonNoteOptions.ShowDropDownArrow = false;
            this.toolStripDropDownButtonNoteOptions.Size = new System.Drawing.Size(24, 27);
            this.toolStripDropDownButtonNoteOptions.Text = "Note Options";
            // 
            // renameNoteToolStripMenuItem
            // 
            this.renameNoteToolStripMenuItem.Name = "renameNoteToolStripMenuItem";
            this.renameNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.renameNoteToolStripMenuItem.Text = "Rename Note";
            this.renameNoteToolStripMenuItem.Click += new System.EventHandler(this.renameNoteToolStripMenuItem_Click);
            // 
            // deleteNoteToolStripMenuItem
            // 
            this.deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
            this.deleteNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteNoteToolStripMenuItem.Text = "Delete Note";
            this.deleteNoteToolStripMenuItem.Click += new System.EventHandler(this.deleteNoteToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Open your NowNotes note";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 30);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(450, 354);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.listBoxMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 30);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(347, 354);
            this.panelSideMenu.TabIndex = 3;
            this.panelSideMenu.Visible = false;
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(341, 404);
            this.listBoxMenu.TabIndex = 0;
            this.listBoxMenu.SelectedValueChanged += new System.EventHandler(this.listBoxMenu_SelectedValueChanged);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.Info;
            this.panelInfo.Controls.Add(this.labelInfo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfo.Location = new System.Drawing.Point(0, 384);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(450, 66);
            this.panelInfo.TabIndex = 4;
            this.panelInfo.Visible = false;
            // 
            // labelInfo
            // 
            this.labelInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelInfo.Location = new System.Drawing.Point(3, 3);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(444, 60);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "Information Panel\r\nInformation Panel";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "NowNotes";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip;
        private NotifyIcon notifyIcon;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonBold;
        private ToolStripButton toolStripButtonItalic;
        private ToolStripButton toolStripButtonUnderline;
        private ToolStripButton toolStripButtonNormal;
        private ToolStripButton toolStripButton2;
        private RichTextBox richTextBox;
        private ToolStripSplitButton toolStripButtonMenu;
        private ToolStripMenuItem allNotesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Panel panelSideMenu;
        private ListBox listBoxMenu;
        private Panel panelInfo;
        private Label labelInfo;
        private ToolStripMenuItem debugToolStripMenuItem;
        private ToolStripMenuItem showNotesFolderToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButtonNoteOptions;
        private ToolStripMenuItem renameNoteToolStripMenuItem;
        private ToolStripMenuItem deleteNoteToolStripMenuItem;
    }
}