using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Player.
	/// </summary>
	public class Player : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        public Button btnChooseClip;
        internal Button btnOpenAtFrames;
        internal GroupBox GroupBox1;
        internal ListBox lstPlaylist;
        internal CheckBox chkPlaylistRandom;
        internal CheckBox chkPlaylistLoop;
        internal Button btnPlaylistClose;
        internal Button btnPlaylistStopAfterCurrent;
        internal Button btnPlaylistPrevious;
        internal Button btnPlaylistNext;
        internal Button btnPlaylistPlay;
        internal Button btnPlaylistAdd;
        internal Label Label6;
        internal Label Label5;
        internal CheckBox chkLoop;
        internal CheckBox chkReopen;
        internal CheckBox chkKeepBounds;
        internal Label label3;
        internal Button btnOpenAtTimes;
        internal TextBox txtStopTime;
        internal TextBox txtStartTime;
        internal TextBox txtStopFrame;
        internal TextBox txtStartFrame;
        public Label Label30;
        internal CheckBox chkUseClock;
        public Button btnHeaderInfo;
        public Button btnClipGeneralInfo;
        internal NumericUpDown updPlayerFastSeekSpeed;
        internal NumericUpDown updPlayerSpeedRatio;
        public TextBox edtPlayerFileName;
        public Button btnClipDuration;
        public Button btnPlayerOpenFile;
        public Button btnOpenLastClipRecorded;
        public Button btnOpenLastClipPlayed;
        public Button btnPlayerCloseFile;
        public Button btnPlayerOpenStreamingURL;
        public CheckBox btnAutoPlay;
        public CheckBox chkPlayerAudioRendering;
        public CheckBox chkRefreshPausedDisplay;
        public Label Label31;
        internal Label label2;
        internal Label label1;
        internal ImageList ImageList1;
        internal Button Button1;
        internal Button btnOpenDVD;
        private TextBox updSpeedRadioValue;
        private System.ComponentModel.IContainer components = null;

		public Player()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Player));
			this.btnChooseClip = new System.Windows.Forms.Button();
			this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
			this.btnOpenAtFrames = new System.Windows.Forms.Button();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.lstPlaylist = new System.Windows.Forms.ListBox();
			this.chkPlaylistRandom = new System.Windows.Forms.CheckBox();
			this.chkPlaylistLoop = new System.Windows.Forms.CheckBox();
			this.btnPlaylistClose = new System.Windows.Forms.Button();
			this.btnPlaylistStopAfterCurrent = new System.Windows.Forms.Button();
			this.btnPlaylistPrevious = new System.Windows.Forms.Button();
			this.btnPlaylistNext = new System.Windows.Forms.Button();
			this.btnPlaylistPlay = new System.Windows.Forms.Button();
			this.btnPlaylistAdd = new System.Windows.Forms.Button();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.chkLoop = new System.Windows.Forms.CheckBox();
			this.chkReopen = new System.Windows.Forms.CheckBox();
			this.chkKeepBounds = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnOpenAtTimes = new System.Windows.Forms.Button();
			this.txtStopTime = new System.Windows.Forms.TextBox();
			this.txtStartTime = new System.Windows.Forms.TextBox();
			this.txtStopFrame = new System.Windows.Forms.TextBox();
			this.txtStartFrame = new System.Windows.Forms.TextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.chkUseClock = new System.Windows.Forms.CheckBox();
			this.btnHeaderInfo = new System.Windows.Forms.Button();
			this.btnClipGeneralInfo = new System.Windows.Forms.Button();
			this.updPlayerFastSeekSpeed = new System.Windows.Forms.NumericUpDown();
			this.updPlayerSpeedRatio = new System.Windows.Forms.NumericUpDown();
			this.edtPlayerFileName = new System.Windows.Forms.TextBox();
			this.btnClipDuration = new System.Windows.Forms.Button();
			this.btnPlayerOpenFile = new System.Windows.Forms.Button();
			this.btnOpenLastClipRecorded = new System.Windows.Forms.Button();
			this.btnOpenLastClipPlayed = new System.Windows.Forms.Button();
			this.btnPlayerCloseFile = new System.Windows.Forms.Button();
			this.btnPlayerOpenStreamingURL = new System.Windows.Forms.Button();
			this.btnAutoPlay = new System.Windows.Forms.CheckBox();
			this.chkPlayerAudioRendering = new System.Windows.Forms.CheckBox();
			this.chkRefreshPausedDisplay = new System.Windows.Forms.CheckBox();
			this.Label31 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.btnOpenDVD = new System.Windows.Forms.Button();
			this.updSpeedRadioValue = new System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updPlayerFastSeekSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updPlayerSpeedRatio)).BeginInit();
			this.SuspendLayout();
			// 
			// btnChooseClip
			// 
			this.btnChooseClip.BackColor = System.Drawing.SystemColors.Control;
			this.btnChooseClip.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnChooseClip.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnChooseClip.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnChooseClip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnChooseClip.ImageIndex = 0;
			this.btnChooseClip.ImageList = this.ImageList1;
			this.btnChooseClip.Location = new System.Drawing.Point(12, 16);
			this.btnChooseClip.Name = "btnChooseClip";
			this.btnChooseClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnChooseClip.Size = new System.Drawing.Size(107, 22);
			this.btnChooseClip.TabIndex = 109;
			this.btnChooseClip.Text = "open a clip...";
			this.btnChooseClip.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnChooseClip.Click += new System.EventHandler(this.btnChooseClip_Click);
			// 
			// ImageList1
			// 
			this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
			this.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia;
			// 
			// btnOpenAtFrames
			// 
			this.btnOpenAtFrames.Location = new System.Drawing.Point(172, 104);
			this.btnOpenAtFrames.Name = "btnOpenAtFrames";
			this.btnOpenAtFrames.Size = new System.Drawing.Size(101, 20);
			this.btnOpenAtFrames.TabIndex = 123;
			this.btnOpenAtFrames.Text = "open at frames ->";
			this.btnOpenAtFrames.Click += new System.EventHandler(this.btnOpenAtFrames_Click);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.lstPlaylist);
			this.GroupBox1.Controls.Add(this.chkPlaylistRandom);
			this.GroupBox1.Controls.Add(this.chkPlaylistLoop);
			this.GroupBox1.Controls.Add(this.btnPlaylistClose);
			this.GroupBox1.Controls.Add(this.btnPlaylistStopAfterCurrent);
			this.GroupBox1.Controls.Add(this.btnPlaylistPrevious);
			this.GroupBox1.Controls.Add(this.btnPlaylistNext);
			this.GroupBox1.Controls.Add(this.btnPlaylistPlay);
			this.GroupBox1.Controls.Add(this.btnPlaylistAdd);
			this.GroupBox1.Location = new System.Drawing.Point(540, 16);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(369, 160);
			this.GroupBox1.TabIndex = 116;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Playlist";
			// 
			// lstPlaylist
			// 
			this.lstPlaylist.Location = new System.Drawing.Point(75, 46);
			this.lstPlaylist.Name = "lstPlaylist";
			this.lstPlaylist.Size = new System.Drawing.Size(287, 95);
			this.lstPlaylist.TabIndex = 8;
			// 
			// chkPlaylistRandom
			// 
			this.chkPlaylistRandom.Location = new System.Drawing.Point(8, 70);
			this.chkPlaylistRandom.Name = "chkPlaylistRandom";
			this.chkPlaylistRandom.Size = new System.Drawing.Size(72, 16);
			this.chkPlaylistRandom.TabIndex = 7;
			this.chkPlaylistRandom.Text = "Random";
			this.chkPlaylistRandom.CheckedChanged += new System.EventHandler(this.chkPlaylistRandom_CheckedChanged);
			// 
			// chkPlaylistLoop
			// 
			this.chkPlaylistLoop.Location = new System.Drawing.Point(8, 46);
			this.chkPlaylistLoop.Name = "chkPlaylistLoop";
			this.chkPlaylistLoop.Size = new System.Drawing.Size(56, 16);
			this.chkPlaylistLoop.TabIndex = 6;
			this.chkPlaylistLoop.Text = "Loop";
			this.chkPlaylistLoop.CheckedChanged += new System.EventHandler(this.chkPlaylistLoop_CheckedChanged);
			// 
			// btnPlaylistClose
			// 
			this.btnPlaylistClose.Location = new System.Drawing.Point(319, 15);
			this.btnPlaylistClose.Name = "btnPlaylistClose";
			this.btnPlaylistClose.Size = new System.Drawing.Size(43, 23);
			this.btnPlaylistClose.TabIndex = 5;
			this.btnPlaylistClose.Text = "Close";
			this.btnPlaylistClose.Click += new System.EventHandler(this.btnPlaylistClose_Click);
			// 
			// btnPlaylistStopAfterCurrent
			// 
			this.btnPlaylistStopAfterCurrent.Location = new System.Drawing.Point(213, 15);
			this.btnPlaylistStopAfterCurrent.Name = "btnPlaylistStopAfterCurrent";
			this.btnPlaylistStopAfterCurrent.Size = new System.Drawing.Size(102, 24);
			this.btnPlaylistStopAfterCurrent.TabIndex = 4;
			this.btnPlaylistStopAfterCurrent.Text = "Stop after current";
			this.btnPlaylistStopAfterCurrent.Click += new System.EventHandler(this.btnPlaylistStopAfterCurrent_Click);
			// 
			// btnPlaylistPrevious
			// 
			this.btnPlaylistPrevious.Location = new System.Drawing.Point(148, 15);
			this.btnPlaylistPrevious.Name = "btnPlaylistPrevious";
			this.btnPlaylistPrevious.Size = new System.Drawing.Size(61, 24);
			this.btnPlaylistPrevious.TabIndex = 3;
			this.btnPlaylistPrevious.Text = "Previous";
			this.btnPlaylistPrevious.Click += new System.EventHandler(this.btnPlaylistPrevious_Click);
			// 
			// btnPlaylistNext
			// 
			this.btnPlaylistNext.Location = new System.Drawing.Point(104, 15);
			this.btnPlaylistNext.Name = "btnPlaylistNext";
			this.btnPlaylistNext.Size = new System.Drawing.Size(40, 24);
			this.btnPlaylistNext.TabIndex = 2;
			this.btnPlaylistNext.Text = "Next";
			this.btnPlaylistNext.Click += new System.EventHandler(this.btnPlaylistNext_Click);
			// 
			// btnPlaylistPlay
			// 
			this.btnPlaylistPlay.Location = new System.Drawing.Point(60, 15);
			this.btnPlaylistPlay.Name = "btnPlaylistPlay";
			this.btnPlaylistPlay.Size = new System.Drawing.Size(40, 24);
			this.btnPlaylistPlay.TabIndex = 1;
			this.btnPlaylistPlay.Text = "Play";
			this.btnPlaylistPlay.Click += new System.EventHandler(this.btnPlaylistPlay_Click);
			// 
			// btnPlaylistAdd
			// 
			this.btnPlaylistAdd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPlaylistAdd.Location = new System.Drawing.Point(8, 16);
			this.btnPlaylistAdd.Name = "btnPlaylistAdd";
			this.btnPlaylistAdd.Size = new System.Drawing.Size(48, 23);
			this.btnPlaylistAdd.TabIndex = 0;
			this.btnPlaylistAdd.Text = "Add...";
			this.btnPlaylistAdd.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
			// 
			// Label6
			// 
			this.Label6.Location = new System.Drawing.Point(131, 1);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(768, 12);
			this.Label6.TabIndex = 131;
			this.Label6.Text = "to use only the player, disable the live video and audio capture devices by setii" +
				"ng VideoDevice = -1 and AudioDevice = -1 (\"video source\" and \"audio\")";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label5.Location = new System.Drawing.Point(4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(90, 16);
			this.Label5.TabIndex = 130;
			this.Label5.Text = "Player functions";
			// 
			// chkLoop
			// 
			this.chkLoop.Location = new System.Drawing.Point(4, 84);
			this.chkLoop.Name = "chkLoop";
			this.chkLoop.Size = new System.Drawing.Size(144, 16);
			this.chkLoop.TabIndex = 129;
			this.chkLoop.Text = "loop (repeat indefinitely)";
			this.chkLoop.CheckedChanged += new System.EventHandler(this.chkLoop_CheckedChanged);
			// 
			// chkReopen
			// 
			this.chkReopen.Location = new System.Drawing.Point(426, 131);
			this.chkReopen.Name = "chkReopen";
			this.chkReopen.Size = new System.Drawing.Size(116, 18);
			this.chkReopen.TabIndex = 126;
			this.chkReopen.Text = "reopen (if opened)";
			// 
			// chkKeepBounds
			// 
			this.chkKeepBounds.Checked = true;
			this.chkKeepBounds.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkKeepBounds.Location = new System.Drawing.Point(426, 107);
			this.chkKeepBounds.Name = "chkKeepBounds";
			this.chkKeepBounds.Size = new System.Drawing.Size(104, 18);
			this.chkKeepBounds.TabIndex = 125;
			this.chkKeepBounds.Text = "keep bounds";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Gray;
			this.label3.Location = new System.Drawing.Point(169, 148);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(323, 16);
			this.label3.TabIndex = 124;
			this.label3.Text = "(times are expressed in 100ns units e.g. 3 seconds - 30000000)";
			// 
			// btnOpenAtTimes
			// 
			this.btnOpenAtTimes.Location = new System.Drawing.Point(172, 128);
			this.btnOpenAtTimes.Name = "btnOpenAtTimes";
			this.btnOpenAtTimes.Size = new System.Drawing.Size(101, 20);
			this.btnOpenAtTimes.TabIndex = 122;
			this.btnOpenAtTimes.Text = "open at times ->";
			this.btnOpenAtTimes.Click += new System.EventHandler(this.btnOpenAtTimes_Click);
			// 
			// txtStopTime
			// 
			this.txtStopTime.Location = new System.Drawing.Point(351, 128);
			this.txtStopTime.Name = "txtStopTime";
			this.txtStopTime.Size = new System.Drawing.Size(71, 20);
			this.txtStopTime.TabIndex = 121;
			this.txtStopTime.Text = "";
			// 
			// txtStartTime
			// 
			this.txtStartTime.Location = new System.Drawing.Point(276, 128);
			this.txtStartTime.Name = "txtStartTime";
			this.txtStartTime.Size = new System.Drawing.Size(71, 20);
			this.txtStartTime.TabIndex = 120;
			this.txtStartTime.Text = "";
			// 
			// txtStopFrame
			// 
			this.txtStopFrame.Location = new System.Drawing.Point(351, 104);
			this.txtStopFrame.Name = "txtStopFrame";
			this.txtStopFrame.Size = new System.Drawing.Size(71, 20);
			this.txtStopFrame.TabIndex = 119;
			this.txtStopFrame.Text = "";
			// 
			// txtStartFrame
			// 
			this.txtStartFrame.Location = new System.Drawing.Point(276, 104);
			this.txtStartFrame.Name = "txtStartFrame";
			this.txtStartFrame.Size = new System.Drawing.Size(71, 20);
			this.txtStartFrame.TabIndex = 118;
			this.txtStartFrame.Text = "";
			// 
			// Label30
			// 
			this.Label30.AutoSize = true;
			this.Label30.BackColor = System.Drawing.SystemColors.Control;
			this.Label30.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label30.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label30.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label30.Location = new System.Drawing.Point(46, 112);
			this.Label30.Name = "Label30";
			this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label30.Size = new System.Drawing.Size(118, 16);
			this.Label30.TabIndex = 117;
			this.Label30.Text = "normal play speed ratio";
			// 
			// chkUseClock
			// 
			this.chkUseClock.Location = new System.Drawing.Point(172, 84);
			this.chkUseClock.Name = "chkUseClock";
			this.chkUseClock.Size = new System.Drawing.Size(72, 16);
			this.chkUseClock.TabIndex = 114;
			this.chkUseClock.Text = "use clock";
			this.chkUseClock.CheckedChanged += new System.EventHandler(this.chkUseClock_CheckedChanged);
			// 
			// btnHeaderInfo
			// 
			this.btnHeaderInfo.BackColor = System.Drawing.SystemColors.Control;
			this.btnHeaderInfo.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnHeaderInfo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnHeaderInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnHeaderInfo.Location = new System.Drawing.Point(386, 42);
			this.btnHeaderInfo.Name = "btnHeaderInfo";
			this.btnHeaderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnHeaderInfo.Size = new System.Drawing.Size(78, 21);
			this.btnHeaderInfo.TabIndex = 113;
			this.btnHeaderInfo.Text = "header info?";
			this.btnHeaderInfo.Click += new System.EventHandler(this.btnHeaderInfo_Click);
			// 
			// btnClipGeneralInfo
			// 
			this.btnClipGeneralInfo.BackColor = System.Drawing.SystemColors.Control;
			this.btnClipGeneralInfo.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnClipGeneralInfo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClipGeneralInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClipGeneralInfo.Location = new System.Drawing.Point(300, 42);
			this.btnClipGeneralInfo.Name = "btnClipGeneralInfo";
			this.btnClipGeneralInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnClipGeneralInfo.Size = new System.Drawing.Size(80, 21);
			this.btnClipGeneralInfo.TabIndex = 112;
			this.btnClipGeneralInfo.Text = "general info?";
			this.btnClipGeneralInfo.Click += new System.EventHandler(this.btnClipGeneralInfo_Click);
			// 
			// updPlayerFastSeekSpeed
			// 
			this.updPlayerFastSeekSpeed.BackColor = System.Drawing.Color.Silver;
			this.updPlayerFastSeekSpeed.Location = new System.Drawing.Point(4, 136);
			this.updPlayerFastSeekSpeed.Name = "updPlayerFastSeekSpeed";
			this.updPlayerFastSeekSpeed.Size = new System.Drawing.Size(42, 20);
			this.updPlayerFastSeekSpeed.TabIndex = 111;
			this.updPlayerFastSeekSpeed.Value = new System.Decimal(new int[] {
																				 1,
																				 0,
																				 0,
																				 0});
			this.updPlayerFastSeekSpeed.ValueChanged += new System.EventHandler(this.updPlayerFastSeekSpeed_ValueChanged);
			// 
			// updPlayerSpeedRatio
			// 
			this.updPlayerSpeedRatio.BackColor = System.Drawing.Color.Silver;
			this.updPlayerSpeedRatio.Location = new System.Drawing.Point(28, 110);
			this.updPlayerSpeedRatio.Minimum = new System.Decimal(new int[] {
																				1,
																				0,
																				0,
																				0});
			this.updPlayerSpeedRatio.Name = "updPlayerSpeedRatio";
			this.updPlayerSpeedRatio.Size = new System.Drawing.Size(18, 20);
			this.updPlayerSpeedRatio.TabIndex = 110;
			this.updPlayerSpeedRatio.Value = new System.Decimal(new int[] {
																			  1,
																			  0,
																			  0,
																			  0});
			this.updPlayerSpeedRatio.ValueChanged += new System.EventHandler(this.updPlayerSpeedRatio_ValueChanged);
			// 
			// edtPlayerFileName
			// 
			this.edtPlayerFileName.AcceptsReturn = true;
			this.edtPlayerFileName.BackColor = System.Drawing.SystemColors.Window;
			this.edtPlayerFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.edtPlayerFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.edtPlayerFileName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.edtPlayerFileName.Location = new System.Drawing.Point(125, 16);
			this.edtPlayerFileName.MaxLength = 0;
			this.edtPlayerFileName.Name = "edtPlayerFileName";
			this.edtPlayerFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.edtPlayerFileName.Size = new System.Drawing.Size(281, 20);
			this.edtPlayerFileName.TabIndex = 108;
			this.edtPlayerFileName.Text = "Choose a video or audio clip...";
			// 
			// btnClipDuration
			// 
			this.btnClipDuration.BackColor = System.Drawing.SystemColors.Control;
			this.btnClipDuration.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnClipDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnClipDuration.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnClipDuration.Location = new System.Drawing.Point(470, 42);
			this.btnClipDuration.Name = "btnClipDuration";
			this.btnClipDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnClipDuration.Size = new System.Drawing.Size(63, 21);
			this.btnClipDuration.TabIndex = 107;
			this.btnClipDuration.Text = "duration?";
			this.btnClipDuration.Click += new System.EventHandler(this.btnClipDuration_Click);
			// 
			// btnPlayerOpenFile
			// 
			this.btnPlayerOpenFile.BackColor = System.Drawing.SystemColors.Control;
			this.btnPlayerOpenFile.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnPlayerOpenFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPlayerOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPlayerOpenFile.Location = new System.Drawing.Point(412, 16);
			this.btnPlayerOpenFile.Name = "btnPlayerOpenFile";
			this.btnPlayerOpenFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnPlayerOpenFile.Size = new System.Drawing.Size(57, 22);
			this.btnPlayerOpenFile.TabIndex = 105;
			this.btnPlayerOpenFile.Text = "Open";
			this.btnPlayerOpenFile.Click += new System.EventHandler(this.btnPlayerOpenFile_Click);
			// 
			// btnOpenLastClipRecorded
			// 
			this.btnOpenLastClipRecorded.BackColor = System.Drawing.SystemColors.Control;
			this.btnOpenLastClipRecorded.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOpenLastClipRecorded.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOpenLastClipRecorded.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnOpenLastClipRecorded.Location = new System.Drawing.Point(189, 42);
			this.btnOpenLastClipRecorded.Name = "btnOpenLastClipRecorded";
			this.btnOpenLastClipRecorded.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnOpenLastClipRecorded.Size = new System.Drawing.Size(105, 21);
			this.btnOpenLastClipRecorded.TabIndex = 104;
			this.btnOpenLastClipRecorded.Text = "Last clip recorded";
			this.btnOpenLastClipRecorded.Click += new System.EventHandler(this.btnOpenLastClipRecorded_Click);
			// 
			// btnOpenLastClipPlayed
			// 
			this.btnOpenLastClipPlayed.BackColor = System.Drawing.SystemColors.Control;
			this.btnOpenLastClipPlayed.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnOpenLastClipPlayed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnOpenLastClipPlayed.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnOpenLastClipPlayed.Location = new System.Drawing.Point(91, 42);
			this.btnOpenLastClipPlayed.Name = "btnOpenLastClipPlayed";
			this.btnOpenLastClipPlayed.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnOpenLastClipPlayed.Size = new System.Drawing.Size(93, 21);
			this.btnOpenLastClipPlayed.TabIndex = 103;
			this.btnOpenLastClipPlayed.Text = "Last clip played";
			this.btnOpenLastClipPlayed.Click += new System.EventHandler(this.btnOpenLastClipPlayed_Click);
			// 
			// btnPlayerCloseFile
			// 
			this.btnPlayerCloseFile.BackColor = System.Drawing.SystemColors.Control;
			this.btnPlayerCloseFile.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnPlayerCloseFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPlayerCloseFile.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPlayerCloseFile.Location = new System.Drawing.Point(476, 16);
			this.btnPlayerCloseFile.Name = "btnPlayerCloseFile";
			this.btnPlayerCloseFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnPlayerCloseFile.Size = new System.Drawing.Size(57, 22);
			this.btnPlayerCloseFile.TabIndex = 102;
			this.btnPlayerCloseFile.Text = "Close";
			this.btnPlayerCloseFile.Click += new System.EventHandler(this.btnPlayerCloseFile_Click);
			// 
			// btnPlayerOpenStreamingURL
			// 
			this.btnPlayerOpenStreamingURL.BackColor = System.Drawing.SystemColors.Control;
			this.btnPlayerOpenStreamingURL.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnPlayerOpenStreamingURL.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPlayerOpenStreamingURL.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnPlayerOpenStreamingURL.Location = new System.Drawing.Point(12, 42);
			this.btnPlayerOpenStreamingURL.Name = "btnPlayerOpenStreamingURL";
			this.btnPlayerOpenStreamingURL.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnPlayerOpenStreamingURL.Size = new System.Drawing.Size(73, 21);
			this.btnPlayerOpenStreamingURL.TabIndex = 101;
			this.btnPlayerOpenStreamingURL.Text = "demo URL?";
			this.btnPlayerOpenStreamingURL.Click += new System.EventHandler(this.btnPlayerOpenStreamingURL_Click);
			// 
			// btnAutoPlay
			// 
			this.btnAutoPlay.BackColor = System.Drawing.SystemColors.Control;
			this.btnAutoPlay.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnAutoPlay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnAutoPlay.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnAutoPlay.Location = new System.Drawing.Point(172, 67);
			this.btnAutoPlay.Name = "btnAutoPlay";
			this.btnAutoPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btnAutoPlay.Size = new System.Drawing.Size(112, 17);
			this.btnAutoPlay.TabIndex = 100;
			this.btnAutoPlay.Text = "auto start playing";
			this.btnAutoPlay.CheckedChanged += new System.EventHandler(this.btnAutoPlay_CheckedChanged);
			// 
			// chkPlayerAudioRendering
			// 
			this.chkPlayerAudioRendering.BackColor = System.Drawing.SystemColors.Control;
			this.chkPlayerAudioRendering.Cursor = System.Windows.Forms.Cursors.Default;
			this.chkPlayerAudioRendering.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkPlayerAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkPlayerAudioRendering.Location = new System.Drawing.Point(4, 67);
			this.chkPlayerAudioRendering.Name = "chkPlayerAudioRendering";
			this.chkPlayerAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkPlayerAudioRendering.Size = new System.Drawing.Size(135, 17);
			this.chkPlayerAudioRendering.TabIndex = 99;
			this.chkPlayerAudioRendering.Text = "render player audio";
			this.chkPlayerAudioRendering.CheckedChanged += new System.EventHandler(this.chkPlayerAudioRendering_CheckedChanged);
			// 
			// chkRefreshPausedDisplay
			// 
			this.chkRefreshPausedDisplay.BackColor = System.Drawing.SystemColors.Control;
			this.chkRefreshPausedDisplay.Cursor = System.Windows.Forms.Cursors.Default;
			this.chkRefreshPausedDisplay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chkRefreshPausedDisplay.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkRefreshPausedDisplay.Location = new System.Drawing.Point(4, 163);
			this.chkRefreshPausedDisplay.Name = "chkRefreshPausedDisplay";
			this.chkRefreshPausedDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkRefreshPausedDisplay.Size = new System.Drawing.Size(523, 17);
			this.chkRefreshPausedDisplay.TabIndex = 98;
			this.chkRefreshPausedDisplay.Text = "refresh periodically paused display when the frame grabber is enabled (e.g. to ap" +
				"ply graphic overlays)";
			this.chkRefreshPausedDisplay.CheckedChanged += new System.EventHandler(this.chkRefreshPausedDisplay_CheckedChanged);
			// 
			// Label31
			// 
			this.Label31.AutoSize = true;
			this.Label31.BackColor = System.Drawing.SystemColors.Control;
			this.Label31.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label31.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label31.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label31.Location = new System.Drawing.Point(46, 138);
			this.Label31.Name = "Label31";
			this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label31.Size = new System.Drawing.Size(109, 16);
			this.Label31.TabIndex = 106;
			this.Label31.Text = "ff / rewind speed ratio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(351, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 14);
			this.label2.TabIndex = 128;
			this.label2.Text = "stop (*)                  (* default = -1)";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(276, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 14);
			this.label1.TabIndex = 127;
			this.label1.Text = "start (*)";
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(415, 63);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(118, 21);
			this.Button1.TabIndex = 133;
			this.Button1.Text = "current DVD info ?";
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// btnOpenDVD
			// 
			this.btnOpenDVD.Location = new System.Drawing.Point(305, 64);
			this.btnOpenDVD.Name = "btnOpenDVD";
			this.btnOpenDVD.Size = new System.Drawing.Size(104, 21);
			this.btnOpenDVD.TabIndex = 132;
			this.btnOpenDVD.Text = "Open DVD";
			this.btnOpenDVD.Click += new System.EventHandler(this.btnOpenDVD_Click);
			// 
			// updSpeedRadioValue
			// 
			this.updSpeedRadioValue.BackColor = System.Drawing.Color.Silver;
			this.updSpeedRadioValue.Location = new System.Drawing.Point(3, 111);
			this.updSpeedRadioValue.Name = "updSpeedRadioValue";
			this.updSpeedRadioValue.Size = new System.Drawing.Size(25, 20);
			this.updSpeedRadioValue.TabIndex = 134;
			this.updSpeedRadioValue.Text = "";
			// 
			// Player
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(954, 221);
			this.ControlBox = false;
			this.Controls.Add(this.updSpeedRadioValue);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.btnOpenDVD);
			this.Controls.Add(this.btnChooseClip);
			this.Controls.Add(this.btnOpenAtFrames);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.chkLoop);
			this.Controls.Add(this.chkReopen);
			this.Controls.Add(this.chkKeepBounds);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnOpenAtTimes);
			this.Controls.Add(this.txtStopTime);
			this.Controls.Add(this.txtStartTime);
			this.Controls.Add(this.txtStopFrame);
			this.Controls.Add(this.txtStartFrame);
			this.Controls.Add(this.Label30);
			this.Controls.Add(this.chkUseClock);
			this.Controls.Add(this.btnHeaderInfo);
			this.Controls.Add(this.btnClipGeneralInfo);
			this.Controls.Add(this.updPlayerFastSeekSpeed);
			this.Controls.Add(this.updPlayerSpeedRatio);
			this.Controls.Add(this.edtPlayerFileName);
			this.Controls.Add(this.btnClipDuration);
			this.Controls.Add(this.btnPlayerOpenFile);
			this.Controls.Add(this.btnOpenLastClipRecorded);
			this.Controls.Add(this.btnOpenLastClipPlayed);
			this.Controls.Add(this.btnPlayerCloseFile);
			this.Controls.Add(this.btnPlayerOpenStreamingURL);
			this.Controls.Add(this.btnAutoPlay);
			this.Controls.Add(this.chkPlayerAudioRendering);
			this.Controls.Add(this.chkRefreshPausedDisplay);
			this.Controls.Add(this.Label31);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Player";
			this.ShowInTaskbar = false;
			this.Load += new System.EventHandler(this.Player_Load);
			this.VisibleChanged += new System.EventHandler(this.Player_VisibleChanged);
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.updPlayerFastSeekSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updPlayerSpeedRatio)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Player_Load(object sender, System.EventArgs e)
		{
		
		}

		public void RefreshControls()
		{
			updPlayerSpeedRatio.Value = (decimal) cMainForm.VideoGrabber1.PlayerSpeedRatio * 10;
			updPlayerFastSeekSpeed.Value = cMainForm.VideoGrabber1.PlayerFastSeekSpeedRatio;
			btnAutoPlay.Checked = cMainForm.VideoGrabber1.AutoStartPlayer;
			chkPlayerAudioRendering.Checked = cMainForm.VideoGrabber1.PlayerAudioRendering;
			chkUseClock.Checked = cMainForm.VideoGrabber1.UseClock;
			chkRefreshPausedDisplay.Checked = cMainForm.VideoGrabber1.PlayerRefreshPausedDisplay;
		}

		private void btnAutoPlay_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.AutoStartPlayer = btnAutoPlay.Checked;
		}

		private void btnChooseClip_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog dlgOpen = new OpenFileDialog();

			dlgOpen.Filter = OPEN_MEDIA_FILES;
			if (dlgOpen.ShowDialog() == DialogResult.OK) 
			{
				edtPlayerFileName.Text = dlgOpen.FileName;
			}
		}

		private void btnClipDuration_Click(object sender, System.EventArgs e)
		{
			Int64 AVIDuration;
			Int64 AVIFrameCount;

			if (cMainForm.VideoGrabber1.AVIDuration(edtPlayerFileName.Text,out AVIDuration,out AVIFrameCount)) 
			{
				AddLog(cMainForm.mmoLog, "Duration: " + AVIDuration.ToString());
				AddLog(cMainForm.mmoLog, "Frame count: " + AVIFrameCount.ToString());
			}
			else 
			{
				AddLog(cMainForm.mmoLog, "failed to get AVIDuration information");
			}
		}

		private void btnClipGeneralInfo_Click(object sender, System.EventArgs e)
		{
			Int64 AVIDuration;
			Int64 AVIFrameCount;
			int VideoWidth;
			int VideoHeight;
			string VideoCodec;
			string AudioCodec;
			double VideoFrameRateFps;
			int AvgBitRate;
			int AudioChannels;
			int AudioSamplesPerSec;
			int AudioBitsPerSample;

			if (cMainForm.VideoGrabber1.AVIInfo(edtPlayerFileName.Text, out AVIDuration, out AVIFrameCount, out VideoWidth, out VideoHeight, out VideoFrameRateFps, out AvgBitRate, out AudioChannels, out AudioSamplesPerSec, out AudioBitsPerSample, out VideoCodec, out AudioCodec))
			{
				double AvgBitRateDiv1024 = AvgBitRate / 1024;
			
				AddLog(cMainForm.mmoLog, edtPlayerFileName.Text + ":");
				AddLog(cMainForm.mmoLog, "duration (in sec): " + AVIDuration.ToString());
				AddLog(cMainForm.mmoLog, "frame count: " + AVIFrameCount.ToString());
				AddLog(cMainForm.mmoLog, "video width: " + VideoWidth.ToString());
				AddLog(cMainForm.mmoLog, "video height: " + VideoHeight.ToString());
				AddLog(cMainForm.mmoLog, "video frame rate (fps): " + VideoFrameRateFps.ToString());
				AddLog(cMainForm.mmoLog, "average bit rate (kb/s): " + AvgBitRateDiv1024.ToString());
				AddLog(cMainForm.mmoLog, "audio channels: " + AudioChannels.ToString());
				AddLog(cMainForm.mmoLog, "audio samples/sec: " + AudioSamplesPerSec.ToString());
				AddLog(cMainForm.mmoLog, "audio bits per sample: " + AudioBitsPerSample.ToString());
				AddLog(cMainForm.mmoLog, "video codec: " + VideoCodec);
				AddLog(cMainForm.mmoLog, "audio codec: " + AudioCodec);
			}
			else
			{
				AddLog(cMainForm.mmoLog, "clip ! found.");
			}
		}

		private void btnOpenLastClipPlayed_Click(object sender, System.EventArgs e)
		{
			if (cMainForm.VideoGrabber1.Last_Clip_Played != "") 
			{
				edtPlayerFileName.Text = cMainForm.VideoGrabber1.Last_Clip_Played;
				cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
				cMainForm.VideoGrabber1.OpenPlayer();
			}
		}

		private void btnOpenLastClipRecorded_Click(object sender, System.EventArgs e)
		{
			if (cMainForm.VideoGrabber1.Last_Recording_FileName != "") {
				edtPlayerFileName.Text = cMainForm.VideoGrabber1.Last_Recording_FileName;
				cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
				cMainForm.VideoGrabber1.OpenPlayer();
			}
		}

		private void btnPlayerCloseFile_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.ClosePlayer();
		}

		private void btnPlayerOpenFile_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			cMainForm.VideoGrabber1.OpenPlayer();
		}

		private void btnPlayerOpenStreamingURL_Click(object sender, System.EventArgs e)
		{
			edtPlayerFileName.Text = "mms://www.datastead.com/demo/demo.wmv";
			cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			cMainForm.VideoGrabber1.OpenPlayer();
		}

		private void chkPlayerAudioRendering_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerAudioRendering = chkPlayerAudioRendering.Checked;
		}

		private void chkRefreshPausedDisplay_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerRefreshPausedDisplay = chkRefreshPausedDisplay.Checked;
		}

		private void updPlayerSpeedRatio_ValueChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerSpeedRatio = ((double) updPlayerSpeedRatio.Value) / 10;
            updSpeedRadioValue.Text = cMainForm.VideoGrabber1.PlayerSpeedRatio.ToString("0.0");
		}

		private void updPlayerFastSeekSpeed_ValueChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerFastSeekSpeedRatio = (int) updPlayerFastSeekSpeed.Value;
		}

		private void btnHeaderInfo_Click(object sender, System.EventArgs e)
		{
			AddLog(cMainForm.mmoLog, "");
			AddLog(cMainForm.mmoLog, edtPlayerFileName.Text + " headers:");
			AddLog(cMainForm.mmoLog, "Title: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Title));
			AddLog(cMainForm.mmoLog, "Description: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Description));
			AddLog(cMainForm.mmoLog, "Author: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Author));
			AddLog(cMainForm.mmoLog, "Copyright: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Copyright));
			AddLog(cMainForm.mmoLog, "Album Artist: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumArtist));
			AddLog(cMainForm.mmoLog, "Album Title: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_AlbumTitle));
			AddLog(cMainForm.mmoLog, "Composer: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Composer));
			AddLog(cMainForm.mmoLog, "Content Distributor: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ContentDistributor));
			AddLog(cMainForm.mmoLog, "Director: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Director));
			AddLog(cMainForm.mmoLog, "Encoding Time: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_EncodingTime));
			AddLog(cMainForm.mmoLog, "Genre: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Genre));
			AddLog(cMainForm.mmoLog, "Language: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Language));
			AddLog(cMainForm.mmoLog, "Parental Rating: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ParentalRating));
			AddLog(cMainForm.mmoLog, "Producer: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Producer));
			AddLog(cMainForm.mmoLog, "Provider: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Provider));
			AddLog(cMainForm.mmoLog, "ToolName: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolName));
			AddLog(cMainForm.mmoLog, "Tool Version: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_ToolVersion));
			AddLog(cMainForm.mmoLog, "Writer: " + cMainForm.VideoGrabber1.AVIHeaderInfo(edtPlayerFileName.Text, VidGrab.THeaderAttribute.ha_Writer));

		}

		private void chkUseClock_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.UseClock = chkUseClock.Checked;
		}

        private void chkLoop_CheckedChanged(object sender, System.EventArgs e)
        {
            // the code is in the VideoGrabber1_OnPlayerEndOfStream event of MainForm
        }

		private void btnPlaylistAdd_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			int i;

			fd.Filter = OPEN_MEDIA_FILES_EXTENDED;
			fd.Multiselect = true;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				for (i = 0; i < fd.FileNames.Length; i ++) 
				{
					cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Add, fd.FileNames.GetValue(i).ToString());
					lstPlaylist.Items.Add(fd.FileNames.GetValue(i));
				}
			}
		}

		private void btnPlaylistPlay_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Play, "");
		}

		private void btnPlaylistNext_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Next, "");
		}

		private void btnPlaylistPrevious_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Previous, "");
		}

		private void btnPlaylistStopAfterCurrent_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Stop, "");
		}

		private void btnPlaylistClose_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.ClosePlayer();
		}

		private void chkPlaylistLoop_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkPlaylistLoop.Checked) 
			{
				cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Loop, "");
			}
			else 
			{
				cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_NoLoop, "");
			}
		}

		private void chkPlaylistRandom_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkPlaylistRandom.Checked) 
			{
				cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Random, "");
			}
			else 
			{
				cMainForm.VideoGrabber1.Playlist(VidGrab.TPlaylist.pl_Sequential, "");
			}
		}

		private void btnOpenAtFrames_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			if (IsNumeric(txtStartFrame.Text) && IsNumeric(txtStopFrame.Text)) 
			{
				cMainForm.VideoGrabber1.OpenPlayerAtFramePositions (Convert.ToInt64 (txtStartFrame.Text), Convert.ToInt64 (txtStopFrame.Text), chkKeepBounds.Checked, chkReopen.Checked);
			}
		}

		private void btnOpenAtTimes_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
			if (IsNumeric(txtStartTime.Text) && IsNumeric(txtStopTime.Text)) 
			{
				cMainForm.VideoGrabber1.OpenPlayerAtTimePositions (Convert.ToInt64 (txtStartTime.Text), Convert.ToInt64 (txtStopTime.Text), chkKeepBounds.Checked, chkReopen.Checked);
			}
		}

		private void Player_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void btnOpenDVD_Click(object sender, EventArgs e)
        {
            if (edtPlayerFileName.Text == "Choose a video or audio clip...") {
                cMainForm.VideoGrabber1.PlayerFileName = ""; // this will use the default DVD
            }
            else {
                cMainForm.VideoGrabber1.PlayerFileName = edtPlayerFileName.Text;
            }
            if (cMainForm.VideoGrabber1.OpenDVD()) {
                edtPlayerFileName.Text = cMainForm.VideoGrabber1.PlayerFileName; // to reflect the real DVD path name used
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int NumberOfTitles;
            int i;

            AddLog(cMainForm.mmoLog, "total DVD duration: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TotalDuration, 0).ToString());

            NumberOfTitles = Convert.ToInt32 (cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_NumberOfTitles, 0));
            AddLog(cMainForm.mmoLog, "number of titles: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_NumberOfTitles, 0).ToString());

            for (i = 1; i <= NumberOfTitles; i++) {
                AddLog(cMainForm.mmoLog, "TITLE " + i.ToString() + ":");
                AddLog(cMainForm.mmoLog, "duration in seconds: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TotalDuration, i).ToString());
                AddLog(cMainForm.mmoLog, "frame count: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TitleFrameCount, i).ToString());
                AddLog(cMainForm.mmoLog, "frame rate: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_TitleFrameRate, i).ToString());
                AddLog(cMainForm.mmoLog, "video resolution X: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_SourceResolutionX, i).ToString());
                AddLog(cMainForm.mmoLog, "video resolution Y: " + cMainForm.VideoGrabber1.DVDInfo(edtPlayerFileName.Text, VidGrab.TDVDInfoType.dvd_SourceResolutionY, i).ToString());
            }

        }

	}
}
