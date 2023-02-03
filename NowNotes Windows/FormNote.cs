using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using NowNotes_Windows.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net;
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
            formRenameNote.Text = Resources.Rename_Note;
            formRenameNote.TopMost = true;
            //
            textBoxRenameNote.Parent = formRenameNote;
            textBoxRenameNote.Size = new Size(358, 27);
            textBoxRenameNote.Location = new Point(12, 12);
            textBoxRenameNote.Text = noteName;
            //
            System.Windows.Forms.Button buttonRename = new System.Windows.Forms.Button();
            buttonRename.Parent = formRenameNote;
            buttonRename.Text = Resources.Rename;
            buttonRename.Size = new Size(94, 29);
            buttonRename.Location = new Point(276, 45);
            buttonRename.Click += ButtonRename_Click;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes");
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\UpdateDownload");
            }
            if (Debugger.IsAttached)
            {
                debugToolStripMenuItem.Visible = true;
            }
            if (Settings.Default.FirstLaunch)
            {
                DialogResult result = MessageBox.Show(Resources.Do_you_want_to_set_NowNotes_to, Resources.Launch_on_Startup, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RegistryKey rkey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
                    rkey.SetValue("NowNotes", System.Windows.Forms.Application.ExecutablePath);
                }
                Settings.Default.FirstLaunch = false;
                Settings.Default.Save();
            }
            Image resizeImage(Image imgToResize, Size size)
            {
                return (Image)(new Bitmap(imgToResize, size));
            }
            this.roundButtonNewNote.Image = resizeImage(Resources.add, new Size(24, 24));
            timerScrolling.Start();
            // Check for updates and install if there's one
            Debug.WriteLine("Checking for updates...");
            WebClient client = new WebClient();
            Debug.WriteLine("WebClient created");
            Stream stream = client.OpenRead("https://raw.githubusercontent.com/SoyFaii/NowNotes/master/NowNotes%20Windows/latest_stable_version.txt");
            Debug.WriteLine("Page opened");
            StreamReader reader = new StreamReader(stream);
            Debug.WriteLine("Reader created");
            String content = reader.ReadToEnd();
            content = content.Replace(" ", "");
            content = content.Replace(Environment.NewLine, "");
            Debug.WriteLine("Readed " + content);
            Debug.WriteLine("Product version is " + Application.ProductVersion);
            if (!Application.ProductVersion.Contains(content))
            {
                DialogResult result = MessageBox.Show("There's an update available for NowNotes. Do you want to install it?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    client.DownloadFile("https://github.com/SoyFaii/NowNotes/releases/download/v" + content + "/NowNotes_Setup.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\UpdateDownload\\NowNotes_Setup.exe");
                    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\UpdateDownload\\NowNotes_Setup.exe");
                    Application.Exit();
                }
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
                    File.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf");
                    fileOpened = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf";
                    System.Windows.Forms.Timer savingTimer = new System.Windows.Forms.Timer();
                    savingTimer.Interval = 60000;
                    savingTimer.Tick += SavingTimer_Tick;
                    savingTimer.Start();
                    noteName = fileOpened.Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\", "");
                    noteName = noteName.Replace(".rtf", "");
                    toolStripLabelTitle.Text = noteName;
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
                ShowInfo(Resources.The_note_wasn_t_able_to_be_sav);
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
            ShowHideSideMenu();
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
                string[] notesFileNames = Directory.EnumerateFiles(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes").ToArray();
                for (int i = 0; i < notesFileNames.Length; i++)
                {
                    notesFileNames[i] = notesFileNames[i].Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\", "");
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
                string fileToOpen = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + listBoxMenu.SelectedItem.ToString() + ".rtf";
                try
                {
                    richTextBox.Rtf = File.ReadAllText(fileToOpen);
                    fileOpened = fileToOpen;
                    ShowHideSideMenu();
                }
                catch (Exception)
                {
                    ShowInfo(Resources.The_note_wasn_t_able_to_be_ope);
                }
                
            }
            noteName = fileOpened.Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\", "");
            noteName = noteName.Replace(".rtf", "");
            toolStripLabelTitle.Text = noteName;
        }

        private void showNotesFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes");
        }

        private void deleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            File.Delete(fileOpened);
            ShowInfo(Resources.The_opened_note_has_been_delet);
        }

        public string newFileName;

        private void renameNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get Note Name
            noteName = fileOpened.Replace(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\", "");
            noteName = noteName.Replace(".rtf", "");

            formRenameNote.Show();
            toolStripLabelTitle.Text = noteName;
        }

        private void ButtonRename_Click(object? sender, EventArgs e)
        {
            SaveActualNote(sender, e);
            Debug.WriteLine("Renaming File");
            try
            {
                File.Move(fileOpened, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + textBoxRenameNote.Text + ".rtf");
            }
            catch (Exception ex)
            {
                ShowInfo(Resources.The_note_wasn_t_able_to_be_ren);
            }
            formRenameNote.Hide();
        }

        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            SaveActualNote(sender, e);
            richTextBox.Clear();
            File.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf");
            fileOpened = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes\\" + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf";
            if (sidemenuShowing) ShowHideSideMenu();
            ShowInfo(Resources.Note_saved_and_cleared);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            roundButtonNewNote.Location = new Point(Size.Width - 89, Size.Height - 115);
        }

        private void timerScrolling_Tick(object sender, EventArgs e)
        {
            if(richTextBox.GetPositionFromCharIndex(0).Y < 0)
            {
                toolStrip.BackColor = Color.FromArgb(232, 226, 208);
            }
            else
            {
                toolStrip.BackColor = Color.FromArgb(255, 251, 255);
            }
        }

        private void focusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
                WindowState = FormWindowState.Normal;
            }
        }
    }
    public class RoundButton : System.Windows.Forms.Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }
}