using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for VideoSource.
	/// </summary>
	public class VideoSource : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        public Label Label11;
        public CheckBox chkReduceDVFrameRate;
        public GroupBox grbVideoSource;
        public ComboBox cboVideoSource;
        public GroupBox grbPreview;
        public Button btnStartPreview;
        public Button btnStopPreview;
        public GroupBox grbFrameRate;
        internal Button btnFrameRateHelp;
        public Button btnFrameRate;
        public TextBox edtFrameRate;
        public GroupBox grbVsVideoCaptureDevice;
        internal GroupBox grbMultiplexedInputs;
        internal CheckBox chkMultiplexedInputEmulation;
        internal CheckBox chk4InputsLayout;
        public ComboBox cboVideoDevices;
        public ComboBox cboVideoInputs;
        public ComboBox cboVideoSizes;
        public ComboBox cboVideoSubtypes;
        public ComboBox cboAnalogVideoStandard;
        public Label Label1;
        public Label Label2;
        public Label Label3;
        public Label Label4;
        public GroupBox grbVsFileOrUrl;
        internal Button btnDemoUrl;
        internal Label label8;
        internal Label label7;
        internal TextBox edtSourceFileOrUrlPassword;
        internal TextBox edtSourceFileOrUrlUserName;
        public Button btnSelectFileOrUrl;
        public TextBox edtVideoSourceFileOrUrl;
        public GroupBox grbVsScreenRecording;
        internal CheckBox chkScreenRecordingWindow;
        public Button btnScreenRecordingWindow;
        internal Button btnMonitorNumberInfo;
        internal TextBox edtMonitorNumber;
        internal Label label6;
        internal Label Label5;
        public TextBox edtScreenRecordingWindow;
        public CheckBox chkScreenRecordingWithCursor;
        public GroupBox grbPreferredVideoSizes;
        public RadioButton rdgPreferredVideoSize1;
        public RadioButton rdgPreferredVideoSize2;
        public RadioButton rdgPreferredVideoSize3;
        public RadioButton rdgPreferredVideoSize4;
        public RadioButton rdgPreferredVideoSize5;
        public RadioButton rdgPreferredVideoSize6;
        public RadioButton rdgPreferredVideoSize7;
        public RadioButton rdgPreferredVideoSize10;
        public RadioButton rdgPreferredVideoSize11;
        public CheckBox chkStretchPreferredVideoSize;
        public RadioButton rdgPreferredVideoSize12;
        public RadioButton rdgPreferredVideoSize13;
        public GroupBox grbVideoDevicesDialogs;
        internal Button btnDVCamcorderControl;
        public Button btnSpecialControls;
        public Button btnDeviceDialog;
        public Button btnStreamDialog;
        public Button btnCameraControlDialog;
        public Button btnVideoQualityDialog;
        public Button btnVideoControlDialog;
        public CheckBox btnAutoRefreshPreview;
        internal Label lblEnumerateWindows;
		private System.ComponentModel.IContainer components;

		public VideoSource()
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
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Label11 = new System.Windows.Forms.Label();
            this.chkReduceDVFrameRate = new System.Windows.Forms.CheckBox();
            this.grbVideoSource = new System.Windows.Forms.GroupBox();
            this.cboVideoSource = new System.Windows.Forms.ComboBox();
            this.grbPreview = new System.Windows.Forms.GroupBox();
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.grbFrameRate = new System.Windows.Forms.GroupBox();
            this.btnFrameRateHelp = new System.Windows.Forms.Button();
            this.btnFrameRate = new System.Windows.Forms.Button();
            this.edtFrameRate = new System.Windows.Forms.TextBox();
            this.grbVsVideoCaptureDevice = new System.Windows.Forms.GroupBox();
            this.grbMultiplexedInputs = new System.Windows.Forms.GroupBox();
            this.chkMultiplexedInputEmulation = new System.Windows.Forms.CheckBox();
            this.chk4InputsLayout = new System.Windows.Forms.CheckBox();
            this.cboVideoDevices = new System.Windows.Forms.ComboBox();
            this.cboVideoInputs = new System.Windows.Forms.ComboBox();
            this.cboVideoSizes = new System.Windows.Forms.ComboBox();
            this.cboVideoSubtypes = new System.Windows.Forms.ComboBox();
            this.cboAnalogVideoStandard = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.grbVsFileOrUrl = new System.Windows.Forms.GroupBox();
            this.btnDemoUrl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtSourceFileOrUrlPassword = new System.Windows.Forms.TextBox();
            this.edtSourceFileOrUrlUserName = new System.Windows.Forms.TextBox();
            this.btnSelectFileOrUrl = new System.Windows.Forms.Button();
            this.edtVideoSourceFileOrUrl = new System.Windows.Forms.TextBox();
            this.grbVsScreenRecording = new System.Windows.Forms.GroupBox();
            this.btnScreenRecordingWindow = new System.Windows.Forms.Button();
            this.btnMonitorNumberInfo = new System.Windows.Forms.Button();
            this.edtMonitorNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.edtScreenRecordingWindow = new System.Windows.Forms.TextBox();
            this.chkScreenRecordingWithCursor = new System.Windows.Forms.CheckBox();
            this.chkScreenRecordingWindow = new System.Windows.Forms.CheckBox();
            this.lblEnumerateWindows = new System.Windows.Forms.Label();
            this.grbPreferredVideoSizes = new System.Windows.Forms.GroupBox();
            this.rdgPreferredVideoSize1 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize2 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize3 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize4 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize5 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize6 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize7 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize10 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize11 = new System.Windows.Forms.RadioButton();
            this.chkStretchPreferredVideoSize = new System.Windows.Forms.CheckBox();
            this.rdgPreferredVideoSize12 = new System.Windows.Forms.RadioButton();
            this.rdgPreferredVideoSize13 = new System.Windows.Forms.RadioButton();
            this.grbVideoDevicesDialogs = new System.Windows.Forms.GroupBox();
            this.btnDVCamcorderControl = new System.Windows.Forms.Button();
            this.btnSpecialControls = new System.Windows.Forms.Button();
            this.btnDeviceDialog = new System.Windows.Forms.Button();
            this.btnStreamDialog = new System.Windows.Forms.Button();
            this.btnCameraControlDialog = new System.Windows.Forms.Button();
            this.btnVideoQualityDialog = new System.Windows.Forms.Button();
            this.btnVideoControlDialog = new System.Windows.Forms.Button();
            this.btnAutoRefreshPreview = new System.Windows.Forms.CheckBox();
            this.grbVideoSource.SuspendLayout();
            this.grbPreview.SuspendLayout();
            this.grbFrameRate.SuspendLayout();
            this.grbVsVideoCaptureDevice.SuspendLayout();
            this.grbMultiplexedInputs.SuspendLayout();
            this.grbVsFileOrUrl.SuspendLayout();
            this.grbVsScreenRecording.SuspendLayout();
            this.grbPreferredVideoSizes.SuspendLayout();
            this.grbVideoDevicesDialogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.BackColor = System.Drawing.SystemColors.Control;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label11.Location = new System.Drawing.Point(432, 0);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(340, 14);
            this.Label11.TabIndex = 57;
            this.Label11.Text = "use FindIndexInListByName to programmatically select an item in a list";
            // 
            // chkReduceDVFrameRate
            // 
            this.chkReduceDVFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.chkReduceDVFrameRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkReduceDVFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReduceDVFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkReduceDVFrameRate.Location = new System.Drawing.Point(434, 31);
            this.chkReduceDVFrameRate.Name = "chkReduceDVFrameRate";
            this.chkReduceDVFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkReduceDVFrameRate.Size = new System.Drawing.Size(113, 17);
            this.chkReduceDVFrameRate.TabIndex = 58;
            this.chkReduceDVFrameRate.Text = "half DV frame rate";
            this.chkReduceDVFrameRate.UseVisualStyleBackColor = false;
            this.chkReduceDVFrameRate.CheckedChanged += new System.EventHandler(this.chkReduceDVFrameRate_CheckedChanged);
            // 
            // grbVideoSource
            // 
            this.grbVideoSource.BackColor = System.Drawing.SystemColors.Control;
            this.grbVideoSource.Controls.Add(this.cboVideoSource);
            this.grbVideoSource.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVideoSource.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVideoSource.Location = new System.Drawing.Point(4, 0);
            this.grbVideoSource.Name = "grbVideoSource";
            this.grbVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVideoSource.Size = new System.Drawing.Size(161, 46);
            this.grbVideoSource.TabIndex = 56;
            this.grbVideoSource.TabStop = false;
            this.grbVideoSource.Text = "VIDEO SOURCE";
            // 
            // cboVideoSource
            // 
            this.cboVideoSource.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSource.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSource.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoSource.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSource.Location = new System.Drawing.Point(8, 18);
            this.cboVideoSource.Name = "cboVideoSource";
            this.cboVideoSource.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSource.Size = new System.Drawing.Size(147, 22);
            this.cboVideoSource.TabIndex = 45;
            this.cboVideoSource.SelectedIndexChanged += new System.EventHandler(this.cboVideoSource_SelectedIndexChanged);
            // 
            // grbPreview
            // 
            this.grbPreview.BackColor = System.Drawing.SystemColors.Control;
            this.grbPreview.Controls.Add(this.btnStartPreview);
            this.grbPreview.Controls.Add(this.btnStopPreview);
            this.grbPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbPreview.Location = new System.Drawing.Point(171, 0);
            this.grbPreview.Name = "grbPreview";
            this.grbPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPreview.Size = new System.Drawing.Size(137, 46);
            this.grbPreview.TabIndex = 55;
            this.grbPreview.TabStop = false;
            this.grbPreview.Text = "Preview";
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartPreview.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPreview.ForeColor = System.Drawing.Color.Red;
            this.btnStartPreview.Location = new System.Drawing.Point(8, 15);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartPreview.Size = new System.Drawing.Size(57, 24);
            this.btnStartPreview.TabIndex = 43;
            this.btnStartPreview.Text = "Start";
            this.btnStartPreview.UseVisualStyleBackColor = false;
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopPreview.Location = new System.Drawing.Point(72, 15);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopPreview.Size = new System.Drawing.Size(57, 24);
            this.btnStopPreview.TabIndex = 42;
            this.btnStopPreview.Text = "Stop";
            this.btnStopPreview.UseVisualStyleBackColor = false;
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // grbFrameRate
            // 
            this.grbFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.grbFrameRate.Controls.Add(this.btnFrameRateHelp);
            this.grbFrameRate.Controls.Add(this.btnFrameRate);
            this.grbFrameRate.Controls.Add(this.edtFrameRate);
            this.grbFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFrameRate.Location = new System.Drawing.Point(313, 0);
            this.grbFrameRate.Name = "grbFrameRate";
            this.grbFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbFrameRate.Size = new System.Drawing.Size(105, 46);
            this.grbFrameRate.TabIndex = 54;
            this.grbFrameRate.TabStop = false;
            this.grbFrameRate.Text = "Frame rate";
            // 
            // btnFrameRateHelp
            // 
            this.btnFrameRateHelp.Location = new System.Drawing.Point(75, 18);
            this.btnFrameRateHelp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFrameRateHelp.Name = "btnFrameRateHelp";
            this.btnFrameRateHelp.Size = new System.Drawing.Size(20, 22);
            this.btnFrameRateHelp.TabIndex = 41;
            this.btnFrameRateHelp.Text = "?";
            this.btnFrameRateHelp.Click += new System.EventHandler(this.btnFrameRateHelp_Click);
            // 
            // btnFrameRate
            // 
            this.btnFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.btnFrameRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFrameRate.Location = new System.Drawing.Point(45, 18);
            this.btnFrameRate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnFrameRate.Name = "btnFrameRate";
            this.btnFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFrameRate.Size = new System.Drawing.Size(30, 22);
            this.btnFrameRate.TabIndex = 40;
            this.btnFrameRate.Text = "OK";
            this.btnFrameRate.UseVisualStyleBackColor = false;
            this.btnFrameRate.Click += new System.EventHandler(this.btnFrameRate_Click);
            // 
            // edtFrameRate
            // 
            this.edtFrameRate.AcceptsReturn = true;
            this.edtFrameRate.BackColor = System.Drawing.SystemColors.Window;
            this.edtFrameRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFrameRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameRate.Location = new System.Drawing.Point(6, 18);
            this.edtFrameRate.MaxLength = 0;
            this.edtFrameRate.Name = "edtFrameRate";
            this.edtFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameRate.Size = new System.Drawing.Size(33, 20);
            this.edtFrameRate.TabIndex = 39;
            this.edtFrameRate.Text = "0";
            // 
            // grbVsVideoCaptureDevice
            // 
            this.grbVsVideoCaptureDevice.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsVideoCaptureDevice.Controls.Add(this.grbMultiplexedInputs);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoDevices);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoInputs);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoSizes);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboVideoSubtypes);
            this.grbVsVideoCaptureDevice.Controls.Add(this.cboAnalogVideoStandard);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label1);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label2);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label3);
            this.grbVsVideoCaptureDevice.Controls.Add(this.Label4);
            this.grbVsVideoCaptureDevice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVsVideoCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsVideoCaptureDevice.Location = new System.Drawing.Point(4, 46);
            this.grbVsVideoCaptureDevice.Name = "grbVsVideoCaptureDevice";
            this.grbVsVideoCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsVideoCaptureDevice.Size = new System.Drawing.Size(569, 74);
            this.grbVsVideoCaptureDevice.TabIndex = 53;
            this.grbVsVideoCaptureDevice.TabStop = false;
            this.grbVsVideoCaptureDevice.Text = "video source = video capture device";
            // 
            // grbMultiplexedInputs
            // 
            this.grbMultiplexedInputs.Controls.Add(this.chkMultiplexedInputEmulation);
            this.grbMultiplexedInputs.Controls.Add(this.chk4InputsLayout);
            this.grbMultiplexedInputs.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMultiplexedInputs.Location = new System.Drawing.Point(414, 8);
            this.grbMultiplexedInputs.Name = "grbMultiplexedInputs";
            this.grbMultiplexedInputs.Size = new System.Drawing.Size(148, 58);
            this.grbMultiplexedInputs.TabIndex = 38;
            this.grbMultiplexedInputs.TabStop = false;
            this.grbMultiplexedInputs.Text = "Multiplexed inputs";
            // 
            // chkMultiplexedInputEmulation
            // 
            this.chkMultiplexedInputEmulation.Location = new System.Drawing.Point(8, 33);
            this.chkMultiplexedInputEmulation.Name = "chkMultiplexedInputEmulation";
            this.chkMultiplexedInputEmulation.Size = new System.Drawing.Size(134, 16);
            this.chkMultiplexedInputEmulation.TabIndex = 1;
            this.chkMultiplexedInputEmulation.Text = "emulation";
            this.chkMultiplexedInputEmulation.CheckedChanged += new System.EventHandler(this.chkMultiplexedInputEmulation_CheckedChanged);
            // 
            // chk4InputsLayout
            // 
            this.chk4InputsLayout.Location = new System.Drawing.Point(8, 16);
            this.chk4InputsLayout.Name = "chk4InputsLayout";
            this.chk4InputsLayout.Size = new System.Drawing.Size(134, 16);
            this.chk4InputsLayout.TabIndex = 0;
            this.chk4InputsLayout.Text = "enable 4 inputs layout";
            this.chk4InputsLayout.CheckedChanged += new System.EventHandler(this.chk4InputsLayout_CheckedChanged);
            // 
            // cboVideoDevices
            // 
            this.cboVideoDevices.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoDevices.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoDevices.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoDevices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoDevices.Location = new System.Drawing.Point(8, 13);
            this.cboVideoDevices.Name = "cboVideoDevices";
            this.cboVideoDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoDevices.Size = new System.Drawing.Size(390, 22);
            this.cboVideoDevices.TabIndex = 33;
            this.cboVideoDevices.Text = "SELECT FIRST A VIDEO CAPTURE DEVICE IN THIS LIST";
            this.cboVideoDevices.SelectedIndexChanged += new System.EventHandler(this.cboVideoDevices_SelectedIndexChanged);
            // 
            // cboVideoInputs
            // 
            this.cboVideoInputs.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoInputs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoInputs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoInputs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoInputs.Location = new System.Drawing.Point(8, 48);
            this.cboVideoInputs.Name = "cboVideoInputs";
            this.cboVideoInputs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoInputs.Size = new System.Drawing.Size(82, 22);
            this.cboVideoInputs.TabIndex = 32;
            this.cboVideoInputs.SelectedIndexChanged += new System.EventHandler(this.cboVideoInputs_SelectedIndexChanged);
            // 
            // cboVideoSizes
            // 
            this.cboVideoSizes.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSizes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSizes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoSizes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSizes.Location = new System.Drawing.Point(98, 48);
            this.cboVideoSizes.Name = "cboVideoSizes";
            this.cboVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSizes.Size = new System.Drawing.Size(82, 22);
            this.cboVideoSizes.TabIndex = 31;
            this.cboVideoSizes.SelectedIndexChanged += new System.EventHandler(this.cboVideoSizes_SelectedIndexChanged);
            // 
            // cboVideoSubtypes
            // 
            this.cboVideoSubtypes.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoSubtypes.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoSubtypes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoSubtypes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoSubtypes.Location = new System.Drawing.Point(187, 48);
            this.cboVideoSubtypes.Name = "cboVideoSubtypes";
            this.cboVideoSubtypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoSubtypes.Size = new System.Drawing.Size(88, 22);
            this.cboVideoSubtypes.TabIndex = 30;
            this.cboVideoSubtypes.SelectedIndexChanged += new System.EventHandler(this.cboVideoSubtypes_SelectedIndexChanged);
            // 
            // cboAnalogVideoStandard
            // 
            this.cboAnalogVideoStandard.BackColor = System.Drawing.SystemColors.Window;
            this.cboAnalogVideoStandard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAnalogVideoStandard.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnalogVideoStandard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAnalogVideoStandard.Location = new System.Drawing.Point(282, 48);
            this.cboAnalogVideoStandard.Name = "cboAnalogVideoStandard";
            this.cboAnalogVideoStandard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAnalogVideoStandard.Size = new System.Drawing.Size(116, 22);
            this.cboAnalogVideoStandard.TabIndex = 29;
            this.cboAnalogVideoStandard.SelectedIndexChanged += new System.EventHandler(this.cboAnalogVideoStandard_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(5, 34);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(65, 17);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "video input";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(184, 34);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(75, 14);
            this.Label2.TabIndex = 36;
            this.Label2.Text = "video subtype";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(98, 34);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(56, 14);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "video size";
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(279, 34);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(121, 17);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "analog video standard";
            // 
            // grbVsFileOrUrl
            // 
            this.grbVsFileOrUrl.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsFileOrUrl.Controls.Add(this.btnDemoUrl);
            this.grbVsFileOrUrl.Controls.Add(this.label8);
            this.grbVsFileOrUrl.Controls.Add(this.label7);
            this.grbVsFileOrUrl.Controls.Add(this.edtSourceFileOrUrlPassword);
            this.grbVsFileOrUrl.Controls.Add(this.edtSourceFileOrUrlUserName);
            this.grbVsFileOrUrl.Controls.Add(this.btnSelectFileOrUrl);
            this.grbVsFileOrUrl.Controls.Add(this.edtVideoSourceFileOrUrl);
            this.grbVsFileOrUrl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVsFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsFileOrUrl.Location = new System.Drawing.Point(4, 120);
            this.grbVsFileOrUrl.Name = "grbVsFileOrUrl";
            this.grbVsFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsFileOrUrl.Size = new System.Drawing.Size(459, 60);
            this.grbVsFileOrUrl.TabIndex = 52;
            this.grbVsFileOrUrl.TabStop = false;
            this.grbVsFileOrUrl.Text = "video source = file or URL";
            // 
            // btnDemoUrl
            // 
            this.btnDemoUrl.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoUrl.Location = new System.Drawing.Point(297, 15);
            this.btnDemoUrl.Name = "btnDemoUrl";
            this.btnDemoUrl.Size = new System.Drawing.Size(78, 20);
            this.btnDemoUrl.TabIndex = 38;
            this.btnDemoUrl.Text = "demo URL?";
            this.btnDemoUrl.Click += new System.EventHandler(this.btnDemoUrl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(381, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 14);
            this.label8.TabIndex = 37;
            this.label8.Text = "pass:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(381, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 14);
            this.label7.TabIndex = 36;
            this.label7.Text = "user:";
            // 
            // edtSourceFileOrUrlPassword
            // 
            this.edtSourceFileOrUrlPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSourceFileOrUrlPassword.Location = new System.Drawing.Point(416, 36);
            this.edtSourceFileOrUrlPassword.Name = "edtSourceFileOrUrlPassword";
            this.edtSourceFileOrUrlPassword.Size = new System.Drawing.Size(37, 20);
            this.edtSourceFileOrUrlPassword.TabIndex = 35;
            this.edtSourceFileOrUrlPassword.TextChanged += new System.EventHandler(this.edtSourceFileOrUrlPassword_TextChanged);
            // 
            // edtSourceFileOrUrlUserName
            // 
            this.edtSourceFileOrUrlUserName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSourceFileOrUrlUserName.Location = new System.Drawing.Point(416, 13);
            this.edtSourceFileOrUrlUserName.Name = "edtSourceFileOrUrlUserName";
            this.edtSourceFileOrUrlUserName.Size = new System.Drawing.Size(37, 20);
            this.edtSourceFileOrUrlUserName.TabIndex = 34;
            this.edtSourceFileOrUrlUserName.TextChanged += new System.EventHandler(this.edtSourceFileOrUrlUserName_TextChanged);
            // 
            // btnSelectFileOrUrl
            // 
            this.btnSelectFileOrUrl.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectFileOrUrl.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectFileOrUrl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFileOrUrl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelectFileOrUrl.Location = new System.Drawing.Point(0, 14);
            this.btnSelectFileOrUrl.Name = "btnSelectFileOrUrl";
            this.btnSelectFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectFileOrUrl.Size = new System.Drawing.Size(45, 21);
            this.btnSelectFileOrUrl.TabIndex = 26;
            this.btnSelectFileOrUrl.Text = "open";
            this.btnSelectFileOrUrl.UseVisualStyleBackColor = false;
            this.btnSelectFileOrUrl.Click += new System.EventHandler(this.btnSelectFileOrUrl_Click);
            // 
            // edtVideoSourceFileOrUrl
            // 
            this.edtVideoSourceFileOrUrl.AcceptsReturn = true;
            this.edtVideoSourceFileOrUrl.BackColor = System.Drawing.SystemColors.Window;
            this.edtVideoSourceFileOrUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtVideoSourceFileOrUrl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtVideoSourceFileOrUrl.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtVideoSourceFileOrUrl.Location = new System.Drawing.Point(50, 14);
            this.edtVideoSourceFileOrUrl.MaxLength = 0;
            this.edtVideoSourceFileOrUrl.Name = "edtVideoSourceFileOrUrl";
            this.edtVideoSourceFileOrUrl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtVideoSourceFileOrUrl.Size = new System.Drawing.Size(241, 20);
            this.edtVideoSourceFileOrUrl.TabIndex = 25;
            this.edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv";
            this.edtVideoSourceFileOrUrl.TextChanged += new System.EventHandler(this.edtVideoSourceFileOrUrl_TextChanged);
            // 
            // grbVsScreenRecording
            // 
            this.grbVsScreenRecording.BackColor = System.Drawing.SystemColors.Control;
            this.grbVsScreenRecording.Controls.Add(this.btnScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.btnMonitorNumberInfo);
            this.grbVsScreenRecording.Controls.Add(this.edtMonitorNumber);
            this.grbVsScreenRecording.Controls.Add(this.label6);
            this.grbVsScreenRecording.Controls.Add(this.Label5);
            this.grbVsScreenRecording.Controls.Add(this.edtScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.chkScreenRecordingWithCursor);
            this.grbVsScreenRecording.Controls.Add(this.chkScreenRecordingWindow);
            this.grbVsScreenRecording.Controls.Add(this.lblEnumerateWindows);
            this.grbVsScreenRecording.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVsScreenRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVsScreenRecording.Location = new System.Drawing.Point(466, 120);
            this.grbVsScreenRecording.Name = "grbVsScreenRecording";
            this.grbVsScreenRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVsScreenRecording.Size = new System.Drawing.Size(316, 60);
            this.grbVsScreenRecording.TabIndex = 51;
            this.grbVsScreenRecording.TabStop = false;
            this.grbVsScreenRecording.Text = "video source = screen recording";
            // 
            // btnScreenRecordingWindow
            // 
            this.btnScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Control;
            this.btnScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnScreenRecordingWindow.Location = new System.Drawing.Point(274, 34);
            this.btnScreenRecordingWindow.Name = "btnScreenRecordingWindow";
            this.btnScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnScreenRecordingWindow.Size = new System.Drawing.Size(28, 21);
            this.btnScreenRecordingWindow.TabIndex = 27;
            this.btnScreenRecordingWindow.Text = "ok";
            this.btnScreenRecordingWindow.UseVisualStyleBackColor = false;
            this.btnScreenRecordingWindow.Click += new System.EventHandler(this.btnScreenRecordingWindow_Click);
            // 
            // btnMonitorNumberInfo
            // 
            this.btnMonitorNumberInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorNumberInfo.Location = new System.Drawing.Point(40, 33);
            this.btnMonitorNumberInfo.Name = "btnMonitorNumberInfo";
            this.btnMonitorNumberInfo.Size = new System.Drawing.Size(43, 20);
            this.btnMonitorNumberInfo.TabIndex = 33;
            this.btnMonitorNumberInfo.Text = "info?";
            this.btnMonitorNumberInfo.Click += new System.EventHandler(this.btnMonitorNumberInfo_Click);
            // 
            // edtMonitorNumber
            // 
            this.edtMonitorNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMonitorNumber.Location = new System.Drawing.Point(6, 34);
            this.edtMonitorNumber.Name = "edtMonitorNumber";
            this.edtMonitorNumber.Size = new System.Drawing.Size(37, 20);
            this.edtMonitorNumber.TabIndex = 32;
            this.edtMonitorNumber.Text = "0";
            this.edtMonitorNumber.TextChanged += new System.EventHandler(this.edtMonitorNumber_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 31;
            this.label6.Text = "monitor num:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(90, 19);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(164, 14);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "use this window (\"\"=full screen)";
            // 
            // edtScreenRecordingWindow
            // 
            this.edtScreenRecordingWindow.AcceptsReturn = true;
            this.edtScreenRecordingWindow.BackColor = System.Drawing.SystemColors.Window;
            this.edtScreenRecordingWindow.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtScreenRecordingWindow.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtScreenRecordingWindow.Location = new System.Drawing.Point(89, 35);
            this.edtScreenRecordingWindow.MaxLength = 0;
            this.edtScreenRecordingWindow.Name = "edtScreenRecordingWindow";
            this.edtScreenRecordingWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtScreenRecordingWindow.Size = new System.Drawing.Size(131, 20);
            this.edtScreenRecordingWindow.TabIndex = 26;
            this.edtScreenRecordingWindow.Text = "TVideoGrabber demo";
            // 
            // chkScreenRecordingWithCursor
            // 
            this.chkScreenRecordingWithCursor.BackColor = System.Drawing.SystemColors.Control;
            this.chkScreenRecordingWithCursor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkScreenRecordingWithCursor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScreenRecordingWithCursor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkScreenRecordingWithCursor.Location = new System.Drawing.Point(260, 11);
            this.chkScreenRecordingWithCursor.Name = "chkScreenRecordingWithCursor";
            this.chkScreenRecordingWithCursor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkScreenRecordingWithCursor.Size = new System.Drawing.Size(60, 21);
            this.chkScreenRecordingWithCursor.TabIndex = 23;
            this.chkScreenRecordingWithCursor.Text = "cursor";
            this.chkScreenRecordingWithCursor.UseVisualStyleBackColor = false;
            this.chkScreenRecordingWithCursor.CheckedChanged += new System.EventHandler(this.chkScreenRecordingWithCursor_CheckedChanged);
            // 
            // chkScreenRecordingWindow
            // 
            this.chkScreenRecordingWindow.AutoSize = true;
            this.chkScreenRecordingWindow.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkScreenRecordingWindow.Location = new System.Drawing.Point(224, 36);
            this.chkScreenRecordingWindow.Name = "chkScreenRecordingWindow";
            this.chkScreenRecordingWindow.Size = new System.Drawing.Size(53, 18);
            this.chkScreenRecordingWindow.TabIndex = 34;
            this.chkScreenRecordingWindow.Text = "exact";
            // 
            // lblEnumerateWindows
            // 
            this.lblEnumerateWindows.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnumerateWindows.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnumerateWindows.Location = new System.Drawing.Point(294, 11);
            this.lblEnumerateWindows.Name = "lblEnumerateWindows";
            this.lblEnumerateWindows.Size = new System.Drawing.Size(22, 18);
            this.lblEnumerateWindows.TabIndex = 36;
            this.lblEnumerateWindows.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbPreferredVideoSizes
            // 
            this.grbPreferredVideoSizes.BackColor = System.Drawing.SystemColors.Control;
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize1);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize2);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize3);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize4);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize5);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize6);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize7);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize10);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize11);
            this.grbPreferredVideoSizes.Controls.Add(this.chkStretchPreferredVideoSize);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize12);
            this.grbPreferredVideoSizes.Controls.Add(this.rdgPreferredVideoSize13);
            this.grbPreferredVideoSizes.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPreferredVideoSizes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbPreferredVideoSizes.Location = new System.Drawing.Point(580, 16);
            this.grbPreferredVideoSizes.Name = "grbPreferredVideoSizes";
            this.grbPreferredVideoSizes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbPreferredVideoSizes.Size = new System.Drawing.Size(201, 104);
            this.grbPreferredVideoSizes.TabIndex = 50;
            this.grbPreferredVideoSizes.TabStop = false;
            this.grbPreferredVideoSizes.Text = "preferred video sizes (examples)";
            // 
            // rdgPreferredVideoSize1
            // 
            this.rdgPreferredVideoSize1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize1.Checked = true;
            this.rdgPreferredVideoSize1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize1.Location = new System.Drawing.Point(8, 14);
            this.rdgPreferredVideoSize1.Name = "rdgPreferredVideoSize1";
            this.rdgPreferredVideoSize1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize1.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize1.TabIndex = 21;
            this.rdgPreferredVideoSize1.TabStop = true;
            this.rdgPreferredVideoSize1.Tag = "0";
            this.rdgPreferredVideoSize1.Text = "device sizes";
            this.rdgPreferredVideoSize1.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize1.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize2
            // 
            this.rdgPreferredVideoSize2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize2.Location = new System.Drawing.Point(8, 28);
            this.rdgPreferredVideoSize2.Name = "rdgPreferredVideoSize2";
            this.rdgPreferredVideoSize2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize2.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize2.TabIndex = 20;
            this.rdgPreferredVideoSize2.TabStop = true;
            this.rdgPreferredVideoSize2.Tag = "1";
            this.rdgPreferredVideoSize2.Text = "88x60";
            this.rdgPreferredVideoSize2.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize2.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize3
            // 
            this.rdgPreferredVideoSize3.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize3.Location = new System.Drawing.Point(8, 42);
            this.rdgPreferredVideoSize3.Name = "rdgPreferredVideoSize3";
            this.rdgPreferredVideoSize3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize3.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize3.TabIndex = 19;
            this.rdgPreferredVideoSize3.TabStop = true;
            this.rdgPreferredVideoSize3.Tag = "2";
            this.rdgPreferredVideoSize3.Text = "88x72";
            this.rdgPreferredVideoSize3.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize3.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize4
            // 
            this.rdgPreferredVideoSize4.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize4.Location = new System.Drawing.Point(8, 56);
            this.rdgPreferredVideoSize4.Name = "rdgPreferredVideoSize4";
            this.rdgPreferredVideoSize4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize4.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize4.TabIndex = 18;
            this.rdgPreferredVideoSize4.TabStop = true;
            this.rdgPreferredVideoSize4.Tag = "3";
            this.rdgPreferredVideoSize4.Text = "180x120";
            this.rdgPreferredVideoSize4.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize4.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize5
            // 
            this.rdgPreferredVideoSize5.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize5.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize5.Location = new System.Drawing.Point(8, 70);
            this.rdgPreferredVideoSize5.Name = "rdgPreferredVideoSize5";
            this.rdgPreferredVideoSize5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize5.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize5.TabIndex = 17;
            this.rdgPreferredVideoSize5.TabStop = true;
            this.rdgPreferredVideoSize5.Tag = "4";
            this.rdgPreferredVideoSize5.Text = "180x144";
            this.rdgPreferredVideoSize5.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize5.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize6
            // 
            this.rdgPreferredVideoSize6.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize6.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize6.Location = new System.Drawing.Point(8, 84);
            this.rdgPreferredVideoSize6.Name = "rdgPreferredVideoSize6";
            this.rdgPreferredVideoSize6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize6.Size = new System.Drawing.Size(97, 15);
            this.rdgPreferredVideoSize6.TabIndex = 16;
            this.rdgPreferredVideoSize6.TabStop = true;
            this.rdgPreferredVideoSize6.Tag = "5";
            this.rdgPreferredVideoSize6.Text = "320x240";
            this.rdgPreferredVideoSize6.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize6.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize7
            // 
            this.rdgPreferredVideoSize7.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize7.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize7.Location = new System.Drawing.Point(104, 14);
            this.rdgPreferredVideoSize7.Name = "rdgPreferredVideoSize7";
            this.rdgPreferredVideoSize7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize7.Size = new System.Drawing.Size(64, 15);
            this.rdgPreferredVideoSize7.TabIndex = 15;
            this.rdgPreferredVideoSize7.TabStop = true;
            this.rdgPreferredVideoSize7.Tag = "6";
            this.rdgPreferredVideoSize7.Text = "352x288";
            this.rdgPreferredVideoSize7.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize7.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize10
            // 
            this.rdgPreferredVideoSize10.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize10.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize10.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize10.Location = new System.Drawing.Point(104, 28);
            this.rdgPreferredVideoSize10.Name = "rdgPreferredVideoSize10";
            this.rdgPreferredVideoSize10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize10.Size = new System.Drawing.Size(74, 15);
            this.rdgPreferredVideoSize10.TabIndex = 12;
            this.rdgPreferredVideoSize10.TabStop = true;
            this.rdgPreferredVideoSize10.Tag = "7";
            this.rdgPreferredVideoSize10.Text = "640x480";
            this.rdgPreferredVideoSize10.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize10.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize11
            // 
            this.rdgPreferredVideoSize11.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize11.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize11.Location = new System.Drawing.Point(104, 42);
            this.rdgPreferredVideoSize11.Name = "rdgPreferredVideoSize11";
            this.rdgPreferredVideoSize11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize11.Size = new System.Drawing.Size(74, 15);
            this.rdgPreferredVideoSize11.TabIndex = 11;
            this.rdgPreferredVideoSize11.TabStop = true;
            this.rdgPreferredVideoSize11.Tag = "8";
            this.rdgPreferredVideoSize11.Text = "720x480";
            this.rdgPreferredVideoSize11.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize11.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // chkStretchPreferredVideoSize
            // 
            this.chkStretchPreferredVideoSize.BackColor = System.Drawing.SystemColors.Control;
            this.chkStretchPreferredVideoSize.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStretchPreferredVideoSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkStretchPreferredVideoSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStretchPreferredVideoSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkStretchPreferredVideoSize.Location = new System.Drawing.Point(116, 84);
            this.chkStretchPreferredVideoSize.Name = "chkStretchPreferredVideoSize";
            this.chkStretchPreferredVideoSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkStretchPreferredVideoSize.Size = new System.Drawing.Size(74, 18);
            this.chkStretchPreferredVideoSize.TabIndex = 10;
            this.chkStretchPreferredVideoSize.Text = "stretch";
            this.chkStretchPreferredVideoSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStretchPreferredVideoSize.UseVisualStyleBackColor = false;
            // 
            // rdgPreferredVideoSize12
            // 
            this.rdgPreferredVideoSize12.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize12.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize12.Location = new System.Drawing.Point(104, 56);
            this.rdgPreferredVideoSize12.Name = "rdgPreferredVideoSize12";
            this.rdgPreferredVideoSize12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize12.Size = new System.Drawing.Size(74, 15);
            this.rdgPreferredVideoSize12.TabIndex = 9;
            this.rdgPreferredVideoSize12.TabStop = true;
            this.rdgPreferredVideoSize12.Tag = "9";
            this.rdgPreferredVideoSize12.Text = "720x576";
            this.rdgPreferredVideoSize12.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize12.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // rdgPreferredVideoSize13
            // 
            this.rdgPreferredVideoSize13.BackColor = System.Drawing.SystemColors.Control;
            this.rdgPreferredVideoSize13.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgPreferredVideoSize13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgPreferredVideoSize13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgPreferredVideoSize13.Location = new System.Drawing.Point(104, 70);
            this.rdgPreferredVideoSize13.Name = "rdgPreferredVideoSize13";
            this.rdgPreferredVideoSize13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgPreferredVideoSize13.Size = new System.Drawing.Size(74, 15);
            this.rdgPreferredVideoSize13.TabIndex = 8;
            this.rdgPreferredVideoSize13.TabStop = true;
            this.rdgPreferredVideoSize13.Tag = "10";
            this.rdgPreferredVideoSize13.Text = "768x576";
            this.rdgPreferredVideoSize13.UseVisualStyleBackColor = false;
            this.rdgPreferredVideoSize13.CheckedChanged += new System.EventHandler(this.rdgPreferredVideoSize_CheckedChanged);
            // 
            // grbVideoDevicesDialogs
            // 
            this.grbVideoDevicesDialogs.BackColor = System.Drawing.SystemColors.Control;
            this.grbVideoDevicesDialogs.Controls.Add(this.btnDVCamcorderControl);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnSpecialControls);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnDeviceDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnStreamDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnCameraControlDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnVideoQualityDialog);
            this.grbVideoDevicesDialogs.Controls.Add(this.btnVideoControlDialog);
            this.grbVideoDevicesDialogs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVideoDevicesDialogs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVideoDevicesDialogs.Location = new System.Drawing.Point(788, 0);
            this.grbVideoDevicesDialogs.Name = "grbVideoDevicesDialogs";
            this.grbVideoDevicesDialogs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVideoDevicesDialogs.Size = new System.Drawing.Size(121, 180);
            this.grbVideoDevicesDialogs.TabIndex = 49;
            this.grbVideoDevicesDialogs.TabStop = false;
            this.grbVideoDevicesDialogs.Text = "video device dialogs";
            // 
            // btnDVCamcorderControl
            // 
            this.btnDVCamcorderControl.Location = new System.Drawing.Point(16, 153);
            this.btnDVCamcorderControl.Name = "btnDVCamcorderControl";
            this.btnDVCamcorderControl.Size = new System.Drawing.Size(88, 20);
            this.btnDVCamcorderControl.TabIndex = 48;
            this.btnDVCamcorderControl.Text = "DV camcorder";
            this.btnDVCamcorderControl.Click += new System.EventHandler(this.btnDVCamcorderControl_Click);
            // 
            // btnSpecialControls
            // 
            this.btnSpecialControls.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpecialControls.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSpecialControls.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecialControls.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpecialControls.Location = new System.Drawing.Point(16, 130);
            this.btnSpecialControls.Name = "btnSpecialControls";
            this.btnSpecialControls.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSpecialControls.Size = new System.Drawing.Size(88, 20);
            this.btnSpecialControls.TabIndex = 7;
            this.btnSpecialControls.Text = "special controls";
            this.btnSpecialControls.UseVisualStyleBackColor = false;
            this.btnSpecialControls.Click += new System.EventHandler(this.btnSpecialControls_Click);
            // 
            // btnDeviceDialog
            // 
            this.btnDeviceDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeviceDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeviceDialog.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeviceDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeviceDialog.Location = new System.Drawing.Point(16, 15);
            this.btnDeviceDialog.Name = "btnDeviceDialog";
            this.btnDeviceDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeviceDialog.Size = new System.Drawing.Size(88, 20);
            this.btnDeviceDialog.TabIndex = 6;
            this.btnDeviceDialog.Text = "device";
            this.btnDeviceDialog.UseVisualStyleBackColor = false;
            this.btnDeviceDialog.Click += new System.EventHandler(this.btnDeviceDialog_Click);
            // 
            // btnStreamDialog
            // 
            this.btnStreamDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnStreamDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStreamDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStreamDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStreamDialog.Location = new System.Drawing.Point(16, 38);
            this.btnStreamDialog.Name = "btnStreamDialog";
            this.btnStreamDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStreamDialog.Size = new System.Drawing.Size(88, 20);
            this.btnStreamDialog.TabIndex = 5;
            this.btnStreamDialog.Text = "stream";
            this.btnStreamDialog.UseVisualStyleBackColor = false;
            this.btnStreamDialog.Click += new System.EventHandler(this.btnStreamDialog_Click);
            // 
            // btnCameraControlDialog
            // 
            this.btnCameraControlDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnCameraControlDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCameraControlDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCameraControlDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCameraControlDialog.Location = new System.Drawing.Point(16, 61);
            this.btnCameraControlDialog.Name = "btnCameraControlDialog";
            this.btnCameraControlDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCameraControlDialog.Size = new System.Drawing.Size(88, 20);
            this.btnCameraControlDialog.TabIndex = 4;
            this.btnCameraControlDialog.Text = "camera control";
            this.btnCameraControlDialog.UseVisualStyleBackColor = false;
            this.btnCameraControlDialog.Click += new System.EventHandler(this.btnCameraControlDialog_Click);
            // 
            // btnVideoQualityDialog
            // 
            this.btnVideoQualityDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnVideoQualityDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVideoQualityDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoQualityDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideoQualityDialog.Location = new System.Drawing.Point(16, 84);
            this.btnVideoQualityDialog.Name = "btnVideoQualityDialog";
            this.btnVideoQualityDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVideoQualityDialog.Size = new System.Drawing.Size(88, 20);
            this.btnVideoQualityDialog.TabIndex = 3;
            this.btnVideoQualityDialog.Text = "video quality";
            this.btnVideoQualityDialog.UseVisualStyleBackColor = false;
            this.btnVideoQualityDialog.Click += new System.EventHandler(this.btnVideoQualityDialog_Click);
            // 
            // btnVideoControlDialog
            // 
            this.btnVideoControlDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnVideoControlDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVideoControlDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoControlDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideoControlDialog.Location = new System.Drawing.Point(16, 107);
            this.btnVideoControlDialog.Name = "btnVideoControlDialog";
            this.btnVideoControlDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVideoControlDialog.Size = new System.Drawing.Size(88, 20);
            this.btnVideoControlDialog.TabIndex = 2;
            this.btnVideoControlDialog.Text = "video control";
            this.btnVideoControlDialog.UseVisualStyleBackColor = false;
            this.btnVideoControlDialog.Click += new System.EventHandler(this.btnVideoControlDialog_Click);
            // 
            // btnAutoRefreshPreview
            // 
            this.btnAutoRefreshPreview.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoRefreshPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAutoRefreshPreview.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoRefreshPreview.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAutoRefreshPreview.Location = new System.Drawing.Point(434, 16);
            this.btnAutoRefreshPreview.Name = "btnAutoRefreshPreview";
            this.btnAutoRefreshPreview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAutoRefreshPreview.Size = new System.Drawing.Size(128, 17);
            this.btnAutoRefreshPreview.TabIndex = 48;
            this.btnAutoRefreshPreview.Text = "Auto refresh preview";
            this.btnAutoRefreshPreview.UseVisualStyleBackColor = false;
            this.btnAutoRefreshPreview.CheckedChanged += new System.EventHandler(this.btnAutoRefreshPreview_CheckedChanged);
            // 
            // VideoSource
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(938, 260);
            this.ControlBox = false;
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.chkReduceDVFrameRate);
            this.Controls.Add(this.grbVideoSource);
            this.Controls.Add(this.grbPreview);
            this.Controls.Add(this.grbFrameRate);
            this.Controls.Add(this.grbVsVideoCaptureDevice);
            this.Controls.Add(this.grbVsFileOrUrl);
            this.Controls.Add(this.grbVsScreenRecording);
            this.Controls.Add(this.grbPreferredVideoSizes);
            this.Controls.Add(this.grbVideoDevicesDialogs);
            this.Controls.Add(this.btnAutoRefreshPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoSource";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.VideoSource_Load);
            this.VisibleChanged += new System.EventHandler(this.VideoSource_VisibleChanged);
            this.grbVideoSource.ResumeLayout(false);
            this.grbPreview.ResumeLayout(false);
            this.grbFrameRate.ResumeLayout(false);
            this.grbFrameRate.PerformLayout();
            this.grbVsVideoCaptureDevice.ResumeLayout(false);
            this.grbVsVideoCaptureDevice.PerformLayout();
            this.grbMultiplexedInputs.ResumeLayout(false);
            this.grbVsFileOrUrl.ResumeLayout(false);
            this.grbVsFileOrUrl.PerformLayout();
            this.grbVsScreenRecording.ResumeLayout(false);
            this.grbVsScreenRecording.PerformLayout();
            this.grbPreferredVideoSizes.ResumeLayout(false);
            this.grbVideoDevicesDialogs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		public miscCameraControl frmMiscCameraControl;
		public miscVideoQuality frmMiscVideoQuality;
		public miscVideoControl frmMiscVideoControl;
		public miscSpecialControl frmMiscSpecialControl;
		public miscDVCommands frmMiscDVCommands;

		private void VideoSource_Load(object sender, System.EventArgs e)
		{
			frmMiscCameraControl = new miscCameraControl();
			frmMiscVideoQuality = new miscVideoQuality();
			frmMiscVideoControl = new miscVideoControl();
			frmMiscSpecialControl = new miscSpecialControl();
			frmMiscDVCommands = new miscDVCommands();
			
			frmMiscCameraControl.cMainForm = cMainForm;
			frmMiscVideoQuality.cMainForm = cMainForm;
			frmMiscVideoControl.cMainForm = cMainForm;
			frmMiscSpecialControl.cMainForm = cMainForm;
			frmMiscDVCommands.cMainForm = cMainForm;
			
		}

		public void RefreshControls()
		{
			AssignListToComboBox (cboVideoSource, cMainForm.axVideoGrabberNET1.VideoSources, (int) cMainForm.axVideoGrabberNET1.VideoSource);
			AssignListToComboBox (cboVideoDevices, cMainForm.axVideoGrabberNET1.VideoDevices, cMainForm.axVideoGrabberNET1.VideoDevice);

            if (cMainForm.axVideoGrabberNET1.VideoDevice >= 0) // if a video capture device has been selected 
            {
                AssignListToComboBox(cboAnalogVideoStandard, cMainForm.axVideoGrabberNET1.AnalogVideoStandards, cMainForm.axVideoGrabberNET1.AnalogVideoStandard);
                AssignListToComboBox(cboVideoSizes, cMainForm.axVideoGrabberNET1.VideoSizes, cMainForm.axVideoGrabberNET1.VideoSize);
                AssignListToComboBox(cboVideoSubtypes, cMainForm.axVideoGrabberNET1.VideoSubtypes, cMainForm.axVideoGrabberNET1.VideoSubtype);
                AssignListToComboBox(cboVideoInputs, cMainForm.axVideoGrabberNET1.VideoInputs, cMainForm.axVideoGrabberNET1.VideoInput);

            }
			cboAnalogVideoStandard.Enabled = cMainForm.axVideoGrabberNET1.IsAnalogVideoDecoderAvailable;
			cboVideoInputs.Enabled = cMainForm.axVideoGrabberNET1.IsVideoCrossbarAvailable;

            btnAutoRefreshPreview.Enabled = cMainForm.axVideoGrabberNET1.AutoRefreshPreview;
			btnAutoRefreshPreview.Checked = cMainForm.axVideoGrabberNET1.AutoRefreshPreview;

			cboVideoSource.SelectedIndex = (int) cMainForm.axVideoGrabberNET1.VideoSource;

			chkScreenRecordingWithCursor.Checked = cMainForm.axVideoGrabberNET1.ScreenRecordingWithCursor;
			edtMonitorNumber.Text = cMainForm.axVideoGrabberNET1.ScreenRecordingMonitor.ToString();

			chkReduceDVFrameRate.Checked = cMainForm.axVideoGrabberNET1.DVReduceFrameRate;
			chkReduceDVFrameRate.Enabled = cMainForm.axVideoGrabberNET1.IsDigitalVideoIn;

			btnStreamDialog.Enabled = ! cMainForm.axVideoGrabberNET1.IsDigitalVideoIn;
			btnCameraControlDialog.Enabled = cMainForm.axVideoGrabberNET1.IsCameraControlAvailable;
			btnVideoQualityDialog.Enabled = cMainForm.axVideoGrabberNET1.IsVideoQualityAvailable;
			btnVideoControlDialog.Enabled = cMainForm.axVideoGrabberNET1.IsVideoControlAvailable;

			edtFrameRate.Text = cMainForm.axVideoGrabberNET1.FrameRate.ToString ("0.00");

			if (frmMiscCameraControl != null) frmMiscCameraControl.RefreshControls();
			if (frmMiscVideoQuality != null) frmMiscVideoQuality.RefreshControls();
			if (frmMiscVideoControl!= null) frmMiscVideoControl.RefreshControls();
			if (frmMiscSpecialControl!= null) frmMiscSpecialControl.RefreshControls();
			if (frmMiscDVCommands!= null) frmMiscDVCommands.RefreshControls();
		}

		private void btnAutoRefreshPreview_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AutoRefreshPreview = btnAutoRefreshPreview.Checked;
		}

		private void btnDeviceDialog_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_VideoDevice);
			cMainForm.RefreshControls();
		}

		private void btnFrameRate_Click(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtFrameRate.Text)) 
			{
				cMainForm.axVideoGrabberNET1.FrameRate = Convert.ToDouble (edtFrameRate.Text);
				if (cMainForm.axVideoGrabberNET1.CurrentState == Vidgrab_NET.TxCurrentState.cs_Preview) 
				{
					AddLog((cMainForm.mmoLog), "current frame rate: " + cMainForm.axVideoGrabberNET1.CurrentFrameRate.ToString ("0.00") + " fps.");
				}
			}
		}

        private void btnFrameRateHelp_Click(object sender, EventArgs e)
        
        {
            MessageBox.Show("'0' means that the default frame rate of the device will be used.\n\nAfter the OnPreviewStarted or OnRecordingStarted event occurs,\nits value is available in the CurrentFrameRate property.",
                    "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
        }
        
        
        private void btnSelectFileOrUrl_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			edtVideoSourceFileOrUrl.Text = "";
			fd.Filter = OPEN_MEDIA_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
				edtVideoSourceFileOrUrl.Text = fd.FileName;
		}

        private void btnDemoUrl_Click(object sender, EventArgs e)
        {
            edtVideoSourceFileOrUrl.Text = "mms://www.datastead.com/demo/demo.wmv";
        }

        private void btnStartPreview_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.StartPreview();
		}

		private void btnStopPreview_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.StopPreview();
		}

		private void btnStreamDialog_Click(object sender, System.EventArgs e)
		{
			// WARNING: USUALLY, THIS DIALOG ALLOWS TO CHANGE ONLY 1 PARAMETER AT THE SAME TIME;
			cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_StreamConfig);
			RefreshControls();
		}

		private void cboVideoSource_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cboVideoSource.SelectedIndex < 5) 
			{
				cMainForm.axVideoGrabberNET1.VideoSource = (Vidgrab_NET.TxVideoSource) cboVideoSource.SelectedIndex;
			}
			else 
			{
				AddLog((cMainForm.mmoLog), "this option is not demonstrated in this demo");
			}
		}

		private void cboAnalogVideoStandard_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AnalogVideoStandard = cboAnalogVideoStandard.SelectedIndex;
		}

		private void cboVideoDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoDevice = cboVideoDevices.SelectedIndex;
			// when selecting another video device, the OnVideoDeviceSelected event occurs.
			// From this event we invoke RefreshControls to to refresh all the device-dependent controls.
		}

		private void cboVideoInputs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoInput = cboVideoInputs.SelectedIndex;
		}

		private void cboVideoSizes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoSize = cboVideoSizes.SelectedIndex;
		}

		private void cboVideoSubtypes_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoSubtype = cboVideoSubtypes.SelectedIndex;
		}

		private void chkReduceDVFrameRate_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.DVReduceFrameRate = chkReduceDVFrameRate.Checked;
		}

		private void btnScreenRecordingWindow_Click(object sender, System.EventArgs e)
		{
            
            cMainForm.axVideoGrabberNET1.SetWindowRecordingByName(edtScreenRecordingWindow.Text, chkScreenRecordingWindow.Checked);  // set to "true" for an exact and case-sensitive match
            //
            // recording window may be designated by name, class or handle by calling EnumerateWindows, which
            //  causes visible window info to be returned in the OnEnumerateWindows event
            // recording window may then be set by handle rather than name with SetWindowRecordingByHandle
            //
            cMainForm.SetEnumerateWindows(edtScreenRecordingWindow.Text, (chkScreenRecordingWindow.Checked));
            if (cMainForm.strScreenRecordingWindow != "")
            {
                cMainForm.axVideoGrabberNET1.EnumerateWindows();
            }
            
		}

		private void chkScreenRecordingWithCursor_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ScreenRecordingWithCursor = chkScreenRecordingWithCursor.Checked;
		}

		private void edtMonitorNumber_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtMonitorNumber.Text)) 
			{
				cMainForm.axVideoGrabberNET1.ScreenRecordingMonitor = Convert.ToInt32 (edtMonitorNumber.Text);
			}
		}

		private void btnMonitorNumberInfo_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show ("  -1 = whole desktop (across monitors)     0 = 1st monitor (default)    1 = 2nd monitor    etc...",
                "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
		}

		private void edtVideoSourceFileOrUrl_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoSource_FileOrURL = edtVideoSourceFileOrUrl.Text;
		}

        private void edtSourceFileOrUrlUserName_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.SetAuthentication (Vidgrab_NET.TxAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        } 

        private void edtSourceFileOrUrlPassword_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.SetAuthentication (Vidgrab_NET.TxAuthenticationType.at_StreamingUrl, edtSourceFileOrUrlUserName.Text, edtSourceFileOrUrlPassword.Text);
        }

        private void rdgPreferredVideoSize_CheckedChanged(object sender, System.EventArgs e)
		{
			int w, h;
			
			if ((sender as RadioButton).Checked) 
			{
				w = 0;
				h = 0;
				switch (Convert.ToInt32 ((sender as Control).Tag))
				{
					case   0: w =   0; h =   0; break;
					case   1: w =  88; h =  60; break;
					case   2: w =  88; h =  72; break;
					case   3: w = 180; h = 120; break;
					case   4: w = 180; h = 144; break;
					case   5: w = 320; h = 240; break;
					case   6: w = 352; h = 288; break;
					case   7: w = 640; h = 480; break;
					case   8: w = 720; h = 480; break;
					case   9: w = 720; h = 576; break;
					case  10: w = 768; h = 576; break;
					default : w =   0; h =   0; break;
				}
				cMainForm.axVideoGrabberNET1.UseNearestVideoSize(w, h, chkStretchPreferredVideoSize.Checked); // disables the nearest size feature, uses the device's VideoSize index in the VideoSizes list
				cboVideoSizes.Enabled = true;
			}
		}

		private void chk4InputsLayout_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk4InputsLayout.Checked) 
			{
				cMainForm.axVideoGrabberNET1.MultiplexedRole = Vidgrab_NET.TxMultiplexedRole.mr_MultiplexedMosaic4;
			}
			else 
			{
				cMainForm.axVideoGrabberNET1.MultiplexedRole = Vidgrab_NET.TxMultiplexedRole.mr_NotMultiplexed;
			}
		}

		private void chkMultiplexedInputEmulation_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MultiplexedInputEmulation = chk4InputsLayout.Checked;
		}

		private void btnSpecialControls_Click(object sender, System.EventArgs e)
		{
			frmMiscSpecialControl.Show();
		}

		private void btnVideoQualityDialog_Click(object sender, System.EventArgs e)
		{
			frmMiscVideoQuality.Show();
		}

		private void btnCameraControlDialog_Click(object sender, System.EventArgs e)
		{
			frmMiscCameraControl.Show();
		}

		private void btnVideoControlDialog_Click(object sender, System.EventArgs e)
		{
			frmMiscVideoControl.Show();
		}

		private void btnDVCamcorderControl_Click(object sender, System.EventArgs e)
		{
			frmMiscDVCommands.Show();
		}

		private void VideoSource_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}
	}
}
