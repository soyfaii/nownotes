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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			toolStrip = new ToolStrip();
			toolStripButtonMenu = new ToolStripButton();
			toolStripDropDownButtonNoteOptions = new ToolStripDropDownButton();
			renameNoteToolStripMenuItem = new ToolStripMenuItem();
			deleteNoteToolStripMenuItem = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			focusToolStripMenuItem = new ToolStripMenuItem();
			settingsToolStripMenuItem = new ToolStripMenuItem();
			debugToolStripMenuItem = new ToolStripMenuItem();
			showNotesFolderToolStripMenuItem = new ToolStripMenuItem();
			closeToolStripMenuItem = new ToolStripMenuItem();
			toolStripLabelTitle = new ToolStripLabel();
			notifyIcon = new NotifyIcon(components);
			richTextBox = new RichTextBox();
			panelSideMenu = new Panel();
			listBoxMenu = new ListBox();
			panelSideMenuTitle = new Panel();
			labelSideMenuTitle = new Label();
			panelInfo = new Panel();
			labelInfo = new Label();
			roundButtonNewNote = new RoundButton();
			toolBar = new ToolStrip();
			toolStripButtonNormal = new ToolStripButton();
			toolStripButtonBold = new ToolStripButton();
			toolStripButtonItalic = new ToolStripButton();
			toolStripButtonUnderline = new ToolStripButton();
			toolStripButton2 = new ToolStripButton();
			timerScrolling = new System.Windows.Forms.Timer(components);
			toolStrip.SuspendLayout();
			panelSideMenu.SuspendLayout();
			panelSideMenuTitle.SuspendLayout();
			panelInfo.SuspendLayout();
			toolBar.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip
			// 
			resources.ApplyResources(toolStrip, "toolStrip");
			toolStrip.BackColor = Color.FromArgb(255, 251, 255);
			toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			toolStrip.ImageScalingSize = new Size(20, 20);
			toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonMenu, toolStripDropDownButtonNoteOptions, toolStripLabelTitle });
			toolStrip.Name = "toolStrip";
			toolStrip.Renderer = new ToolStripSystemRendererNoBorder();
			// 
			// toolStripButtonMenu
			// 
			resources.ApplyResources(toolStripButtonMenu, "toolStripButtonMenu");
			toolStripButtonMenu.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonMenu.Name = "toolStripButtonMenu";
			toolStripButtonMenu.Click += toolStripButtonMenu_Click;
			// 
			// toolStripDropDownButtonNoteOptions
			// 
			toolStripDropDownButtonNoteOptions.Alignment = ToolStripItemAlignment.Right;
			resources.ApplyResources(toolStripDropDownButtonNoteOptions, "toolStripDropDownButtonNoteOptions");
			toolStripDropDownButtonNoteOptions.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButtonNoteOptions.DropDownItems.AddRange(new ToolStripItem[] { renameNoteToolStripMenuItem, deleteNoteToolStripMenuItem, toolStripSeparator2, focusToolStripMenuItem, settingsToolStripMenuItem, debugToolStripMenuItem, closeToolStripMenuItem });
			toolStripDropDownButtonNoteOptions.Name = "toolStripDropDownButtonNoteOptions";
			toolStripDropDownButtonNoteOptions.ShowDropDownArrow = false;
			// 
			// renameNoteToolStripMenuItem
			// 
			renameNoteToolStripMenuItem.Name = "renameNoteToolStripMenuItem";
			resources.ApplyResources(renameNoteToolStripMenuItem, "renameNoteToolStripMenuItem");
			renameNoteToolStripMenuItem.Click += renameNoteToolStripMenuItem_Click;
			// 
			// deleteNoteToolStripMenuItem
			// 
			deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
			resources.ApplyResources(deleteNoteToolStripMenuItem, "deleteNoteToolStripMenuItem");
			deleteNoteToolStripMenuItem.Click += deleteNoteToolStripMenuItem_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			resources.ApplyResources(toolStripSeparator2, "toolStripSeparator2");
			// 
			// focusToolStripMenuItem
			// 
			focusToolStripMenuItem.Name = "focusToolStripMenuItem";
			resources.ApplyResources(focusToolStripMenuItem, "focusToolStripMenuItem");
			focusToolStripMenuItem.Click += focusToolStripMenuItem_Click;
			// 
			// settingsToolStripMenuItem
			// 
			settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			resources.ApplyResources(settingsToolStripMenuItem, "settingsToolStripMenuItem");
			settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
			// 
			// debugToolStripMenuItem
			// 
			debugToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showNotesFolderToolStripMenuItem });
			debugToolStripMenuItem.Name = "debugToolStripMenuItem";
			resources.ApplyResources(debugToolStripMenuItem, "debugToolStripMenuItem");
			// 
			// showNotesFolderToolStripMenuItem
			// 
			showNotesFolderToolStripMenuItem.Name = "showNotesFolderToolStripMenuItem";
			resources.ApplyResources(showNotesFolderToolStripMenuItem, "showNotesFolderToolStripMenuItem");
			showNotesFolderToolStripMenuItem.Click += showNotesFolderToolStripMenuItem_Click;
			// 
			// closeToolStripMenuItem
			// 
			closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			resources.ApplyResources(closeToolStripMenuItem, "closeToolStripMenuItem");
			closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
			// 
			// toolStripLabelTitle
			// 
			resources.ApplyResources(toolStripLabelTitle, "toolStripLabelTitle");
			toolStripLabelTitle.Name = "toolStripLabelTitle";
			// 
			// notifyIcon
			// 
			resources.ApplyResources(notifyIcon, "notifyIcon");
			notifyIcon.Click += notifyIcon_Click;
			// 
			// richTextBox
			// 
			richTextBox.BackColor = Color.FromArgb(255, 251, 255);
			richTextBox.BorderStyle = BorderStyle.None;
			resources.ApplyResources(richTextBox, "richTextBox");
			richTextBox.ForeColor = Color.FromArgb(29, 28, 22);
			richTextBox.Name = "richTextBox";
			// 
			// panelSideMenu
			// 
			panelSideMenu.BackColor = Color.FromArgb(232, 226, 208);
			panelSideMenu.Controls.Add(listBoxMenu);
			panelSideMenu.Controls.Add(panelSideMenuTitle);
			resources.ApplyResources(panelSideMenu, "panelSideMenu");
			panelSideMenu.ForeColor = SystemColors.ControlText;
			panelSideMenu.Name = "panelSideMenu";
			// 
			// listBoxMenu
			// 
			listBoxMenu.BackColor = Color.FromArgb(232, 226, 208);
			listBoxMenu.BorderStyle = BorderStyle.None;
			resources.ApplyResources(listBoxMenu, "listBoxMenu");
			listBoxMenu.ForeColor = Color.FromArgb(74, 71, 57);
			listBoxMenu.FormattingEnabled = true;
			listBoxMenu.Name = "listBoxMenu";
			listBoxMenu.DrawMode = DrawMode.OwnerDrawFixed;
			listBoxMenu.SelectedValueChanged += listBoxMenu_SelectedValueChanged;
			listBoxMenu.DrawItem += listBoxMenu_DrawItem;
			// 
			// panelSideMenuTitle
			// 
			panelSideMenuTitle.Controls.Add(labelSideMenuTitle);
			resources.ApplyResources(panelSideMenuTitle, "panelSideMenuTitle");
			panelSideMenuTitle.ForeColor = Color.FromArgb(74, 71, 57);
			panelSideMenuTitle.Name = "panelSideMenuTitle";
			// 
			// labelSideMenuTitle
			// 
			resources.ApplyResources(labelSideMenuTitle, "labelSideMenuTitle");
			labelSideMenuTitle.Name = "labelSideMenuTitle";
			// 
			// panelInfo
			// 
			resources.ApplyResources(panelInfo, "panelInfo");
			panelInfo.BackColor = Color.FromArgb(0, 4, 0);
			panelInfo.BorderStyle = BorderStyle.FixedSingle;
			panelInfo.Controls.Add(labelInfo);
			panelInfo.Name = "panelInfo";
			// 
			// labelInfo
			// 
			labelInfo.BackColor = Color.FromArgb(0, 4, 0);
			labelInfo.ForeColor = Color.FromArgb(226, 227, 233);
			resources.ApplyResources(labelInfo, "labelInfo");
			labelInfo.Name = "labelInfo";
			// 
			// roundButtonNewNote
			// 
			roundButtonNewNote.BackColor = Color.FromArgb(252, 227, 101);
			roundButtonNewNote.Cursor = Cursors.Hand;
			roundButtonNewNote.FlatAppearance.BorderSize = 0;
			resources.ApplyResources(roundButtonNewNote, "roundButtonNewNote");
			roundButtonNewNote.Name = "roundButtonNewNote";
			roundButtonNewNote.UseVisualStyleBackColor = false;
			roundButtonNewNote.Click += buttonNewNote_Click;
			// 
			// toolBar
			// 
			resources.ApplyResources(toolBar, "toolBar");
			toolBar.BackColor = Color.FromArgb(232, 226, 208);
			toolBar.ForeColor = Color.FromArgb(74, 71, 57);
			toolBar.GripStyle = ToolStripGripStyle.Hidden;
			toolBar.ImageScalingSize = new Size(20, 20);
			toolBar.Items.AddRange(new ToolStripItem[] { toolStripButtonNormal, toolStripButtonBold, toolStripButtonItalic, toolStripButtonUnderline, toolStripButton2 });
			toolBar.Name = "toolBar";
			toolBar.Renderer = new ToolStripSystemRendererNoBorder();
			// 
			// toolStripButtonNormal
			// 
			resources.ApplyResources(toolStripButtonNormal, "toolStripButtonNormal");
			toolStripButtonNormal.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonNormal.Margin = new Padding(4, 1, 0, 2);
			toolStripButtonNormal.Name = "toolStripButtonNormal";
			toolStripButtonNormal.Click += toolStripButtonNormal_Click;
			// 
			// toolStripButtonBold
			// 
			resources.ApplyResources(toolStripButtonBold, "toolStripButtonBold");
			toolStripButtonBold.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonBold.Name = "toolStripButtonBold";
			toolStripButtonBold.Click += toolStripButtonBold_Click;
			// 
			// toolStripButtonItalic
			// 
			resources.ApplyResources(toolStripButtonItalic, "toolStripButtonItalic");
			toolStripButtonItalic.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonItalic.Name = "toolStripButtonItalic";
			toolStripButtonItalic.Click += toolStripButtonItalic_Click;
			// 
			// toolStripButtonUnderline
			// 
			resources.ApplyResources(toolStripButtonUnderline, "toolStripButtonUnderline");
			toolStripButtonUnderline.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButtonUnderline.Name = "toolStripButtonUnderline";
			toolStripButtonUnderline.Click += toolStripButtonUnderline_Click;
			// 
			// toolStripButton2
			// 
			resources.ApplyResources(toolStripButton2, "toolStripButton2");
			toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
			toolStripButton2.Name = "toolStripButton2";
			toolStripButton2.Click += toolStripButton2_Click;
			// 
			// timerScrolling
			// 
			timerScrolling.Interval = 10;
			timerScrolling.Tick += timerScrolling_Tick;
			// 
			// FormMain
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			ControlBox = false;
			Controls.Add(richTextBox);
			Controls.Add(roundButtonNewNote);
			Controls.Add(panelInfo);
			Controls.Add(toolBar);
			Controls.Add(toolStrip);
			Controls.Add(panelSideMenu);
			FormBorderStyle = FormBorderStyle.SizableToolWindow;
			Name = "FormMain";
			Opacity = 0D;
			ShowIcon = false;
			ShowInTaskbar = false;
			TopMost = true;
			FormClosing += FormMain_FormClosing;
			Load += FormMain_Load;
			Resize += FormMain_Resize;
			toolStrip.ResumeLayout(false);
			toolStrip.PerformLayout();
			panelSideMenu.ResumeLayout(false);
			panelSideMenuTitle.ResumeLayout(false);
			panelSideMenuTitle.PerformLayout();
			panelInfo.ResumeLayout(false);
			toolBar.ResumeLayout(false);
			toolBar.PerformLayout();
			ResumeLayout(false);
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