using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using NowNotes_Windows.Properties;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NowNotes_Windows
{
    public partial class FormMain : Form
    {
        public bool isBeingShowed = false;
        public string fileOpened;
        public bool hasBeenShowed = false;
        public bool sidemenuShowing = false;
        System.Windows.Forms.Timer infoMessageTimer = new System.Windows.Forms.Timer();
        Form formRenameNote = new Form();
        System.Windows.Forms.TextBox textBoxRenameNote = new System.Windows.Forms.TextBox();
        public string noteName;
        
        public FormMain()
        {
            InitializeComponent();
            //
            formRenameNote.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            formRenameNote.Size = new Size(400, 130);
            formRenameNote.Text = "Rename Note";
            formRenameNote.TopMost = true;
            //
            textBoxRenameNote.Parent = formRenameNote;
            textBoxRenameNote.Size = new Size(358, 27);
            textBoxRenameNote.Location = new Point(12, 12);
            textBoxRenameNote.Text = noteName;
            //
            System.Windows.Forms.Button buttonRename = new System.Windows.Forms.Button();
            buttonRename.Parent = formRenameNote;
            buttonRename.Text = "Rename";
            buttonRename.Size = new Size(94, 29);
            buttonRename.Location = new Point(276, 45);
            buttonRename.Click += ButtonRename_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes");
            }
            if (Debugger.IsAttached)
            {
                debugToolStripMenuItem.Visible = true;
            }
            if (Settings.Default.FirstLaunch)
            {
                DialogResult result = MessageBox.Show("Do you want to set NowNotes to launch on startup?", "Launch on Startup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                    rkey.SetValue("NowNotes", Application.ExecutablePath);
                }
                Settings.Default.FirstLaunch = false;
                Settings.Default.Save();
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
                ShowInfo("The note wasn't able to be saved because another app has the internal note file opened.");
            }
        }

        public void ShowInfo(string info)
        {
            labelInfo.Text = info;
            panelInfo.Show();
            infoMessageTimer.Tick += InfoMessageTimer_Tick;
            infoMessageTimer.Interval = 5000;
            infoMessageTimer.Start();
        }

        private void InfoMessageTimer_Tick(object? sender, EventArgs e)
        {
            infoMessageTimer.Stop();
            panelInfo.Hide();
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
                try
                {
                    richTextBox.Rtf = File.ReadAllText(fileToOpen);
                    fileOpened = fileToOpen;
                    ShowHideSideMenu();
                }
                catch (Exception)
                {
                    ShowInfo("The note wasn't able to be opened because another app has the internal note file opened.");
                }
                
            }
        }

        private void showNotesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes");
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            File.Delete(fileOpened);
            ShowInfo("The opened note has been deleted.");
        }

        public string newFileName;

        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get Note Name
            noteName = fileOpened.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\", "");
            noteName = noteName.Replace(".rtf", "");

            formRenameNote.Show();
            
        }

        private void ButtonRename_Click(object? sender, EventArgs e)
        {
            SaveActualNote(sender, e);
            Debug.WriteLine("Renaming File");
            File.Move(fileOpened, Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NowNotes\\Notes\\" + textBoxRenameNote.Text + ".rtf");
            formRenameNote.Hide();
        }
    }
}