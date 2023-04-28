namespace NowNotes_Windows
{
	partial class AboutNowNotesBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
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
			tableLayoutPanel = new TableLayoutPanel();
			logoPictureBox = new PictureBox();
			labelProductName = new Label();
			labelVersion = new Label();
			labelCopyright = new Label();
			textBoxDescription = new TextBox();
			okButton = new Button();
			labelCompanyName = new Label();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(11, 13);
			tableLayoutPanel.Margin = new Padding(5, 4, 5, 4);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.Size = new Size(557, 410);
			tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Image = Properties.Resources.aboutbanner_normal;
			logoPictureBox.Location = new Point(5, 4);
			logoPictureBox.Margin = new Padding(5, 4, 5, 4);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new Size(173, 402);
			logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			// 
			// labelProductName
			// 
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.Location = new Point(191, 0);
			labelProductName.Margin = new Padding(8, 0, 5, 0);
			labelProductName.MaximumSize = new Size(0, 27);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(361, 27);
			labelProductName.TabIndex = 19;
			labelProductName.Text = "Product Name";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelVersion
			// 
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.Location = new Point(191, 41);
			labelVersion.Margin = new Padding(8, 0, 5, 0);
			labelVersion.MaximumSize = new Size(0, 27);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(361, 27);
			labelVersion.TabIndex = 0;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelCopyright
			// 
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.Location = new Point(191, 82);
			labelCopyright.Margin = new Padding(8, 0, 5, 0);
			labelCopyright.MaximumSize = new Size(0, 27);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(361, 27);
			labelCopyright.TabIndex = 21;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxDescription
			// 
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(191, 168);
			textBoxDescription.Margin = new Padding(8, 4, 5, 4);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(361, 197);
			textBoxDescription.TabIndex = 23;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "Description";
			// 
			// okButton
			// 
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.DialogResult = DialogResult.Cancel;
			okButton.Location = new Point(451, 373);
			okButton.Margin = new Padding(5, 4, 5, 4);
			okButton.Name = "okButton";
			okButton.Size = new Size(101, 33);
			okButton.TabIndex = 24;
			okButton.Text = "&OK";
			okButton.Click += okButton_Click;
			// 
			// labelCompanyName
			// 
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.Location = new Point(191, 123);
			labelCompanyName.Margin = new Padding(8, 0, 5, 0);
			labelCompanyName.MaximumSize = new Size(0, 27);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(361, 27);
			labelCompanyName.TabIndex = 22;
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// AboutNowNotesBox
			// 
			AcceptButton = okButton;
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(579, 436);
			Controls.Add(tableLayoutPanel);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Margin = new Padding(5, 4, 5, 4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutNowNotesBox";
			Padding = new Padding(11, 13, 11, 13);
			ShowIcon = false;
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "AboutNowNotesBox";
			TopMost = true;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.PictureBox logoPictureBox;
		private System.Windows.Forms.Label labelProductName;
		private System.Windows.Forms.Label labelVersion;
		private System.Windows.Forms.Label labelCopyright;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Button okButton;
		private Label labelCompanyName;
	}
}
