namespace NowNotes_Windows
{
	partial class FormSettings
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
			this.tabControlSettingsTabs = new System.Windows.Forms.TabControl();
			this.tabPageSync = new System.Windows.Forms.TabPage();
			this.comboBoxOneDriveAccount = new System.Windows.Forms.ComboBox();
			this.labelOneDriveAccount = new System.Windows.Forms.Label();
			this.checkBoxEnableSync = new System.Windows.Forms.CheckBox();
			this.tabPageAdvanced = new System.Windows.Forms.TabPage();
			this.checkBoxStartup = new System.Windows.Forms.CheckBox();
			this.buttonDeleteAllNotes = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonAboutNowNotes = new System.Windows.Forms.Button();
			this.tabControlSettingsTabs.SuspendLayout();
			this.tabPageSync.SuspendLayout();
			this.tabPageAdvanced.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlSettingsTabs
			// 
			this.tabControlSettingsTabs.Controls.Add(this.tabPageSync);
			this.tabControlSettingsTabs.Controls.Add(this.tabPageAdvanced);
			resources.ApplyResources(this.tabControlSettingsTabs, "tabControlSettingsTabs");
			this.tabControlSettingsTabs.Multiline = true;
			this.tabControlSettingsTabs.Name = "tabControlSettingsTabs";
			this.tabControlSettingsTabs.SelectedIndex = 0;
			// 
			// tabPageSync
			// 
			this.tabPageSync.Controls.Add(this.comboBoxOneDriveAccount);
			this.tabPageSync.Controls.Add(this.labelOneDriveAccount);
			this.tabPageSync.Controls.Add(this.checkBoxEnableSync);
			resources.ApplyResources(this.tabPageSync, "tabPageSync");
			this.tabPageSync.Name = "tabPageSync";
			this.tabPageSync.UseVisualStyleBackColor = true;
			// 
			// comboBoxOneDriveAccount
			// 
			this.comboBoxOneDriveAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOneDriveAccount.FormattingEnabled = true;
			resources.ApplyResources(this.comboBoxOneDriveAccount, "comboBoxOneDriveAccount");
			this.comboBoxOneDriveAccount.Name = "comboBoxOneDriveAccount";
			this.comboBoxOneDriveAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxOneDriveAccount_SelectedIndexChanged);
			// 
			// labelOneDriveAccount
			// 
			resources.ApplyResources(this.labelOneDriveAccount, "labelOneDriveAccount");
			this.labelOneDriveAccount.Name = "labelOneDriveAccount";
			// 
			// checkBoxEnableSync
			// 
			resources.ApplyResources(this.checkBoxEnableSync, "checkBoxEnableSync");
			this.checkBoxEnableSync.Name = "checkBoxEnableSync";
			this.checkBoxEnableSync.UseVisualStyleBackColor = true;
			this.checkBoxEnableSync.CheckedChanged += new System.EventHandler(this.checkBoxEnableSync_CheckedChanged);
			// 
			// tabPageAdvanced
			// 
			this.tabPageAdvanced.Controls.Add(this.checkBoxStartup);
			this.tabPageAdvanced.Controls.Add(this.buttonDeleteAllNotes);
			resources.ApplyResources(this.tabPageAdvanced, "tabPageAdvanced");
			this.tabPageAdvanced.Name = "tabPageAdvanced";
			this.tabPageAdvanced.UseVisualStyleBackColor = true;
			// 
			// checkBoxStartup
			// 
			resources.ApplyResources(this.checkBoxStartup, "checkBoxStartup");
			this.checkBoxStartup.Name = "checkBoxStartup";
			this.checkBoxStartup.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteAllNotes
			// 
			resources.ApplyResources(this.buttonDeleteAllNotes, "buttonDeleteAllNotes");
			this.buttonDeleteAllNotes.Name = "buttonDeleteAllNotes";
			this.buttonDeleteAllNotes.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonApply
			// 
			resources.ApplyResources(this.buttonApply, "buttonApply");
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// buttonAboutNowNotes
			// 
			resources.ApplyResources(this.buttonAboutNowNotes, "buttonAboutNowNotes");
			this.buttonAboutNowNotes.Name = "buttonAboutNowNotes";
			this.buttonAboutNowNotes.UseVisualStyleBackColor = true;
			this.buttonAboutNowNotes.Click += new System.EventHandler(this.buttonAboutNowNotes_Click);
			// 
			// FormSettings
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAboutNowNotes);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tabControlSettingsTabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormSettings";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.FormSettings_Load);
			this.tabControlSettingsTabs.ResumeLayout(false);
			this.tabPageSync.ResumeLayout(false);
			this.tabPageSync.PerformLayout();
			this.tabPageAdvanced.ResumeLayout(false);
			this.tabPageAdvanced.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControlSettingsTabs;
		private TabPage tabPageSync;
		private TabPage tabPageAdvanced;
		private Button buttonOK;
		private Button buttonCancel;
		private Button buttonApply;
		private ComboBox comboBoxOneDriveAccount;
		private Label labelOneDriveAccount;
		private CheckBox checkBoxEnableSync;
		private Button buttonDeleteAllNotes;
		private CheckBox checkBoxStartup;
		private Button buttonAboutNowNotes;
	}
}