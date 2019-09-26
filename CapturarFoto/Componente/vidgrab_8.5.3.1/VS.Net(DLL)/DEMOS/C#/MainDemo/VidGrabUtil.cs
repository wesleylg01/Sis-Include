using System.Runtime.InteropServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;


namespace MainDemo
{
    public class WindowsFormWithTools : System.Windows.Forms.Form
    {
        public const string AUDIO_CLIPS = "*.mp3;*.wav;*.wma;*.mid";
        public const string VIDEO_CLIPS = "*.mp*;*.vro;*.avi;*.asf;*.wmv;*.vob;*.avs;*.mov;*.divx;*.mp4;*.mts;*.3gp;*.swf;*.m2v;*.mkv;*.flv;*.wemb;*.ts;*.m4v;*.mp4v";
        public const string IMAGE_FILES = "*.jpg;*.jpeg;*.jpe;*.bmp;*.gif;*.png";
        public const string OPEN_MEDIA_FILES = "All media files|" + VIDEO_CLIPS + AUDIO_CLIPS + IMAGE_FILES
                        + "|Video clips|" + VIDEO_CLIPS
                        + "|Audio clips|" + AUDIO_CLIPS;
        public const string OPEN_MEDIA_FILES_EXTENDED = OPEN_MEDIA_FILES
                        + "|Image files|" + IMAGE_FILES;
        public const string OPEN_PICTURE_FILES = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif;*.tiff;*.wmf;*.emf;*.exf;*.jpe;*.jpeg";
        public const string OPEN_PROFILES = "WMV9 profiles (*.prx)|*.prx";
        public const string OPEN_COMPRESSOR_SETTINGS = "Compressor saved settings (*.txt)|*.txt";

        public enum ShowCommands
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct TFrameInfo
        {
            public Int64 frameTime;
            public Int64 frameTime_TotalMin;
            public Int64 frameTime_TotalSec;
            public Int64 frameTime_TotalHs;
            public Int64 frameNumber;
            public Int32 droppedFrameCount;
            public Int32 frameTime_Hour;
            public Int32 frameTime_Min;
            public Int32 frameTime_Sec;
            public Int32 frameTime_Hs;
            public Int32 dVTimeCode_IsAvailable;
            public Int32 dVTimeCode_Hour;
            public Int32 dVTimeCode_Min;
            public Int32 dVTimeCode_Sec;
            public Int32 dVTimeCode_Ff;
            public Int32 dVTimeCode_TrackNumber;
            public Int32 dVDateTime_IsAvailable;
            public Int32 dVDateTime_Year;
            public Int32 dVDateTime_Month;
            public Int32 dVDateTime_Day;
            public Int32 dVDateTime_Hour;
            public Int32 dVDateTime_Min;
            public Int32 dVDateTime_Sec;
            public VidGrab.TCurrentState currentState;
            public VidGrab.TGraphState graphState;
            public VidGrab.TPlayerState playerState;
            public Int32 reserved0;
            public Int32 reserved1;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct TFrameBitmapInfo
        {
            public Int32 bitmapWidth;
            public Int32 bitmapHeight;
            public Int32 bitmapBitsPerPixel;
            public Int32 bitmapLineSize;
            public Int32 bitmapSize;
            public Int32 bitmapPlanes;
            public Int32 bitmapHandle;
            public Int32 bitmapDataPtr;
            public Int32 bitmapDC;
            public Int32 CurrentXMouseLocation;
            public Int32 CurrentYMouseLocation;
            public Int32 LastXMouseDownLocation;
            public Int32 LastYMouseDownLocation;
            public Boolean IsMouseDown;
            public VidGrab.TMouseButton LastMouseButtonClicked;
            public Int32 reserved0;
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
        public struct RGBTRIPLE
        {
            public byte rgbtBlue;
            public byte rgbtGreen;
            public byte rgbtRed;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public struct RGBQUAD
        {
            public byte rgbBlue;
            public byte rgbGreen;
            public byte rgbRed;
            public byte rgbReserved;
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

        [DllImport("gdi32")]
        public static extern int GetObject(IntPtr hObject, int nCount, IntPtr lpObject);

        [DllImport("gdi32")]
        public static extern int DeleteObject(IntPtr hObject);

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
                if (Ctrl.GetType() == typeof(System.Windows.Forms.RadioButton))
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

        public void AddLog(System.Windows.Forms.TextBox TxtBox, string Line)
        {
            TxtBox.AppendText(Environment.NewLine + Line);
        }

        IList<string> CRLFDelimitedStringToIList(string CRLFString)
        {
            IList<string> list = new List<string>();

            if (! String.IsNullOrEmpty(CRLFString)) 
            {
                string[] lines = Regex.Split(CRLFString, "\r\n");
                foreach (string line in lines)
                {
                    list.Add(line);
                }
            }
            return list;
        }

        public void LoadTextBox(System.Windows.Forms.ListBox Dest, string CRLFString)
        {
            Dest.Items.Clear();
            IList<string> ListItems = CRLFDelimitedStringToIList(CRLFString);
            foreach (string Item in ListItems)
            {
                Dest.Items.Add(Item);
            }
        }

        public void AssignListToComboBox(System.Windows.Forms.ComboBox Dest, string CRLFString, int Indx)
        {
            Dest.Items.Clear();
            IList<string> ListItems = CRLFDelimitedStringToIList(CRLFString);
            foreach (string Item in ListItems)
            {
                Dest.Items.Add(Item);
            }
            if ((Indx >= 0) && (Indx < Dest.Items.Count))
            {
                Dest.SelectedIndex = Indx;
            }
            else
            {
                Dest.SelectedIndex = -1;
            }
        }

        public bool IsNumeric(string numberString)
        {
            double Number;
            return double.TryParse(numberString, System.Globalization.NumberStyles.Any, null, out Number);
        }

        public int CreateBitmapHandleFromPictureBox(System.Windows.Forms.PictureBox PbControl)
        {
            Bitmap bmp = new Bitmap(PbControl.ClientRectangle.Width, PbControl.ClientRectangle.Height);
            Graphics gMem = Graphics.FromImage(bmp);

            gMem.DrawImageUnscaled(PbControl.Image, new Point(0, 0));

            gMem.Dispose();

            int BitmapHandle = bmp.GetHbitmap().ToInt32();

            return BitmapHandle;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WindowsFormWithTools
            // 
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Name = "WindowsFormWithTools";
            this.Load += new System.EventHandler(this.WindowsFormWithTools_Load);
            this.ResumeLayout(false);

        }

        private void WindowsFormWithTools_Load(object sender, EventArgs e)
        {

        }
    }

    public class VideoFromImagesFileList : ArrayList
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

        public bool ReinitFolder(string Folder, string FileType, bool LoopIndefinitely)
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
                FileInfo[] fileInfoArray = di.GetFiles(FileType);
                Array.Sort(fileInfoArray, 0, fileInfoArray.Length, new FileSort());
                this.AddRange(fileInfoArray);
                return this.Count > 0;
            }
            else
            {
                return false;
            }
        }

        public string FirstImageFile()
        {
            m_CurrentIndex = 0;
            return NextImageFile();
        }

        public string NextImageFile()
        {
            string ImageFileFound;

            if (this.Count == 0)
            {
                return "";
            }
            else if ((m_CurrentIndex >= this.Count) && (!m_LoopIndefinitely))
            {
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

    }
}

