using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using NowNotes_Windows.Properties;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

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
		public string noteFolderPath;
		public bool themesDark = false;

		public FormMain(bool showSysTrayIcon = true)
		{
			InitializeComponent();
			RegisterHotKey(Handle, 1, MOD_WIN | MOD_ALT, VK_N);
			if (showSysTrayIcon == false)
			{
				notifyIcon.Visible = false;
			}
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
					rkey.SetValue("NowNotes", Application.ExecutablePath);
				}
				Settings.Default.FirstLaunch = false;
				Settings.Default.Save();
			}
			if (Settings.Default.CloudSyncEnabled) { noteFolderPath = Settings.Default.OneDriveFolder; }
			else { noteFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\Notes"; }
			Image resizeImage(Image imgToResize, Size size)
			{
				return (Image)(new Bitmap(imgToResize, size));
			}
			roundButtonNewNote.Image = resizeImage(roundButtonNewNote.Image, new Size(24, 24));
			timerScrolling.Start();
			// Check for updates
			CheckForUpdates();
			// Theme applying
			toolStrip.ForeColor = Color.FromArgb(74, 71, 57);
			if (Settings.Default.Theme == "dark") { ApplyDarkTheme(); themesDark = true; }
			else if (Settings.Default.Theme == "auto")
			{
				try
				{
					RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize");

					if (key != null)
					{
						object value = key.GetValue("AppsUseLightTheme");
						if (value != null)
						{
							int lightTheme = (int)value;
							if (lightTheme == 0)
							{
								ApplyDarkTheme();
								themesDark = true;
							}
						}
					}
				}
				catch (Exception ex) { }
			}
		}

		public void ApplyDarkTheme()
		{
			// Modify simple colors
			toolStrip.BackColor = Color.FromArgb(74, 71, 57);
			toolStrip.ForeColor = Color.FromArgb(205, 198, 180);
			richTextBox.BackColor = Color.FromArgb(29, 27, 22);
			richTextBox.ForeColor = Color.FromArgb(231, 226, 217);
			labelInfo.ForeColor = Color.FromArgb(231, 226, 217);
			panelInfo.ForeColor = Color.FromArgb(231, 226, 217);
			labelInfo.BackColor = Color.FromArgb(29, 27, 22);
			panelInfo.BackColor = Color.FromArgb(29, 27, 22);
			toolBar.BackColor = Color.FromArgb(74, 71, 57);
			toolBar.ForeColor = Color.FromArgb(205, 198, 180);
			roundButtonNewNote.BackColor = Color.FromArgb(82, 70, 0);
			panelSideMenu.BackColor = Color.FromArgb(74, 71, 57);
			panelSideMenu.ForeColor = Color.FromArgb(205, 198, 180);
			listBoxMenu.BackColor = Color.FromArgb(74, 71, 57);
			listBoxMenu.ForeColor = Color.FromArgb(205, 198, 180);
			panelSideMenuTitle.BackColor = Color.FromArgb(74, 71, 57);
			panelSideMenuTitle.ForeColor = Color.FromArgb(205, 198, 180);
			// Modify icons
			{
				// Menu
				{
					Bitmap pic = new Bitmap(toolStripButtonMenu.Image);
					for (int y = 0; (y <= (pic.Height - 1)); y++)
					{
						for (int x = 0; (x <= (pic.Width - 1)); x++)
						{
							Color inv = pic.GetPixel(x, y);
							inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
							pic.SetPixel(x, y, inv);
						}
					}

					toolStripButtonMenu.Image = pic;
				}
				// Add
				{
					Bitmap pic = new Bitmap(roundButtonNewNote.Image);
					for (int y = 0; (y <= (pic.Height - 1)); y++)
					{
						for (int x = 0; (x <= (pic.Width - 1)); x++)
						{
							Color inv = pic.GetPixel(x, y);
							inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
							pic.SetPixel(x, y, inv);
						}
					}
					roundButtonNewNote.Image = pic;
				}
				// More
				{
					Bitmap pic = new Bitmap(toolStripDropDownButtonNoteOptions.Image);
					for (int y = 0; (y <= (pic.Height - 1)); y++)
					{
						for (int x = 0; (x <= (pic.Width - 1)); x++)
						{
							Color inv = pic.GetPixel(x, y);
							inv = Color.FromArgb(inv.A, (255 - inv.R), (255 - inv.G), (255 - inv.B));
							pic.SetPixel(x, y, inv);
						}
					}
					toolStripDropDownButtonNoteOptions.Image = pic;
				}
			}
			// Window Borders
			UseImmersiveDarkMode(Handle, true);
		}

		private void notifyIcon_Click(object sender, EventArgs e)
		{
			ShowHideNoteWindow();
		}

		public void ShowHideNoteWindow()
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
					File.Create(noteFolderPath + "\\" + Resources.Untitled + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf");
					fileOpened = noteFolderPath + "\\" + Resources.Untitled + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf";
					System.Windows.Forms.Timer savingTimer = new System.Windows.Forms.Timer();
					savingTimer.Interval = 60000;
					savingTimer.Tick += SavingTimer_Tick;
					savingTimer.Start();
					noteName = fileOpened.Replace(noteFolderPath + "\\", "");
					noteName = noteName.Replace(".rtf", "");
					toolStripLabelTitle.Text = noteName;
					hasBeenShowed = true;
				}
				richTextBox.Focus();
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
				string[] notesFileNames = Directory.EnumerateFiles(noteFolderPath).ToArray();
				for (int i = 0; i < notesFileNames.Length; i++)
				{
					notesFileNames[i] = notesFileNames[i].Replace(noteFolderPath + "\\", "");
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
				string fileToOpen = noteFolderPath + "\\" + listBoxMenu.SelectedItem.ToString() + ".rtf";
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
			noteName = fileOpened.Replace(noteFolderPath + "\\", "");
			noteName = noteName.Replace(".rtf", "");
			toolStripLabelTitle.Text = noteName;
		}

		private void showNotesFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", noteFolderPath);
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
			noteName = fileOpened.Replace(noteFolderPath + "\\", "");
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
				File.Move(fileOpened, noteFolderPath + "\\" + textBoxRenameNote.Text + ".rtf");
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
			File.Create(noteFolderPath + "\\" + Resources.Untitled + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf");
			fileOpened = noteFolderPath + "\\" + Resources.Untitled + ((DateTime.Now.ToString()).Replace("/", "-")).Replace(":", "-") + ".rtf";
			if (sidemenuShowing) ShowHideSideMenu();
			ShowInfo(Resources.Note_saved_and_cleared);
		}

		private void FormMain_Resize(object sender, EventArgs e)
		{
			roundButtonNewNote.Location = new Point(Size.Width - 89, Size.Height - 115);
		}

		private void timerScrolling_Tick(object sender, EventArgs e)
		{
			if (richTextBox.GetPositionFromCharIndex(0).Y < 0)
			{
				if (!themesDark)
				{
					toolStrip.BackColor = Color.FromArgb(232, 226, 208);
				}
				else
				{
					toolStrip.BackColor = Color.FromArgb(205, 198, 180);
				}
			}
			else
			{
				if (!themesDark)
				{
					toolStrip.BackColor = Color.FromArgb(255, 251, 255);
				}
				else
				{
					toolStrip.BackColor = Color.FromArgb(74, 71, 57);
				}
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

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormSettings form = new FormSettings();
			form.Show();
		}

		public void CheckForUpdates()
		{
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
			content = content.Replace("\r", "").Replace("\n", "");
			Debug.WriteLine("Readed " + content);
			Debug.WriteLine("Product version is " + Application.ProductVersion);
			if (!Application.ProductVersion.Contains(content))
			{
				DialogResult result = MessageBox.Show(Resources.There_s_an_update_available_fo, Resources.Update_Available, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
				if (result == DialogResult.Yes)
				{
					string downloadPage = "https://github.com/SoyFaii/NowNotes/releases/download/v" + content + "/NowNotes_Setup.exe";
					Debug.WriteLine("Latest release download page: " + downloadPage);
					client.DownloadFile(downloadPage, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\UpdateDownload\\NowNotes_Setup.exe");
					Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\NowNotes\\UpdateDownload\\NowNotes_Setup.exe");
					Application.Exit();
				}
			}
		}

		// THIS CODE IS TOTALLY NOT TAKEN FROM STACK OVERFLOW

		[DllImport("dwmapi.dll")]
		private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		private const int DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1 = 19;
		private const int DWMWA_USE_IMMERSIVE_DARK_MODE = 20;

		private static bool UseImmersiveDarkMode(IntPtr handle, bool enabled)
		{
			if (IsWindows10OrGreater(17763))
			{
				var attribute = DWMWA_USE_IMMERSIVE_DARK_MODE_BEFORE_20H1;
				if (IsWindows10OrGreater(18985))
				{
					attribute = DWMWA_USE_IMMERSIVE_DARK_MODE;
				}

				int useImmersiveDarkMode = enabled ? 1 : 0;
				return DwmSetWindowAttribute(handle, (int)attribute, ref useImmersiveDarkMode, sizeof(int)) == 0;
			}

			return false;
		}

		private static bool IsWindows10OrGreater(int build = -1)
		{
			return Environment.OSVersion.Version.Major >= 10 && Environment.OSVersion.Version.Build >= build;
		}

		private void listBoxMenu_DrawItem(object sender, DrawItemEventArgs e)
		{
			Console.WriteLine("Item drawed");
			if (e.Index < 0) return;
			if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
				e = new DrawItemEventArgs(e.Graphics,
										  e.Font,
										  e.Bounds,
										  e.Index,
										  e.State ^ DrawItemState.Selected,
										  e.ForeColor,
										  Color.FromArgb(237, 226, 188));
			e.DrawBackground();
			e.Graphics.DrawString(listBoxMenu.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
			e.DrawFocusRectangle();
		}

		private const int MOD_WIN = 0x0008; // Windows key
		private const int MOD_ALT = 0x0001; // Alt key
		private const int VK_N = 0x4E; // N key

		[DllImport("user32.dll")]
		private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);

			const int WM_HOTKEY = 0x0312;
			if (m.Msg == WM_HOTKEY && m.WParam.ToInt32() == 1)
			{
				ShowHideNoteWindow();
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			UnregisterHotKey(this.Handle, 1);
		}
	}
}