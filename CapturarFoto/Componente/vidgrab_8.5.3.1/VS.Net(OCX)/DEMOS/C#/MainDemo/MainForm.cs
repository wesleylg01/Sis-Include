using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;

namespace MainDemo
{
    public class MainForm : WindowsFormWithTools
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuAbout;
        public AxVidgrab_NET.AxVideoGrabberNET axVideoGrabberNET1; // modified as "public" to be accessible from the sub forms
        /// <summary>
        /// Required designer variable.
        /// 


        public struct WINDOW_ENUM
        {
            public int WindowHandle;
            public string WindowName;
            public string WindowClass;
        }
		public bool IsVideoGrabberMouseDown;
        public int lngScreenRecordingWindow;
        public string strScreenRecordingWindow;
        public bool boolScreenRecordingWindow;
        public WINDOW_ENUM[] wenScreenRecordingWindow;

        public int frmOverlays_edtDrawGrid;
		public bool frmOverlays_drawTarget;
		private System.Drawing.Point frmOverlays_drawTarget_Location;
        public Color frmOverlays_btnDrawGridColor;
        public Color frmOverlays_btnFreeHandColor;

        public bool VideoProcessing_DetectNoVideoSignal;
        public bool VideoProcessing_DetectConnexantBlueScreen;

        public bool OldVideoSignalState;


        public VideoFromImagesFileList VideoFromImages;
        public bool VideoFromImagesUsePictureBox;

        public FreeHandDrawing cFreeHandDrawing;
        public PickupColor cPickupColor;

        private double LastKBWrittenReportTime;

        public System.Windows.Forms.Form frmInsetForm;

        private int CountPictureBox;

        private int StartupWidth;
        private int StartupHeight;


        public int StartupVGWidth;
        public int StartupVGHeight;


        private Audio frmAudio;
        private VideoSource frmVideoSource;
        private IPCamera frmIPCamera;
        private VideoFromJPEGsOrBitmaps frmVideoFromJPEGsOrBitmaps;
        private Display frmDisplay;
        private FrameGrabber frmFrameGrabber;
        private MotionDetection frmMotionDetection;
        private NetworkStreaming frmNetworkStreaming;
        private Overlays frmOverlays;
        private Player frmPlayer;
        private Recording frmRecording;
        private Reencoding frmReencoding;
        private SnapForm frmSnapForm;
        private TVTuner frmTVTuner;
        private VideoProcessing frmVideoProcessing;


        public Brush brushMotionRatio;
        public bool boolMotionRatio;

        public System.Windows.Forms.TextBox mmoLog;
        public System.Windows.Forms.TextBox edtDVDateTime;
        public System.Windows.Forms.TextBox edtFrameCount;
        public System.Windows.Forms.TextBox edtStoragePath;
        internal TabControl tbcTabs;
        internal TabPage tbpVideoSource;
        internal TabPage tbpIPCameras;
        internal TabPage tbpAudio;
        internal TabPage tbpRecording;
        internal TabPage tbpVideoFromJPEGsorBitmaps;
        internal TabPage tbpNetworkStreaming;
        internal TabPage tbpPlayer;
        internal TabPage tbpFrameGrabber;
        internal TabPage tbpMotionDetection;
        internal TabPage tbpOverlays;
        internal TabPage tbpVideoProcessing;
        internal TabPage tbpDisplay;
        internal TabPage tbpReencoding;
        internal TabPage tbpTVTuner;
        internal GroupBox gbPlayerControl;
        public Button btnFastFwd;
        internal ImageList ImageList1;
        public Button btnFastRew;
        public Button btnPlay;
        public Button btnPause;
        public Button btnPlayBackwards;
        internal TrackBar tbrPlayer;
        public Button btnStop;
        public Label Label1;
        private MenuItem mnuDVCommands;
        private MenuItem mnuDVPlay;
        private MenuItem mnuDVStop;
        private MenuItem mnuDVFreeze;
        private MenuItem mnuDVThaw;
        private MenuItem mnuDVFF;
        private MenuItem mnuDVRew;
        private MenuItem mnuDVRecord;
        private MenuItem mnuDVRecordFreeze;
        private MenuItem mnuDVRecordStrobe;
        private MenuItem mnuDVStepFwd;
        private MenuItem mnuDVStepRev;
        private MenuItem mnuDVModeShuttle;
        private MenuItem mnuDVPlayFastestFwd;
        private MenuItem mnuDVPlaySlowestFwd;
        private MenuItem mnuDVPlayFastestRev;
        private MenuItem mnuDVPlaySlowestRev;
        private MenuItem mnuPriority;
        private MenuItem mnuPriorityDefault;
        private MenuItem mnuPriorityIdle;
        private MenuItem mnuPriorityNormal;
        private MenuItem mnuPriorityHigh;
        private MenuItem mnuPriorityRealTime;
        internal CheckBox chkPlayerTrackBarSynchrone;
        public Button btnFrameStep;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        internal TrackBar tbrZoom;
        private Label label2;
        internal TrackBar tbrZoomX;
        private Label label3;
        private Label label4;
        internal TrackBar tbrZoomY;
        internal Label AutoSizeInfo;
        private IContainer components;

        public MainForm()
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
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuDVCommands = new System.Windows.Forms.MenuItem();
            this.mnuDVPlay = new System.Windows.Forms.MenuItem();
            this.mnuDVStop = new System.Windows.Forms.MenuItem();
            this.mnuDVFreeze = new System.Windows.Forms.MenuItem();
            this.mnuDVThaw = new System.Windows.Forms.MenuItem();
            this.mnuDVFF = new System.Windows.Forms.MenuItem();
            this.mnuDVRew = new System.Windows.Forms.MenuItem();
            this.mnuDVRecord = new System.Windows.Forms.MenuItem();
            this.mnuDVRecordFreeze = new System.Windows.Forms.MenuItem();
            this.mnuDVRecordStrobe = new System.Windows.Forms.MenuItem();
            this.mnuDVStepFwd = new System.Windows.Forms.MenuItem();
            this.mnuDVStepRev = new System.Windows.Forms.MenuItem();
            this.mnuDVModeShuttle = new System.Windows.Forms.MenuItem();
            this.mnuDVPlayFastestFwd = new System.Windows.Forms.MenuItem();
            this.mnuDVPlaySlowestFwd = new System.Windows.Forms.MenuItem();
            this.mnuDVPlayFastestRev = new System.Windows.Forms.MenuItem();
            this.mnuDVPlaySlowestRev = new System.Windows.Forms.MenuItem();
            this.mnuPriority = new System.Windows.Forms.MenuItem();
            this.mnuPriorityDefault = new System.Windows.Forms.MenuItem();
            this.mnuPriorityIdle = new System.Windows.Forms.MenuItem();
            this.mnuPriorityNormal = new System.Windows.Forms.MenuItem();
            this.mnuPriorityHigh = new System.Windows.Forms.MenuItem();
            this.mnuPriorityRealTime = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuAbout = new System.Windows.Forms.MenuItem();
            this.axVideoGrabberNET1 = new AxVidgrab_NET.AxVideoGrabberNET();
            this.mmoLog = new System.Windows.Forms.TextBox();
            this.edtDVDateTime = new System.Windows.Forms.TextBox();
            this.edtFrameCount = new System.Windows.Forms.TextBox();
            this.edtStoragePath = new System.Windows.Forms.TextBox();
            this.tbcTabs = new System.Windows.Forms.TabControl();
            this.tbpVideoSource = new System.Windows.Forms.TabPage();
            this.tbpIPCameras = new System.Windows.Forms.TabPage();
            this.tbpAudio = new System.Windows.Forms.TabPage();
            this.tbpRecording = new System.Windows.Forms.TabPage();
            this.tbpVideoFromJPEGsorBitmaps = new System.Windows.Forms.TabPage();
            this.tbpNetworkStreaming = new System.Windows.Forms.TabPage();
            this.tbpPlayer = new System.Windows.Forms.TabPage();
            this.tbpFrameGrabber = new System.Windows.Forms.TabPage();
            this.tbpMotionDetection = new System.Windows.Forms.TabPage();
            this.tbpOverlays = new System.Windows.Forms.TabPage();
            this.tbpVideoProcessing = new System.Windows.Forms.TabPage();
            this.tbpDisplay = new System.Windows.Forms.TabPage();
            this.tbpReencoding = new System.Windows.Forms.TabPage();
            this.tbpTVTuner = new System.Windows.Forms.TabPage();
            this.gbPlayerControl = new System.Windows.Forms.GroupBox();
            this.btnFrameStep = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFastFwd = new System.Windows.Forms.Button();
            this.btnFastRew = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlayBackwards = new System.Windows.Forms.Button();
            this.tbrPlayer = new System.Windows.Forms.TrackBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.chkPlayerTrackBarSynchrone = new System.Windows.Forms.CheckBox();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrZoomX = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbrZoomY = new System.Windows.Forms.TrackBar();
            this.AutoSizeInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoGrabberNET1)).BeginInit();
            this.tbcTabs.SuspendLayout();
            this.gbPlayerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.mnuDVCommands,
            this.mnuPriority,
            this.menuItem1,
            this.mnuAbout});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuExit});
            this.menuFile.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 0;
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuDVCommands
            // 
            this.mnuDVCommands.Index = 1;
            this.mnuDVCommands.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDVPlay,
            this.mnuDVStop,
            this.mnuDVFreeze,
            this.mnuDVThaw,
            this.mnuDVFF,
            this.mnuDVRew,
            this.mnuDVRecord,
            this.mnuDVRecordFreeze,
            this.mnuDVRecordStrobe,
            this.mnuDVStepFwd,
            this.mnuDVStepRev,
            this.mnuDVModeShuttle,
            this.mnuDVPlayFastestFwd,
            this.mnuDVPlaySlowestFwd,
            this.mnuDVPlayFastestRev,
            this.mnuDVPlaySlowestRev});
            this.mnuDVCommands.Text = "Send DV Commands";
            // 
            // mnuDVPlay
            // 
            this.mnuDVPlay.Index = 0;
            this.mnuDVPlay.Text = "Play";
            this.mnuDVPlay.Click += new System.EventHandler(this.mnuDVPlay_Click);
            // 
            // mnuDVStop
            // 
            this.mnuDVStop.Index = 1;
            this.mnuDVStop.Text = "Stop";
            this.mnuDVStop.Click += new System.EventHandler(this.mnuDVStop_Click);
            // 
            // mnuDVFreeze
            // 
            this.mnuDVFreeze.Index = 2;
            this.mnuDVFreeze.Text = "Freeze";
            this.mnuDVFreeze.Click += new System.EventHandler(this.mnuDVFreeze_Click);
            // 
            // mnuDVThaw
            // 
            this.mnuDVThaw.Index = 3;
            this.mnuDVThaw.Text = "Thaw";
            this.mnuDVThaw.Click += new System.EventHandler(this.mnuDVThaw_Click);
            // 
            // mnuDVFF
            // 
            this.mnuDVFF.Index = 4;
            this.mnuDVFF.Text = "FF";
            this.mnuDVFF.Click += new System.EventHandler(this.mnuDVFF_Click);
            // 
            // mnuDVRew
            // 
            this.mnuDVRew.Index = 5;
            this.mnuDVRew.Text = "Rew";
            this.mnuDVRew.Click += new System.EventHandler(this.mnuDVRew_Click);
            // 
            // mnuDVRecord
            // 
            this.mnuDVRecord.Index = 6;
            this.mnuDVRecord.Text = "Record";
            this.mnuDVRecord.Click += new System.EventHandler(this.mnuDVRecord_Click);
            // 
            // mnuDVRecordFreeze
            // 
            this.mnuDVRecordFreeze.Index = 7;
            this.mnuDVRecordFreeze.Text = "Record Freeze";
            this.mnuDVRecordFreeze.Click += new System.EventHandler(this.mnuDVRecordFreeze_Click);
            // 
            // mnuDVRecordStrobe
            // 
            this.mnuDVRecordStrobe.Index = 8;
            this.mnuDVRecordStrobe.Text = "Record Strobe";
            this.mnuDVRecordStrobe.Click += new System.EventHandler(this.mnuDVRecordStrobe_Click);
            // 
            // mnuDVStepFwd
            // 
            this.mnuDVStepFwd.Index = 9;
            this.mnuDVStepFwd.Text = "Step Fwd";
            this.mnuDVStepFwd.Click += new System.EventHandler(this.mnuDVStepFwd_Click);
            // 
            // mnuDVStepRev
            // 
            this.mnuDVStepRev.Index = 10;
            this.mnuDVStepRev.Text = "Step Rev";
            this.mnuDVStepRev.Click += new System.EventHandler(this.mnuDVStepRev_Click);
            // 
            // mnuDVModeShuttle
            // 
            this.mnuDVModeShuttle.Index = 11;
            this.mnuDVModeShuttle.Text = "Mode Shuttle";
            this.mnuDVModeShuttle.Click += new System.EventHandler(this.mnuDVModeShuttle_Click);
            // 
            // mnuDVPlayFastestFwd
            // 
            this.mnuDVPlayFastestFwd.Index = 12;
            this.mnuDVPlayFastestFwd.Text = "Play Fastest Fwd";
            this.mnuDVPlayFastestFwd.Click += new System.EventHandler(this.mnuDVPlayFastestFwd_Click);
            // 
            // mnuDVPlaySlowestFwd
            // 
            this.mnuDVPlaySlowestFwd.Index = 13;
            this.mnuDVPlaySlowestFwd.Text = "Play Slowest Fwd";
            this.mnuDVPlaySlowestFwd.Click += new System.EventHandler(this.mnuDVPlaySlowestFwd_Click);
            // 
            // mnuDVPlayFastestRev
            // 
            this.mnuDVPlayFastestRev.Index = 14;
            this.mnuDVPlayFastestRev.Text = "Play Fastest Rev";
            this.mnuDVPlayFastestRev.Click += new System.EventHandler(this.mnuDVPlayFastestRev_Click);
            // 
            // mnuDVPlaySlowestRev
            // 
            this.mnuDVPlaySlowestRev.Index = 15;
            this.mnuDVPlaySlowestRev.Text = "Plat Slowest Rev";
            this.mnuDVPlaySlowestRev.Click += new System.EventHandler(this.mnuDVPlaySlowestRev_Click);
            // 
            // mnuPriority
            // 
            this.mnuPriority.Index = 2;
            this.mnuPriority.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuPriorityDefault,
            this.mnuPriorityIdle,
            this.mnuPriorityNormal,
            this.mnuPriorityHigh,
            this.mnuPriorityRealTime});
            this.mnuPriority.Text = "Priority";
            // 
            // mnuPriorityDefault
            // 
            this.mnuPriorityDefault.Index = 0;
            this.mnuPriorityDefault.Text = "Default";
            this.mnuPriorityDefault.Click += new System.EventHandler(this.mnuPriorityDefault_Click);
            // 
            // mnuPriorityIdle
            // 
            this.mnuPriorityIdle.Index = 1;
            this.mnuPriorityIdle.Text = "Idle";
            this.mnuPriorityIdle.Click += new System.EventHandler(this.mnuPriorityIdle_Click);
            // 
            // mnuPriorityNormal
            // 
            this.mnuPriorityNormal.Index = 2;
            this.mnuPriorityNormal.Text = "Normal";
            this.mnuPriorityNormal.Click += new System.EventHandler(this.mnuPriorityNormal_Click);
            // 
            // mnuPriorityHigh
            // 
            this.mnuPriorityHigh.Index = 3;
            this.mnuPriorityHigh.Text = "High";
            this.mnuPriorityHigh.Click += new System.EventHandler(this.mnuPriorityHigh_Click);
            // 
            // mnuPriorityRealTime
            // 
            this.mnuPriorityRealTime.Index = 4;
            this.mnuPriorityRealTime.Text = "Real Time";
            this.mnuPriorityRealTime.Click += new System.EventHandler(this.mnuPriorityRealTime_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 3;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2});
            this.menuItem1.Text = "Options";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "Reset video capture device settings";
            this.menuItem2.Click += new System.EventHandler(this.mnuResetVideoDeviceSettings_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Index = 4;
            this.mnuAbout.Text = "About";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // axVideoGrabberNET1
            // 
            this.axVideoGrabberNET1.Location = new System.Drawing.Point(245, 329);
            this.axVideoGrabberNET1.Name = "axVideoGrabberNET1";
            this.axVideoGrabberNET1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoGrabberNET1.OcxState")));
            this.axVideoGrabberNET1.Size = new System.Drawing.Size(408, 312);
            this.axVideoGrabberNET1.TabIndex = 33;
            this.axVideoGrabberNET1.OnCreatePreallocFileStarted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileStartedEventHandler(this.axVideoGrabberNET1_OnCreatePreallocFileStarted);
            this.axVideoGrabberNET1.OnTVChannelScanCompleted += new System.EventHandler(this.axVideoGrabberNET1_OnTVChannelScanCompleted);
            this.axVideoGrabberNET1.OnRecordingStarted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingStartedEventHandler(this.axVideoGrabberNET1_OnRecordingStarted);
            this.axVideoGrabberNET1.OnGraphBuilt += new System.EventHandler(this.axVideoGrabberNET1_OnGraphBuilt);
            this.axVideoGrabberNET1.OnEnumerateWindows += new AxVidgrab_NET.IVideoGrabberNETEvents_OnEnumerateWindowsEventHandler(this.axVideoGrabberNET1_OnEnumerateWindows);
            this.axVideoGrabberNET1.OnMotionDetected += new AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionDetectedEventHandler(this.axVideoGrabberNET1_OnMotionDetected);
            this.axVideoGrabberNET1.OnReencodingCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingCompletedEventHandler(this.axVideoGrabberNET1_OnReencodingCompleted);
            this.axVideoGrabberNET1.OnDirectNetworkStreamingHostUrl += new AxVidgrab_NET.IVideoGrabberNETEvents_OnDirectNetworkStreamingHostUrlEventHandler(this.axVideoGrabberNET1_OnDirectNetworkStreamingHostUrl);
            this.axVideoGrabberNET1.OnFrameCaptureCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameCaptureCompletedEventHandler(this.axVideoGrabberNET1_OnFrameCaptureCompleted);
            this.axVideoGrabberNET1.OnDeviceArrivalOrRemoval += new AxVidgrab_NET.IVideoGrabberNETEvents_OnDeviceArrivalOrRemovalEventHandler(this.axVideoGrabberNET1_OnDeviceArrivalOrRemoval);
            this.axVideoGrabberNET1.OnClientConnection += new AxVidgrab_NET.IVideoGrabberNETEvents_OnClientConnectionEventHandler(this.axVideoGrabberNET1_OnClientConnection);
            this.axVideoGrabberNET1.OnCopyPreallocDataProgress += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataProgressEventHandler(this.axVideoGrabberNET1_OnCopyPreallocDataProgress);
            this.axVideoGrabberNET1.OnCopyPreallocDataCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataCompletedEventHandler(this.axVideoGrabberNET1_OnCopyPreallocDataCompleted);
            this.axVideoGrabberNET1.OnReinitializing += new System.EventHandler(this.axVideoGrabberNET1_OnReinitializing);
            this.axVideoGrabberNET1.OnMotionNotDetected += new AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionNotDetectedEventHandler(this.axVideoGrabberNET1_OnMotionNotDetected);
            this.axVideoGrabberNET1.OnReencodingProgress += new AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingProgressEventHandler(this.axVideoGrabberNET1_OnReencodingProgress);
            this.axVideoGrabberNET1.OnRecordingCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingCompletedEventHandler(this.axVideoGrabberNET1_OnRecordingCompleted);
            this.axVideoGrabberNET1.OnCreatePreallocFileCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileCompletedEventHandler(this.axVideoGrabberNET1_OnCreatePreallocFileCompleted);
            this.axVideoGrabberNET1.OnCopyPreallocDataStarted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataStartedEventHandler(this.axVideoGrabberNET1_OnCopyPreallocDataStarted);
            this.axVideoGrabberNET1.OnFrameBitmap += new AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameBitmapEventHandler(this.axVideoGrabberNET1_OnFrameBitmap);
            this.axVideoGrabberNET1.OnReencodingStarted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingStartedEventHandler(this.axVideoGrabberNET1_OnReencodingStarted);
            this.axVideoGrabberNET1.OnDiskFull += new System.EventHandler(this.axVideoGrabberNET1_OnDiskFull);
            this.axVideoGrabberNET1.OnTVChannelScanStarted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelScanStartedEventHandler(this.axVideoGrabberNET1_OnTVChannelScanStarted);
            this.axVideoGrabberNET1.OnRecordingReadyToStart += new System.EventHandler(this.axVideoGrabberNET1_OnRecordingReadyToStart);
            this.axVideoGrabberNET1.OnPlayerUpdateTrackbarPosition += new AxVidgrab_NET.IVideoGrabberNETEvents_OnPlayerUpdateTrackbarPositionEventHandler(this.axVideoGrabberNET1_OnPlayerUpdateTrackbarPosition);
            this.axVideoGrabberNET1.OnFrameProgress2 += new AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameProgress2EventHandler(this.axVideoGrabberNET1_OnFrameProgress2);
            this.axVideoGrabberNET1.OnRecordingPaused += new System.EventHandler(this.axVideoGrabberNET1_OnRecordingPaused);
            this.axVideoGrabberNET1.OnVideoDeviceSelected += new System.EventHandler(this.axVideoGrabberNET1_OnVideoDeviceSelected);
            this.axVideoGrabberNET1.OnResizeVideo += new AxVidgrab_NET.IVideoGrabberNETEvents_OnResizeVideoEventHandler(this.axVideoGrabberNET1_OnResizeVideo);
            this.axVideoGrabberNET1.OnMouseUp += new AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseUpEventHandler(this.axVideoGrabberNET1_OnMouseUp);
            this.axVideoGrabberNET1.OnCreatePreallocFileProgress += new AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileProgressEventHandler(this.axVideoGrabberNET1_OnCreatePreallocFileProgress);
            this.axVideoGrabberNET1.OnLog += new AxVidgrab_NET.IVideoGrabberNETEvents_OnLogEventHandler(this.axVideoGrabberNET1_OnLog);
            this.axVideoGrabberNET1.OnPreviewStarted += new System.EventHandler(this.axVideoGrabberNET1_OnPreviewStarted);
            this.axVideoGrabberNET1.OnPlayerEndOfStream += new System.EventHandler(this.axVideoGrabberNET1_OnPlayerEndOfStream);
            this.axVideoGrabberNET1.OnMouseMove += new AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseMoveEventHandler(this.axVideoGrabberNET1_OnMouseMove);
            this.axVideoGrabberNET1.OnTVChannelSelected += new AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelSelectedEventHandler(this.axVideoGrabberNET1_OnTVChannelSelected);
            this.axVideoGrabberNET1.OnDeviceLost += new System.EventHandler(this.axVideoGrabberNET1_OnDeviceLost);
            this.axVideoGrabberNET1.OnPlayerOpened += new System.EventHandler(this.axVideoGrabberNET1_OnPlayerOpened);
            this.axVideoGrabberNET1.OnDVCommandCompleted += new AxVidgrab_NET.IVideoGrabberNETEvents_OnDVCommandCompletedEventHandler(this.axVideoGrabberNET1_OnDVCommandCompleted);
            this.axVideoGrabberNET1.OnVideoFromBitmapsNextFrameNeeded += new AxVidgrab_NET.IVideoGrabberNETEvents_OnVideoFromBitmapsNextFrameNeededEventHandler(this.axVideoGrabberNET1_OnVideoFromBitmapsNextFrameNeeded);
            this.axVideoGrabberNET1.OnAudioDeviceSelected += new System.EventHandler(this.axVideoGrabberNET1_OnAudioDeviceSelected);
            this.axVideoGrabberNET1.OnInactive += new System.EventHandler(this.axVideoGrabberNET1_OnInactive);
            this.axVideoGrabberNET1.OnDVDiscontinuity += new AxVidgrab_NET.IVideoGrabberNETEvents_OnDVDiscontinuityEventHandler(this.axVideoGrabberNET1_OnDVDiscontinuity);
            this.axVideoGrabberNET1.OnResize += new System.EventHandler(this.axVideoGrabberNET1_OnResize);
            this.axVideoGrabberNET1.OnMouseDown += new AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseDownEventHandler(this.axVideoGrabberNET1_OnMouseDown);
            // 
            // mmoLog
            // 
            this.mmoLog.AcceptsReturn = true;
            this.mmoLog.BackColor = System.Drawing.SystemColors.Window;
            this.mmoLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoLog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoLog.Location = new System.Drawing.Point(6, 349);
            this.mmoLog.MaxLength = 0;
            this.mmoLog.Multiline = true;
            this.mmoLog.Name = "mmoLog";
            this.mmoLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoLog.Size = new System.Drawing.Size(208, 305);
            this.mmoLog.TabIndex = 50;
            // 
            // edtDVDateTime
            // 
            this.edtDVDateTime.AcceptsReturn = true;
            this.edtDVDateTime.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtDVDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDVDateTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDVDateTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDVDateTime.Location = new System.Drawing.Point(6, 325);
            this.edtDVDateTime.MaxLength = 0;
            this.edtDVDateTime.Name = "edtDVDateTime";
            this.edtDVDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDVDateTime.Size = new System.Drawing.Size(208, 20);
            this.edtDVDateTime.TabIndex = 49;
            // 
            // edtFrameCount
            // 
            this.edtFrameCount.AcceptsReturn = true;
            this.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameCount.Location = new System.Drawing.Point(6, 301);
            this.edtFrameCount.MaxLength = 0;
            this.edtFrameCount.Name = "edtFrameCount";
            this.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameCount.Size = new System.Drawing.Size(208, 20);
            this.edtFrameCount.TabIndex = 48;
            // 
            // edtStoragePath
            // 
            this.edtStoragePath.AcceptsReturn = true;
            this.edtStoragePath.BackColor = System.Drawing.SystemColors.Window;
            this.edtStoragePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStoragePath.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStoragePath.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStoragePath.Location = new System.Drawing.Point(6, 277);
            this.edtStoragePath.MaxLength = 0;
            this.edtStoragePath.Name = "edtStoragePath";
            this.edtStoragePath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStoragePath.Size = new System.Drawing.Size(208, 20);
            this.edtStoragePath.TabIndex = 46;
            this.edtStoragePath.TextChanged += new System.EventHandler(this.edtStoragePath_TextChanged);
            // 
            // tbcTabs
            // 
            this.tbcTabs.Controls.Add(this.tbpVideoSource);
            this.tbcTabs.Controls.Add(this.tbpIPCameras);
            this.tbcTabs.Controls.Add(this.tbpAudio);
            this.tbcTabs.Controls.Add(this.tbpRecording);
            this.tbcTabs.Controls.Add(this.tbpVideoFromJPEGsorBitmaps);
            this.tbcTabs.Controls.Add(this.tbpNetworkStreaming);
            this.tbcTabs.Controls.Add(this.tbpPlayer);
            this.tbcTabs.Controls.Add(this.tbpFrameGrabber);
            this.tbcTabs.Controls.Add(this.tbpMotionDetection);
            this.tbcTabs.Controls.Add(this.tbpOverlays);
            this.tbcTabs.Controls.Add(this.tbpVideoProcessing);
            this.tbcTabs.Controls.Add(this.tbpDisplay);
            this.tbcTabs.Controls.Add(this.tbpReencoding);
            this.tbcTabs.Controls.Add(this.tbpTVTuner);
            this.tbcTabs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcTabs.Location = new System.Drawing.Point(6, 0);
            this.tbcTabs.Name = "tbcTabs";
            this.tbcTabs.Padding = new System.Drawing.Point(5, 3);
            this.tbcTabs.SelectedIndex = 0;
            this.tbcTabs.Size = new System.Drawing.Size(947, 210);
            this.tbcTabs.TabIndex = 59;
            this.tbcTabs.SelectedIndexChanged += new System.EventHandler(this.tbcTabs_SelectedIndexChanged);
            // 
            // tbpVideoSource
            // 
            this.tbpVideoSource.Location = new System.Drawing.Point(4, 23);
            this.tbpVideoSource.Name = "tbpVideoSource";
            this.tbpVideoSource.Size = new System.Drawing.Size(939, 183);
            this.tbpVideoSource.TabIndex = 0;
            this.tbpVideoSource.Text = "video source";
            // 
            // tbpIPCameras
            // 
            this.tbpIPCameras.Location = new System.Drawing.Point(4, 23);
            this.tbpIPCameras.Name = "tbpIPCameras";
            this.tbpIPCameras.Size = new System.Drawing.Size(939, 183);
            this.tbpIPCameras.TabIndex = 1;
            this.tbpIPCameras.Text = "IP cameras";
            // 
            // tbpAudio
            // 
            this.tbpAudio.Location = new System.Drawing.Point(4, 23);
            this.tbpAudio.Name = "tbpAudio";
            this.tbpAudio.Size = new System.Drawing.Size(939, 183);
            this.tbpAudio.TabIndex = 2;
            this.tbpAudio.Text = "audio";
            // 
            // tbpRecording
            // 
            this.tbpRecording.Location = new System.Drawing.Point(4, 23);
            this.tbpRecording.Name = "tbpRecording";
            this.tbpRecording.Size = new System.Drawing.Size(939, 183);
            this.tbpRecording.TabIndex = 3;
            this.tbpRecording.Text = "recording";
            // 
            // tbpVideoFromJPEGsorBitmaps
            // 
            this.tbpVideoFromJPEGsorBitmaps.Location = new System.Drawing.Point(4, 23);
            this.tbpVideoFromJPEGsorBitmaps.Name = "tbpVideoFromJPEGsorBitmaps";
            this.tbpVideoFromJPEGsorBitmaps.Size = new System.Drawing.Size(939, 183);
            this.tbpVideoFromJPEGsorBitmaps.TabIndex = 13;
            this.tbpVideoFromJPEGsorBitmaps.Text = "img>vid";
            // 
            // tbpNetworkStreaming
            // 
            this.tbpNetworkStreaming.Location = new System.Drawing.Point(4, 23);
            this.tbpNetworkStreaming.Name = "tbpNetworkStreaming";
            this.tbpNetworkStreaming.Size = new System.Drawing.Size(939, 183);
            this.tbpNetworkStreaming.TabIndex = 4;
            this.tbpNetworkStreaming.Text = "network streaming & WMV";
            // 
            // tbpPlayer
            // 
            this.tbpPlayer.Location = new System.Drawing.Point(4, 23);
            this.tbpPlayer.Name = "tbpPlayer";
            this.tbpPlayer.Size = new System.Drawing.Size(939, 183);
            this.tbpPlayer.TabIndex = 5;
            this.tbpPlayer.Text = "player";
            // 
            // tbpFrameGrabber
            // 
            this.tbpFrameGrabber.Location = new System.Drawing.Point(4, 23);
            this.tbpFrameGrabber.Name = "tbpFrameGrabber";
            this.tbpFrameGrabber.Size = new System.Drawing.Size(939, 183);
            this.tbpFrameGrabber.TabIndex = 6;
            this.tbpFrameGrabber.Text = "frame grabber";
            // 
            // tbpMotionDetection
            // 
            this.tbpMotionDetection.Location = new System.Drawing.Point(4, 23);
            this.tbpMotionDetection.Name = "tbpMotionDetection";
            this.tbpMotionDetection.Size = new System.Drawing.Size(939, 183);
            this.tbpMotionDetection.TabIndex = 7;
            this.tbpMotionDetection.Text = "motion detection";
            // 
            // tbpOverlays
            // 
            this.tbpOverlays.Location = new System.Drawing.Point(4, 23);
            this.tbpOverlays.Name = "tbpOverlays";
            this.tbpOverlays.Size = new System.Drawing.Size(939, 183);
            this.tbpOverlays.TabIndex = 8;
            this.tbpOverlays.Text = "overlays";
            // 
            // tbpVideoProcessing
            // 
            this.tbpVideoProcessing.Location = new System.Drawing.Point(4, 23);
            this.tbpVideoProcessing.Name = "tbpVideoProcessing";
            this.tbpVideoProcessing.Size = new System.Drawing.Size(939, 183);
            this.tbpVideoProcessing.TabIndex = 9;
            this.tbpVideoProcessing.Text = "video processing";
            // 
            // tbpDisplay
            // 
            this.tbpDisplay.Location = new System.Drawing.Point(4, 23);
            this.tbpDisplay.Name = "tbpDisplay";
            this.tbpDisplay.Size = new System.Drawing.Size(939, 183);
            this.tbpDisplay.TabIndex = 10;
            this.tbpDisplay.Text = "display";
            // 
            // tbpReencoding
            // 
            this.tbpReencoding.Location = new System.Drawing.Point(4, 23);
            this.tbpReencoding.Name = "tbpReencoding";
            this.tbpReencoding.Size = new System.Drawing.Size(939, 183);
            this.tbpReencoding.TabIndex = 11;
            this.tbpReencoding.Text = "reencoding";
            // 
            // tbpTVTuner
            // 
            this.tbpTVTuner.Location = new System.Drawing.Point(4, 23);
            this.tbpTVTuner.Name = "tbpTVTuner";
            this.tbpTVTuner.Size = new System.Drawing.Size(939, 183);
            this.tbpTVTuner.TabIndex = 12;
            this.tbpTVTuner.Text = "tuner";
            // 
            // gbPlayerControl
            // 
            this.gbPlayerControl.Controls.Add(this.btnFrameStep);
            this.gbPlayerControl.Controls.Add(this.btnFastFwd);
            this.gbPlayerControl.Controls.Add(this.btnFastRew);
            this.gbPlayerControl.Controls.Add(this.btnPlay);
            this.gbPlayerControl.Controls.Add(this.btnPause);
            this.gbPlayerControl.Controls.Add(this.btnPlayBackwards);
            this.gbPlayerControl.Controls.Add(this.tbrPlayer);
            this.gbPlayerControl.Controls.Add(this.btnStop);
            this.gbPlayerControl.Location = new System.Drawing.Point(6, 214);
            this.gbPlayerControl.Name = "gbPlayerControl";
            this.gbPlayerControl.Size = new System.Drawing.Size(928, 44);
            this.gbPlayerControl.TabIndex = 60;
            this.gbPlayerControl.TabStop = false;
            this.gbPlayerControl.Text = "player control";
            // 
            // btnFrameStep
            // 
            this.btnFrameStep.BackColor = System.Drawing.SystemColors.Control;
            this.btnFrameStep.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrameStep.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrameStep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFrameStep.ImageIndex = 6;
            this.btnFrameStep.ImageList = this.ImageList1;
            this.btnFrameStep.Location = new System.Drawing.Point(156, 16);
            this.btnFrameStep.Name = "btnFrameStep";
            this.btnFrameStep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrameStep.Size = new System.Drawing.Size(32, 22);
            this.btnFrameStep.TabIndex = 33;
            this.btnFrameStep.UseVisualStyleBackColor = false;
            this.btnFrameStep.Click += new System.EventHandler(this.btnFrameStep_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Silver;
            this.ImageList1.Images.SetKeyName(0, "");
            this.ImageList1.Images.SetKeyName(1, "");
            this.ImageList1.Images.SetKeyName(2, "");
            this.ImageList1.Images.SetKeyName(3, "");
            this.ImageList1.Images.SetKeyName(4, "");
            this.ImageList1.Images.SetKeyName(5, "");
            this.ImageList1.Images.SetKeyName(6, "");
            // 
            // btnFastFwd
            // 
            this.btnFastFwd.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastFwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastFwd.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastFwd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastFwd.ImageIndex = 0;
            this.btnFastFwd.ImageList = this.ImageList1;
            this.btnFastFwd.Location = new System.Drawing.Point(232, 15);
            this.btnFastFwd.Name = "btnFastFwd";
            this.btnFastFwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastFwd.Size = new System.Drawing.Size(32, 22);
            this.btnFastFwd.TabIndex = 32;
            this.btnFastFwd.UseVisualStyleBackColor = false;
            this.btnFastFwd.Click += new System.EventHandler(this.btnFastFwd_Click);
            // 
            // btnFastRew
            // 
            this.btnFastRew.BackColor = System.Drawing.SystemColors.Control;
            this.btnFastRew.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFastRew.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFastRew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFastRew.ImageIndex = 1;
            this.btnFastRew.ImageList = this.ImageList1;
            this.btnFastRew.Location = new System.Drawing.Point(194, 16);
            this.btnFastRew.Name = "btnFastRew";
            this.btnFastRew.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFastRew.Size = new System.Drawing.Size(32, 22);
            this.btnFastRew.TabIndex = 31;
            this.btnFastRew.UseVisualStyleBackColor = false;
            this.btnFastRew.Click += new System.EventHandler(this.btnFastRew_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlay.ImageIndex = 2;
            this.btnPlay.ImageList = this.ImageList1;
            this.btnPlay.Location = new System.Drawing.Point(118, 16);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlay.Size = new System.Drawing.Size(32, 22);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPause.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.ImageIndex = 4;
            this.btnPause.ImageList = this.ImageList1;
            this.btnPause.Location = new System.Drawing.Point(80, 16);
            this.btnPause.Name = "btnPause";
            this.btnPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPause.Size = new System.Drawing.Size(32, 22);
            this.btnPause.TabIndex = 28;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlayBackwards
            // 
            this.btnPlayBackwards.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlayBackwards.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlayBackwards.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayBackwards.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlayBackwards.ImageIndex = 5;
            this.btnPlayBackwards.ImageList = this.ImageList1;
            this.btnPlayBackwards.Location = new System.Drawing.Point(6, 16);
            this.btnPlayBackwards.Name = "btnPlayBackwards";
            this.btnPlayBackwards.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPlayBackwards.Size = new System.Drawing.Size(32, 22);
            this.btnPlayBackwards.TabIndex = 27;
            this.btnPlayBackwards.UseVisualStyleBackColor = false;
            this.btnPlayBackwards.Click += new System.EventHandler(this.btnPlayBackwards_Click);
            // 
            // tbrPlayer
            // 
            this.tbrPlayer.AutoSize = false;
            this.tbrPlayer.Location = new System.Drawing.Point(270, 15);
            this.tbrPlayer.Name = "tbrPlayer";
            this.tbrPlayer.Size = new System.Drawing.Size(651, 29);
            this.tbrPlayer.TabIndex = 20;
            this.tbrPlayer.Scroll += new System.EventHandler(this.tbrPlayer_Scroll);
            this.tbrPlayer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyUp);
            this.tbrPlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseDown);
            this.tbrPlayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbrPlayer_MouseUp);
            this.tbrPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbrPlayer_KeyDown);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStop.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStop.ImageIndex = 3;
            this.btnStop.ImageList = this.ImageList1;
            this.btnStop.Location = new System.Drawing.Point(43, 16);
            this.btnStop.Name = "btnStop";
            this.btnStop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStop.Size = new System.Drawing.Size(32, 22);
            this.btnStop.TabIndex = 29;
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(6, 261);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(71, 14);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "storage path:";
            // 
            // chkPlayerTrackBarSynchrone
            // 
            this.chkPlayerTrackBarSynchrone.Location = new System.Drawing.Point(779, 248);
            this.chkPlayerTrackBarSynchrone.Name = "chkPlayerTrackBarSynchrone";
            this.chkPlayerTrackBarSynchrone.Size = new System.Drawing.Size(148, 17);
            this.chkPlayerTrackBarSynchrone.TabIndex = 62;
            this.chkPlayerTrackBarSynchrone.Text = "player trackbar synchrone";
            this.chkPlayerTrackBarSynchrone.CheckedChanged += new System.EventHandler(this.chkPlayerTrackBarSynchrone_CheckedChanged);
            // 
            // tbrZoom
            // 
            this.tbrZoom.AutoSize = false;
            this.tbrZoom.Location = new System.Drawing.Point(254, 261);
            this.tbrZoom.Maximum = 20000;
            this.tbrZoom.Minimum = 1000;
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Size = new System.Drawing.Size(537, 26);
            this.tbrZoom.TabIndex = 63;
            this.tbrZoom.Value = 1000;
            this.tbrZoom.Scroll += new System.EventHandler(this.tbrZoom_Scroll);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(220, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 27);
            this.label2.TabIndex = 64;
            this.label2.Text = "ZOOM:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbrZoomX
            // 
            this.tbrZoomX.AutoSize = false;
            this.tbrZoomX.Location = new System.Drawing.Point(297, 293);
            this.tbrZoomX.Maximum = 20000;
            this.tbrZoomX.Minimum = 1000;
            this.tbrZoomX.Name = "tbrZoomX";
            this.tbrZoomX.Size = new System.Drawing.Size(483, 15);
            this.tbrZoomX.TabIndex = 65;
            this.tbrZoomX.Value = 1000;
            this.tbrZoomX.Scroll += new System.EventHandler(this.tbrZoomX_Scroll);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(222, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 27);
            this.label3.TabIndex = 66;
            this.label3.Text = "zoom center X:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "Y:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbrZoomY
            // 
            this.tbrZoomY.AutoSize = false;
            this.tbrZoomY.Location = new System.Drawing.Point(221, 323);
            this.tbrZoomY.Maximum = 20000;
            this.tbrZoomY.Minimum = 1000;
            this.tbrZoomY.Name = "tbrZoomY";
            this.tbrZoomY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrZoomY.Size = new System.Drawing.Size(18, 318);
            this.tbrZoomY.TabIndex = 68;
            this.tbrZoomY.Value = 1000;
            this.tbrZoomY.Scroll += new System.EventHandler(this.tbrZoomY_Scroll);
            // 
            // AutoSizeInfo
            // 
            this.AutoSizeInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AutoSizeInfo.Location = new System.Drawing.Point(251, 311);
            this.AutoSizeInfo.Name = "AutoSizeInfo";
            this.AutoSizeInfo.Size = new System.Drawing.Size(693, 20);
            this.AutoSizeInfo.TabIndex = 69;
            this.AutoSizeInfo.Text = "the component will resize automatically because Display_AutoSize is enabled in th" +
                "e Form_Load event (default = disabled)";
            this.AutoSizeInfo.Click += new System.EventHandler(this.AutoSizeInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(956, 663);
            this.Controls.Add(this.tbrZoomY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrZoomX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbrZoom);
            this.Controls.Add(this.chkPlayerTrackBarSynchrone);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.gbPlayerControl);
            this.Controls.Add(this.tbcTabs);
            this.Controls.Add(this.mmoLog);
            this.Controls.Add(this.edtDVDateTime);
            this.Controls.Add(this.edtFrameCount);
            this.Controls.Add(this.edtStoragePath);
            this.Controls.Add(this.axVideoGrabberNET1);
            this.Controls.Add(this.AutoSizeInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datastead Software - TVideoGrabber demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoGrabberNET1)).EndInit();
            this.tbcTabs.ResumeLayout(false);
            this.gbPlayerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoomY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            VideoFromImages = new VideoFromImagesFileList();
            VideoFromImagesUsePictureBox = false;

            axVideoGrabberNET1.StoragePath = System.IO.Directory.GetCurrentDirectory();
            axVideoGrabberNET1.Display_AutoSize = true;   // the control will resize automatically
            axVideoGrabberNET1.AutoRefreshPreview = true; // the preview will restart automatically when changing device properties (e.g. video size, analog video standard, etc...)

            StartupWidth = Width;
            StartupHeight = Height;


			IsVideoGrabberMouseDown = false;
            frmOverlays_edtDrawGrid = 0;
			frmOverlays_drawTarget = false;
            frmOverlays_btnDrawGridColor = Color.Blue;
            frmOverlays_btnFreeHandColor = Color.Red;

            StartupVGWidth = axVideoGrabberNET1.Width;
            StartupVGHeight = axVideoGrabberNET1.Height;


            CountPictureBox = 0;

            edtStoragePath.Text = axVideoGrabberNET1.StoragePath;

            cFreeHandDrawing = new FreeHandDrawing();
            cPickupColor = new PickupColor();

            LastKBWrittenReportTime = 0;

            frmAudio = new Audio();
            frmVideoSource = new VideoSource();
            frmIPCamera = new IPCamera();
            frmVideoFromJPEGsOrBitmaps = new VideoFromJPEGsOrBitmaps();
            frmDisplay = new Display();
            frmFrameGrabber = new FrameGrabber();
            frmMotionDetection = new MotionDetection();
            frmNetworkStreaming = new NetworkStreaming();
            frmOverlays = new Overlays();
            frmPlayer = new Player();
            frmRecording = new Recording();
            frmReencoding = new Reencoding();
            frmSnapForm = new SnapForm();
            frmTVTuner = new TVTuner();
            frmVideoProcessing = new VideoProcessing();

            frmAudio.cMainForm = this;
            frmVideoSource.cMainForm = this;
            frmIPCamera.cMainForm = this;
            frmVideoFromJPEGsOrBitmaps.cMainForm = this;
            frmDisplay.cMainForm = this;
            frmFrameGrabber.cMainForm = this;
            frmMotionDetection.cMainForm = this;
            frmNetworkStreaming.cMainForm = this;
            frmOverlays.cMainForm = this;
            frmPlayer.cMainForm = this;
            frmRecording.cMainForm = this;
            frmReencoding.cMainForm = this;
            frmSnapForm.cMainForm = this;
            frmTVTuner.cMainForm = this;
            frmVideoProcessing.cMainForm = this;

            RefreshControls();


            tbcTabs.SelectedTab = tbpVideoSource;
            SelectInsetForm(tbcTabs);


        }

        public void RefreshControls()
        {
            frmVideoSource.RefreshControls();
            frmIPCamera.RefreshControls();
            frmVideoFromJPEGsOrBitmaps.RefreshControls();
            frmAudio.RefreshControls();
            frmDisplay.RefreshControls();
            frmFrameGrabber.RefreshControls();
            frmMotionDetection.RefreshControls();
            frmNetworkStreaming.RefreshControls();
            frmOverlays.RefreshControls();
            frmPlayer.RefreshControls();
            frmRecording.RefreshControls();
            frmReencoding.RefreshControls();
            frmTVTuner.RefreshControls();
            frmVideoProcessing.RefreshControls();
        }

		private void tbcTabs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SelectInsetForm(tbcTabs);
		}

        private void SelectInsetForm(TabControl Tabs)
        {

            if (frmInsetForm != null)
            {
                frmInsetForm.Close();
            }

            switch (Tabs.SelectedTab.Name)
            {
                case "tbpVideoSource":
                    frmInsetForm = frmVideoSource;
                    break;
                case "tbpIPCameras":
                    frmInsetForm = frmIPCamera;
                    break;
                case "tbpAudio":
                    frmInsetForm = frmAudio;
                    break;
                case "tbpRecording":
                    frmInsetForm = frmRecording;
                    break;
                case "tbpVideoFromJPEGsorBitmaps":
                    frmInsetForm = frmVideoFromJPEGsOrBitmaps;
                    break;
                case "tbpNetworkStreaming":
                    frmInsetForm = frmNetworkStreaming;
                    break;
                case "tbpPlayer":
                    frmInsetForm = frmPlayer;
                    break;
                case "tbpFrameGrabber":
                    frmInsetForm = frmFrameGrabber;
                    break;
                case "tbpMotionDetection":
                    frmInsetForm = frmMotionDetection;
                    break;
                case "tbpOverlays":
                    frmInsetForm = frmOverlays;
                    break;
                case "tbpVideoProcessing":
                    frmInsetForm = frmVideoProcessing;
                    break;
                case "tbpDisplay":
                    frmInsetForm = frmDisplay;
                    break;
                case "tbpReencoding":
                    frmInsetForm = frmReencoding;
                    break;
                case "tbpTVTuner":
                    frmInsetForm = frmTVTuner;
                    break;
            }

            if (frmInsetForm != null)
            {
                InsetForms.InsetForm(ref frmInsetForm, Tabs.SelectedTab.Handle.ToInt32());
                frmInsetForm.Show();
            }

        }

        public void SetEnumerateWindows(string WindowName, bool ExactMatch)
        {
            wenScreenRecordingWindow = new WINDOW_ENUM[1];
            lngScreenRecordingWindow = 0;
            strScreenRecordingWindow = WindowName;
            boolScreenRecordingWindow = ExactMatch;
            frmVideoSource.lblEnumerateWindows.Text = ((strScreenRecordingWindow == "") ? "" : System.Convert.ToString(lngScreenRecordingWindow));
        }

        private void axVideoGrabberNET1_OnEnumerateWindows(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnEnumerateWindowsEvent e)
        {
            // EnumerateWindows begins gathering of visible windows
            // Demo proc SetEnumerateWindows initializes array wenScreenRecordingWindow(),
            //  called in OnRecordingReadyToStart event, which is instigated by
            //  enabling HoldRecording before calling StartRecording
            //  (see btnStartRecordingControlled in Recording form)

            bool b = false;

            if (strScreenRecordingWindow.ToLower() == e.windowName.ToLower())
            {
                b = true;
            }
            else if ((!boolScreenRecordingWindow) & (e.windowName.ToLower().IndexOf(strScreenRecordingWindow.ToLower(), 0) + 1) > 0)
            {
                b = true;
            }
            else
            {
                b = false;
            }
            if (b)
            {
#if (!VS2003) 
				Array.Resize(ref wenScreenRecordingWindow, lngScreenRecordingWindow + 1);
#endif
				wenScreenRecordingWindow[lngScreenRecordingWindow].WindowHandle = e.windowHandle;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowClass = e.windowClass;
                wenScreenRecordingWindow[lngScreenRecordingWindow].WindowName = e.windowName;
                lngScreenRecordingWindow = lngScreenRecordingWindow + 1;

                frmVideoSource.lblEnumerateWindows.Text = Convert.ToString(lngScreenRecordingWindow);
            }
        }


        private void axVideoGrabberNET1_OnVideoDeviceSelected(object sender, System.EventArgs e)
        {
            RefreshControls(); // updates all the ComboBox lists and controls, especially those that depend of the video capture device (like VideoInputs, VideoSubtypes, etc...)
        }

        private void axVideoGrabberNET1_OnAudioDeviceSelected(object sender, System.EventArgs e)
        {
            RefreshControls(); // updates all the ComboBox lists and controls, especially those that depend of the audio capture device (like AudioInputs, etc...)
        }

        private void axVideoGrabberNET1_OnFrameProgress2(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameProgress2Event e)
        {
            string DVTimeCode;
            string DVDateTime;

            {
                TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(TFrameInfo)); 

                if (FrameInfo.currentState == Vidgrab_NET.TxCurrentState.cs_Playback) // we don't include the dropped frames during playback
                {
                    edtFrameCount.Text = String.Format("frame: {0} time:{1:00}:{2:00}:{3:00}:{4:00}", FrameInfo.frameNumber, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
                }
                else
                {
                    edtFrameCount.Text = String.Format("frame: {0} dropped:{1} time:{2:00}:{3:00}:{4:00}:{5:00}", FrameInfo.frameNumber, FrameInfo.droppedFrameCount, FrameInfo.frameTime_Hour, FrameInfo.frameTime_Min, FrameInfo.frameTime_Sec, FrameInfo.frameTime_Hs);
                }

                if (FrameInfo.dVTimeCode_IsAvailable > 0) // if available
                {
                    DVTimeCode = String.Format("tc: {0:00}:{1:00}:{2:00}:{3:00}", FrameInfo.dVTimeCode_Hour, FrameInfo.dVTimeCode_Min, FrameInfo.dVTimeCode_Sec, FrameInfo.dVTimeCode_Ff);
                }
                else
                {
                    DVTimeCode = " ";
                }
                if (FrameInfo.dVDateTime_IsAvailable > 0)  // if available
                {
                    DVDateTime = String.Format("dv date: {0:00}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}", FrameInfo.dVDateTime_Day, FrameInfo.dVDateTime_Month, FrameInfo.dVDateTime_Year, FrameInfo.dVDateTime_Hour, FrameInfo.dVDateTime_Min, FrameInfo.dVDateTime_Sec);
                }
                else
                {
                    DVDateTime = " ";
                }
                edtDVDateTime.Text = DVTimeCode + " " + DVDateTime;

                if (axVideoGrabberNET1.CurrentState == Vidgrab_NET.TxCurrentState.cs_Recording)
                {
                    if ((FrameInfo.frameTime - LastKBWrittenReportTime) > 50000000)
                    {  // every 5 seconds
                        LastKBWrittenReportTime = FrameInfo.frameTime;
                        AddLog(mmoLog, String.Format("written to disk: {0} KB", axVideoGrabberNET1.RecordingKBytesWrittenToDisk()));
                    }
                }
            }
        }

        private void axVideoGrabberNET1_OnFrameBitmap(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameBitmapEvent e)
        {
            // this event is called directly from a thread. Read the (*) comment at the bottom of this page

            // GRID DRAWING
            // ============
            {
                TFrameInfo FrameInfo = (TFrameInfo)Marshal.PtrToStructure((IntPtr)e.frameInfo, typeof(TFrameInfo));
                TFrameBitmapInfo FrameBitmapInfo = (TFrameBitmapInfo)Marshal.PtrToStructure((IntPtr)e.bitmapInfo, typeof(TFrameBitmapInfo)); 

				if (frmOverlays_drawTarget)
				{
				Graphics MyGraphics = Graphics.FromHdcInternal(new IntPtr(FrameBitmapInfo.bitmapDC));

				Pen p = new Pen(Color.Blue);
				SolidBrush b = new SolidBrush(Color.Blue);

				int TargetRadius = 50;
				int TargetRadiusX2 = TargetRadius * 2;

				MyGraphics.DrawEllipse(p, frmOverlays_drawTarget_Location.X - TargetRadius, frmOverlays_drawTarget_Location.Y - TargetRadius, TargetRadiusX2, TargetRadiusX2);

				MyGraphics.FillRectangle(b, frmOverlays_drawTarget_Location.X - TargetRadius, frmOverlays_drawTarget_Location.Y, TargetRadiusX2, 1);
				MyGraphics.FillRectangle(b, frmOverlays_drawTarget_Location.X, frmOverlays_drawTarget_Location.Y - TargetRadius, 1, TargetRadiusX2);

				MyGraphics.Dispose();
			}

                if (frmOverlays_edtDrawGrid > 1)
                {

                    Graphics MyGraphics = Graphics.FromHdcInternal(new IntPtr(FrameBitmapInfo.bitmapDC));
                    SolidBrush b = new SolidBrush(frmOverlays_btnDrawGridColor);

                    int xStep = FrameBitmapInfo.bitmapWidth / frmOverlays_edtDrawGrid;
                    int yStep = xStep;

                    int xLocation = xStep;
                    int yLocation = yStep;

                    while (xLocation < FrameBitmapInfo.bitmapWidth)
                    {
                        MyGraphics.FillRectangle(b, xLocation, 0, 1, FrameBitmapInfo.bitmapHeight);
                        xLocation += xStep;
                    }

                    while (yLocation < FrameBitmapInfo.bitmapHeight)
                    {
                        MyGraphics.FillRectangle(b, 0, yLocation, FrameBitmapInfo.bitmapWidth, 1);
                        yLocation += yStep;
                    }

                    MyGraphics.Dispose();
                }

                // FREE HAND DRAWING
                // ============

                if (cFreeHandDrawing.iArrayCoordinates > 0)
                { // see the VideoGrabberMouse... events;

                    Graphics MyGraphics = Graphics.FromHdcInternal(new IntPtr(FrameBitmapInfo.bitmapDC));
                    Pen p = new Pen(frmOverlays_btnFreeHandColor);
                    SolidBrush b = new SolidBrush(frmOverlays_btnFreeHandColor);

                    int LastX = 0;
                    int LastY = 0;

                    int i;

                    for (i = 0; i < cFreeHandDrawing.iArrayCoordinates; i++)
                    {
                        if (cFreeHandDrawing.ArrayCoordinates[i].Width == 0)
                        { //// Width is used as boolean to know if (it is a MoveTo or a LineTo;
                            LastX = cFreeHandDrawing.ArrayCoordinates[i].X;
                            LastY = cFreeHandDrawing.ArrayCoordinates[i].Y;
                            MyGraphics.FillRectangle(b, LastX, LastY, 1, 1);
                        }
                        else
                        {
                            MyGraphics.DrawLine(p, LastX, LastY, cFreeHandDrawing.ArrayCoordinates[i].X, cFreeHandDrawing.ArrayCoordinates[i].Y);
                            LastX = cFreeHandDrawing.ArrayCoordinates[i].X;
                            LastY = cFreeHandDrawing.ArrayCoordinates[i].Y;
                        }
                    }

                    MyGraphics.Dispose();
                }

                // VIDEO SIGNAL DETECTION
                // ============

                bool NewVideoSignalState = false;

                NewVideoSignalState = OldVideoSignalState;

                if (VideoProcessing_DetectNoVideoSignal)
                {
                    NewVideoSignalState = axVideoGrabberNET1.IsVideoSignalDetected(false, true, 30, 30, 30, true);
                }
                else if (VideoProcessing_DetectConnexantBlueScreen)
                {
                    NewVideoSignalState = axVideoGrabberNET1.IsVideoSignalDetected(true, false, 0, 0, 0, false);
                }

                if (NewVideoSignalState != OldVideoSignalState)
                {
                    OldVideoSignalState = NewVideoSignalState;
                    if (NewVideoSignalState)
                    {
                        AddLog(mmoLog, "Video signal is back");
                    }
                    else
                    {
                        AddLog(mmoLog, "VIDEO SIGNAL LOST");
                    }
                }

                // used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
                if (cPickupColor.MustGetRGBPixel)
                {
                    cPickupColor.MustGetRGBPixel = false;
                    cPickupColor.LastRGBPixelValueAtMousePosition = axVideoGrabberNET1.GetRGBPixelAt(cPickupColor.MouseXVideoPosition, cPickupColor.MouseYVideoPosition);
                }
            }
        }

        private void axVideoGrabberNET1_OnFrameCaptureCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnFrameCaptureCompletedEvent e)
        {
            if (e.success)
            {
                AddLog((frmFrameGrabber.mmoFrameCaptureLog), "frame #" + e.frameNumber.ToString() + " captured");
            }

            if ((e.destType == Vidgrab_NET.TxFrameCaptureDest.fc_JpegFile) || (e.destType == Vidgrab_NET.TxFrameCaptureDest.fc_BmpFile))
            {
                if (e.success)
                {
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), e.fileName);
                }
                else
                {
                    AddLog((frmFrameGrabber.mmoFrameCaptureLog), "error: failed to create " + e.fileName);
                }
            }
            if (e.destType == Vidgrab_NET.TxFrameCaptureDest.fc_TBitmap)
            {
                if (!frmSnapForm.Visible)
                {
                    frmSnapForm.Show();
                }
                if (frmSnapForm.SnapImage.Image != null)
                {
                    frmSnapForm.SnapImage.Image.Dispose();
                }
                frmSnapForm.SnapImage.Image = Image.FromHbitmap((System.IntPtr)e.frameBitmapHandle);
            }
        }

        private void axVideoGrabberNET1_OnCopyPreallocDataCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataCompletedEvent e)
        {
            if (e.success)
            {
                AddLog(mmoLog, " successfully copied to " + e.destFile + ".");
            }
            else
            {
                AddLog(mmoLog, "ERROR: Failed to copy " + e.sourceFile + " to " + e.destFile + "!");
            }
        }

        private void axVideoGrabberNET1_OnCopyPreallocDataProgress(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataProgressEvent e)
        {
            AddLog(mmoLog, "copying data: " + e.percent.ToString() + "% completed.");
        }

        private void axVideoGrabberNET1_OnCopyPreallocDataStarted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCopyPreallocDataStartedEvent e)
        {
            AddLog(mmoLog, "copying data from " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void axVideoGrabberNET1_OnCreatePreallocFileCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileCompletedEvent e)
        {
            if (e.success)
            {
                AddLog(mmoLog, "preallocated file " + e.fileName + " successfully created.");
            }
            else
            {
                AddLog(mmoLog, "ERROR: Failed to preallocate " + e.fileName);
            }
        }

        private void axVideoGrabberNET1_OnCreatePreallocFileProgress(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileProgressEvent e)
        {
            AddLog(mmoLog, e.percent.ToString() + "% of preallocated file completed");
        }

        private void axVideoGrabberNET1_OnCreatePreallocFileStarted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnCreatePreallocFileStartedEvent e)
        {
            AddLog(mmoLog, "preallocating file " + e.fileName + "...");
        }

        private void axVideoGrabberNET1_OnDeviceArrivalOrRemoval(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnDeviceArrivalOrRemovalEvent e)
        {
            string AudioOrVideoDevice;

            if (e.isVideoDevice)
            {
                AudioOrVideoDevice = "video device ";
            }
            else
            {
                AudioOrVideoDevice = "audio device ";
            }
            if (e.isDeviceArrival)
            {
                AddLog(mmoLog, AudioOrVideoDevice + " arrival:");
            }
            else
            {
                AddLog(mmoLog, AudioOrVideoDevice + " removal:");
            }
            AddLog(mmoLog, e.deviceName);
            if (e.isVideoDevice)
            {
                AssignListToComboBox(frmVideoSource.cboVideoDevices, axVideoGrabberNET1.VideoDevices, axVideoGrabberNET1.VideoDevice);
            }
            else
            {
                AssignListToComboBox(frmAudio.cboAudioDevices, axVideoGrabberNET1.AudioDevices, axVideoGrabberNET1.AudioDevice);
            }
        }

        private void axVideoGrabberNET1_OnDeviceLost(object sender, System.EventArgs e)
        {
            AddLog(mmoLog, "DEVICE LOST!");
            AssignListToComboBox(frmVideoSource.cboVideoDevices, axVideoGrabberNET1.VideoDevices, axVideoGrabberNET1.VideoDevice);
            AssignListToComboBox(frmAudio.cboAudioDevices, axVideoGrabberNET1.AudioDevices, axVideoGrabberNET1.AudioDevice);
        }

        private void axVideoGrabberNET1_OnDirectNetworkStreamingHostUrl(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnDirectNetworkStreamingHostUrlEvent e)
        {
            AddLog(mmoLog, "streaming URL: " + e.hostUrl);
            AddLog(mmoLog, "streaming host: " + e.hostName);
            AddLog(mmoLog, "streaming port: " + e.hostPort.ToString());
        }

        private void axVideoGrabberNET1_OnDiskFull(object sender, System.EventArgs e)
        {
            AddLog(mmoLog, "DISK FULL!");
        }

        private void axVideoGrabberNET1_OnDVCommandCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnDVCommandCompletedEvent e)
        {
            AddLog(mmoLog, "camcorder state: " + e.newStateLabel);
        }

        private void axVideoGrabberNET1_OnDVDiscontinuity(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnDVDiscontinuityEvent e)
        {
            // SAMPLE CODE 1: creates a new file during recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // axVideoGrabberNET1.RecordToNewFileNow();

            // SAMPLE CODE 2: stops the recording when a discontinuity in the DV date/time is detected (uncommend the 2 lines below);
            // e.deliverNewFrame = false;
            // axVideoGrabberNET1.StopRecording();

            // read the (*) comment at the bottom of this unit;
        }

        private void axVideoGrabberNET1_OnLog(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnLogEvent e)
        {
            AddLog(mmoLog, "[" + e.severity + "] " + e.infoMsg);
        }

        private void axVideoGrabberNET1_OnMotionDetected(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionDetectedEvent e)
        {
            int MaxMotionXLocation = 0;
            int MaxMotionYLocation = 0;

            frmMotionDetection.edtMotionRatio.Text = axVideoGrabberNET1.MotionDetector_GlobalMotionRatio.ToString("0.000");

            frmMotionDetection.MotionDetected = true;

            frmMotionDetection.edtMaxMotionXY.Text = "x:" + e.maxMotionCellX.ToString() + " y:" + e.maxMotionCellY.ToString();

            if (axVideoGrabberNET1.MotionDetector_GetCellLocation(e.maxMotionCellX, e.maxMotionCellY, ref MaxMotionXLocation, ref MaxMotionYLocation))
            { 
                frmMotionDetection.edtMaxMotionCoord.Text = "x: " + MaxMotionXLocation.ToString() + "  y: " + MaxMotionYLocation.ToString();
            }

            frmMotionDetection.mmoMotionGrid.Text = axVideoGrabberNET1.MotionDetector_Get2DTextMotion();

            System.IntPtr FrameBitmap = (System.IntPtr) axVideoGrabberNET1.GetLastFrameAsHBITMAP(0, false, 0, 0, 0, 0, frmMotionDetection.imgMotionDetected.Width, frmMotionDetection.imgMotionDetected.Height, 32);
            if (! FrameBitmap.Equals (System.IntPtr.Zero)) {
                frmMotionDetection.imgMotionDetected.Image = Image.FromHbitmap(FrameBitmap);
                DeleteObject(FrameBitmap);
            }
        }

        private void axVideoGrabberNET1_OnMotionNotDetected(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnMotionNotDetectedEvent e)
        {
            frmMotionDetection.edtMotionRatio.Text = "";

            frmMotionDetection.MotionDetected = false;

            frmMotionDetection.mmoMotionGrid.Text = axVideoGrabberNET1.MotionDetector_Get2DTextMotion();
        }

        private void axVideoGrabberNET1_OnMouseDown(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseDownEvent e)
        {
            if (e.videoWindow != -1)  // if (the video is displayed;
            {
				if (frmOverlays.chkTargetAtMouseLocation.Checked) 
				{
					frmOverlays_drawTarget_Location.X = e.x;
					frmOverlays_drawTarget_Location.Y = e.y;
					frmOverlays_drawTarget = true;
				}

                if (frmOverlays.chkFreeHandEnabled.Checked)
                {
                    if (cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY)
                    {
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].X = e.x;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Y = e.y;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Width = 0; // Width is used as boolean to know if [it is a MoveTo or a LineTo
                        cFreeHandDrawing.iArrayCoordinates++;
                        cFreeHandDrawing.DrawingEnabled = true;
                        axVideoGrabberNET1.RefreshPlayerOverlays();
                    }
                }
				IsVideoGrabberMouseDown = true;
            }
        }

        private void axVideoGrabberNET1_OnMouseMove(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseMoveEvent e)
        {
            if (e.videoWindow != -1)  // if (the video is displayed;
            {

				if (frmOverlays_drawTarget) 
				{
					if (IsVideoGrabberMouseDown) 
					{
						frmOverlays_drawTarget_Location.X = e.x;
						frmOverlays_drawTarget_Location.Y = e.y;
					}
				}

                if (cFreeHandDrawing.DrawingEnabled)
                {
                    if (cFreeHandDrawing.iArrayCoordinates < cFreeHandDrawing.MAXCOORDINATESARRAY)
                    {
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].X = e.x;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Y = e.y;
                        cFreeHandDrawing.ArrayCoordinates[cFreeHandDrawing.iArrayCoordinates].Width = 1; // Width is used as boolean to know if [it is a MoveTo or a LineTo;
                        cFreeHandDrawing.iArrayCoordinates++;
                        axVideoGrabberNET1.RefreshPlayerOverlays();
                    }
                }
            }
        }

        private void axVideoGrabberNET1_OnMouseUp(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnMouseUpEvent e)
        {
			IsVideoGrabberMouseDown = false;
            cFreeHandDrawing.DrawingEnabled = false;

            // used in the image overlay sample, to pickup a transparent color on the video frame at the last mouse click location
            cPickupColor.LastRGBPixelValueAtMousePosition = 0;
            cPickupColor.MouseXVideoPosition = e.x;
            cPickupColor.MouseYVideoPosition = e.y;
            cPickupColor.MustGetRGBPixel = true;
            axVideoGrabberNET1.RefreshPlayerOverlays();
        }

        private void axVideoGrabberNET1_OnPlayerOpened(object sender, System.EventArgs e)
        {
            tbrPlayer.Minimum = 1;
            tbrPlayer.TickFrequency = 1;
            tbrPlayer.Maximum = (int)axVideoGrabberNET1.PlayerFrameCount;

            AddLog(mmoLog, "");
            AddLog(mmoLog, "playing " + axVideoGrabberNET1.PlayerFileName);

            if (axVideoGrabberNET1.IsPlayerVideoStreamAvailable == Vidgrab_NET.TxTriState.ts_True)
            {
                AddLog(mmoLog, "this clip has a video stream");
            }
            else if (axVideoGrabberNET1.IsPlayerVideoStreamAvailable == Vidgrab_NET.TxTriState.ts_False)
            {
                AddLog(mmoLog, "this clip does not have video");
            }
            if (axVideoGrabberNET1.IsPlayerAudioStreamAvailable == Vidgrab_NET.TxTriState.ts_True)
            {
                AddLog(mmoLog, "this clip has a Audio stream");
            }
            else if (axVideoGrabberNET1.IsPlayerAudioStreamAvailable == Vidgrab_NET.TxTriState.ts_False)
            {
                AddLog(mmoLog, "this clip does not have Audio");

            }

            AddLog(mmoLog, "");
            AddLog(mmoLog, "video codec: " + axVideoGrabberNET1.PlayerVideoCodec);
            AddLog(mmoLog, "audio codec: " + axVideoGrabberNET1.PlayerAudioCodec);
            AddLog(mmoLog, "");
            double PlayerDuration = axVideoGrabberNET1.PlayerDuration / 10000000;
            AddLog(mmoLog, "Duration: " + PlayerDuration.ToString("0.00"));
            AddLog(mmoLog, "Frame count: " + axVideoGrabberNET1.PlayerFrameCount.ToString());
            AddLog(mmoLog, "Frame rate: " + axVideoGrabberNET1.PlayerFrameRate.ToString("0.00"));
            AddLog(mmoLog, "size:" + axVideoGrabberNET1.VideoWidth.ToString() + "x" + axVideoGrabberNET1.VideoHeight.ToString());

            if (axVideoGrabberNET1.IsPlaylistActive())
            {
                frmPlayer.lstPlaylist.SelectedIndex = axVideoGrabberNET1.PlaylistIndex;
            }
        }

        private void axVideoGrabberNET1_OnPlayerEndOfStream(object sender, System.EventArgs e)
        {
            AddLog(mmoLog, "end of stream.");

            if (frmPlayer.chkLoop.Checked)
            {
                axVideoGrabberNET1.RunPlayer();
            }
        }

        private void tbrPlayer_Scroll(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.PlayerFramePosition = tbrPlayer.Value;
        }

        private void chkPlayerTrackBarSynchrone_CheckedChanged(object sender, EventArgs e)
        {
            axVideoGrabberNET1.PlayerTrackBarSynchrone = chkPlayerTrackBarSynchrone.Checked;
        }

        private void btnPlayBackwards_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.RunPlayerBackwards();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.RunPlayer();
        }

        private void btnFrameStep_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.PlayerFrameStep(1);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.PausePlayer();
        }

        private void btnFastFwd_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.FastForwardPlayer();
        }

        private void btnFastRew_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.RewindPlayer();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.StopPlayer();
        }

        private void axVideoGrabberNET1_OnPlayerUpdateTrackbarPosition(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnPlayerUpdateTrackbarPositionEvent e)
        {
            tbrPlayer.Value = (int)e.frameNumber;
        }

        private void tbrPlayer_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            axVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_MouseDown);
        }

        private void tbrPlayer_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            axVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_MouseUp);
        }

        private void tbrPlayer_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            axVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_KeyDown);
        }

        private void tbrPlayer_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            axVideoGrabberNET1.NotifyPlayerTrackbarAction(Vidgrab_NET.TxTrackbarAction.tba_KeyUp);
        }

        private void axVideoGrabberNET1_OnPreviewStarted(object sender, System.EventArgs e)
        {
            AddLog(mmoLog, "");
            AddLog(mmoLog, "video size: " + axVideoGrabberNET1.VideoWidth.ToString() + " x" + axVideoGrabberNET1.VideoHeight.ToString());
            AddLog(mmoLog, "display size: " + axVideoGrabberNET1.Display_VideoWidth.ToString() + " x" + axVideoGrabberNET1.Display_VideoHeight.ToString());
            AddLog(mmoLog, "current frame rate: " + axVideoGrabberNET1.CurrentFrameRate.ToString("0.00") + " fps.");
            AddLog(mmoLog, "");
        }

        private void axVideoGrabberNET1_OnRecordingPaused(object sender, EventArgs e)
        {
            AddLog(mmoLog, "recording paused...");
        }

        private void axVideoGrabberNET1_OnRecordingCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingCompletedEvent e)
        {
            if (e.success)
            {
                AddLog(mmoLog, " successfully created.");
                AddLog(mmoLog, " size: " + axVideoGrabberNET1.RecordingKBytesWrittenToDisk().ToString() + " KB");
            }
            else
            {
                AddLog(mmoLog, "recording failed.");
            }
            frmRecording.btnRenewRecordingFile.Enabled = false;
        }

        private void axVideoGrabberNET1_OnRecordingReadyToStart(object sender, System.EventArgs e)
        {

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired
            DialogResult result;
            result = MessageBox.Show("\"StartRecording\" was initiated with \"HoldRecording\" enabled,\nfiring the \"OnRecordingReadyToStart\" event.\n\nReady to start recording!", "DataStead TVideoGrabber VB.NET OCX Demo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if ((axVideoGrabberNET1.VideoSource == Vidgrab_NET.TxVideoSource.vs_ScreenRecording) & (frmRecording.chkScreenRecordWindow.Checked == true) & (lngScreenRecordingWindow > 0))
                {
                    // for screen recording of a window, this code will make it the top window before recording start;
                    //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                    // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                    InsetForms.SetWindowPos(wenScreenRecordingWindow[lngScreenRecordingWindow - 1].WindowHandle, InsetForms.HWND_TOP, 0, 0, 0, 0, InsetForms.SWP_NOMOVE | InsetForms.SWP_NOSIZE);
                }
                axVideoGrabberNET1.ResumeRecording();
            }
            else
            {
                axVideoGrabberNET1.StopRecording();
            }

        }

        private void axVideoGrabberNET1_OnRecordingStarted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnRecordingStartedEvent e)
        {
            AddLog(mmoLog, "recording to " + e.fileName + ":");
            AddLog(mmoLog, axVideoGrabberNET1.RecordingWidth.ToString() + " x" + axVideoGrabberNET1.RecordingHeight.ToString());
            AddLog(mmoLog, "current frame rate: " + axVideoGrabberNET1.CurrentFrameRate.ToString("0.0") + " fps.");
            frmRecording.btnRenewRecordingFile.Enabled = true;
            LastKBWrittenReportTime = 0;
        }

        private void axVideoGrabberNET1_OnReencodingCompleted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingCompletedEvent e)
        {
            if (e.success)
            {
                AddLog(mmoLog, " successfully reencoded to " + e.destFile);
            }
            else
            {
                AddLog(mmoLog, "Failed to reencode " + e.sourceFile + " to " + e.destFile);
            }
        }

        private void axVideoGrabberNET1_OnReencodingProgress(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingProgressEvent e)
        {
            AddLog(mmoLog, e.percent.ToString() + "% completed...");
        }

        private void axVideoGrabberNET1_OnReencodingStarted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnReencodingStartedEvent e)
        {
            AddLog(mmoLog, "reencoding " + e.sourceFile + " to " + e.destFile + "...");
        }

        private void axVideoGrabberNET1_OnReinitializing(object sender, System.EventArgs e)
        {
            mmoLog.Text = "";
        }

        private void axVideoGrabberNET1_OnResize(object sender, System.EventArgs e)
        {
            int NewWidth;
            int NewHeight;

            NewWidth = axVideoGrabberNET1.Left + axVideoGrabberNET1.VideoWidth + 30;
            NewHeight = axVideoGrabberNET1.Top + axVideoGrabberNET1.VideoHeight + 60;
            if ((NewWidth >= Width) | (NewHeight >= Height))
            {
                Width = ((NewWidth < StartupWidth) ? StartupWidth : NewWidth);
                Height = ((NewHeight < StartupHeight) ? StartupHeight : NewHeight);
            }
            else
            {
                if (NewWidth < StartupWidth)
                {
                    Width = StartupWidth;
                }
                if (NewHeight < StartupHeight)
                {
                    Height = StartupHeight;
                }
            }
        }

        private void axVideoGrabberNET1_OnResizeVideo(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnResizeVideoEvent e)
        {
            if (frmVideoProcessing != null) // frmVideoProcessing may ! have been yet created 
            {
                frmVideoProcessing.trkCroppingX.Maximum = axVideoGrabberNET1.Cropping_XMax;
                frmVideoProcessing.trkCroppingX.TickFrequency = (frmVideoProcessing.trkCroppingX.Maximum / 10);
                frmVideoProcessing.trkCroppingY.Maximum = axVideoGrabberNET1.Cropping_YMax;
                frmVideoProcessing.trkCroppingY.TickFrequency = (frmVideoProcessing.trkCroppingY.Maximum / 10);
            }
        }

        private void axVideoGrabberNET1_OnTVChannelScanCompleted(object sender, System.EventArgs e)
        {
            AddLog(frmTVTuner.mmoChannelLog, "autoscan completed.");
        }

        private void axVideoGrabberNET1_OnTVChannelScanStarted(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelScanStartedEvent e)
        {
            string InputType;

            InputType = " ";
            if (axVideoGrabberNET1.TVTunerInputType == Vidgrab_NET.TxTunerInputType.TunerInputCable)
            {
                InputType = "cable input";
            }
            else
            {
                InputType = "antenna input";
            }
            AddLog(frmTVTuner.mmoChannelLog, "scanning country code " + axVideoGrabberNET1.TVCountryCode.ToString() + " (" + InputType + ") from channel " + e.minChannel.ToString() + " to " + e.maxChannel.ToString() + "...");
        }

        private void axVideoGrabberNET1_OnTVChannelSelected(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnTVChannelSelectedEvent e)
        {
            string sFrequencyInfo = "";

            int TunerVideoFrequency = e.tunerVideoFrequency / 1000000;

            if (e.locked)
            {
                sFrequencyInfo = e.channel.ToString() + ": " + TunerVideoFrequency.ToString("0.00") + " Mhz (" + e.tunerVideoFrequency.ToString() + " Hz";
                if (e.overriddenVideoFrequency != -1)
                {
                    sFrequencyInfo = sFrequencyInfo + ", overridden";
                }
                sFrequencyInfo = sFrequencyInfo + ")";
                AddLog((frmTVTuner.mmoChannelLog), sFrequencyInfo);
            }
            else
            {
                if (e.overriddenVideoFrequency != -1)
                {
                    AddLog((frmTVTuner.mmoChannelLog), e.channel.ToString() + "... overridden and ! locked");
                }
                else
                {
                    AddLog((frmTVTuner.mmoChannelLog), e.channel.ToString() + "...");
                }
            }

            frmTVTuner.edtTVChannel.Text = e.channel.ToString();
            if (e.overriddenVideoFrequency != -1)
            {
                frmTVTuner.edtChannelFrequency.Text = e.overriddenVideoFrequency.ToString();
            }
            else
            {
                frmTVTuner.edtChannelFrequency.Text = e.tunerVideoFrequency.ToString();
            }
        }

        private void axVideoGrabberNET1_OnVideoFromBitmapsNextFrameNeeded(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnVideoFromBitmapsNextFrameNeededEvent e)
        {
            // you can pass to this event:;
            // - either the path to a BMP file or a JPEG file (this is the case in this example);
            // - either a the HBITMAP handle of a bitmap;

            bool EndOfData = false;

            if (VideoFromImagesUsePictureBox) // VideoFromImagesUsePictureBox is set in VideoFromJPEGsOrBitmaps.cs
            {
                int BitmapHandle = 0;
                bool CanFreeBitmapHandle = true;
                EndOfData = false; // we loop indefinitely

                switch (CountPictureBox)
                {
                    case 0: BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox1);
                        break;
                    case 1: BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox2);
                        break;
                    case 2: BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox3);
                        break;
                    case 3: BitmapHandle = CreateBitmapHandleFromPictureBox(frmVideoFromJPEGsOrBitmaps.PictureBox4);
                        break;
                }

                axVideoGrabberNET1.SendImageToVideoFromBitmaps("", BitmapHandle, CanFreeBitmapHandle, EndOfData);

                CountPictureBox++;
                if (CountPictureBox > 3)
                {
                    CountPictureBox = 0;
                }
            }
            else
            {
                string ImageFile = "";

                if (e.firstSample)
                {
                    ImageFile = VideoFromImages.FirstImageFile(); // the initialization is done in VideoFromJPEGsOrBitmaps
                    if (ImageFile == "")  // no image file found
                    {
                        EndOfData = true;
                    }
                }
                else
                {
                    ImageFile = VideoFromImages.NextImageFile(); // the initialization is done in VideoFromJPEGsOrBitmaps
                    if (ImageFile == "")  // it was the last image
                    {
                        EndOfData = true;
                    }
                }
                axVideoGrabberNET1.SendImageToVideoFromBitmaps(ImageFile, 0, false, EndOfData);
            }
        }

        private void axVideoGrabberNET1_OnClientConnection(object sender, AxVidgrab_NET.IVideoGrabberNETEvents_OnClientConnectionEvent e)
        {
            if (e.connected)
            {
                AddLog(mmoLog, "client connected: " + e.clientInfo);
            }
            else
            {
                AddLog(mmoLog, "client disconnected: " + e.clientInfo);
            }
        }

        private void edtStoragePath_TextChanged(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.StoragePath = edtStoragePath.Text;
        }

        private void mnuAbout_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.About();
        }

        private void mnuExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void axVideoGrabberNET1_OnGraphBuilt(object sender, System.EventArgs e)
        {
            AutoSizeInfo.Visible = false;

            tbrZoomX.Minimum = -(axVideoGrabberNET1.VideoWidth / 2);
            tbrZoomX.Maximum = axVideoGrabberNET1.VideoWidth / 2;
            tbrZoomX.Value = 0;
            tbrZoomY.Minimum = -(axVideoGrabberNET1.VideoHeight / 2);
            tbrZoomY.Maximum = axVideoGrabberNET1.VideoHeight / 2;
            tbrZoomY.Value = 0;
        }

        private void axVideoGrabberNET1_OnInactive(object sender, System.EventArgs e)
        {
            AddLog(mmoLog, "(done.)");
        }

        private void SendDVCommand(Vidgrab_NET.TxDVCommand DvCommand)
        {
            if (axVideoGrabberNET1.SendDVCommand(DvCommand))
            {
                AddLog(mmoLog, "DV command sent...");
            }
            else
            {
                if ((axVideoGrabberNET1.CurrentState != Vidgrab_NET.TxCurrentState.cs_Preview) & (axVideoGrabberNET1.CurrentState != Vidgrab_NET.TxCurrentState.cs_Recording))
                {
                    AddLog(mmoLog, "DV command failed. Preview must be running!");
                }
                else
                {
                    AddLog(mmoLog, "DV command failed.");
                }
            }
        }

        private void mnuDVPlay_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Play);
        }

        private void mnuDVStop_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Stop);
        }

        private void mnuDVFreeze_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Freeze);
        }

        private void mnuDVThaw_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Thaw);
        }

        private void mnuDVFF_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Ff);
        }

        private void mnuDVRew_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Rew);
        }

        private void mnuDVRecord_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_Record);
        }

        private void mnuDVRecordFreeze_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_RecordFreeze);
        }

        private void mnuDVRecordStrobe_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_RecordStrobe);
        }

        private void mnuDVStepFwd_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_StepFwd);
        }

        private void mnuDVStepRev_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_StepRev);
        }

        private void mnuDVModeShuttle_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_ModeShuttle);
        }

        private void mnuDVPlayFastestFwd_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlayFastestFwd);
        }

        private void mnuDVPlaySlowestFwd_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlaySlowestFwd);
        }

        private void mnuDVPlayFastestRev_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlayFastestRev);
        }

        private void mnuDVPlaySlowestRev_Click(object sender, System.EventArgs e)
        {
            SendDVCommand(Vidgrab_NET.TxDVCommand.dv_PlaySlowestRev);
        }

        private void mnuPriorityDefault_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_default;
        }
        private void mnuPriorityIdle_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_idle;
        }

        private void mnuPriorityNormal_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_normal;
        }

        private void mnuPriorityHigh_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_high;
        }

        private void mnuPriorityRealTime_Click(object sender, System.EventArgs e)
        {
            axVideoGrabberNET1.ApplicationPriority = Vidgrab_NET.TxApplicationPriority.ap_realtime;
        }

        private void mnuResetVideoDeviceSettings_Click(object sender, EventArgs e)
        {
            axVideoGrabberNET1.ResetVideoDeviceSettings();
        }

        public class FreeHandDrawing
        {
            public int MAXCOORDINATESARRAY = 5000;
            public bool DrawingEnabled = false;
            public int iArrayCoordinates = 0;
            public System.Drawing.Rectangle[] ArrayCoordinates;

            public FreeHandDrawing()
            {
                ArrayCoordinates = new System.Drawing.Rectangle[MAXCOORDINATESARRAY + 1];
            }
        }

        public class PickupColor
        {
            public bool MustGetRGBPixel = false;
            public int LastRGBPixelValueAtMousePosition = -1;
            public int MouseXVideoPosition = 0;
            public int MouseYVideoPosition = 0;
        }

        private void tbrZoom_Scroll(object sender, EventArgs e)
        {
            axVideoGrabberNET1.ZoomCoeff = tbrZoom.Value;
        }

        private void tbrZoomX_Scroll(object sender, EventArgs e)
        {
            axVideoGrabberNET1.ZoomXCenter = tbrZoomX.Value;

        }

        private void tbrZoomY_Scroll(object sender, EventArgs e)
        {
            axVideoGrabberNET1.ZoomYCenter = tbrZoomY.Value;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AutoSizeInfo_Click(object sender, EventArgs e)
        {

        }

    }
}




//(*) From this event you should not perform any actions with the potential to block:
//    1. do not hold a critical section or wait on another thread,
//    2. do not call any GDI or USER32.DLL APIs that might cause a window to move,
//    3. do not invoke component properties that send messages, e.g. do not read the ItemIndex property
//       of a ListBox component. If you need to read a such property, set an intermediary variable when
//       the property changes, and then read the intermediary variable from this event.
