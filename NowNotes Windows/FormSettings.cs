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

		public FormSettings()
		{
			InitializeComponent();
		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			// Load all the parameters

		}

		private void buttonOK_Click(object sender, EventArgs e)
		{
			// Saves and closes the window, also closes NowNotes if necessary
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
			Settings.Default.Save();
		}

		private void buttonAboutNowNotes_Click(object sender, EventArgs e)
		{
			AboutNowNotesBox about = new AboutNowNotesBox();
			about.Show();
		}
	}
}
