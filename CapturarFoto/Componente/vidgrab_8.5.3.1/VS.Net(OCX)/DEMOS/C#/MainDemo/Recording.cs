using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Recording.
	/// </summary>
	public class Recording : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        public Button btnCreatePreallocFileNow;
        public TextBox edtPreallocSize;
        public TextBox edtRecordingFileName;
        public Button btnMoreInfo;
        public Button btnStartRecordingImmediately;
        public Button btnStartRecordingControlled;
        public Button btnStopRecording;
        public Button btnRenewRecordingFile;
        public GroupBox rdgRecordingMethod;
        internal Button btnSendToDVinfo;
        internal Button btnASFinfo;
        public RadioButton rdgRecordingMethodSendToDV;
        public RadioButton rdgRecordingMethodAVI;
        public RadioButton rdgRecordingMethodWMV;
        public CheckBox chkAudioRecording;
        public ComboBox cboAudioFormats;
        public CheckBox chkPreserveNativeFormat;
        public CheckBox chkAVISaveToThisFile;
        public CheckBox chkOpenDML;
        public CheckBox chkPreallocFile;
        public Label Label13;
        public Label Label15;
        internal Timer timStartRecordingControlled;
        internal GroupBox rdgRecordingTimer;
        internal RadioButton rdgRecordingTimer4;
        internal RadioButton rdgRecordingTimer3;
        internal RadioButton rdgRecordingTimer2;
        internal RadioButton rdgRecordingTimer1;
        internal CheckBox chkScreenRecordWindow;
        internal Label lblStartRecordingControlled;
        internal TextBox edtRecordingTimer;
        private RadioButton rdgRecordingMethodMKV;
        private RadioButton rdgRecordingMethodMP4;
        private RadioButton rdgRecordingMethodFLV;
        private RadioButton rdgRecordingMethod_WebM;
        private RadioButton rdgRecordingMethod_Multiplexer;
        private RadioButton rdgRecordingMethod_MPG;
        public Button btnResumeRecording;
        public Button btnPauseRecording;
        internal CheckBox chkRecordingOnMotion;
        internal CheckBox chkPauseCreatesNewFile;
        public CheckBox chkRecordingCanPause;
        public GroupBox rdgCompressMode;
        public RadioButton rdgCompressModeNo;
        public RadioButton rdgCompressModeAfterCapture;
        public RadioButton rdgCompressModeOnTheFly;
        public GroupBox rdgCompressType;
        public RadioButton rdgCompressTypeAudio;
        public RadioButton rdgCompressTypeAudioVideo;
        public RadioButton rdgCompressTypeVideo;
        public Button btnReloadAudioCompressorSettings;
        public Button btnSaveAudioCompressorSettings;
        public Button btnReloadVideoCompressorSettings;
        public Button btnSaveVideoCompressorSettings;
        public ComboBox cboVideoCompressors;
        public Button btnVideoCompressorSettings;
        public ComboBox cboAudioCompressors;
        public Button btnAudioCompressorSettings;
        public Label Label1;
        public Label Label2;
        public ComboBox cboMultiplexers;
        public Label label44;
        internal Button btnCodecExamples;
        public Button btnMultiplexerSettings;
		private System.ComponentModel.IContainer components;

		public Recording()
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
            this.btnCreatePreallocFileNow = new System.Windows.Forms.Button();
            this.edtPreallocSize = new System.Windows.Forms.TextBox();
            this.edtRecordingFileName = new System.Windows.Forms.TextBox();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.btnStartRecordingImmediately = new System.Windows.Forms.Button();
            this.btnStartRecordingControlled = new System.Windows.Forms.Button();
            this.btnStopRecording = new System.Windows.Forms.Button();
            this.btnRenewRecordingFile = new System.Windows.Forms.Button();
            this.rdgRecordingMethod = new System.Windows.Forms.GroupBox();
            this.rdgRecordingMethod_Multiplexer = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethod_MPG = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethod_WebM = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodMP4 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodFLV = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodMKV = new System.Windows.Forms.RadioButton();
            this.btnSendToDVinfo = new System.Windows.Forms.Button();
            this.btnASFinfo = new System.Windows.Forms.Button();
            this.rdgRecordingMethodSendToDV = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodAVI = new System.Windows.Forms.RadioButton();
            this.rdgRecordingMethodWMV = new System.Windows.Forms.RadioButton();
            this.chkAudioRecording = new System.Windows.Forms.CheckBox();
            this.cboAudioFormats = new System.Windows.Forms.ComboBox();
            this.chkPreserveNativeFormat = new System.Windows.Forms.CheckBox();
            this.chkAVISaveToThisFile = new System.Windows.Forms.CheckBox();
            this.chkOpenDML = new System.Windows.Forms.CheckBox();
            this.chkPreallocFile = new System.Windows.Forms.CheckBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.timStartRecordingControlled = new System.Windows.Forms.Timer(this.components);
            this.rdgRecordingTimer = new System.Windows.Forms.GroupBox();
            this.rdgRecordingTimer4 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer3 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer2 = new System.Windows.Forms.RadioButton();
            this.rdgRecordingTimer1 = new System.Windows.Forms.RadioButton();
            this.chkScreenRecordWindow = new System.Windows.Forms.CheckBox();
            this.lblStartRecordingControlled = new System.Windows.Forms.Label();
            this.edtRecordingTimer = new System.Windows.Forms.TextBox();
            this.btnResumeRecording = new System.Windows.Forms.Button();
            this.btnPauseRecording = new System.Windows.Forms.Button();
            this.chkRecordingOnMotion = new System.Windows.Forms.CheckBox();
            this.chkPauseCreatesNewFile = new System.Windows.Forms.CheckBox();
            this.chkRecordingCanPause = new System.Windows.Forms.CheckBox();
            this.rdgCompressMode = new System.Windows.Forms.GroupBox();
            this.rdgCompressModeNo = new System.Windows.Forms.RadioButton();
            this.rdgCompressModeAfterCapture = new System.Windows.Forms.RadioButton();
            this.rdgCompressModeOnTheFly = new System.Windows.Forms.RadioButton();
            this.rdgCompressType = new System.Windows.Forms.GroupBox();
            this.rdgCompressTypeAudio = new System.Windows.Forms.RadioButton();
            this.rdgCompressTypeAudioVideo = new System.Windows.Forms.RadioButton();
            this.rdgCompressTypeVideo = new System.Windows.Forms.RadioButton();
            this.btnReloadAudioCompressorSettings = new System.Windows.Forms.Button();
            this.btnSaveAudioCompressorSettings = new System.Windows.Forms.Button();
            this.btnReloadVideoCompressorSettings = new System.Windows.Forms.Button();
            this.btnSaveVideoCompressorSettings = new System.Windows.Forms.Button();
            this.cboVideoCompressors = new System.Windows.Forms.ComboBox();
            this.btnVideoCompressorSettings = new System.Windows.Forms.Button();
            this.cboAudioCompressors = new System.Windows.Forms.ComboBox();
            this.btnAudioCompressorSettings = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cboMultiplexers = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.btnCodecExamples = new System.Windows.Forms.Button();
            this.btnMultiplexerSettings = new System.Windows.Forms.Button();
            this.rdgRecordingMethod.SuspendLayout();
            this.rdgRecordingTimer.SuspendLayout();
            this.rdgCompressMode.SuspendLayout();
            this.rdgCompressType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreatePreallocFileNow
            // 
            this.btnCreatePreallocFileNow.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreatePreallocFileNow.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCreatePreallocFileNow.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePreallocFileNow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreatePreallocFileNow.Location = new System.Drawing.Point(255, 138);
            this.btnCreatePreallocFileNow.Name = "btnCreatePreallocFileNow";
            this.btnCreatePreallocFileNow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCreatePreallocFileNow.Size = new System.Drawing.Size(140, 23);
            this.btnCreatePreallocFileNow.TabIndex = 43;
            this.btnCreatePreallocFileNow.Text = "create preallocated file";
            this.btnCreatePreallocFileNow.UseVisualStyleBackColor = false;
            this.btnCreatePreallocFileNow.Click += new System.EventHandler(this.btnCreatePreallocFileNow_Click);
            // 
            // edtPreallocSize
            // 
            this.edtPreallocSize.AcceptsReturn = true;
            this.edtPreallocSize.BackColor = System.Drawing.SystemColors.Window;
            this.edtPreallocSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPreallocSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPreallocSize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPreallocSize.Location = new System.Drawing.Point(163, 141);
            this.edtPreallocSize.MaxLength = 0;
            this.edtPreallocSize.Name = "edtPreallocSize";
            this.edtPreallocSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPreallocSize.Size = new System.Drawing.Size(39, 20);
            this.edtPreallocSize.TabIndex = 44;
            this.edtPreallocSize.Text = "100";
            this.edtPreallocSize.TextChanged += new System.EventHandler(this.edtPreallocSize_TextChanged);
            // 
            // edtRecordingFileName
            // 
            this.edtRecordingFileName.AcceptsReturn = true;
            this.edtRecordingFileName.BackColor = System.Drawing.SystemColors.Window;
            this.edtRecordingFileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtRecordingFileName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtRecordingFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtRecordingFileName.Location = new System.Drawing.Point(268, 107);
            this.edtRecordingFileName.MaxLength = 0;
            this.edtRecordingFileName.Name = "edtRecordingFileName";
            this.edtRecordingFileName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtRecordingFileName.Size = new System.Drawing.Size(127, 20);
            this.edtRecordingFileName.TabIndex = 47;
            this.edtRecordingFileName.Text = "CaptureFile01.wmv";
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackColor = System.Drawing.SystemColors.Control;
            this.btnMoreInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMoreInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMoreInfo.Location = new System.Drawing.Point(167, 49);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMoreInfo.Size = new System.Drawing.Size(18, 20);
            this.btnMoreInfo.TabIndex = 61;
            this.btnMoreInfo.Text = "?";
            this.btnMoreInfo.UseVisualStyleBackColor = false;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // btnStartRecordingImmediately
            // 
            this.btnStartRecordingImmediately.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartRecordingImmediately.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartRecordingImmediately.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRecordingImmediately.ForeColor = System.Drawing.Color.Red;
            this.btnStartRecordingImmediately.Location = new System.Drawing.Point(1, 4);
            this.btnStartRecordingImmediately.Name = "btnStartRecordingImmediately";
            this.btnStartRecordingImmediately.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartRecordingImmediately.Size = new System.Drawing.Size(105, 24);
            this.btnStartRecordingImmediately.TabIndex = 58;
            this.btnStartRecordingImmediately.Text = "start (immediately)";
            this.btnStartRecordingImmediately.UseVisualStyleBackColor = false;
            this.btnStartRecordingImmediately.Click += new System.EventHandler(this.btnStartRecordingImmediately_Click);
            // 
            // btnStartRecordingControlled
            // 
            this.btnStartRecordingControlled.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartRecordingControlled.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartRecordingControlled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartRecordingControlled.ForeColor = System.Drawing.Color.Red;
            this.btnStartRecordingControlled.Location = new System.Drawing.Point(110, 4);
            this.btnStartRecordingControlled.Name = "btnStartRecordingControlled";
            this.btnStartRecordingControlled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartRecordingControlled.Size = new System.Drawing.Size(97, 24);
            this.btnStartRecordingControlled.TabIndex = 57;
            this.btnStartRecordingControlled.Text = "start (controlled)";
            this.btnStartRecordingControlled.UseVisualStyleBackColor = false;
            this.btnStartRecordingControlled.Click += new System.EventHandler(this.btnStartRecordingControlled_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopRecording.Location = new System.Drawing.Point(210, 4);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopRecording.Size = new System.Drawing.Size(45, 24);
            this.btnStopRecording.TabIndex = 56;
            this.btnStopRecording.Text = "stop";
            this.btnStopRecording.UseVisualStyleBackColor = false;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // btnRenewRecordingFile
            // 
            this.btnRenewRecordingFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnRenewRecordingFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRenewRecordingFile.Enabled = false;
            this.btnRenewRecordingFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenewRecordingFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRenewRecordingFile.Location = new System.Drawing.Point(258, 4);
            this.btnRenewRecordingFile.Name = "btnRenewRecordingFile";
            this.btnRenewRecordingFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRenewRecordingFile.Size = new System.Drawing.Size(138, 24);
            this.btnRenewRecordingFile.TabIndex = 55;
            this.btnRenewRecordingFile.Text = "new file during recording";
            this.btnRenewRecordingFile.UseVisualStyleBackColor = false;
            this.btnRenewRecordingFile.Click += new System.EventHandler(this.btnRenewRecordingFile_Click);
            // 
            // rdgRecordingMethod
            // 
            this.rdgRecordingMethod.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethod_Multiplexer);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethod_MPG);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethod_WebM);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodMP4);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodFLV);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodMKV);
            this.rdgRecordingMethod.Controls.Add(this.btnSendToDVinfo);
            this.rdgRecordingMethod.Controls.Add(this.btnASFinfo);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodSendToDV);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodAVI);
            this.rdgRecordingMethod.Controls.Add(this.rdgRecordingMethodWMV);
            this.rdgRecordingMethod.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgRecordingMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethod.Location = new System.Drawing.Point(402, 0);
            this.rdgRecordingMethod.Name = "rdgRecordingMethod";
            this.rdgRecordingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethod.Size = new System.Drawing.Size(118, 180);
            this.rdgRecordingMethod.TabIndex = 52;
            this.rdgRecordingMethod.TabStop = false;
            this.rdgRecordingMethod.Text = "recording method";
            // 
            // rdgRecordingMethod_Multiplexer
            // 
            this.rdgRecordingMethod_Multiplexer.AutoSize = true;
            this.rdgRecordingMethod_Multiplexer.Location = new System.Drawing.Point(8, 160);
            this.rdgRecordingMethod_Multiplexer.Name = "rdgRecordingMethod_Multiplexer";
            this.rdgRecordingMethod_Multiplexer.Size = new System.Drawing.Size(109, 18);
            this.rdgRecordingMethod_Multiplexer.TabIndex = 47;
            this.rdgRecordingMethod_Multiplexer.TabStop = true;
            this.rdgRecordingMethod_Multiplexer.Tag = "8";
            this.rdgRecordingMethod_Multiplexer.Text = "Multiplexer(other)";
            this.rdgRecordingMethod_Multiplexer.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethod_MPG
            // 
            this.rdgRecordingMethod_MPG.AutoSize = true;
            this.rdgRecordingMethod_MPG.Location = new System.Drawing.Point(8, 142);
            this.rdgRecordingMethod_MPG.Name = "rdgRecordingMethod_MPG";
            this.rdgRecordingMethod_MPG.Size = new System.Drawing.Size(47, 18);
            this.rdgRecordingMethod_MPG.TabIndex = 46;
            this.rdgRecordingMethod_MPG.TabStop = true;
            this.rdgRecordingMethod_MPG.Tag = "7";
            this.rdgRecordingMethod_MPG.Text = "MPG";
            this.rdgRecordingMethod_MPG.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethod_WebM
            // 
            this.rdgRecordingMethod_WebM.AutoSize = true;
            this.rdgRecordingMethod_WebM.Location = new System.Drawing.Point(8, 124);
            this.rdgRecordingMethod_WebM.Name = "rdgRecordingMethod_WebM";
            this.rdgRecordingMethod_WebM.Size = new System.Drawing.Size(86, 18);
            this.rdgRecordingMethod_WebM.TabIndex = 45;
            this.rdgRecordingMethod_WebM.TabStop = true;
            this.rdgRecordingMethod_WebM.Tag = "6";
            this.rdgRecordingMethod_WebM.Text = "WebM (VP8)";
            this.rdgRecordingMethod_WebM.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodMP4
            // 
            this.rdgRecordingMethodMP4.AutoSize = true;
            this.rdgRecordingMethodMP4.Location = new System.Drawing.Point(8, 106);
            this.rdgRecordingMethodMP4.Name = "rdgRecordingMethodMP4";
            this.rdgRecordingMethodMP4.Size = new System.Drawing.Size(45, 18);
            this.rdgRecordingMethodMP4.TabIndex = 44;
            this.rdgRecordingMethodMP4.TabStop = true;
            this.rdgRecordingMethodMP4.Tag = "5";
            this.rdgRecordingMethodMP4.Text = "MP4";
            this.rdgRecordingMethodMP4.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodFLV
            // 
            this.rdgRecordingMethodFLV.AutoSize = true;
            this.rdgRecordingMethodFLV.Location = new System.Drawing.Point(8, 88);
            this.rdgRecordingMethodFLV.Name = "rdgRecordingMethodFLV";
            this.rdgRecordingMethodFLV.Size = new System.Drawing.Size(44, 18);
            this.rdgRecordingMethodFLV.TabIndex = 43;
            this.rdgRecordingMethodFLV.TabStop = true;
            this.rdgRecordingMethodFLV.Tag = "4";
            this.rdgRecordingMethodFLV.Text = "FLV";
            this.rdgRecordingMethodFLV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodMKV
            // 
            this.rdgRecordingMethodMKV.AutoSize = true;
            this.rdgRecordingMethodMKV.Location = new System.Drawing.Point(8, 70);
            this.rdgRecordingMethodMKV.Name = "rdgRecordingMethodMKV";
            this.rdgRecordingMethodMKV.Size = new System.Drawing.Size(48, 18);
            this.rdgRecordingMethodMKV.TabIndex = 42;
            this.rdgRecordingMethodMKV.TabStop = true;
            this.rdgRecordingMethodMKV.Tag = "3";
            this.rdgRecordingMethodMKV.Text = "MKV";
            this.rdgRecordingMethodMKV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // btnSendToDVinfo
            // 
            this.btnSendToDVinfo.Location = new System.Drawing.Point(90, 54);
            this.btnSendToDVinfo.Name = "btnSendToDVinfo";
            this.btnSendToDVinfo.Size = new System.Drawing.Size(25, 20);
            this.btnSendToDVinfo.TabIndex = 41;
            this.btnSendToDVinfo.Text = "?";
            this.btnSendToDVinfo.Click += new System.EventHandler(this.btnSendToDVinfo_Click);
            // 
            // btnASFinfo
            // 
            this.btnASFinfo.Location = new System.Drawing.Point(90, 35);
            this.btnASFinfo.Name = "btnASFinfo";
            this.btnASFinfo.Size = new System.Drawing.Size(25, 20);
            this.btnASFinfo.TabIndex = 40;
            this.btnASFinfo.Text = "?";
            this.btnASFinfo.Click += new System.EventHandler(this.btnASFinfo_Click);
            // 
            // rdgRecordingMethodSendToDV
            // 
            this.rdgRecordingMethodSendToDV.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodSendToDV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodSendToDV.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgRecordingMethodSendToDV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodSendToDV.Location = new System.Drawing.Point(8, 53);
            this.rdgRecordingMethodSendToDV.Name = "rdgRecordingMethodSendToDV";
            this.rdgRecordingMethodSendToDV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodSendToDV.Size = new System.Drawing.Size(96, 17);
            this.rdgRecordingMethodSendToDV.TabIndex = 39;
            this.rdgRecordingMethodSendToDV.TabStop = true;
            this.rdgRecordingMethodSendToDV.Tag = "2";
            this.rdgRecordingMethodSendToDV.Text = "Send to DV";
            this.rdgRecordingMethodSendToDV.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodSendToDV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodAVI
            // 
            this.rdgRecordingMethodAVI.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodAVI.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodAVI.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgRecordingMethodAVI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodAVI.Location = new System.Drawing.Point(8, 19);
            this.rdgRecordingMethodAVI.Name = "rdgRecordingMethodAVI";
            this.rdgRecordingMethodAVI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodAVI.Size = new System.Drawing.Size(89, 17);
            this.rdgRecordingMethodAVI.TabIndex = 11;
            this.rdgRecordingMethodAVI.TabStop = true;
            this.rdgRecordingMethodAVI.Tag = "0";
            this.rdgRecordingMethodAVI.Text = "AVI or MPEG";
            this.rdgRecordingMethodAVI.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodAVI.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // rdgRecordingMethodWMV
            // 
            this.rdgRecordingMethodWMV.BackColor = System.Drawing.SystemColors.Control;
            this.rdgRecordingMethodWMV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgRecordingMethodWMV.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgRecordingMethodWMV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingMethodWMV.Location = new System.Drawing.Point(8, 36);
            this.rdgRecordingMethodWMV.Name = "rdgRecordingMethodWMV";
            this.rdgRecordingMethodWMV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgRecordingMethodWMV.Size = new System.Drawing.Size(89, 17);
            this.rdgRecordingMethodWMV.TabIndex = 10;
            this.rdgRecordingMethodWMV.TabStop = true;
            this.rdgRecordingMethodWMV.Tag = "1";
            this.rdgRecordingMethodWMV.Text = "ASF (WMV)";
            this.rdgRecordingMethodWMV.UseVisualStyleBackColor = false;
            this.rdgRecordingMethodWMV.CheckedChanged += new System.EventHandler(this.rdgRecordingMethod_CheckedChanged);
            // 
            // chkAudioRecording
            // 
            this.chkAudioRecording.BackColor = System.Drawing.SystemColors.Control;
            this.chkAudioRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAudioRecording.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAudioRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudioRecording.Location = new System.Drawing.Point(1, 50);
            this.chkAudioRecording.Name = "chkAudioRecording";
            this.chkAudioRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAudioRecording.Size = new System.Drawing.Size(153, 17);
            this.chkAudioRecording.TabIndex = 51;
            this.chkAudioRecording.Text = "enable audio recording";
            this.chkAudioRecording.UseVisualStyleBackColor = false;
            this.chkAudioRecording.CheckedChanged += new System.EventHandler(this.chkAudioRecording_CheckedChanged);
            // 
            // cboAudioFormats
            // 
            this.cboAudioFormats.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioFormats.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioFormats.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAudioFormats.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioFormats.Location = new System.Drawing.Point(1, 80);
            this.cboAudioFormats.Name = "cboAudioFormats";
            this.cboAudioFormats.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioFormats.Size = new System.Drawing.Size(184, 22);
            this.cboAudioFormats.TabIndex = 50;
            this.cboAudioFormats.SelectedIndexChanged += new System.EventHandler(this.cboAudioFormats_SelectedIndexChanged);
            // 
            // chkPreserveNativeFormat
            // 
            this.chkPreserveNativeFormat.AutoSize = true;
            this.chkPreserveNativeFormat.BackColor = System.Drawing.SystemColors.Control;
            this.chkPreserveNativeFormat.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPreserveNativeFormat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreserveNativeFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPreserveNativeFormat.Location = new System.Drawing.Point(1, 32);
            this.chkPreserveNativeFormat.Name = "chkPreserveNativeFormat";
            this.chkPreserveNativeFormat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPreserveNativeFormat.Size = new System.Drawing.Size(171, 18);
            this.chkPreserveNativeFormat.TabIndex = 49;
            this.chkPreserveNativeFormat.Text = "RECORD IN NATIVE FORMAT";
            this.chkPreserveNativeFormat.UseVisualStyleBackColor = false;
            this.chkPreserveNativeFormat.CheckedChanged += new System.EventHandler(this.chkPreserveNativeFormat_CheckedChanged);
            // 
            // chkAVISaveToThisFile
            // 
            this.chkAVISaveToThisFile.BackColor = System.Drawing.SystemColors.Control;
            this.chkAVISaveToThisFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAVISaveToThisFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAVISaveToThisFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAVISaveToThisFile.Location = new System.Drawing.Point(1, 107);
            this.chkAVISaveToThisFile.Name = "chkAVISaveToThisFile";
            this.chkAVISaveToThisFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAVISaveToThisFile.Size = new System.Drawing.Size(267, 17);
            this.chkAVISaveToThisFile.TabIndex = 48;
            this.chkAVISaveToThisFile.Text = "do not generate file names automatically, save to:";
            this.chkAVISaveToThisFile.UseVisualStyleBackColor = false;
            // 
            // chkOpenDML
            // 
            this.chkOpenDML.BackColor = System.Drawing.SystemColors.Control;
            this.chkOpenDML.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkOpenDML.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOpenDML.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkOpenDML.Location = new System.Drawing.Point(1, 124);
            this.chkOpenDML.Name = "chkOpenDML";
            this.chkOpenDML.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkOpenDML.Size = new System.Drawing.Size(256, 17);
            this.chkOpenDML.TabIndex = 46;
            this.chkOpenDML.Text = "OpenDML format (avi 2.0, captured file > 1 Gb)";
            this.chkOpenDML.UseVisualStyleBackColor = false;
            this.chkOpenDML.CheckedChanged += new System.EventHandler(this.chkOpenDML_CheckedChanged);
            // 
            // chkPreallocFile
            // 
            this.chkPreallocFile.BackColor = System.Drawing.SystemColors.Control;
            this.chkPreallocFile.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPreallocFile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPreallocFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkPreallocFile.Location = new System.Drawing.Point(1, 140);
            this.chkPreallocFile.Name = "chkPreallocFile";
            this.chkPreallocFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPreallocFile.Size = new System.Drawing.Size(168, 17);
            this.chkPreallocFile.TabIndex = 45;
            this.chkPreallocFile.Text = "use preallocated capture file:";
            this.chkPreallocFile.UseVisualStyleBackColor = false;
            this.chkPreallocFile.CheckedChanged += new System.EventHandler(this.chkPreallocFile_CheckedChanged);
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.SystemColors.Control;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(1, 66);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(72, 17);
            this.Label13.TabIndex = 60;
            this.Label13.Text = "audio format:";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.SystemColors.Control;
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(202, 143);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(52, 18);
            this.Label15.TabIndex = 59;
            this.Label15.Text = "Mb (size)";
            // 
            // timStartRecordingControlled
            // 
            this.timStartRecordingControlled.Interval = 1000;
            this.timStartRecordingControlled.Tick += new System.EventHandler(this.timStartRecordingControlled_Tick);
            // 
            // rdgRecordingTimer
            // 
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer4);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer3);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer2);
            this.rdgRecordingTimer.Controls.Add(this.rdgRecordingTimer1);
            this.rdgRecordingTimer.Controls.Add(this.chkScreenRecordWindow);
            this.rdgRecordingTimer.Controls.Add(this.lblStartRecordingControlled);
            this.rdgRecordingTimer.Controls.Add(this.edtRecordingTimer);
            this.rdgRecordingTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgRecordingTimer.Location = new System.Drawing.Point(191, 29);
            this.rdgRecordingTimer.Name = "rdgRecordingTimer";
            this.rdgRecordingTimer.Size = new System.Drawing.Size(205, 75);
            this.rdgRecordingTimer.TabIndex = 64;
            this.rdgRecordingTimer.TabStop = false;
            this.rdgRecordingTimer.Text = "recording timer";
            // 
            // rdgRecordingTimer4
            // 
            this.rdgRecordingTimer4.Location = new System.Drawing.Point(116, 28);
            this.rdgRecordingTimer4.Name = "rdgRecordingTimer4";
            this.rdgRecordingTimer4.Size = new System.Drawing.Size(84, 17);
            this.rdgRecordingTimer4.TabIndex = 52;
            this.rdgRecordingTimer4.TabStop = true;
            this.rdgRecordingTimer4.Tag = "3";
            this.rdgRecordingTimer4.Text = "start after...";
            this.rdgRecordingTimer4.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer4_CheckedChanged);
            // 
            // rdgRecordingTimer3
            // 
            this.rdgRecordingTimer3.Location = new System.Drawing.Point(116, 13);
            this.rdgRecordingTimer3.Name = "rdgRecordingTimer3";
            this.rdgRecordingTimer3.Size = new System.Drawing.Size(84, 17);
            this.rdgRecordingTimer3.TabIndex = 51;
            this.rdgRecordingTimer3.TabStop = true;
            this.rdgRecordingTimer3.Tag = "2";
            this.rdgRecordingTimer3.Text = "stop after...";
            this.rdgRecordingTimer3.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer3_CheckedChanged);
            // 
            // rdgRecordingTimer2
            // 
            this.rdgRecordingTimer2.Location = new System.Drawing.Point(9, 28);
            this.rdgRecordingTimer2.Name = "rdgRecordingTimer2";
            this.rdgRecordingTimer2.Size = new System.Drawing.Size(106, 18);
            this.rdgRecordingTimer2.TabIndex = 50;
            this.rdgRecordingTimer2.TabStop = true;
            this.rdgRecordingTimer2.Tag = "1";
            this.rdgRecordingTimer2.Text = "new file every...";
            this.rdgRecordingTimer2.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer2_CheckedChanged);
            // 
            // rdgRecordingTimer1
            // 
            this.rdgRecordingTimer1.Location = new System.Drawing.Point(9, 13);
            this.rdgRecordingTimer1.Name = "rdgRecordingTimer1";
            this.rdgRecordingTimer1.Size = new System.Drawing.Size(97, 17);
            this.rdgRecordingTimer1.TabIndex = 49;
            this.rdgRecordingTimer1.TabStop = true;
            this.rdgRecordingTimer1.Tag = "0";
            this.rdgRecordingTimer1.Text = "disabled";
            this.rdgRecordingTimer1.CheckedChanged += new System.EventHandler(this.rdgRecordingTimer1_CheckedChanged);
            // 
            // chkScreenRecordWindow
            // 
            this.chkScreenRecordWindow.Checked = true;
            this.chkScreenRecordWindow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScreenRecordWindow.Enabled = false;
            this.chkScreenRecordWindow.Location = new System.Drawing.Point(93, 41);
            this.chkScreenRecordWindow.Name = "chkScreenRecordWindow";
            this.chkScreenRecordWindow.Size = new System.Drawing.Size(105, 32);
            this.chkScreenRecordWindow.TabIndex = 48;
            this.chkScreenRecordWindow.Text = "e.g. source = screen window";
            this.chkScreenRecordWindow.CheckedChanged += new System.EventHandler(this.chkScreenRecordWindow_CheckedChanged);
            // 
            // lblStartRecordingControlled
            // 
            this.lblStartRecordingControlled.AutoSize = true;
            this.lblStartRecordingControlled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStartRecordingControlled.Location = new System.Drawing.Point(38, 50);
            this.lblStartRecordingControlled.Name = "lblStartRecordingControlled";
            this.lblStartRecordingControlled.Size = new System.Drawing.Size(47, 13);
            this.lblStartRecordingControlled.TabIndex = 46;
            this.lblStartRecordingControlled.Text = "seconds";
            // 
            // edtRecordingTimer
            // 
            this.edtRecordingTimer.Location = new System.Drawing.Point(8, 48);
            this.edtRecordingTimer.Name = "edtRecordingTimer";
            this.edtRecordingTimer.Size = new System.Drawing.Size(28, 20);
            this.edtRecordingTimer.TabIndex = 45;
            this.edtRecordingTimer.Text = "0";
            this.edtRecordingTimer.TextChanged += new System.EventHandler(this.edtRecordingTimer_TextChanged);
            // 
            // btnResumeRecording
            // 
            this.btnResumeRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnResumeRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResumeRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumeRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResumeRecording.Location = new System.Drawing.Point(587, 63);
            this.btnResumeRecording.Name = "btnResumeRecording";
            this.btnResumeRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResumeRecording.Size = new System.Drawing.Size(58, 20);
            this.btnResumeRecording.TabIndex = 65;
            this.btnResumeRecording.Text = "resume";
            this.btnResumeRecording.UseVisualStyleBackColor = false;
            this.btnResumeRecording.Click += new System.EventHandler(this.btnResumeRecording_Click);
            // 
            // btnPauseRecording
            // 
            this.btnPauseRecording.BackColor = System.Drawing.SystemColors.Control;
            this.btnPauseRecording.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPauseRecording.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPauseRecording.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPauseRecording.Location = new System.Drawing.Point(523, 63);
            this.btnPauseRecording.Name = "btnPauseRecording";
            this.btnPauseRecording.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPauseRecording.Size = new System.Drawing.Size(58, 20);
            this.btnPauseRecording.TabIndex = 66;
            this.btnPauseRecording.Text = "pause";
            this.btnPauseRecording.UseVisualStyleBackColor = false;
            this.btnPauseRecording.Click += new System.EventHandler(this.btnPauseRecording_Click);
            // 
            // chkRecordingOnMotion
            // 
            this.chkRecordingOnMotion.Location = new System.Drawing.Point(523, 39);
            this.chkRecordingOnMotion.Name = "chkRecordingOnMotion";
            this.chkRecordingOnMotion.Size = new System.Drawing.Size(148, 20);
            this.chkRecordingOnMotion.TabIndex = 69;
            this.chkRecordingOnMotion.Text = "pause/resume on motion";
            this.chkRecordingOnMotion.Click += new System.EventHandler(this.chkRecordingOnMotion_CheckedChanged);
            // 
            // chkPauseCreatesNewFile
            // 
            this.chkPauseCreatesNewFile.Location = new System.Drawing.Point(523, 20);
            this.chkPauseCreatesNewFile.Name = "chkPauseCreatesNewFile";
            this.chkPauseCreatesNewFile.Size = new System.Drawing.Size(152, 20);
            this.chkPauseCreatesNewFile.TabIndex = 68;
            this.chkPauseCreatesNewFile.Text = "pause creates new file";
            this.chkPauseCreatesNewFile.Click += new System.EventHandler(this.chkPauseCreatesNewFile_CheckedChanged);
            // 
            // chkRecordingCanPause
            // 
            this.chkRecordingCanPause.BackColor = System.Drawing.SystemColors.Control;
            this.chkRecordingCanPause.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRecordingCanPause.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRecordingCanPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRecordingCanPause.Location = new System.Drawing.Point(523, 3);
            this.chkRecordingCanPause.Name = "chkRecordingCanPause";
            this.chkRecordingCanPause.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRecordingCanPause.Size = new System.Drawing.Size(152, 20);
            this.chkRecordingCanPause.TabIndex = 67;
            this.chkRecordingCanPause.Text = "recording can pause";
            this.chkRecordingCanPause.UseVisualStyleBackColor = false;
            this.chkRecordingCanPause.Click += new System.EventHandler(this.chkRecordingCanPause_CheckedChanged);
            // 
            // rdgCompressMode
            // 
            this.rdgCompressMode.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeNo);
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeAfterCapture);
            this.rdgCompressMode.Controls.Add(this.rdgCompressModeOnTheFly);
            this.rdgCompressMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressMode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressMode.Location = new System.Drawing.Point(664, 0);
            this.rdgCompressMode.Name = "rdgCompressMode";
            this.rdgCompressMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressMode.Size = new System.Drawing.Size(102, 70);
            this.rdgCompressMode.TabIndex = 71;
            this.rdgCompressMode.TabStop = false;
            this.rdgCompressMode.Text = "compress. mode";
            // 
            // rdgCompressModeNo
            // 
            this.rdgCompressModeNo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeNo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressModeNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeNo.Location = new System.Drawing.Point(8, 16);
            this.rdgCompressModeNo.Name = "rdgCompressModeNo";
            this.rdgCompressModeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeNo.Size = new System.Drawing.Size(57, 17);
            this.rdgCompressModeNo.TabIndex = 24;
            this.rdgCompressModeNo.TabStop = true;
            this.rdgCompressModeNo.Tag = "0";
            this.rdgCompressModeNo.Text = "no";
            this.rdgCompressModeNo.UseVisualStyleBackColor = false;
            this.rdgCompressModeNo.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressModeAfterCapture
            // 
            this.rdgCompressModeAfterCapture.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeAfterCapture.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeAfterCapture.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressModeAfterCapture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeAfterCapture.Location = new System.Drawing.Point(8, 48);
            this.rdgCompressModeAfterCapture.Name = "rdgCompressModeAfterCapture";
            this.rdgCompressModeAfterCapture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeAfterCapture.Size = new System.Drawing.Size(88, 17);
            this.rdgCompressModeAfterCapture.TabIndex = 23;
            this.rdgCompressModeAfterCapture.TabStop = true;
            this.rdgCompressModeAfterCapture.Tag = "2";
            this.rdgCompressModeAfterCapture.Text = "after capture";
            this.rdgCompressModeAfterCapture.UseVisualStyleBackColor = false;
            this.rdgCompressModeAfterCapture.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressModeOnTheFly
            // 
            this.rdgCompressModeOnTheFly.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressModeOnTheFly.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressModeOnTheFly.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressModeOnTheFly.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressModeOnTheFly.Location = new System.Drawing.Point(8, 32);
            this.rdgCompressModeOnTheFly.Name = "rdgCompressModeOnTheFly";
            this.rdgCompressModeOnTheFly.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressModeOnTheFly.Size = new System.Drawing.Size(81, 17);
            this.rdgCompressModeOnTheFly.TabIndex = 22;
            this.rdgCompressModeOnTheFly.TabStop = true;
            this.rdgCompressModeOnTheFly.Tag = "1";
            this.rdgCompressModeOnTheFly.Text = "on the fly";
            this.rdgCompressModeOnTheFly.UseVisualStyleBackColor = false;
            this.rdgCompressModeOnTheFly.CheckedChanged += new System.EventHandler(this.rdgCompressMode_CheckedChanged);
            // 
            // rdgCompressType
            // 
            this.rdgCompressType.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeAudio);
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeAudioVideo);
            this.rdgCompressType.Controls.Add(this.rdgCompressTypeVideo);
            this.rdgCompressType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressType.Location = new System.Drawing.Point(664, 71);
            this.rdgCompressType.Name = "rdgCompressType";
            this.rdgCompressType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressType.Size = new System.Drawing.Size(102, 70);
            this.rdgCompressType.TabIndex = 70;
            this.rdgCompressType.TabStop = false;
            this.rdgCompressType.Text = "compress. type";
            // 
            // rdgCompressTypeAudio
            // 
            this.rdgCompressTypeAudio.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeAudio.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeAudio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressTypeAudio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeAudio.Location = new System.Drawing.Point(8, 32);
            this.rdgCompressTypeAudio.Name = "rdgCompressTypeAudio";
            this.rdgCompressTypeAudio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeAudio.Size = new System.Drawing.Size(81, 17);
            this.rdgCompressTypeAudio.TabIndex = 20;
            this.rdgCompressTypeAudio.TabStop = true;
            this.rdgCompressTypeAudio.Tag = "1";
            this.rdgCompressTypeAudio.Text = "audio";
            this.rdgCompressTypeAudio.UseVisualStyleBackColor = false;
            this.rdgCompressTypeAudio.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // rdgCompressTypeAudioVideo
            // 
            this.rdgCompressTypeAudioVideo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeAudioVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeAudioVideo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressTypeAudioVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeAudioVideo.Location = new System.Drawing.Point(8, 48);
            this.rdgCompressTypeAudioVideo.Name = "rdgCompressTypeAudioVideo";
            this.rdgCompressTypeAudioVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeAudioVideo.Size = new System.Drawing.Size(89, 17);
            this.rdgCompressTypeAudioVideo.TabIndex = 19;
            this.rdgCompressTypeAudioVideo.TabStop = true;
            this.rdgCompressTypeAudioVideo.Tag = "2";
            this.rdgCompressTypeAudioVideo.Text = "audio + video";
            this.rdgCompressTypeAudioVideo.UseVisualStyleBackColor = false;
            this.rdgCompressTypeAudioVideo.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // rdgCompressTypeVideo
            // 
            this.rdgCompressTypeVideo.BackColor = System.Drawing.SystemColors.Control;
            this.rdgCompressTypeVideo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgCompressTypeVideo.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgCompressTypeVideo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgCompressTypeVideo.Location = new System.Drawing.Point(8, 16);
            this.rdgCompressTypeVideo.Name = "rdgCompressTypeVideo";
            this.rdgCompressTypeVideo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgCompressTypeVideo.Size = new System.Drawing.Size(57, 17);
            this.rdgCompressTypeVideo.TabIndex = 18;
            this.rdgCompressTypeVideo.TabStop = true;
            this.rdgCompressTypeVideo.Tag = "0";
            this.rdgCompressTypeVideo.Text = "video";
            this.rdgCompressTypeVideo.UseVisualStyleBackColor = false;
            this.rdgCompressTypeVideo.CheckedChanged += new System.EventHandler(this.rdgCompressType_CheckedChanged);
            // 
            // btnReloadAudioCompressorSettings
            // 
            this.btnReloadAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnReloadAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReloadAudioCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadAudioCompressorSettings.Location = new System.Drawing.Point(888, 90);
            this.btnReloadAudioCompressorSettings.Name = "btnReloadAudioCompressorSettings";
            this.btnReloadAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReloadAudioCompressorSettings.Size = new System.Drawing.Size(50, 18);
            this.btnReloadAudioCompressorSettings.TabIndex = 81;
            this.btnReloadAudioCompressorSettings.Text = "reload";
            this.btnReloadAudioCompressorSettings.UseVisualStyleBackColor = false;
            this.btnReloadAudioCompressorSettings.Click += new System.EventHandler(this.btnReloadAudioCompressorSettings_Click);
            // 
            // btnSaveAudioCompressorSettings
            // 
            this.btnSaveAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveAudioCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveAudioCompressorSettings.Location = new System.Drawing.Point(839, 90);
            this.btnSaveAudioCompressorSettings.Name = "btnSaveAudioCompressorSettings";
            this.btnSaveAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveAudioCompressorSettings.Size = new System.Drawing.Size(50, 18);
            this.btnSaveAudioCompressorSettings.TabIndex = 80;
            this.btnSaveAudioCompressorSettings.Text = "save";
            this.btnSaveAudioCompressorSettings.UseVisualStyleBackColor = false;
            this.btnSaveAudioCompressorSettings.Click += new System.EventHandler(this.btnSaveAudioCompressorSettings_Click);
            // 
            // btnReloadVideoCompressorSettings
            // 
            this.btnReloadVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnReloadVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReloadVideoCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReloadVideoCompressorSettings.Location = new System.Drawing.Point(888, 36);
            this.btnReloadVideoCompressorSettings.Name = "btnReloadVideoCompressorSettings";
            this.btnReloadVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReloadVideoCompressorSettings.Size = new System.Drawing.Size(50, 18);
            this.btnReloadVideoCompressorSettings.TabIndex = 79;
            this.btnReloadVideoCompressorSettings.Text = "reload";
            this.btnReloadVideoCompressorSettings.UseVisualStyleBackColor = false;
            this.btnReloadVideoCompressorSettings.Click += new System.EventHandler(this.btnReloadVideoCompressorSettings_Click);
            // 
            // btnSaveVideoCompressorSettings
            // 
            this.btnSaveVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveVideoCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSaveVideoCompressorSettings.Location = new System.Drawing.Point(839, 36);
            this.btnSaveVideoCompressorSettings.Name = "btnSaveVideoCompressorSettings";
            this.btnSaveVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSaveVideoCompressorSettings.Size = new System.Drawing.Size(50, 18);
            this.btnSaveVideoCompressorSettings.TabIndex = 78;
            this.btnSaveVideoCompressorSettings.Text = "save";
            this.btnSaveVideoCompressorSettings.UseVisualStyleBackColor = false;
            this.btnSaveVideoCompressorSettings.Click += new System.EventHandler(this.btnSaveVideoCompressorSettings_Click);
            // 
            // cboVideoCompressors
            // 
            this.cboVideoCompressors.BackColor = System.Drawing.SystemColors.Window;
            this.cboVideoCompressors.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboVideoCompressors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVideoCompressors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboVideoCompressors.Location = new System.Drawing.Point(772, 14);
            this.cboVideoCompressors.Name = "cboVideoCompressors";
            this.cboVideoCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboVideoCompressors.Size = new System.Drawing.Size(166, 22);
            this.cboVideoCompressors.TabIndex = 75;
            this.cboVideoCompressors.SelectedIndexChanged += new System.EventHandler(this.cboVideoCompressors_SelectedIndexChanged);
            // 
            // btnVideoCompressorSettings
            // 
            this.btnVideoCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnVideoCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVideoCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideoCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVideoCompressorSettings.Location = new System.Drawing.Point(772, 36);
            this.btnVideoCompressorSettings.Name = "btnVideoCompressorSettings";
            this.btnVideoCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnVideoCompressorSettings.Size = new System.Drawing.Size(61, 18);
            this.btnVideoCompressorSettings.TabIndex = 74;
            this.btnVideoCompressorSettings.Text = "settings";
            this.btnVideoCompressorSettings.UseVisualStyleBackColor = false;
            this.btnVideoCompressorSettings.Click += new System.EventHandler(this.btnVideoCompressorSettings_Click);
            // 
            // cboAudioCompressors
            // 
            this.cboAudioCompressors.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioCompressors.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioCompressors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAudioCompressors.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioCompressors.Location = new System.Drawing.Point(772, 68);
            this.cboAudioCompressors.Name = "cboAudioCompressors";
            this.cboAudioCompressors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioCompressors.Size = new System.Drawing.Size(166, 22);
            this.cboAudioCompressors.TabIndex = 73;
            this.cboAudioCompressors.SelectedIndexChanged += new System.EventHandler(this.cboAudioCompressors_SelectedIndexChanged);
            // 
            // btnAudioCompressorSettings
            // 
            this.btnAudioCompressorSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnAudioCompressorSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAudioCompressorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAudioCompressorSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAudioCompressorSettings.Location = new System.Drawing.Point(772, 90);
            this.btnAudioCompressorSettings.Name = "btnAudioCompressorSettings";
            this.btnAudioCompressorSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAudioCompressorSettings.Size = new System.Drawing.Size(61, 18);
            this.btnAudioCompressorSettings.TabIndex = 72;
            this.btnAudioCompressorSettings.Text = "settings";
            this.btnAudioCompressorSettings.UseVisualStyleBackColor = false;
            this.btnAudioCompressorSettings.Click += new System.EventHandler(this.btnAudioCompressorSettings_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(772, 0);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(113, 17);
            this.Label1.TabIndex = 77;
            this.Label1.Text = "video compressor";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(772, 54);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(113, 17);
            this.Label2.TabIndex = 76;
            this.Label2.Text = "audio compressor";
            // 
            // cboMultiplexers
            // 
            this.cboMultiplexers.BackColor = System.Drawing.SystemColors.Window;
            this.cboMultiplexers.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboMultiplexers.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMultiplexers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboMultiplexers.Location = new System.Drawing.Point(772, 122);
            this.cboMultiplexers.Name = "cboMultiplexers";
            this.cboMultiplexers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboMultiplexers.Size = new System.Drawing.Size(166, 22);
            this.cboMultiplexers.TabIndex = 82;
            this.cboMultiplexers.SelectedIndexChanged += new System.EventHandler(this.cboMultiplexers_SelectedIndexChanged);
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.SystemColors.Control;
            this.label44.Cursor = System.Windows.Forms.Cursors.Default;
            this.label44.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label44.Location = new System.Drawing.Point(772, 108);
            this.label44.Name = "label44";
            this.label44.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label44.Size = new System.Drawing.Size(166, 18);
            this.label44.TabIndex = 83;
            this.label44.Text = "multiplexer (default = -1)";
            // 
            // btnCodecExamples
            // 
            this.btnCodecExamples.Location = new System.Drawing.Point(598, 160);
            this.btnCodecExamples.Name = "btnCodecExamples";
            this.btnCodecExamples.Size = new System.Drawing.Size(340, 20);
            this.btnCodecExamples.TabIndex = 84;
            this.btnCodecExamples.Text = "Examples of compatible codecs depending on the recording method";
            this.btnCodecExamples.Click += new System.EventHandler(this.btnCodecExamples_Click);
            // 
            // btnMultiplexerSettings
            // 
            this.btnMultiplexerSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiplexerSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMultiplexerSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplexerSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMultiplexerSettings.Location = new System.Drawing.Point(772, 143);
            this.btnMultiplexerSettings.Name = "btnMultiplexerSettings";
            this.btnMultiplexerSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMultiplexerSettings.Size = new System.Drawing.Size(61, 18);
            this.btnMultiplexerSettings.TabIndex = 85;
            this.btnMultiplexerSettings.Text = "settings";
            this.btnMultiplexerSettings.UseVisualStyleBackColor = false;
            this.btnMultiplexerSettings.Click += new System.EventHandler(this.btnMultiplexerSettings_Click);
            // 
            // Recording
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(958, 185);
            this.ControlBox = false;
            this.Controls.Add(this.btnMultiplexerSettings);
            this.Controls.Add(this.btnCodecExamples);
            this.Controls.Add(this.cboMultiplexers);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.btnReloadAudioCompressorSettings);
            this.Controls.Add(this.btnSaveAudioCompressorSettings);
            this.Controls.Add(this.btnReloadVideoCompressorSettings);
            this.Controls.Add(this.btnSaveVideoCompressorSettings);
            this.Controls.Add(this.cboVideoCompressors);
            this.Controls.Add(this.btnVideoCompressorSettings);
            this.Controls.Add(this.cboAudioCompressors);
            this.Controls.Add(this.btnAudioCompressorSettings);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.rdgCompressMode);
            this.Controls.Add(this.rdgCompressType);
            this.Controls.Add(this.btnResumeRecording);
            this.Controls.Add(this.btnPauseRecording);
            this.Controls.Add(this.rdgRecordingTimer);
            this.Controls.Add(this.btnCreatePreallocFileNow);
            this.Controls.Add(this.edtPreallocSize);
            this.Controls.Add(this.edtRecordingFileName);
            this.Controls.Add(this.btnMoreInfo);
            this.Controls.Add(this.btnStartRecordingImmediately);
            this.Controls.Add(this.btnStartRecordingControlled);
            this.Controls.Add(this.btnStopRecording);
            this.Controls.Add(this.btnRenewRecordingFile);
            this.Controls.Add(this.rdgRecordingMethod);
            this.Controls.Add(this.chkAudioRecording);
            this.Controls.Add(this.cboAudioFormats);
            this.Controls.Add(this.chkPreserveNativeFormat);
            this.Controls.Add(this.chkAVISaveToThisFile);
            this.Controls.Add(this.chkOpenDML);
            this.Controls.Add(this.chkPreallocFile);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.chkPauseCreatesNewFile);
            this.Controls.Add(this.chkRecordingOnMotion);
            this.Controls.Add(this.chkRecordingCanPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Recording";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Recording_VisibleChanged);
            this.rdgRecordingMethod.ResumeLayout(false);
            this.rdgRecordingMethod.PerformLayout();
            this.rdgRecordingTimer.ResumeLayout(false);
            this.rdgRecordingTimer.PerformLayout();
            this.rdgCompressMode.ResumeLayout(false);
            this.rdgCompressType.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{
			SetRadioButtonInGroupUsingTag((rdgRecordingMethod), (short) cMainForm.axVideoGrabberNET1.RecordingMethod);
			SetRadioButtonInGroupUsingTag((rdgCompressMode), (short) cMainForm.axVideoGrabberNET1.CompressionMode);
			SetRadioButtonInGroupUsingTag((rdgCompressType), (short) cMainForm.axVideoGrabberNET1.CompressionType);
            SetRadioButtonInGroupUsingTag((rdgRecordingTimer), (short)cMainForm.axVideoGrabberNET1.RecordingTimer);

			edtPreallocSize.Text = cMainForm.axVideoGrabberNET1.PreallocCapFileSizeInMB.ToString();
			chkRecordingCanPause.Checked = cMainForm.axVideoGrabberNET1.RecordingCanPause;
			chkPauseCreatesNewFile.Checked = cMainForm.axVideoGrabberNET1.RecordingPauseCreatesNewFile;
			chkRecordingOnMotion.Checked = cMainForm.axVideoGrabberNET1.RecordingOnMotion_Enabled;

			chkPreallocFile.Checked = cMainForm.axVideoGrabberNET1.PreallocCapFileEnabled;
			chkOpenDML.Checked = cMainForm.axVideoGrabberNET1.AVIFormatOpenDML;
			chkPreserveNativeFormat.Checked = cMainForm.axVideoGrabberNET1.RecordingInNativeFormat;

			chkAudioRecording.Checked = cMainForm.axVideoGrabberNET1.AudioRecording;

			AssignListToComboBox((cboVideoCompressors), cMainForm.axVideoGrabberNET1.VideoCompressors, cMainForm.axVideoGrabberNET1.VideoCompressor);
			AssignListToComboBox((cboAudioCompressors), cMainForm.axVideoGrabberNET1.AudioCompressors, cMainForm.axVideoGrabberNET1.AudioCompressor);
            AssignListToComboBox((cboMultiplexers), cMainForm.axVideoGrabberNET1.Multiplexers, cMainForm.axVideoGrabberNET1.Multiplexer);

            AssignListToComboBox(cboAudioFormats, cMainForm.axVideoGrabberNET1.AudioFormats, (int) cMainForm.axVideoGrabberNET1.AudioFormat);

            btnPauseRecording.Enabled = cMainForm.axVideoGrabberNET1.RecordingCanPause;
			btnResumeRecording.Enabled = cMainForm.axVideoGrabberNET1.RecordingCanPause;

			rdgCompressMode.Enabled = true;
			rdgCompressType.Enabled = true;

            chkScreenRecordWindow.Enabled = ((cMainForm.axVideoGrabberNET1.VideoSource == Vidgrab_NET.TxVideoSource.vs_ScreenRecording) ? true : false);

			if (! cMainForm.axVideoGrabberNET1.AudioRecording) 
			{
				rdgCompressType.Enabled = false;
			}
			
            chkOpenDML.Enabled = cMainForm.axVideoGrabberNET1.RecordingMethod == Vidgrab_NET.TxRecordingMethod.rm_AVI;

            bool CanUseCompressors = (cMainForm.axVideoGrabberNET1.RecordingMethod != Vidgrab_NET.TxRecordingMethod.rm_ASF) 
                                        && (cMainForm.axVideoGrabberNET1.RecordingMethod != Vidgrab_NET.TxRecordingMethod.rm_SendToDV);

            bool CanUseMultiplexer = CanUseCompressors && (cMainForm.axVideoGrabberNET1.RecordingMethod != Vidgrab_NET.TxRecordingMethod.rm_AVI); // AVI uses the Microsoft's AVI mux 

            rdgCompressMode.Enabled = CanUseCompressors;
            rdgCompressType.Enabled = CanUseCompressors;
            cboVideoCompressors.Enabled = CanUseCompressors;
            btnVideoCompressorSettings.Enabled = CanUseCompressors;
            cboAudioCompressors.Enabled = CanUseCompressors;
            btnAudioCompressorSettings.Enabled = CanUseCompressors;
            chkPreallocFile.Enabled = CanUseCompressors;
            cboVideoCompressors.Enabled = CanUseCompressors;
            cboMultiplexers.Enabled = CanUseMultiplexer;
        }

        private void btnVideoCompressorSettings_Click(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_VideoCompressor);
        }

        private void btnAudioCompressorSettings_Click(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_AudioCompressor);
        }

        private void btnMultiplexerSettings_Click(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_Multiplexer);
        }

        private void btnCodecExamples_Click(object sender, EventArgs e)
        {
            ShellExecute((System.IntPtr)0, "open", "http://www.datastead.com/tvideograbber-recording-codecs-examples.html?demo=csharp", "", "", ShowCommands.SW_SHOWNORMAL);
        }

        private void btnSaveVideoCompressorSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            SaveDlg.FileName = cMainForm.axVideoGrabberNET1.VideoCompressorName + " (" + cMainForm.axVideoGrabberNET1.RecordingMethod.ToString() + ").txt";
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

                cMainForm.axVideoGrabberNET1.SaveCompressorSettingsToTextFile(true, cMainForm.axVideoGrabberNET1.VideoCompressor, SaveDlg.FileName);

                // remark: you can use instead SaveCompressorSettingsToDataString (TRUE, VideoGrabber.VideoCompressor, YourDataString)
            }
        }

        private void btnSaveAudioCompressorSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();

            SaveDlg.FileName = cMainForm.axVideoGrabberNET1.AudioCompressorName + " (" + cMainForm.axVideoGrabberNET1.RecordingMethod.ToString() + ").txt";
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                // be sure to have selected the RecordingMethod and VideoCompressor before invoking SaveCompressorSettings...

                cMainForm.axVideoGrabberNET1.SaveCompressorSettingsToTextFile(false, cMainForm.axVideoGrabberNET1.AudioCompressor, SaveDlg.FileName);

                // remark: you can use instead SaveCompressorSettingsToDataString (FALSE, VideoGrabber.AudioCompressor, YourDataString)
            }
        }

        private void btnReloadVideoCompressorSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            OpenDlg.Filter = OPEN_COMPRESSOR_SETTINGS;
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                cMainForm.axVideoGrabberNET1.LoadCompressorSettingsFromTextFile(true, cMainForm.axVideoGrabberNET1.VideoCompressor, OpenDlg.FileName);

                // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (TRUE, VideoGrabber.VideoCompressor)
            }
        }

        private void btnReloadAudioCompressorSettings_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            OpenDlg.Filter = OPEN_COMPRESSOR_SETTINGS;
            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                cMainForm.axVideoGrabberNET1.LoadCompressorSettingsFromTextFile(false, cMainForm.axVideoGrabberNET1.AudioCompressor, OpenDlg.FileName);

                // remark: you can use instead YourDataString := LoadCompressorSettingsFromDataString (FALSE, VideoGrabber.AudioCompressor)
            }
        }

		private void btnCreatePreallocFileNow_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.CreatePreallocCapFile();
		}

		private void btnMoreInfo_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show("Means that the recording stream will ! be uncompressed.\n\r\n\rMUST BE ENABLED: \n\r\n\r- to record hardware-encoded MPEG \n\r\n\r- to record or DV devices in native DV format \n\r\n\r- to record the DV date/time into the video clip and retrieve it during playback \n\r\n\r\n\r\n\rMUST BE DISABLED: \n\r\n\r- to record the text and graphics overlays into the video clip, and retrieve them during playback",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
		}

		private void btnPauseRecording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.PauseRecording();
		}

		private void btnRenewRecordingFile_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = edtRecordingFileName.Text;
			}
			else 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = "";
			}
			cMainForm.axVideoGrabberNET1.RecordToNewFileNow("", true);
		}

		private void btnResumeRecording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ResumeRecording();
		}

		private void btnStartRecordingControlled_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = edtRecordingFileName.Text;
			} 
			else 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = "";
			}

			cMainForm.axVideoGrabberNET1.HoldRecording = true;
			cMainForm.axVideoGrabberNET1.StartRecording();

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired

            if ((cMainForm.axVideoGrabberNET1.RecordingTimer == Vidgrab_NET.TxRecordingTimer.rt_StartRecording) & (cMainForm.axVideoGrabberNET1.VideoSource == Vidgrab_NET.TxVideoSource.vs_ScreenRecording) & (chkScreenRecordWindow.Checked == true) & (cMainForm.lngScreenRecordingWindow > 0))
            {
                // for screen recording of a window, this code will make it the top window before recording start;
                //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                InsetForms.SetWindowPos(cMainForm.wenScreenRecordingWindow[cMainForm.lngScreenRecordingWindow - 1].WindowHandle, InsetForms.HWND_TOP, 0, 0, 0, 0, InsetForms.SWP_NOMOVE | InsetForms.SWP_NOSIZE);
            }
        }

        private void rdgRecordingTimer1_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.RecordingTimer = Vidgrab_NET.TxRecordingTimer.rt_Disabled;
        }

        private void rdgRecordingTimer2_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.RecordingTimer = Vidgrab_NET.TxRecordingTimer.rt_RecordToNewFile;
        }

        private void rdgRecordingTimer3_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.RecordingTimer = Vidgrab_NET.TxRecordingTimer.rt_StopRecording;
        }

        private void rdgRecordingTimer4_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.RecordingTimer = Vidgrab_NET.TxRecordingTimer.rt_StartRecording;
        }

        private void edtRecordingTimer_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(edtRecordingTimer.Text) > 0)
            {
                cMainForm.axVideoGrabberNET1.RecordingTimerInterval = Convert.ToInt32(edtRecordingTimer.Text);
            }
            else
            {
                cMainForm.axVideoGrabberNET1.RecordingTimerInterval = 0;
            }
        }

        private void chkScreenRecordWindow_CheckedChanged(object sender, EventArgs e)
        {
            // for source = screen demonstration purposes, if:
            // - VideoSource = vs_ScreenRecording
            // - source window handle is identified with VideoSource form btnScreenRecordingWindow
            //   via EnumerateWindows and OnEnumerateWindows event (SetEnumerateWindows demo procedure)
            // - chkScreenRecordWindow is enabled
            // source window will be made top window at recording start (using API SetWindowPos),
            //  see Recording form btnStartRecordingImmediately and btnStartRecordingControlled,
            //  and events OnEnumerateWindows, OnRecordingReadyToStart
        }
        
        private void btnStartRecordingImmediately_Click(object sender, System.EventArgs e)
		{
			if (chkAVISaveToThisFile.Checked) 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = edtRecordingFileName.Text;
			} 
			else 
			{
				cMainForm.axVideoGrabberNET1.RecordingFileName = "";
			}
			cMainForm.axVideoGrabberNET1.HoldRecording = false; // let's start recording as soon as the graph is built.

            // Enabling HoldRecording before calling StartRecording prevents the recording
            //  to start (when the recording graph is built) until the
            //  OnRecordingReadyToStart event is fired, where ResumeRecording must be invoked
            //  to commence recording, or StopRecording to cancel recording
            // EXCEPTION: RecordingTimer = rt_StartRecording: recording is started
            //  after RecordingTimerInterval regardless of HoldRecording setting,
            //  and OnRecordingReadyToStart event is not fired

            if ((cMainForm.axVideoGrabberNET1.RecordingTimer == Vidgrab_NET.TxRecordingTimer.rt_StartRecording) & (cMainForm.axVideoGrabberNET1.VideoSource == Vidgrab_NET.TxVideoSource.vs_ScreenRecording) & (chkScreenRecordWindow.Checked == true) & (cMainForm.lngScreenRecordingWindow > 0))
            {
                // for screen recording of a window, this code will make it the top window before recording start;
                //  window handle was gathered by EnumerateWindows in OnEnumerateWindows
                // (see demo procedures in VideoSource form btnScreenRecordingWindow and SetEnumerateWindows)
                InsetForms.SetWindowPos(cMainForm.wenScreenRecordingWindow[cMainForm.lngScreenRecordingWindow - 1].WindowHandle, InsetForms.HWND_TOP, 0, 0, 0, 0, InsetForms.SWP_NOMOVE | InsetForms.SWP_NOSIZE);
            }
            cMainForm.axVideoGrabberNET1.StartRecording();
		}

		private void btnStopRecording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.StopRecording();
		}

		private void cboAudioCompressors_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioCompressor = cboAudioCompressors.SelectedIndex;
		}

        private void cboMultiplexers_SelectedIndexChanged(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.Multiplexer = cboMultiplexers.SelectedIndex;
        }

		private void cboAudioFormats_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioFormat = (Vidgrab_NET.TxAudioFormat) cboAudioFormats.SelectedIndex;
		}

		private void cboVideoCompressors_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.VideoCompressor = cboVideoCompressors.SelectedIndex;
		}

		private void chkAudioRecording_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioRecording = chkAudioRecording.Checked;
			RefreshControls();
		}

		private void chkOpenDML_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AVIFormatOpenDML = chkOpenDML.Checked;
		}

		private void chkPreallocFile_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.PreallocCapFileEnabled = chkPreallocFile.Checked;
		}

		private void chkPreserveNativeFormat_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.RecordingInNativeFormat = chkPreserveNativeFormat.Checked;
		}

		private void chkRecordingCanPause_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.RecordingCanPause = chkRecordingCanPause.Checked;
			RefreshControls();
		}

		private void chkPauseCreatesNewFile_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.RecordingPauseCreatesNewFile = chkPauseCreatesNewFile.Checked;
		}

		private void chkRecordingOnMotion_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.RecordingOnMotion_Enabled = chkRecordingOnMotion.Checked;
			chkRecordingCanPause.Checked = chkRecordingOnMotion.Checked;
		}

		private void edtPreallocSize_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtPreallocSize.Text)) 
			{
				cMainForm.axVideoGrabberNET1.PreallocCapFileSizeInMB = Convert.ToInt32 (edtPreallocSize.Text);
			}
		}

		private void rdgCompressMode_CheckedChanged (object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.CompressionMode = (Vidgrab_NET.TxCompressionMode) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgCompressType_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.CompressionType = (Vidgrab_NET.TxCompressionType) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgRecordingMethod_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.RecordingMethod = (Vidgrab_NET.TxRecordingMethod) Convert.ToInt32 ((sender as Control).Tag);
                RefreshControls();
			}
		}

		private void btnASFinfo_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show("the ASF settings are located on the 'network streaming// tab",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
		}

		private void btnSendToDVinfo_Click(object sender, System.EventArgs e)
		{
            MessageBox.Show("the recording is sent to the DV camcorder (this feature is called also 'print to DV')",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
		}

		private void Recording_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void timStartRecordingControlled_Tick(object sender, EventArgs e)
        {
            timStartRecordingControlled.Enabled = false;
            cMainForm.axVideoGrabberNET1.ResumeRecording();
        }
	}
}
