using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Drawing;
using System.IO;

namespace MainDemo 
{
	public class WindowsFormWithTools : System.Windows.Forms.Form
	{
		public const string OPEN_PROFILES = "Profiles (*.prx)|*.prx";
		public const string OPEN_PICTURE_FILES = "Pictures (*.bmp;*.gif;*.jpg;*.tif;*.wmf;*.png;*.exf;*.emf)|*.bmp;*.gif;*.jpg;*.tif;*.wmf;*.png;*.emf;*.exf";
		public const string OPEN_MEDIA_FILES = "Clips (*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.mov;*.avs)|*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.mov;*.avs";
		public const string OPEN_MEDIA_FILES_EXTENDED = "Clips and Pictures (*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.mov;*.avs;*.bmp;*.gif;*.jpg;*.tif;*.wmf)|*.mp*;*.vro;*.avi;*.wav;*.asf;*.wm*;*.vob;*.mov;*.avs;*.bmp;*.gif;*.jpg;*.tif;*.wmf";

		public enum ShowCommands 
		{
			SW_HIDE				= 0,
			SW_SHOWNORMAL		= 1,
			SW_SHOWMINIMIZED    = 2,
			SW_SHOWMAXIMIZED    = 3,
			SW_SHOWNOACTIVATE   = 4,
			SW_SHOW				= 5,
			SW_MINIMIZE			= 6,
			SW_SHOWMINNOACTIVE  = 7,
			SW_SHOWNA			= 8,
			SW_RESTORE			= 9,
			SW_SHOWDEFAULT      = 10,
			SW_FORCEMINIMIZE    = 11
		}

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct BITMAP
        {
        public Int32 bmType;
        public Int32 bmWidth;
        public Int32 bmHeight;
        public Int32 bmWidthBytes;
        public Int16 bmPlanes;
        public Int16 bmBitsPixel;
        public IntPtr bmBits;
        }
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct BITMAPINFOHEADER
        {
        public int biSize;
        public int biWidth;
        public int biHeight;
        public Int16 biPlanes;
        public Int16 biBitCount;
        public int biCompression;
        public int biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public int biClrUsed;
        public int bitClrImportant;
        }

    [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct DIBSECTION
        {
        public BITMAP dsBm;
        public BITMAPINFOHEADER dsBmih;
        public int dsBitField1;
        public int dsBitField2;
        public int dsBitField3;
        public IntPtr dshSection;
        public int dsOffset;
        }

        public const int SizeOf_DIBSECTION = 84;

		const int INVALID_HANDLE_VALUE = -1;

		[DllImport("shell32.dll")]
		public static extern IntPtr ShellExecute(
			IntPtr hwnd,
			string lpOperation,
			string lpFile,
			string lpParameters,
			string lpDirectory,
			ShowCommands nShowCmd);

		public void SetRadioButtonInGroupUsingTag(System.Windows.Forms.Control FrameName, short Indx)
		{
			foreach (System.Windows.Forms.Control Ctrl in FrameName.Controls) 
			{
				if (Ctrl.GetType() == typeof (System.Windows.Forms.RadioButton))
				{
					if (Ctrl.Tag != null) 
					{
						if (Ctrl.Tag.ToString() == Indx.ToString()) 
						{
							(Ctrl as System.Windows.Forms.RadioButton).Checked = true;
						}
					}
				}
			}
		}

		public void AddLog (System.Windows.Forms.TextBox TxtBox, string Line)
		{
			TxtBox.Text += "\r\n" + Line;
            TxtBox.Select(TxtBox.Text.Length - 1, 0);
            TxtBox.ScrollToCaret();
		}

		public void LoadTextBox(System.Windows.Forms.ListBox Dest, string Source)
		{
			int StartPos;
			int Endpos;
			bool Done;

			StartPos = 0;
			Done = false;
			Dest.Items.Clear();
			while (! Done) 
			{
				if (StartPos >= Source.Length) 
				{
					Done = true;
				}
				else 
				{
					Endpos = Source.IndexOf("\r", StartPos);
					if (Endpos >= 0) 
					{
						Dest.Items.Add(Source.Substring(StartPos, Endpos - StartPos));
						StartPos = Endpos + 2; // skip CR/LF
					}
					else 
					{
						Done = true;
					}
				}
			}
		}


		public void AssignListToComboBox(System.Windows.Forms.ComboBox Dest, string Source, int Indx) 
		{
			int StartPos;
			int Endpos;
			bool Done;

			if (Source == null) return;

			Dest.Items.Clear();


			StartPos = 0;
			Done = false;
			Dest.Items.Clear();
			while (! Done) 
			{
				if (StartPos >= Source.Length) 
				{
					Done = true;
				}
				else 
				{
					Endpos = Source.IndexOf("\r", StartPos);
					if (Endpos >= 0) 
					{
						Dest.Items.Add(Source.Substring(StartPos, Endpos - StartPos));
						StartPos = Endpos + 2; // skip CR/LF
					}
					else 
					{
						Done = true;
					}
				}
			}

			if ((Indx >= 0) && (Indx < Dest.Items.Count)) 
			{
				Dest.SelectedIndex = Indx;
			}
		}
		
		public bool IsNumeric(string numberString)
		{	
		    double Number;
            return double.TryParse(numberString, System.Globalization.NumberStyles.Any, null, out Number);

		}
		
		public int CreateBitmapHandleFromPictureBox (System.Windows.Forms.PictureBox PbControl)
		{
			Bitmap bmp = new Bitmap (PbControl.ClientRectangle.Width, PbControl.ClientRectangle.Height);
			Graphics gMem = Graphics.FromImage(bmp);

            gMem.DrawImageUnscaled(PbControl.Image, new Point(0, 0));

            gMem.Dispose();

            int BitmapHandle = bmp.GetHbitmap().ToInt32();

			return BitmapHandle;
		}
	}


    public class VideoFromImagesFileList: ArrayList
    {
        private int m_CurrentIndex;
        private string m_CurrentFolder;
        private bool m_LoopIndefinitely;

        public VideoFromImagesFileList()
        {
            m_CurrentFolder = "";
            m_CurrentIndex = 0;
            m_LoopIndefinitely = false;
        }

        class FileSort : IComparer 
        {
            public int Compare(object x, object y)
            {
                FileInfo d1 = x as FileInfo;
                FileInfo d2 = y as FileInfo;
                return d1.Name.CompareTo(d2.Name);
            }   
        }

        public bool ReinitFolder (string Folder, string FileType, bool LoopIndefinitely)
        {
            m_CurrentFolder = Folder.Trim();
            if (m_CurrentFolder == "") 
            {
                m_CurrentFolder = Directory.GetCurrentDirectory();
            }
            this.Clear();
            m_CurrentIndex = 0;
            DirectoryInfo di = new DirectoryInfo(m_CurrentFolder);
            if (di.Exists) 
            {
                FileInfo[] fileInfoArray = di.GetFiles (FileType);
                Array.Sort(fileInfoArray, 0, fileInfoArray.Length, new FileSort()); 
                this.AddRange (fileInfoArray);
                return this.Count > 0;
            }
            else 
            {
                return false;
            }
        }

        public string FirstImageFile ()
        {
            m_CurrentIndex = 0;
            return NextImageFile();
        }

        public string NextImageFile ()
        {
            string ImageFileFound;

            if (this.Count == 0) 
            {
                return "";
            }
            else if ((m_CurrentIndex >= this.Count) && (! m_LoopIndefinitely)) { 
               m_CurrentIndex = 0;
            }
            ImageFileFound = m_CurrentFolder + "\\" + this[m_CurrentIndex++].ToString();
            return ImageFileFound;
        }
    }

	// this form is inherited by all the sub-forms (excepted the MainForm form).
	// when a sub-form is closed, it is simply hidden (instead of being destroyed), because MainForm may still reference it.
	public class SubForm : WindowsFormWithTools
	{
		public MainForm cMainForm; // assigned by MainForm when it creates the sub-form, then used by the sub-form to reference MainForm.

		public SubForm() 
		{
			this.Closing += new System.ComponentModel.CancelEventHandler(this.SubForm_Closing);
		}

		private void SubForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = true;
			this.Visible = false;
		}

		private void InitializeComponent()
		{
			// 
			// SubForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(1112, 437);
			this.Name = "SubForm";

		}

		new private void VisibleChanged (object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				BringToFront();
			}
		}
	}
}

 


