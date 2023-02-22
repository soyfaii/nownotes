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
			this.tabPageAdvanced = new System.Windows.Forms.TabPage();
			this.buttonOK = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonDeleteAllNotes = new System.Windows.Forms.Button();
			this.checkBoxEnableSync = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
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
			this.tabPageSync.Controls.Add(this.comboBox1);
			this.tabPageSync.Controls.Add(this.label1);
			this.tabPageSync.Controls.Add(this.checkBoxEnableSync);
			resources.ApplyResources(this.tabPageSync, "tabPageSync");
			this.tabPageSync.Name = "tabPageSync";
			this.tabPageSync.UseVisualStyleBackColor = true;
			// 
			// tabPageAdvanced
			// 
			this.tabPageAdvanced.Controls.Add(this.buttonDeleteAllNotes);
			resources.ApplyResources(this.tabPageAdvanced, "tabPageAdvanced");
			this.tabPageAdvanced.Name = "tabPageAdvanced";
			this.tabPageAdvanced.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			resources.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			// 
			// buttonCancel
			// 
			resources.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			resources.ApplyResources(this.buttonApply, "buttonApply");
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteAllNotes
			// 
			resources.ApplyResources(this.buttonDeleteAllNotes, "buttonDeleteAllNotes");
			this.buttonDeleteAllNotes.Name = "buttonDeleteAllNotes";
			this.buttonDeleteAllNotes.UseVisualStyleBackColor = true;
			// 
			// checkBoxEnableSync
			// 
			resources.ApplyResources(this.checkBoxEnableSync, "checkBoxEnableSync");
			this.checkBoxEnableSync.Name = "checkBoxEnableSync";
			this.checkBoxEnableSync.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			resources.ApplyResources(this.label1, "label1");
			this.label1.Name = "label1";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			resources.ApplyResources(this.comboBox1, "comboBox1");
			this.comboBox1.Name = "comboBox1";
			// 
			// FormSettings
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.tabControlSettingsTabs);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormSettings";
			this.TopMost = true;
			this.tabControlSettingsTabs.ResumeLayout(false);
			this.tabPageSync.ResumeLayout(false);
			this.tabPageSync.PerformLayout();
			this.tabPageAdvanced.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControlSettingsTabs;
		private TabPage tabPageSync;
		private TabPage tabPageAdvanced;
		private Button buttonOK;
		private Button buttonCancel;
		private Button buttonApply;
		private ComboBox comboBox1;
		private Label label1;
		private CheckBox checkBoxEnableSync;
		private Button buttonDeleteAllNotes;
	}
}