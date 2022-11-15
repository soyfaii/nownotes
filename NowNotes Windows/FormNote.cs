using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;
using System.Windows.Forms;

namespace NowNotes_Windows
{
    public partial class FormMain : Form
    {
        public bool isBeingShowed = false;
        public string fileOpened;
        public bool hasBeenShowed = false;
        public bool sidemenuShowing = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes");
            }
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            if (isBeingShowed)
            {
                isBeingShowed = false;
                Opacity = 0;
            }
            else
            {
                isBeingShowed = true;
                Opacity = 100;
                if (!hasBeenShowed)
                {
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf");
                    fileOpened = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf";
                    System.Windows.Forms.Timer savingTimer = new System.Windows.Forms.Timer();
                    savingTimer.Interval = 60000;
                    savingTimer.Tick += SavingTimer_Tick;
                    savingTimer.Start();
                    hasBeenShowed = true;
                }
            }
        }

        private void SavingTimer_Tick(object? sender, EventArgs e)
        {
            SaveActualNote(sender, e);
        }

        public void SaveActualNote(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(fileOpened, richTextBox.Rtf.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("The note wasn't able to be saved because another app has the internal note file opened.", "An error occured.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonMenu_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonBold_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void toolStripButtonItalic_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Italic);
        }

        private void toolStripButtonUnderline_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Underline);
        }

        private void toolStripButtonNormal_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("Segoe UI", 9, FontStyle.Regular);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox.SelectionFont = new Font("Segoe UI", 16, FontStyle.Bold);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveActualNote(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButtonMenu_ButtonClick(object sender, EventArgs e)
        {
            ShowHideSideMenu();
        }

        public void ShowHideSideMenu()
        {
            if (sidemenuShowing)
            {
                panelSideMenu.Hide();
                toolStripButtonMenu.Select();
                sidemenuShowing = false;
            }
            else
            {
                panelSideMenu.Show();
                toolStripButtonMenu.Select();
                string[] notesFileNames = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes").ToArray();
                for (int i = 0; i < notesFileNames.Length; i++)
                {
                    notesFileNames[i] = notesFileNames[i].Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\", "");
                    notesFileNames[i] = notesFileNames[i].Replace(".rtf", "");
                }
                listBoxMenu.Items.Clear();
                listBoxMenu.Items.AddRange(notesFileNames);
                string fileOpenedDisplayName = Microsoft.VisualBasic.FileIO.FileSystem.GetName(fileOpened).Replace(".rtf", "");
                listBoxMenu.SelectedItems.Add(fileOpenedDisplayName);
                sidemenuShowing = true;
            }
        }

        private void listBoxMenu_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sidemenuShowing)
            {
                SaveActualNote(sender, e);
                string fileToOpen = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\" + listBoxMenu.SelectedItem.ToString() + ".rtf";
                richTextBox.Rtf = File.ReadAllText(fileToOpen);
                fileOpened = fileToOpen;
                ShowHideSideMenu(); 
            }
        }
    }
}