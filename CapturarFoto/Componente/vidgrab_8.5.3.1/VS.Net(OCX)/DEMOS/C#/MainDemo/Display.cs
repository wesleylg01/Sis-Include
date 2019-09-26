using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Display.
	/// </summary>
	public class Display : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;
        public CheckBox chkAdjustPixelAspectRatio;
        internal CheckBox chkVideoVisibleWhenStopped;
        public GroupBox rdgVideoRenderer;
        internal RadioButton rdgVideoRendererNone;
        public RadioButton rdgVideoRendererOverlay;
        public RadioButton rdgVideoRendererStandard;
        public RadioButton rdgVideoRendererAutoSelect;
        public RadioButton rdgVideoRendererVMR7;
        public RadioButton rdgVideoRendererVMR9;
        internal RadioButton rdgVideoRendererRecPriority;
        internal CheckBox chkTransparency;
        public CheckBox chk2ndVideoWindowActive;
        public GroupBox grb2ndVideoWindow;
        public GroupBox rdg2ndDisplayedOn;
        public RadioButton rdg2ndDisplayedOn2;
        public RadioButton rdg2ndDisplayedOn1;
        internal TrackBar tbr2PanScan;
        internal Label Label2;
        internal CheckBox chk2ndVisible;
        internal GroupBox rdg2AspectRatio;
        internal RadioButton rdg2DisplayAspectRatioPanScan;
        internal RadioButton rdg2DisplayAspectRatioStretch;
        internal RadioButton rdg2DisplayAspectRatioPan;
        internal RadioButton rdg2DisplayAspectRatioBox;
        public Button btnEG2ndNewLocation2;
        public Button btnEG2ndNewLocation;
        public CheckBox chk2ndAutoSize;
        public CheckBox chk2ndStayOnTop;
        public CheckBox chk2ndMouseMovesWindow;
        public CheckBox chk2ndFullScreen;
        public CheckBox chk2ndUseVideoPort;
        public CheckBox chk2ndEmbedded;
        public GroupBox grbMainVideoWindow;
        internal Button btnTestPanScanHelp;
        internal Label Label1;
        public GroupBox rdg1stDisplayedOn;
        public RadioButton rdg1stDisplayedOn2;
        public RadioButton rdg1stDisplayedOn1;
        public CheckBox chk1stFullScreen;
        public CheckBox chk1stUseVideoPort;
        internal Button btnTestPanScan;
        internal TrackBar tbr1PanScan;
        internal CheckBox chk1stVisible;
        internal GroupBox rdg1AspectRatio;
        internal RadioButton rdg1DisplayAspectRatioPanScan;
        internal RadioButton rdg1DisplayAspectRatioStretch;
        internal RadioButton rdg1DisplayAspectRatioPan;
        internal RadioButton rdg1DisplayAspectRatioBox;
        public CheckBox chk1stEmbedded;
        public CheckBox chk1stMouseMovesWindow;
        public CheckBox chk1stStayOnTop;
        public CheckBox chk1stAutoSize;
        public Button btnEG1stNewLocation;
        public Button btnEG1stNewLocation2;
        public CheckBox chk1stVideoWindowActive;
        public CheckBox chkSetLogo;
        public CheckBox chkBorder;
        public CheckBox chkChangeCursor;
        public PictureBox imgLogo;

        private TransparentWindow frmTransparentWindow;

        
        private bool boolPanScan;
        private int PanScanVGWidth;
        public RadioButton rdgVideoRendererEVR;
        internal CheckBox chkBlackMagicOutput;
        private int PanScanVGHeight;
        

        private void Display_Load(object sender, System.EventArgs e)
        {
            frmTransparentWindow = new TransparentWindow();
        }

		public Display()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAdjustPixelAspectRatio = new System.Windows.Forms.CheckBox();
            this.chkVideoVisibleWhenStopped = new System.Windows.Forms.CheckBox();
            this.rdgVideoRenderer = new System.Windows.Forms.GroupBox();
            this.rdgVideoRendererEVR = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererNone = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererOverlay = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererStandard = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererAutoSelect = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererVMR7 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererVMR9 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRendererRecPriority = new System.Windows.Forms.RadioButton();
            this.chkTransparency = new System.Windows.Forms.CheckBox();
            this.chk2ndVideoWindowActive = new System.Windows.Forms.CheckBox();
            this.grb2ndVideoWindow = new System.Windows.Forms.GroupBox();
            this.rdg2ndDisplayedOn = new System.Windows.Forms.GroupBox();
            this.rdg2ndDisplayedOn2 = new System.Windows.Forms.RadioButton();
            this.rdg2ndDisplayedOn1 = new System.Windows.Forms.RadioButton();
            this.tbr2PanScan = new System.Windows.Forms.TrackBar();
            this.Label2 = new System.Windows.Forms.Label();
            this.chk2ndVisible = new System.Windows.Forms.CheckBox();
            this.rdg2AspectRatio = new System.Windows.Forms.GroupBox();
            this.rdg2DisplayAspectRatioPanScan = new System.Windows.Forms.RadioButton();
            this.rdg2DisplayAspectRatioStretch = new System.Windows.Forms.RadioButton();
            this.rdg2DisplayAspectRatioPan = new System.Windows.Forms.RadioButton();
            this.rdg2DisplayAspectRatioBox = new System.Windows.Forms.RadioButton();
            this.btnEG2ndNewLocation2 = new System.Windows.Forms.Button();
            this.btnEG2ndNewLocation = new System.Windows.Forms.Button();
            this.chk2ndAutoSize = new System.Windows.Forms.CheckBox();
            this.chk2ndStayOnTop = new System.Windows.Forms.CheckBox();
            this.chk2ndMouseMovesWindow = new System.Windows.Forms.CheckBox();
            this.chk2ndFullScreen = new System.Windows.Forms.CheckBox();
            this.chk2ndUseVideoPort = new System.Windows.Forms.CheckBox();
            this.chk2ndEmbedded = new System.Windows.Forms.CheckBox();
            this.grbMainVideoWindow = new System.Windows.Forms.GroupBox();
            this.btnTestPanScan = new System.Windows.Forms.Button();
            this.btnTestPanScanHelp = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.rdg1stDisplayedOn = new System.Windows.Forms.GroupBox();
            this.rdg1stDisplayedOn2 = new System.Windows.Forms.RadioButton();
            this.rdg1stDisplayedOn1 = new System.Windows.Forms.RadioButton();
            this.chk1stFullScreen = new System.Windows.Forms.CheckBox();
            this.chk1stUseVideoPort = new System.Windows.Forms.CheckBox();
            this.tbr1PanScan = new System.Windows.Forms.TrackBar();
            this.chk1stVisible = new System.Windows.Forms.CheckBox();
            this.rdg1AspectRatio = new System.Windows.Forms.GroupBox();
            this.rdg1DisplayAspectRatioPanScan = new System.Windows.Forms.RadioButton();
            this.rdg1DisplayAspectRatioStretch = new System.Windows.Forms.RadioButton();
            this.rdg1DisplayAspectRatioPan = new System.Windows.Forms.RadioButton();
            this.rdg1DisplayAspectRatioBox = new System.Windows.Forms.RadioButton();
            this.chk1stEmbedded = new System.Windows.Forms.CheckBox();
            this.chk1stMouseMovesWindow = new System.Windows.Forms.CheckBox();
            this.chk1stStayOnTop = new System.Windows.Forms.CheckBox();
            this.chk1stAutoSize = new System.Windows.Forms.CheckBox();
            this.btnEG1stNewLocation = new System.Windows.Forms.Button();
            this.btnEG1stNewLocation2 = new System.Windows.Forms.Button();
            this.chk1stVideoWindowActive = new System.Windows.Forms.CheckBox();
            this.chkSetLogo = new System.Windows.Forms.CheckBox();
            this.chkBorder = new System.Windows.Forms.CheckBox();
            this.chkChangeCursor = new System.Windows.Forms.CheckBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.chkBlackMagicOutput = new System.Windows.Forms.CheckBox();
            this.rdgVideoRenderer.SuspendLayout();
            this.grb2ndVideoWindow.SuspendLayout();
            this.rdg2ndDisplayedOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr2PanScan)).BeginInit();
            this.rdg2AspectRatio.SuspendLayout();
            this.grbMainVideoWindow.SuspendLayout();
            this.rdg1stDisplayedOn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbr1PanScan)).BeginInit();
            this.rdg1AspectRatio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAdjustPixelAspectRatio
            // 
            this.chkAdjustPixelAspectRatio.BackColor = System.Drawing.SystemColors.Control;
            this.chkAdjustPixelAspectRatio.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAdjustPixelAspectRatio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustPixelAspectRatio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAdjustPixelAspectRatio.Location = new System.Drawing.Point(120, 39);
            this.chkAdjustPixelAspectRatio.Name = "chkAdjustPixelAspectRatio";
            this.chkAdjustPixelAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAdjustPixelAspectRatio.Size = new System.Drawing.Size(151, 17);
            this.chkAdjustPixelAspectRatio.TabIndex = 53;
            this.chkAdjustPixelAspectRatio.Text = "adjust pixel aspect ratio";
            this.chkAdjustPixelAspectRatio.UseVisualStyleBackColor = false;
            this.chkAdjustPixelAspectRatio.CheckedChanged += new System.EventHandler(this.chkAdjustPixelAspectRatio_CheckedChanged);
            // 
            // chkVideoVisibleWhenStopped
            // 
            this.chkVideoVisibleWhenStopped.AutoSize = true;
            this.chkVideoVisibleWhenStopped.Location = new System.Drawing.Point(120, 23);
            this.chkVideoVisibleWhenStopped.Name = "chkVideoVisibleWhenStopped";
            this.chkVideoVisibleWhenStopped.Size = new System.Drawing.Size(154, 17);
            this.chkVideoVisibleWhenStopped.TabIndex = 52;
            this.chkVideoVisibleWhenStopped.Text = "video visible when stopped";
            this.chkVideoVisibleWhenStopped.CheckedChanged += new System.EventHandler(this.chkVideoVisibleWhenStopped_CheckedChanged);
            // 
            // rdgVideoRenderer
            // 
            this.rdgVideoRenderer.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererEVR);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererNone);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererOverlay);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererStandard);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererAutoSelect);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererVMR7);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererVMR9);
            this.rdgVideoRenderer.Controls.Add(this.rdgVideoRendererRecPriority);
            this.rdgVideoRenderer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRenderer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRenderer.Location = new System.Drawing.Point(4, 0);
            this.rdgVideoRenderer.Name = "rdgVideoRenderer";
            this.rdgVideoRenderer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRenderer.Size = new System.Drawing.Size(110, 179);
            this.rdgVideoRenderer.TabIndex = 51;
            this.rdgVideoRenderer.TabStop = false;
            this.rdgVideoRenderer.Text = "video renderer";
            // 
            // rdgVideoRendererEVR
            // 
            this.rdgVideoRendererEVR.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererEVR.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererEVR.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererEVR.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererEVR.Location = new System.Drawing.Point(8, 36);
            this.rdgVideoRendererEVR.Name = "rdgVideoRendererEVR";
            this.rdgVideoRendererEVR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererEVR.Size = new System.Drawing.Size(65, 17);
            this.rdgVideoRendererEVR.TabIndex = 45;
            this.rdgVideoRendererEVR.TabStop = true;
            this.rdgVideoRendererEVR.Tag = "1";
            this.rdgVideoRendererEVR.Text = "EVR";
            this.rdgVideoRendererEVR.UseVisualStyleBackColor = false;
            this.rdgVideoRendererEVR.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererNone
            // 
            this.rdgVideoRendererNone.Location = new System.Drawing.Point(8, 156);
            this.rdgVideoRendererNone.Name = "rdgVideoRendererNone";
            this.rdgVideoRendererNone.Size = new System.Drawing.Size(80, 17);
            this.rdgVideoRendererNone.TabIndex = 43;
            this.rdgVideoRendererNone.Tag = "7";
            this.rdgVideoRendererNone.Text = "none";
            this.rdgVideoRendererNone.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererOverlay
            // 
            this.rdgVideoRendererOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererOverlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererOverlay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererOverlay.Location = new System.Drawing.Point(8, 116);
            this.rdgVideoRendererOverlay.Name = "rdgVideoRendererOverlay";
            this.rdgVideoRendererOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererOverlay.Size = new System.Drawing.Size(64, 17);
            this.rdgVideoRendererOverlay.TabIndex = 42;
            this.rdgVideoRendererOverlay.TabStop = true;
            this.rdgVideoRendererOverlay.Tag = "5";
            this.rdgVideoRendererOverlay.Text = "overlay";
            this.rdgVideoRendererOverlay.UseVisualStyleBackColor = false;
            this.rdgVideoRendererOverlay.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererStandard
            // 
            this.rdgVideoRendererStandard.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererStandard.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererStandard.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererStandard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererStandard.Location = new System.Drawing.Point(8, 96);
            this.rdgVideoRendererStandard.Name = "rdgVideoRendererStandard";
            this.rdgVideoRendererStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererStandard.Size = new System.Drawing.Size(73, 17);
            this.rdgVideoRendererStandard.TabIndex = 41;
            this.rdgVideoRendererStandard.TabStop = true;
            this.rdgVideoRendererStandard.Tag = "4";
            this.rdgVideoRendererStandard.Text = "standard";
            this.rdgVideoRendererStandard.UseVisualStyleBackColor = false;
            this.rdgVideoRendererStandard.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererAutoSelect
            // 
            this.rdgVideoRendererAutoSelect.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererAutoSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererAutoSelect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererAutoSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererAutoSelect.Location = new System.Drawing.Point(8, 16);
            this.rdgVideoRendererAutoSelect.Name = "rdgVideoRendererAutoSelect";
            this.rdgVideoRendererAutoSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererAutoSelect.Size = new System.Drawing.Size(80, 17);
            this.rdgVideoRendererAutoSelect.TabIndex = 40;
            this.rdgVideoRendererAutoSelect.TabStop = true;
            this.rdgVideoRendererAutoSelect.Tag = "0";
            this.rdgVideoRendererAutoSelect.Text = "auto select";
            this.rdgVideoRendererAutoSelect.UseVisualStyleBackColor = false;
            this.rdgVideoRendererAutoSelect.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererVMR7
            // 
            this.rdgVideoRendererVMR7.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererVMR7.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererVMR7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererVMR7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererVMR7.Location = new System.Drawing.Point(8, 76);
            this.rdgVideoRendererVMR7.Name = "rdgVideoRendererVMR7";
            this.rdgVideoRendererVMR7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererVMR7.Size = new System.Drawing.Size(65, 17);
            this.rdgVideoRendererVMR7.TabIndex = 39;
            this.rdgVideoRendererVMR7.TabStop = true;
            this.rdgVideoRendererVMR7.Tag = "3";
            this.rdgVideoRendererVMR7.Text = "VMR7";
            this.rdgVideoRendererVMR7.UseVisualStyleBackColor = false;
            this.rdgVideoRendererVMR7.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererVMR9
            // 
            this.rdgVideoRendererVMR9.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRendererVMR9.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRendererVMR9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRendererVMR9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRendererVMR9.Location = new System.Drawing.Point(8, 56);
            this.rdgVideoRendererVMR9.Name = "rdgVideoRendererVMR9";
            this.rdgVideoRendererVMR9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRendererVMR9.Size = new System.Drawing.Size(65, 17);
            this.rdgVideoRendererVMR9.TabIndex = 38;
            this.rdgVideoRendererVMR9.TabStop = true;
            this.rdgVideoRendererVMR9.Tag = "2";
            this.rdgVideoRendererVMR9.Text = "VMR9";
            this.rdgVideoRendererVMR9.UseVisualStyleBackColor = false;
            this.rdgVideoRendererVMR9.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // rdgVideoRendererRecPriority
            // 
            this.rdgVideoRendererRecPriority.Location = new System.Drawing.Point(8, 136);
            this.rdgVideoRendererRecPriority.Name = "rdgVideoRendererRecPriority";
            this.rdgVideoRendererRecPriority.Size = new System.Drawing.Size(107, 17);
            this.rdgVideoRendererRecPriority.TabIndex = 44;
            this.rdgVideoRendererRecPriority.Tag = "6";
            this.rdgVideoRendererRecPriority.Text = "recording priority";
            this.rdgVideoRendererRecPriority.CheckedChanged += new System.EventHandler(this.rdgVideoRenderer_CheckedChanged);
            // 
            // chkTransparency
            // 
            this.chkTransparency.Location = new System.Drawing.Point(120, 87);
            this.chkTransparency.Name = "chkTransparency";
            this.chkTransparency.Size = new System.Drawing.Size(96, 17);
            this.chkTransparency.TabIndex = 50;
            this.chkTransparency.Text = "transparency";
            this.chkTransparency.CheckedChanged += new System.EventHandler(this.chkTransparency_CheckedChanged);
            // 
            // chk2ndVideoWindowActive
            // 
            this.chk2ndVideoWindowActive.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndVideoWindowActive.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndVideoWindowActive.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndVideoWindowActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndVideoWindowActive.Location = new System.Drawing.Point(660, 0);
            this.chk2ndVideoWindowActive.Name = "chk2ndVideoWindowActive";
            this.chk2ndVideoWindowActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndVideoWindowActive.Size = new System.Drawing.Size(185, 17);
            this.chk2ndVideoWindowActive.TabIndex = 48;
            this.chk2ndVideoWindowActive.Text = "2ND VIDEO WINDOW ACTIVE";
            this.chk2ndVideoWindowActive.UseVisualStyleBackColor = false;
            this.chk2ndVideoWindowActive.CheckedChanged += new System.EventHandler(this.chk2ndVideoWindowActive_CheckedChanged);
            // 
            // grb2ndVideoWindow
            // 
            this.grb2ndVideoWindow.BackColor = System.Drawing.SystemColors.Control;
            this.grb2ndVideoWindow.Controls.Add(this.rdg2ndDisplayedOn);
            this.grb2ndVideoWindow.Controls.Add(this.tbr2PanScan);
            this.grb2ndVideoWindow.Controls.Add(this.Label2);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndVisible);
            this.grb2ndVideoWindow.Controls.Add(this.rdg2AspectRatio);
            this.grb2ndVideoWindow.Controls.Add(this.btnEG2ndNewLocation2);
            this.grb2ndVideoWindow.Controls.Add(this.btnEG2ndNewLocation);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndAutoSize);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndStayOnTop);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndMouseMovesWindow);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndFullScreen);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndUseVideoPort);
            this.grb2ndVideoWindow.Controls.Add(this.chk2ndEmbedded);
            this.grb2ndVideoWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb2ndVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grb2ndVideoWindow.Location = new System.Drawing.Point(604, 16);
            this.grb2ndVideoWindow.Name = "grb2ndVideoWindow";
            this.grb2ndVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grb2ndVideoWindow.Size = new System.Drawing.Size(313, 163);
            this.grb2ndVideoWindow.TabIndex = 47;
            this.grb2ndVideoWindow.TabStop = false;
            this.grb2ndVideoWindow.Text = "main video window";
            // 
            // rdg2ndDisplayedOn
            // 
            this.rdg2ndDisplayedOn.BackColor = System.Drawing.SystemColors.Control;
            this.rdg2ndDisplayedOn.Controls.Add(this.rdg2ndDisplayedOn2);
            this.rdg2ndDisplayedOn.Controls.Add(this.rdg2ndDisplayedOn1);
            this.rdg2ndDisplayedOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg2ndDisplayedOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg2ndDisplayedOn.Location = new System.Drawing.Point(220, 9);
            this.rdg2ndDisplayedOn.Name = "rdg2ndDisplayedOn";
            this.rdg2ndDisplayedOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg2ndDisplayedOn.Size = new System.Drawing.Size(87, 52);
            this.rdg2ndDisplayedOn.TabIndex = 31;
            this.rdg2ndDisplayedOn.TabStop = false;
            this.rdg2ndDisplayedOn.Text = "display on...";
            // 
            // rdg2ndDisplayedOn2
            // 
            this.rdg2ndDisplayedOn2.BackColor = System.Drawing.SystemColors.Control;
            this.rdg2ndDisplayedOn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdg2ndDisplayedOn2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg2ndDisplayedOn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg2ndDisplayedOn2.Location = new System.Drawing.Point(6, 31);
            this.rdg2ndDisplayedOn2.Name = "rdg2ndDisplayedOn2";
            this.rdg2ndDisplayedOn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg2ndDisplayedOn2.Size = new System.Drawing.Size(79, 17);
            this.rdg2ndDisplayedOn2.TabIndex = 33;
            this.rdg2ndDisplayedOn2.TabStop = true;
            this.rdg2ndDisplayedOn2.Tag = "1";
            this.rdg2ndDisplayedOn2.Text = "2nd monitor";
            this.rdg2ndDisplayedOn2.UseVisualStyleBackColor = false;
            this.rdg2ndDisplayedOn2.CheckedChanged += new System.EventHandler(this.rdg2ndDisplayedOn_CheckedChanged);
            // 
            // rdg2ndDisplayedOn1
            // 
            this.rdg2ndDisplayedOn1.BackColor = System.Drawing.SystemColors.Control;
            this.rdg2ndDisplayedOn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdg2ndDisplayedOn1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg2ndDisplayedOn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg2ndDisplayedOn1.Location = new System.Drawing.Point(6, 16);
            this.rdg2ndDisplayedOn1.Name = "rdg2ndDisplayedOn1";
            this.rdg2ndDisplayedOn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg2ndDisplayedOn1.Size = new System.Drawing.Size(79, 17);
            this.rdg2ndDisplayedOn1.TabIndex = 32;
            this.rdg2ndDisplayedOn1.TabStop = true;
            this.rdg2ndDisplayedOn1.Tag = "0";
            this.rdg2ndDisplayedOn1.Text = "1st monitor";
            this.rdg2ndDisplayedOn1.UseVisualStyleBackColor = false;
            this.rdg2ndDisplayedOn1.CheckedChanged += new System.EventHandler(this.rdg2ndDisplayedOn_CheckedChanged);
            // 
            // tbr2PanScan
            // 
            this.tbr2PanScan.AutoSize = false;
            this.tbr2PanScan.Location = new System.Drawing.Point(165, 137);
            this.tbr2PanScan.Maximum = 100;
            this.tbr2PanScan.Name = "tbr2PanScan";
            this.tbr2PanScan.Size = new System.Drawing.Size(142, 20);
            this.tbr2PanScan.TabIndex = 39;
            this.tbr2PanScan.TickFrequency = 10;
            this.tbr2PanScan.Value = 50;
            this.tbr2PanScan.Scroll += new System.EventHandler(this.tbr2PanScan_Scroll);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(167, 125);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 14);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "pan-scan ratio: (0..100)";
            // 
            // chk2ndVisible
            // 
            this.chk2ndVisible.Location = new System.Drawing.Point(8, 14);
            this.chk2ndVisible.Name = "chk2ndVisible";
            this.chk2ndVisible.Size = new System.Drawing.Size(56, 17);
            this.chk2ndVisible.TabIndex = 37;
            this.chk2ndVisible.Text = "visible";
            this.chk2ndVisible.CheckedChanged += new System.EventHandler(this.chk2ndVisible_CheckedChanged);
            // 
            // rdg2AspectRatio
            // 
            this.rdg2AspectRatio.Controls.Add(this.rdg2DisplayAspectRatioPanScan);
            this.rdg2AspectRatio.Controls.Add(this.rdg2DisplayAspectRatioStretch);
            this.rdg2AspectRatio.Controls.Add(this.rdg2DisplayAspectRatioPan);
            this.rdg2AspectRatio.Controls.Add(this.rdg2DisplayAspectRatioBox);
            this.rdg2AspectRatio.Location = new System.Drawing.Point(8, 80);
            this.rdg2AspectRatio.Name = "rdg2AspectRatio";
            this.rdg2AspectRatio.Size = new System.Drawing.Size(153, 83);
            this.rdg2AspectRatio.TabIndex = 36;
            this.rdg2AspectRatio.TabStop = false;
            this.rdg2AspectRatio.Text = "aspect ratio";
            // 
            // rdg2DisplayAspectRatioPanScan
            // 
            this.rdg2DisplayAspectRatioPanScan.Location = new System.Drawing.Point(8, 62);
            this.rdg2DisplayAspectRatioPanScan.Name = "rdg2DisplayAspectRatioPanScan";
            this.rdg2DisplayAspectRatioPanScan.Size = new System.Drawing.Size(116, 16);
            this.rdg2DisplayAspectRatioPanScan.TabIndex = 4;
            this.rdg2DisplayAspectRatioPanScan.Tag = "3";
            this.rdg2DisplayAspectRatioPanScan.Text = "pan-scan";
            this.rdg2DisplayAspectRatioPanScan.CheckedChanged += new System.EventHandler(this.rdgDualDisplayAspectRatio_CheckedChanged);
            // 
            // rdg2DisplayAspectRatioStretch
            // 
            this.rdg2DisplayAspectRatioStretch.Location = new System.Drawing.Point(8, 46);
            this.rdg2DisplayAspectRatioStretch.Name = "rdg2DisplayAspectRatioStretch";
            this.rdg2DisplayAspectRatioStretch.Size = new System.Drawing.Size(116, 18);
            this.rdg2DisplayAspectRatioStretch.TabIndex = 2;
            this.rdg2DisplayAspectRatioStretch.Tag = "2";
            this.rdg2DisplayAspectRatioStretch.Text = "stretch";
            this.rdg2DisplayAspectRatioStretch.CheckedChanged += new System.EventHandler(this.rdgDualDisplayAspectRatio_CheckedChanged);
            // 
            // rdg2DisplayAspectRatioPan
            // 
            this.rdg2DisplayAspectRatioPan.Location = new System.Drawing.Point(8, 30);
            this.rdg2DisplayAspectRatioPan.Name = "rdg2DisplayAspectRatioPan";
            this.rdg2DisplayAspectRatioPan.Size = new System.Drawing.Size(116, 16);
            this.rdg2DisplayAspectRatioPan.TabIndex = 1;
            this.rdg2DisplayAspectRatioPan.Tag = "1";
            this.rdg2DisplayAspectRatioPan.Text = "no resize";
            this.rdg2DisplayAspectRatioPan.CheckedChanged += new System.EventHandler(this.rdgDualDisplayAspectRatio_CheckedChanged);
            // 
            // rdg2DisplayAspectRatioBox
            // 
            this.rdg2DisplayAspectRatioBox.Location = new System.Drawing.Point(8, 14);
            this.rdg2DisplayAspectRatioBox.Name = "rdg2DisplayAspectRatioBox";
            this.rdg2DisplayAspectRatioBox.Size = new System.Drawing.Size(143, 16);
            this.rdg2DisplayAspectRatioBox.TabIndex = 0;
            this.rdg2DisplayAspectRatioBox.Tag = "0";
            this.rdg2DisplayAspectRatioBox.Text = "box (letterbox, pillarbox)";
            this.rdg2DisplayAspectRatioBox.CheckedChanged += new System.EventHandler(this.rdgDualDisplayAspectRatio_CheckedChanged);
            // 
            // btnEG2ndNewLocation2
            // 
            this.btnEG2ndNewLocation2.BackColor = System.Drawing.SystemColors.Control;
            this.btnEG2ndNewLocation2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEG2ndNewLocation2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEG2ndNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEG2ndNewLocation2.Location = new System.Drawing.Point(165, 91);
            this.btnEG2ndNewLocation2.Name = "btnEG2ndNewLocation2";
            this.btnEG2ndNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEG2ndNewLocation2.Size = new System.Drawing.Size(140, 21);
            this.btnEG2ndNewLocation2.TabIndex = 35;
            this.btnEG2ndNewLocation2.Text = "e.g. 520,20 (480,200)";
            this.btnEG2ndNewLocation2.UseVisualStyleBackColor = false;
            this.btnEG2ndNewLocation2.Click += new System.EventHandler(this.btnEG2ndNewLocation2_Click);
            // 
            // btnEG2ndNewLocation
            // 
            this.btnEG2ndNewLocation.BackColor = System.Drawing.SystemColors.Control;
            this.btnEG2ndNewLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEG2ndNewLocation.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEG2ndNewLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEG2ndNewLocation.Location = new System.Drawing.Point(165, 67);
            this.btnEG2ndNewLocation.Name = "btnEG2ndNewLocation";
            this.btnEG2ndNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEG2ndNewLocation.Size = new System.Drawing.Size(140, 21);
            this.btnEG2ndNewLocation.TabIndex = 34;
            this.btnEG2ndNewLocation.Text = "e.g. 510,10 (autosize)";
            this.btnEG2ndNewLocation.UseVisualStyleBackColor = false;
            this.btnEG2ndNewLocation.Click += new System.EventHandler(this.btnEG2ndNewLocation_Click);
            // 
            // chk2ndAutoSize
            // 
            this.chk2ndAutoSize.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndAutoSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndAutoSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndAutoSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndAutoSize.Location = new System.Drawing.Point(8, 46);
            this.chk2ndAutoSize.Name = "chk2ndAutoSize";
            this.chk2ndAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndAutoSize.Size = new System.Drawing.Size(74, 17);
            this.chk2ndAutoSize.TabIndex = 30;
            this.chk2ndAutoSize.Text = "autosize";
            this.chk2ndAutoSize.UseVisualStyleBackColor = false;
            this.chk2ndAutoSize.CheckedChanged += new System.EventHandler(this.chk2ndAutoSize_CheckedChanged);
            // 
            // chk2ndStayOnTop
            // 
            this.chk2ndStayOnTop.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndStayOnTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndStayOnTop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndStayOnTop.Location = new System.Drawing.Point(8, 62);
            this.chk2ndStayOnTop.Name = "chk2ndStayOnTop";
            this.chk2ndStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndStayOnTop.Size = new System.Drawing.Size(88, 17);
            this.chk2ndStayOnTop.TabIndex = 29;
            this.chk2ndStayOnTop.Text = "stay on top";
            this.chk2ndStayOnTop.UseVisualStyleBackColor = false;
            this.chk2ndStayOnTop.CheckedChanged += new System.EventHandler(this.chk2ndStayOnTop_CheckedChanged);
            // 
            // chk2ndMouseMovesWindow
            // 
            this.chk2ndMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndMouseMovesWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndMouseMovesWindow.Location = new System.Drawing.Point(85, 46);
            this.chk2ndMouseMovesWindow.Name = "chk2ndMouseMovesWindow";
            this.chk2ndMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndMouseMovesWindow.Size = new System.Drawing.Size(137, 17);
            this.chk2ndMouseMovesWindow.TabIndex = 28;
            this.chk2ndMouseMovesWindow.Text = "mouse moves window";
            this.chk2ndMouseMovesWindow.UseVisualStyleBackColor = false;
            this.chk2ndMouseMovesWindow.CheckedChanged += new System.EventHandler(this.chk2ndMouseMovesWindow_CheckedChanged);
            // 
            // chk2ndFullScreen
            // 
            this.chk2ndFullScreen.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndFullScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndFullScreen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndFullScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndFullScreen.Location = new System.Drawing.Point(85, 14);
            this.chk2ndFullScreen.Name = "chk2ndFullScreen";
            this.chk2ndFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndFullScreen.Size = new System.Drawing.Size(89, 17);
            this.chk2ndFullScreen.TabIndex = 27;
            this.chk2ndFullScreen.Text = "full screen";
            this.chk2ndFullScreen.UseVisualStyleBackColor = false;
            this.chk2ndFullScreen.CheckedChanged += new System.EventHandler(this.chk2ndFullScreen_CheckedChanged);
            // 
            // chk2ndUseVideoPort
            // 
            this.chk2ndUseVideoPort.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndUseVideoPort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndUseVideoPort.Location = new System.Drawing.Point(85, 30);
            this.chk2ndUseVideoPort.Name = "chk2ndUseVideoPort";
            this.chk2ndUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndUseVideoPort.Size = new System.Drawing.Size(120, 17);
            this.chk2ndUseVideoPort.TabIndex = 25;
            this.chk2ndUseVideoPort.Text = "use video port";
            this.chk2ndUseVideoPort.UseVisualStyleBackColor = false;
            this.chk2ndUseVideoPort.CheckedChanged += new System.EventHandler(this.chk2ndUseVideoPort_CheckedChanged);
            // 
            // chk2ndEmbedded
            // 
            this.chk2ndEmbedded.BackColor = System.Drawing.SystemColors.Control;
            this.chk2ndEmbedded.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk2ndEmbedded.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk2ndEmbedded.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk2ndEmbedded.Location = new System.Drawing.Point(8, 30);
            this.chk2ndEmbedded.Name = "chk2ndEmbedded";
            this.chk2ndEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk2ndEmbedded.Size = new System.Drawing.Size(89, 17);
            this.chk2ndEmbedded.TabIndex = 24;
            this.chk2ndEmbedded.Text = "embedded";
            this.chk2ndEmbedded.UseVisualStyleBackColor = false;
            this.chk2ndEmbedded.CheckedChanged += new System.EventHandler(this.chk2ndEmbedded_CheckedChanged);
            // 
            // grbMainVideoWindow
            // 
            this.grbMainVideoWindow.BackColor = System.Drawing.SystemColors.Control;
            this.grbMainVideoWindow.Controls.Add(this.btnTestPanScan);
            this.grbMainVideoWindow.Controls.Add(this.btnTestPanScanHelp);
            this.grbMainVideoWindow.Controls.Add(this.Label1);
            this.grbMainVideoWindow.Controls.Add(this.rdg1stDisplayedOn);
            this.grbMainVideoWindow.Controls.Add(this.chk1stFullScreen);
            this.grbMainVideoWindow.Controls.Add(this.chk1stUseVideoPort);
            this.grbMainVideoWindow.Controls.Add(this.tbr1PanScan);
            this.grbMainVideoWindow.Controls.Add(this.chk1stVisible);
            this.grbMainVideoWindow.Controls.Add(this.rdg1AspectRatio);
            this.grbMainVideoWindow.Controls.Add(this.chk1stEmbedded);
            this.grbMainVideoWindow.Controls.Add(this.chk1stMouseMovesWindow);
            this.grbMainVideoWindow.Controls.Add(this.chk1stStayOnTop);
            this.grbMainVideoWindow.Controls.Add(this.chk1stAutoSize);
            this.grbMainVideoWindow.Controls.Add(this.btnEG1stNewLocation);
            this.grbMainVideoWindow.Controls.Add(this.btnEG1stNewLocation2);
            this.grbMainVideoWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMainVideoWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbMainVideoWindow.Location = new System.Drawing.Point(288, 16);
            this.grbMainVideoWindow.Name = "grbMainVideoWindow";
            this.grbMainVideoWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbMainVideoWindow.Size = new System.Drawing.Size(313, 163);
            this.grbMainVideoWindow.TabIndex = 46;
            this.grbMainVideoWindow.TabStop = false;
            this.grbMainVideoWindow.Text = "main video window";
            // 
            // btnTestPanScan
            // 
            this.btnTestPanScan.Location = new System.Drawing.Point(249, 118);
            this.btnTestPanScan.Name = "btnTestPanScan";
            this.btnTestPanScan.Size = new System.Drawing.Size(37, 21);
            this.btnTestPanScan.TabIndex = 27;
            this.btnTestPanScan.Text = "test";
            this.btnTestPanScan.Click += new System.EventHandler(this.btnTestPanScan_Click);
            // 
            // btnTestPanScanHelp
            // 
            this.btnTestPanScanHelp.Location = new System.Drawing.Point(286, 118);
            this.btnTestPanScanHelp.Name = "btnTestPanScanHelp";
            this.btnTestPanScanHelp.Size = new System.Drawing.Size(18, 21);
            this.btnTestPanScanHelp.TabIndex = 28;
            this.btnTestPanScanHelp.Text = "?";
            this.btnTestPanScanHelp.Click += new System.EventHandler(this.btnTestPanScanHelp_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(167, 114);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 28);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "pan-scan ratio:\r\n (0 - 100)";
            // 
            // rdg1stDisplayedOn
            // 
            this.rdg1stDisplayedOn.BackColor = System.Drawing.SystemColors.Control;
            this.rdg1stDisplayedOn.Controls.Add(this.rdg1stDisplayedOn2);
            this.rdg1stDisplayedOn.Controls.Add(this.rdg1stDisplayedOn1);
            this.rdg1stDisplayedOn.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg1stDisplayedOn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg1stDisplayedOn.Location = new System.Drawing.Point(220, 9);
            this.rdg1stDisplayedOn.Name = "rdg1stDisplayedOn";
            this.rdg1stDisplayedOn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg1stDisplayedOn.Size = new System.Drawing.Size(87, 52);
            this.rdg1stDisplayedOn.TabIndex = 13;
            this.rdg1stDisplayedOn.TabStop = false;
            this.rdg1stDisplayedOn.Text = "display on...";
            // 
            // rdg1stDisplayedOn2
            // 
            this.rdg1stDisplayedOn2.BackColor = System.Drawing.SystemColors.Control;
            this.rdg1stDisplayedOn2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdg1stDisplayedOn2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg1stDisplayedOn2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg1stDisplayedOn2.Location = new System.Drawing.Point(6, 31);
            this.rdg1stDisplayedOn2.Name = "rdg1stDisplayedOn2";
            this.rdg1stDisplayedOn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg1stDisplayedOn2.Size = new System.Drawing.Size(79, 17);
            this.rdg1stDisplayedOn2.TabIndex = 14;
            this.rdg1stDisplayedOn2.TabStop = true;
            this.rdg1stDisplayedOn2.Tag = "1";
            this.rdg1stDisplayedOn2.Text = "2nd monitor";
            this.rdg1stDisplayedOn2.UseVisualStyleBackColor = false;
            this.rdg1stDisplayedOn2.CheckedChanged += new System.EventHandler(this.rdg1stDisplayedOn_CheckedChanged);
            // 
            // rdg1stDisplayedOn1
            // 
            this.rdg1stDisplayedOn1.BackColor = System.Drawing.SystemColors.Control;
            this.rdg1stDisplayedOn1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdg1stDisplayedOn1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdg1stDisplayedOn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdg1stDisplayedOn1.Location = new System.Drawing.Point(6, 16);
            this.rdg1stDisplayedOn1.Name = "rdg1stDisplayedOn1";
            this.rdg1stDisplayedOn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdg1stDisplayedOn1.Size = new System.Drawing.Size(79, 17);
            this.rdg1stDisplayedOn1.TabIndex = 15;
            this.rdg1stDisplayedOn1.TabStop = true;
            this.rdg1stDisplayedOn1.Tag = "0";
            this.rdg1stDisplayedOn1.Text = "1st monitor";
            this.rdg1stDisplayedOn1.UseVisualStyleBackColor = false;
            this.rdg1stDisplayedOn1.CheckedChanged += new System.EventHandler(this.rdg1stDisplayedOn_CheckedChanged);
            // 
            // chk1stFullScreen
            // 
            this.chk1stFullScreen.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stFullScreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stFullScreen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stFullScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stFullScreen.Location = new System.Drawing.Point(85, 14);
            this.chk1stFullScreen.Name = "chk1stFullScreen";
            this.chk1stFullScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stFullScreen.Size = new System.Drawing.Size(89, 17);
            this.chk1stFullScreen.TabIndex = 19;
            this.chk1stFullScreen.Text = "full screen";
            this.chk1stFullScreen.UseVisualStyleBackColor = false;
            this.chk1stFullScreen.CheckedChanged += new System.EventHandler(this.chk1stFullScreen_CheckedChanged);
            // 
            // chk1stUseVideoPort
            // 
            this.chk1stUseVideoPort.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stUseVideoPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stUseVideoPort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stUseVideoPort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stUseVideoPort.Location = new System.Drawing.Point(85, 30);
            this.chk1stUseVideoPort.Name = "chk1stUseVideoPort";
            this.chk1stUseVideoPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stUseVideoPort.Size = new System.Drawing.Size(120, 17);
            this.chk1stUseVideoPort.TabIndex = 21;
            this.chk1stUseVideoPort.Text = "use video port";
            this.chk1stUseVideoPort.UseVisualStyleBackColor = false;
            this.chk1stUseVideoPort.CheckedChanged += new System.EventHandler(this.chk1stUseVideoPort_CheckedChanged);
            // 
            // tbr1PanScan
            // 
            this.tbr1PanScan.AutoSize = false;
            this.tbr1PanScan.Location = new System.Drawing.Point(165, 137);
            this.tbr1PanScan.Maximum = 100;
            this.tbr1PanScan.Name = "tbr1PanScan";
            this.tbr1PanScan.Size = new System.Drawing.Size(142, 20);
            this.tbr1PanScan.TabIndex = 26;
            this.tbr1PanScan.TickFrequency = 10;
            this.tbr1PanScan.Value = 50;
            this.tbr1PanScan.Scroll += new System.EventHandler(this.tbr1PanScan_Scroll);
            // 
            // chk1stVisible
            // 
            this.chk1stVisible.Location = new System.Drawing.Point(8, 14);
            this.chk1stVisible.Name = "chk1stVisible";
            this.chk1stVisible.Size = new System.Drawing.Size(80, 17);
            this.chk1stVisible.TabIndex = 24;
            this.chk1stVisible.Text = "visible";
            this.chk1stVisible.CheckedChanged += new System.EventHandler(this.chk1stVisible_CheckedChanged);
            // 
            // rdg1AspectRatio
            // 
            this.rdg1AspectRatio.Controls.Add(this.rdg1DisplayAspectRatioPanScan);
            this.rdg1AspectRatio.Controls.Add(this.rdg1DisplayAspectRatioStretch);
            this.rdg1AspectRatio.Controls.Add(this.rdg1DisplayAspectRatioPan);
            this.rdg1AspectRatio.Controls.Add(this.rdg1DisplayAspectRatioBox);
            this.rdg1AspectRatio.Location = new System.Drawing.Point(8, 80);
            this.rdg1AspectRatio.Name = "rdg1AspectRatio";
            this.rdg1AspectRatio.Size = new System.Drawing.Size(153, 83);
            this.rdg1AspectRatio.TabIndex = 23;
            this.rdg1AspectRatio.TabStop = false;
            this.rdg1AspectRatio.Text = "aspect ratio";
            // 
            // rdg1DisplayAspectRatioPanScan
            // 
            this.rdg1DisplayAspectRatioPanScan.Location = new System.Drawing.Point(8, 62);
            this.rdg1DisplayAspectRatioPanScan.Name = "rdg1DisplayAspectRatioPanScan";
            this.rdg1DisplayAspectRatioPanScan.Size = new System.Drawing.Size(115, 16);
            this.rdg1DisplayAspectRatioPanScan.TabIndex = 3;
            this.rdg1DisplayAspectRatioPanScan.Tag = "3";
            this.rdg1DisplayAspectRatioPanScan.Text = "pan-scan";
            this.rdg1DisplayAspectRatioPanScan.CheckedChanged += new System.EventHandler(this.rdg1DisplayAspectRatio_CheckedChanged);
            // 
            // rdg1DisplayAspectRatioStretch
            // 
            this.rdg1DisplayAspectRatioStretch.Location = new System.Drawing.Point(8, 46);
            this.rdg1DisplayAspectRatioStretch.Name = "rdg1DisplayAspectRatioStretch";
            this.rdg1DisplayAspectRatioStretch.Size = new System.Drawing.Size(115, 16);
            this.rdg1DisplayAspectRatioStretch.TabIndex = 2;
            this.rdg1DisplayAspectRatioStretch.Tag = "2";
            this.rdg1DisplayAspectRatioStretch.Text = "stretch";
            this.rdg1DisplayAspectRatioStretch.CheckedChanged += new System.EventHandler(this.rdg1DisplayAspectRatio_CheckedChanged);
            // 
            // rdg1DisplayAspectRatioPan
            // 
            this.rdg1DisplayAspectRatioPan.Location = new System.Drawing.Point(8, 30);
            this.rdg1DisplayAspectRatioPan.Name = "rdg1DisplayAspectRatioPan";
            this.rdg1DisplayAspectRatioPan.Size = new System.Drawing.Size(115, 17);
            this.rdg1DisplayAspectRatioPan.TabIndex = 1;
            this.rdg1DisplayAspectRatioPan.Tag = "1";
            this.rdg1DisplayAspectRatioPan.Text = "no resize";
            this.rdg1DisplayAspectRatioPan.CheckedChanged += new System.EventHandler(this.rdg1DisplayAspectRatio_CheckedChanged);
            // 
            // rdg1DisplayAspectRatioBox
            // 
            this.rdg1DisplayAspectRatioBox.Location = new System.Drawing.Point(8, 14);
            this.rdg1DisplayAspectRatioBox.Name = "rdg1DisplayAspectRatioBox";
            this.rdg1DisplayAspectRatioBox.Size = new System.Drawing.Size(143, 16);
            this.rdg1DisplayAspectRatioBox.TabIndex = 0;
            this.rdg1DisplayAspectRatioBox.Tag = "0";
            this.rdg1DisplayAspectRatioBox.Text = "box (letterbox, pillarbox)";
            this.rdg1DisplayAspectRatioBox.CheckedChanged += new System.EventHandler(this.rdg1DisplayAspectRatio_CheckedChanged);
            // 
            // chk1stEmbedded
            // 
            this.chk1stEmbedded.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stEmbedded.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stEmbedded.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stEmbedded.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stEmbedded.Location = new System.Drawing.Point(8, 30);
            this.chk1stEmbedded.Name = "chk1stEmbedded";
            this.chk1stEmbedded.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stEmbedded.Size = new System.Drawing.Size(80, 17);
            this.chk1stEmbedded.TabIndex = 22;
            this.chk1stEmbedded.Text = "embedded";
            this.chk1stEmbedded.UseVisualStyleBackColor = false;
            this.chk1stEmbedded.CheckedChanged += new System.EventHandler(this.chk1stEmbedded_CheckedChanged);
            // 
            // chk1stMouseMovesWindow
            // 
            this.chk1stMouseMovesWindow.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stMouseMovesWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stMouseMovesWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stMouseMovesWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stMouseMovesWindow.Location = new System.Drawing.Point(85, 46);
            this.chk1stMouseMovesWindow.Name = "chk1stMouseMovesWindow";
            this.chk1stMouseMovesWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stMouseMovesWindow.Size = new System.Drawing.Size(136, 17);
            this.chk1stMouseMovesWindow.TabIndex = 18;
            this.chk1stMouseMovesWindow.Text = "mouse moves window";
            this.chk1stMouseMovesWindow.UseVisualStyleBackColor = false;
            this.chk1stMouseMovesWindow.CheckedChanged += new System.EventHandler(this.chk1stMouseMovesWindow_CheckedChanged);
            // 
            // chk1stStayOnTop
            // 
            this.chk1stStayOnTop.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stStayOnTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stStayOnTop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stStayOnTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stStayOnTop.Location = new System.Drawing.Point(8, 62);
            this.chk1stStayOnTop.Name = "chk1stStayOnTop";
            this.chk1stStayOnTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stStayOnTop.Size = new System.Drawing.Size(88, 17);
            this.chk1stStayOnTop.TabIndex = 17;
            this.chk1stStayOnTop.Text = "stay on top";
            this.chk1stStayOnTop.UseVisualStyleBackColor = false;
            this.chk1stStayOnTop.CheckedChanged += new System.EventHandler(this.chk1stStayOnTop_CheckedChanged);
            // 
            // chk1stAutoSize
            // 
            this.chk1stAutoSize.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stAutoSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stAutoSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stAutoSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stAutoSize.Location = new System.Drawing.Point(8, 46);
            this.chk1stAutoSize.Name = "chk1stAutoSize";
            this.chk1stAutoSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stAutoSize.Size = new System.Drawing.Size(80, 17);
            this.chk1stAutoSize.TabIndex = 16;
            this.chk1stAutoSize.Text = "autosize";
            this.chk1stAutoSize.UseVisualStyleBackColor = false;
            this.chk1stAutoSize.CheckedChanged += new System.EventHandler(this.chk1stAutoSize_CheckedChanged);
            // 
            // btnEG1stNewLocation
            // 
            this.btnEG1stNewLocation.BackColor = System.Drawing.SystemColors.Control;
            this.btnEG1stNewLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEG1stNewLocation.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEG1stNewLocation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEG1stNewLocation.Location = new System.Drawing.Point(165, 67);
            this.btnEG1stNewLocation.Name = "btnEG1stNewLocation";
            this.btnEG1stNewLocation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEG1stNewLocation.Size = new System.Drawing.Size(140, 21);
            this.btnEG1stNewLocation.TabIndex = 12;
            this.btnEG1stNewLocation.Text = "e.g. 10,10 (autosize)";
            this.btnEG1stNewLocation.UseVisualStyleBackColor = false;
            this.btnEG1stNewLocation.Click += new System.EventHandler(this.btnEG1stNewLocation_Click);
            // 
            // btnEG1stNewLocation2
            // 
            this.btnEG1stNewLocation2.BackColor = System.Drawing.SystemColors.Control;
            this.btnEG1stNewLocation2.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEG1stNewLocation2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEG1stNewLocation2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEG1stNewLocation2.Location = new System.Drawing.Point(165, 91);
            this.btnEG1stNewLocation2.Name = "btnEG1stNewLocation2";
            this.btnEG1stNewLocation2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEG1stNewLocation2.Size = new System.Drawing.Size(140, 21);
            this.btnEG1stNewLocation2.TabIndex = 11;
            this.btnEG1stNewLocation2.Text = "e.g. 20,20 (480,200)";
            this.btnEG1stNewLocation2.UseVisualStyleBackColor = false;
            this.btnEG1stNewLocation2.Click += new System.EventHandler(this.btnEG1stNewLocation2_Click);
            // 
            // chk1stVideoWindowActive
            // 
            this.chk1stVideoWindowActive.BackColor = System.Drawing.SystemColors.Control;
            this.chk1stVideoWindowActive.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk1stVideoWindowActive.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1stVideoWindowActive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk1stVideoWindowActive.Location = new System.Drawing.Point(348, 0);
            this.chk1stVideoWindowActive.Name = "chk1stVideoWindowActive";
            this.chk1stVideoWindowActive.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk1stVideoWindowActive.Size = new System.Drawing.Size(185, 17);
            this.chk1stVideoWindowActive.TabIndex = 45;
            this.chk1stVideoWindowActive.Text = "MAIN VIDEO WINDOW ACTIVE";
            this.chk1stVideoWindowActive.UseVisualStyleBackColor = false;
            this.chk1stVideoWindowActive.CheckedChanged += new System.EventHandler(this.chk1stVideoWindowActive_CheckedChanged);
            // 
            // chkSetLogo
            // 
            this.chkSetLogo.BackColor = System.Drawing.SystemColors.Control;
            this.chkSetLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkSetLogo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSetLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkSetLogo.Location = new System.Drawing.Point(120, 109);
            this.chkSetLogo.Name = "chkSetLogo";
            this.chkSetLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkSetLogo.Size = new System.Drawing.Size(135, 17);
            this.chkSetLogo.TabIndex = 44;
            this.chkSetLogo.Text = "show logo, e.g.:";
            this.chkSetLogo.UseVisualStyleBackColor = false;
            this.chkSetLogo.CheckedChanged += new System.EventHandler(this.chkSetLogo_CheckedChanged);
            // 
            // chkBorder
            // 
            this.chkBorder.BackColor = System.Drawing.SystemColors.Control;
            this.chkBorder.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkBorder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBorder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkBorder.Location = new System.Drawing.Point(120, 71);
            this.chkBorder.Name = "chkBorder";
            this.chkBorder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkBorder.Size = new System.Drawing.Size(96, 17);
            this.chkBorder.TabIndex = 43;
            this.chkBorder.Text = "border";
            this.chkBorder.UseVisualStyleBackColor = false;
            this.chkBorder.CheckedChanged += new System.EventHandler(this.chkBorder_CheckedChanged);
            // 
            // chkChangeCursor
            // 
            this.chkChangeCursor.BackColor = System.Drawing.SystemColors.Control;
            this.chkChangeCursor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkChangeCursor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChangeCursor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkChangeCursor.Location = new System.Drawing.Point(120, 55);
            this.chkChangeCursor.Name = "chkChangeCursor";
            this.chkChangeCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkChangeCursor.Size = new System.Drawing.Size(160, 17);
            this.chkChangeCursor.TabIndex = 42;
            this.chkChangeCursor.Text = "change cursor (e.g.: cross)";
            this.chkChangeCursor.UseVisualStyleBackColor = false;
            this.chkChangeCursor.CheckedChanged += new System.EventHandler(this.chkChangeCursor_CheckedChanged);
            // 
            // imgLogo
            // 
            this.imgLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(120, 126);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(76, 53);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLogo.TabIndex = 49;
            this.imgLogo.TabStop = false;
            // 
            // chkBlackMagicOutput
            // 
            this.chkBlackMagicOutput.AutoSize = true;
            this.chkBlackMagicOutput.Location = new System.Drawing.Point(120, 7);
            this.chkBlackMagicOutput.Name = "chkBlackMagicOutput";
            this.chkBlackMagicOutput.Size = new System.Drawing.Size(160, 17);
            this.chkBlackMagicOutput.TabIndex = 54;
            this.chkBlackMagicOutput.Text = "BlackMagic Decklink output";
            this.chkBlackMagicOutput.CheckedChanged += new System.EventHandler(this.chkBlackMagicOutput_CheckedChanged);
            // 
            // Display
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(938, 217);
            this.ControlBox = false;
            this.Controls.Add(this.chkBlackMagicOutput);
            this.Controls.Add(this.chkAdjustPixelAspectRatio);
            this.Controls.Add(this.chkVideoVisibleWhenStopped);
            this.Controls.Add(this.rdgVideoRenderer);
            this.Controls.Add(this.chkTransparency);
            this.Controls.Add(this.chk2ndVideoWindowActive);
            this.Controls.Add(this.grb2ndVideoWindow);
            this.Controls.Add(this.grbMainVideoWindow);
            this.Controls.Add(this.chk1stVideoWindowActive);
            this.Controls.Add(this.chkSetLogo);
            this.Controls.Add(this.chkBorder);
            this.Controls.Add(this.chkChangeCursor);
            this.Controls.Add(this.imgLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Display";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Display_Load);
            this.VisibleChanged += new System.EventHandler(this.Display_VisibleChanged);
            this.rdgVideoRenderer.ResumeLayout(false);
            this.grb2ndVideoWindow.ResumeLayout(false);
            this.grb2ndVideoWindow.PerformLayout();
            this.rdg2ndDisplayedOn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbr2PanScan)).EndInit();
            this.rdg2AspectRatio.ResumeLayout(false);
            this.grbMainVideoWindow.ResumeLayout(false);
            this.grbMainVideoWindow.PerformLayout();
            this.rdg1stDisplayedOn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbr1PanScan)).EndInit();
            this.rdg1AspectRatio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		public void RefreshControls()
		{
			// this procedure is called each time a setting of this form is changed,
			// to show what features can be used, according to their respective states

			// NOTE: duplicating 2 times all the components of this form for the 2 windows
			// is not very efficient, this has been done only for a better readability.
			SetRadioButtonInGroupUsingTag(rdgVideoRenderer, (short) cMainForm.axVideoGrabberNET1.VideoRenderer);
			chkBorder.Checked = cMainForm.axVideoGrabberNET1.BorderStyle == Vidgrab_NET.TxBorderStyle.bsSingle;
            chkAdjustPixelAspectRatio.Checked = cMainForm.axVideoGrabberNET1.AdjustPixelAspectRatio;

			chk1stVisible.Checked = cMainForm.axVideoGrabberNET1.Display_Visible;
			chk1stVideoWindowActive.Checked = cMainForm.axVideoGrabberNET1.Display_Active;
			chk1stEmbedded.Checked = cMainForm.axVideoGrabberNET1.Display_Embedded;
			chk1stFullScreen.Checked = cMainForm.axVideoGrabberNET1.Display_FullScreen;
			chk1stStayOnTop.Checked = cMainForm.axVideoGrabberNET1.Display_StayOnTop;
			chk1stUseVideoPort.Checked = cMainForm.axVideoGrabberNET1.Display_VideoPortEnabled;
			chk1stMouseMovesWindow.Checked = cMainForm.axVideoGrabberNET1.Display_MouseMovesWindow;
			chk1stAutoSize.Checked = cMainForm.axVideoGrabberNET1.Display_AutoSize;
			SetRadioButtonInGroupUsingTag(rdg1stDisplayedOn, (short) cMainForm.axVideoGrabberNET1.Display_Monitor);
			SetRadioButtonInGroupUsingTag(rdg1AspectRatio, (short) cMainForm.axVideoGrabberNET1.Display_AspectRatio);
			tbr1PanScan.Value = cMainForm.axVideoGrabberNET1.Display_PanScanRatio;

			grbMainVideoWindow.Enabled = cMainForm.axVideoGrabberNET1.Display_Active;

			if (cMainForm.axVideoGrabberNET1.Display_Active) {
				chk1stStayOnTop.Enabled = (! cMainForm.axVideoGrabberNET1.Display_Embedded) || cMainForm.axVideoGrabberNET1.Display_FullScreen;
				chk1stMouseMovesWindow.Enabled = ! cMainForm.axVideoGrabberNET1.Display_Embedded;
				rdg1stDisplayedOn.Enabled = ! cMainForm.axVideoGrabberNET1.Display_Embedded;
				btnEG1stNewLocation.Enabled = ! cMainForm.axVideoGrabberNET1.Display_Embedded;
				btnEG1stNewLocation2.Enabled = ! cMainForm.axVideoGrabberNET1.Display_Embedded;
				chk1stUseVideoPort.Enabled = cMainForm.axVideoGrabberNET1.IsVideoPortAvailable;
			}

			chk2ndVisible.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_Visible;
			chk2ndVideoWindowActive.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_Active;
			chk2ndEmbedded.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_Embedded;
			chk2ndFullScreen.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_FullScreen;
			chk2ndStayOnTop.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_StayOnTop;
			chk2ndUseVideoPort.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_VideoPortEnabled;
			chk2ndMouseMovesWindow.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_MouseMovesWindow;
			chk2ndAutoSize.Checked = cMainForm.axVideoGrabberNET1.DualDisplay_AutoSize;
			SetRadioButtonInGroupUsingTag(rdg2ndDisplayedOn, (short) cMainForm.axVideoGrabberNET1.DualDisplay_Monitor);
			SetRadioButtonInGroupUsingTag(rdg2AspectRatio, (short) cMainForm.axVideoGrabberNET1.DualDisplay_AspectRatio);
			tbr2PanScan.Value = cMainForm.axVideoGrabberNET1.DualDisplay_PanScanRatio;

			grb2ndVideoWindow.Enabled = cMainForm.axVideoGrabberNET1.DualDisplay_Active;

			if (cMainForm.axVideoGrabberNET1.DualDisplay_Active) {
				chk2ndStayOnTop.Enabled = (! cMainForm.axVideoGrabberNET1.DualDisplay_Embedded) || cMainForm.axVideoGrabberNET1.DualDisplay_FullScreen;
				chk2ndMouseMovesWindow.Enabled = ! cMainForm.axVideoGrabberNET1.DualDisplay_Embedded;
				rdg2ndDisplayedOn.Enabled = ! cMainForm.axVideoGrabberNET1.DualDisplay_Embedded;
				btnEG2ndNewLocation.Enabled = ! cMainForm.axVideoGrabberNET1.DualDisplay_Embedded;
				btnEG2ndNewLocation.Enabled = ! cMainForm.axVideoGrabberNET1.DualDisplay_Embedded;
				chk2ndUseVideoPort.Enabled = cMainForm.axVideoGrabberNET1.IsVideoPortAvailable;
			}
		}

		private void btnEG1stNewLocation_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_AutoSize = true; // the component"s video size will be used
			cMainForm.axVideoGrabberNET1.Display_Embedded = false; // detach from component
			cMainForm.axVideoGrabberNET1.Display_SetLocation(10, 10, 320, 240); // 320 and 240 are not used because of AutoSize above
			RefreshControls();
		}

		private void btnEG1stNewLocation2_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_AutoSize = false; // we will specify the size below
			cMainForm.axVideoGrabberNET1.Display_Embedded = false; // detach from component
			cMainForm.axVideoGrabberNET1.Display_SetLocation(20, 20, 480, 200); // new size: 480 x 360
			RefreshControls();
		}

		private void btnEG2ndNewLocation_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_AutoSize = true; // the component's video size will be used
			cMainForm.axVideoGrabberNET1.DualDisplay_Embedded = false; // detach from component
			cMainForm.axVideoGrabberNET1.DualDisplay_SetLocation(510, 10, 320, 240); // 320 and 240 are ! used because of AutoSize above
			RefreshControls();
		}

		private void btnEG2ndNewLocation2_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_AutoSize = false; // we will specify the size below
			cMainForm.axVideoGrabberNET1.DualDisplay_Embedded = false; // detach from component
			cMainForm.axVideoGrabberNET1.DualDisplay_SetLocation(520, 30, 480, 200); // new size: 480 x 360
			RefreshControls();
		}

		private void chk1stAutoSize_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_AutoSize = chk1stAutoSize.Checked;
			RefreshControls();

            
            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainForm_Load values if Display_AutoSize has been disabled:
            if (!cMainForm.axVideoGrabberNET1.Display_AutoSize)
            {
                if (cMainForm.axVideoGrabberNET1.Display_Embedded)
                {
                    cMainForm.axVideoGrabberNET1.Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.Height = cMainForm.StartupVGHeight;
                }
                else
                {
                    cMainForm.axVideoGrabberNET1.Display_Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.Display_Height = cMainForm.StartupVGHeight;
                }
            }
            
		}

		private void chk1stVisible_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_Visible = chk1stVisible.Checked;
		}

		private void chk1stEmbedded_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_Embedded = chk1stEmbedded.Checked;
			RefreshControls();
		}

		private void chk1stFullScreen_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_FullScreen = chk1stFullScreen.Checked;
			RefreshControls();
		}

		private void chk1stMouseMovesWindow_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_MouseMovesWindow = chk1stMouseMovesWindow.Checked;
			RefreshControls();
		}

		private void chk1stStayOnTop_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_StayOnTop = chk1stStayOnTop.Checked;
			RefreshControls();
		}

		private void chk1stUseVideoPort_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_VideoPortEnabled = chk1stUseVideoPort.Checked;
			RefreshControls();
		}

		private void chk2ndAutoSize_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_AutoSize = chk2ndAutoSize.Checked;
			RefreshControls();

            
            // disabling DualDisplay_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainForm_Load values if DualDisplay_AutoSize has been disabled:
            if (!cMainForm.axVideoGrabberNET1.DualDisplay_AutoSize)
            {
                if (cMainForm.axVideoGrabberNET1.DualDisplay_Embedded)
                {
                    cMainForm.axVideoGrabberNET1.Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.Height = cMainForm.StartupVGHeight;
                }
                else
                {
                    cMainForm.axVideoGrabberNET1.DualDisplay_Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.DualDisplay_Height = cMainForm.StartupVGHeight;
                }
            }
            
		}

		private void chk2ndVisible_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_Visible = chk2ndVisible.Checked;
		}

		private void chk2ndEmbedded_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_Embedded = chk2ndEmbedded.Checked;
			RefreshControls();
		}

		private void chk2ndFullScreen_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_FullScreen = chk2ndFullScreen.Checked;
			RefreshControls();
		}

		private void chk2ndMouseMovesWindow_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_MouseMovesWindow = chk2ndMouseMovesWindow.Checked;
			RefreshControls();
		}

		private void chk2ndStayOnTop_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_StayOnTop = chk2ndStayOnTop.Checked;
			RefreshControls();
		}

		private void chk2ndUseVideoPort_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_VideoPortEnabled = chk2ndUseVideoPort.Checked;
			RefreshControls();
		}

        private void chkBlackMagicOutput_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                cMainForm.axVideoGrabberNET1.VideoRendererExternal = Vidgrab_NET.TxVideoRendererExternal.vre_BlackMagic_Decklink;
            }
            else
            {
                cMainForm.axVideoGrabberNET1.VideoRendererExternal = Vidgrab_NET.TxVideoRendererExternal.vre_None;
            }
        }

		private void chkVideoVisibleWhenStopped_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoVisibleWhenStopped = chkVideoVisibleWhenStopped.Checked;
		}

        private void chkAdjustPixelAspectRatio_CheckedChanged(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.AdjustPixelAspectRatio = chkAdjustPixelAspectRatio.Checked;
        }

		private void chkBorder_CheckedChanged(object sender, System.EventArgs e)
		{
#if (! VS2003) 
			if (chkBorder.Checked) 
			{
				cMainForm.axVideoGrabberNET1.BorderStyle = Vidgrab_NET.TxBorderStyle.bsSingle;
			}
			else {
				cMainForm.axVideoGrabberNET1.BorderStyle = Vidgrab_NET.TxBorderStyle.bsNone;
			}
#endif
		}

		private void chkChangeCursor_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkChangeCursor.Checked) {
				cMainForm.axVideoGrabberNET1.VideoCursor = Vidgrab_NET.TxCursors.cr_cross;
			}
			else {
				cMainForm.axVideoGrabberNET1.VideoCursor = Vidgrab_NET.TxCursors.cr_Default;
			}
		}

		private void chk2ndVideoWindowActive_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_Active = chk2ndVideoWindowActive.Checked;
			RefreshControls();
		}

		private void chk1stVideoWindowActive_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_Active = chk1stVideoWindowActive.Checked;
			RefreshControls();
		}

		private void chkSetLogo_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkSetLogo.Checked) {

                cMainForm.axVideoGrabberNET1.LogoLayout = Vidgrab_NET.TxLogoLayout.lg_Stretched;
                cMainForm.axVideoGrabberNET1.SetLogoFromHBitmap(CreateBitmapHandleFromPictureBox (imgLogo));
                cMainForm.axVideoGrabberNET1.LogoDisplayed = true;
			}
            else {
                cMainForm.axVideoGrabberNET1.LogoDisplayed = false;
            }
        }

		private void chkTransparency_CheckedChanged(object sender, System.EventArgs e)
		{
            frmTransparentWindow.TransparencyKey = cMainForm.axVideoGrabberNET1.ColorKey;
            frmTransparentWindow.BackColor = frmTransparentWindow.TransparencyKey;
            frmTransparentWindow.TransparentLabel.ForeColor = Color.Red;
            frmTransparentWindow.Show();
		}

		private void rdgVideoRenderer_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.VideoRenderer = (Vidgrab_NET.TxVideoRenderer) Convert.ToInt32 ((sender as Control).Tag);
			}
		
		}

		private void rdg1DisplayAspectRatio_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.Display_AspectRatio = (Vidgrab_NET.TxAspectRatio) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void tbr1PanScan_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Display_PanScanRatio = tbr1PanScan.Value;
		}

		private void btnTestPanScan_Click(object sender, System.EventArgs e)
		{
            
            chk1stEmbedded.Checked = true;
            cMainForm.axVideoGrabberNET1.Display_Embedded = true;
            chkAdjustPixelAspectRatio.Checked = false;
            cMainForm.axVideoGrabberNET1.AdjustPixelAspectRatio = false;

            chk1stAutoSize.Checked = false;
            cMainForm.axVideoGrabberNET1.Display_AutoSize = false;

            // disabling Display_AutoSize alone will not restore previously set video Width 
            //  and Height...for demonstration purposes, Width and Height are here restored
            //  to initial IDE MainForm_Load values if Display_AutoSize is enabled
            if (!cMainForm.axVideoGrabberNET1.Display_AutoSize)
            {
                if (cMainForm.axVideoGrabberNET1.Display_Embedded)
                {
                    cMainForm.axVideoGrabberNET1.Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.Height = cMainForm.StartupVGHeight;
                }
                else
                {
                    cMainForm.axVideoGrabberNET1.Display_Width = cMainForm.StartupVGWidth;
                    cMainForm.axVideoGrabberNET1.Display_Height = cMainForm.StartupVGHeight;
                }
            }

            // for pan / scan demonstration, change video Width and Height to a
            //  16 x 9 aspect ratio, or restore to pre-demonstration Width and Height
            if (boolPanScan)
            {
                cMainForm.axVideoGrabberNET1.Width = PanScanVGWidth;
                cMainForm.axVideoGrabberNET1.Height = PanScanVGHeight;
            }
            else
            {
                Single h = 9;
                Single w = 16;
                PanScanVGWidth = cMainForm.axVideoGrabberNET1.Width;
                PanScanVGHeight = cMainForm.axVideoGrabberNET1.Height;
                cMainForm.axVideoGrabberNET1.Width =Convert.ToInt32(Convert.ToSingle( cMainForm.axVideoGrabberNET1.Height) * (w / h));
            }
            boolPanScan = !boolPanScan;

            // setting Display_AspectRatio to ar_PanScan (pan and scan)
            rdg1DisplayAspectRatioPanScan.Checked = true;
            cMainForm.axVideoGrabberNET1.Display_AspectRatio = Vidgrab_NET.TxAspectRatio.ar_PanScan;
            
        }

		private void rdg2DisplayAspectRatio_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.DualDisplay_AspectRatio = (Vidgrab_NET.TxAspectRatio) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void tbr2PanScan_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DualDisplay_PanScanRatio = tbr2PanScan.Value;
		}

		private void rdg1stDisplayedOn_CheckedChanged (object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.Display_Monitor = Convert.ToInt32 ((sender as Control).Tag);
				RefreshControls();
			}
		}

		private void rdg2ndDisplayedOn_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.DualDisplay_Monitor = Convert.ToInt32 ((sender as Control).Tag);
				RefreshControls();
			}
		}

		private void Display_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		
		}

        private void btnTestPanScanHelp_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Test Display_AspectRatio settings with Display_AutoSize disabled:\n\nWith Display_AutoSize = False and AdjustPixelAspectRatio= False, the Display_AspectRatio setting\n  determines how the video is displayed within the control Width and Height properties:\n  ar_Box: video appears in full with correct aspect ratio (e.g. letterbox)\n  ar_NoResize: video appears in \"native\" size with correct aspect ratio\n  ar_Stretch: video is stretched to fill the control, regardless of correct aspect ratio\n  ar_PanScan: Display_PanScanRatio (0-100) determines setting between \"letterbox\" and \"pan-scan\"\n\n(see Help: \"User guide.Display - Dual display.Video window\")",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
            
        }

        private void rdgDualDisplayAspectRatio_CheckedChanged(object sender, System.EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                cMainForm.axVideoGrabberNET1.DualDisplay_AspectRatio = (Vidgrab_NET.TxAspectRatio)Convert.ToInt32((sender as Control).Tag);
            }
        }
	}
}
