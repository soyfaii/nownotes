using NowNotes_Windows.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NowNotes_Windows
{
	public partial class FormSettings : Form
	{
		bool necessarytoReopenApp = false;
		string previousNotesFolder;
		bool onedriveFolderChanged = false;

		public FormSettings()
		{
			InitializeComponent();
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			// Load all the parameters

			// Cloud Sync
			if (Settings.Default.CloudSyncEnabled) { checkBoxEnableSync.Checked = true; comboBoxOneDriveAccount.Enabled = true; } else { checkBoxEnableSync.Checked = false; comboBoxOneDriveAccount.Enabled = false; }
			{
				// Load OneDrive Folders
				string rootPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
				string[] dirs = Directory.GetDirectories(rootPath, "OneDrive", SearchOption.TopDirectoryOnly);
				for (int i = 0; i < dirs.Length; i++)
				{
					dirs[i] = Path.GetFileName(dirs[i]);
				}
				comboBoxOneDriveAccount.Items.Clear();
				comboBoxOneDriveAccount.Items.AddRange(dirs);
				comboBoxOneDriveAccount.Text = Settings.Default.OneDriveFolder;
				previousNotesFolder = Settings.Default.OneDriveFolder;
			}
			// Appearance
			{
				// Theme
				{
					if (Settings.Default.Theme == "auto") { comboBoxTheme.Text = "Auto (System defined)"; }
					else if (Settings.Default.Theme == "light") { comboBoxTheme.Text = "Light"; }
					else if (Settings.Default.Theme == "dark") { comboBoxTheme.Text = "Dark"; }
				}
			}
		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			// Saves and closes the window, also closes NowNotes if necessary
			if (onedriveFolderChanged) { OneDriveSyncChangedOperations(); }
			if (comboBoxTheme.Text == "Auto (System defined)") { Settings.Default.Theme = "auto"; }
			else if (comboBoxTheme.Text == "Light") { Settings.Default.Theme = "light"; }
			else if (comboBoxTheme.Text == "Dark)") { Settings.Default.Theme = "dark"; }
			SettingsApplying();
			Settings.Default.Save();
			Close();
			Dispose();
			if (necessarytoReopenApp)
			{
				MessageBox.Show("NowNotes will restart.", "Restart necessary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Application.Restart();
			}
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			// Cancels everything and closes the window 
			Settings.Default.Reload();
			Close();
			Dispose();
			if (necessarytoReopenApp)
			{
				MessageBox.Show("NowNotes will restart.", "Restart necessary", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				Application.Restart();
			}
		}

		private void buttonApply_Click(object sender, EventArgs e)
		{
			// Applies everything without closing the window
			if (onedriveFolderChanged) { OneDriveSyncChangedOperations(); }
			if (comboBoxTheme.Text == "Auto (System defined)") { Settings.Default.Theme = "auto"; }
			else if (comboBoxTheme.Text == "Light") { Settings.Default.Theme = "light"; }
			else if (comboBoxTheme.Text == "Dark)") { Settings.Default.Theme = "dark"; }
			SettingsApplying();
			Settings.Default.Save();
		}

		private void buttonAboutNowNotes_Click(object sender, EventArgs e)
		{
			AboutNowNotesBox about = new AboutNowNotesBox();
			about.Show();
		}

		private void checkBoxEnableSync_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableSync.Checked == true) { comboBoxOneDriveAccount.Enabled = true; }
			else { comboBoxOneDriveAccount.Enabled = false; }
			necessarytoReopenApp = true;
		}

		private void comboBoxOneDriveAccount_SelectedIndexChanged(object sender, EventArgs e)
		{
			necessarytoReopenApp = true;
		}

		public void OneDriveSyncChangedOperations()
		{
			// Checks what kind of transfer is needed
			bool toOneDrive;
			if (checkBoxEnableSync.Checked)
			{
				toOneDrive = true;
			}
			else
			{
				toOneDrive = false;
			}
			// Creates NowNotes folders on OneDrive if they don't exist
			if (toOneDrive)
			{
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + comboBoxOneDriveAccount.Text + "\\NowNotes");
				Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + comboBoxOneDriveAccount.Text + "\\NowNotes\\Notes");
			}
			// Transfers files form previous folder to new folder
			string sourceFolder = previousNotesFolder;
			string destinationFolder;
			if (toOneDrive)
			{
				destinationFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + comboBoxOneDriveAccount.Text + "\\NowNotes\\Notes";
			}
			else
			{
				destinationFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes";
			}
			string[] files = Directory.GetFiles(sourceFolder);
			foreach (string file in files)
			{
				string fileName = Path.GetFileName(file);
				string destinationFile = Path.Combine(destinationFolder, fileName);
				File.Copy(file, destinationFile);
			}
		}

		public void SettingsApplying()
		{
			if (checkBoxEnableSync.Checked) { Settings.Default.CloudSyncEnabled = true; } else { Settings.Default.CloudSyncEnabled = false; }
			Settings.Default.OneDriveFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\" + comboBoxOneDriveAccount.Text + "\\NowNotes\\Notes";
		}
	}
}
