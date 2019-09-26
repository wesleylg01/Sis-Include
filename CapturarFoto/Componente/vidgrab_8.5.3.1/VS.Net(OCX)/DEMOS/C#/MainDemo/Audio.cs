using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Audio.
	/// </summary>
	public class Audio : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
		private System.ComponentModel.IContainer components;

		private const int VU_LEFT = 0;
        public CheckBox chkRenderAudioDevice;
        internal GroupBox GroupBox1;
        internal Button btnStopAudio;
        internal Button btnStartWMVRecording;
        internal Button btnSartMP3Recording;
        internal Button btnStartWavRecording;
        internal Button btnStartAudioRendering;
        internal CheckBox chkUseAudioOfVideoCaptureDevice;
        internal Panel pnlVUMeterRight;
        internal Panel pnlVUMeterLeft;
        internal GroupBox grbVuMeters;
        internal RadioButton rdgVUBargraph;
        internal RadioButton rdgVUAnalog;
        internal RadioButton rdgVUDisabled;
        public GroupBox grbAudioRendering;
        internal ComboBox cboAudioRenderers;
        public TrackBar tbrAudioVolume;
        public TrackBar tbrAudioBalance;
        public CheckBox chkMuteAudioRendering;
        public Label Label5;
        public Label Label6;
        public GroupBox grbAudioCaptureDevice;
        internal Label Label2;
        internal Button btnAudioDeviceDialog;
        public TrackBar tbrAudioInputLevel;
        public TrackBar tbrAudioInputBalance;
        public ComboBox cboAudioDevices;
        public ComboBox cboAudioInputs;
        public CheckBox chkAudioInputMono;
        public Label Label7;
        public Label Label8;
        public Label Label9;
		private const int VU_RIGHT = 1;

		public Audio()
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
            this.chkRenderAudioDevice = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStopAudio = new System.Windows.Forms.Button();
            this.btnStartWMVRecording = new System.Windows.Forms.Button();
            this.btnSartMP3Recording = new System.Windows.Forms.Button();
            this.btnStartWavRecording = new System.Windows.Forms.Button();
            this.btnStartAudioRendering = new System.Windows.Forms.Button();
            this.chkUseAudioOfVideoCaptureDevice = new System.Windows.Forms.CheckBox();
            this.pnlVUMeterRight = new System.Windows.Forms.Panel();
            this.pnlVUMeterLeft = new System.Windows.Forms.Panel();
            this.grbVuMeters = new System.Windows.Forms.GroupBox();
            this.rdgVUBargraph = new System.Windows.Forms.RadioButton();
            this.rdgVUAnalog = new System.Windows.Forms.RadioButton();
            this.rdgVUDisabled = new System.Windows.Forms.RadioButton();
            this.grbAudioRendering = new System.Windows.Forms.GroupBox();
            this.cboAudioRenderers = new System.Windows.Forms.ComboBox();
            this.tbrAudioVolume = new System.Windows.Forms.TrackBar();
            this.tbrAudioBalance = new System.Windows.Forms.TrackBar();
            this.chkMuteAudioRendering = new System.Windows.Forms.CheckBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.grbAudioCaptureDevice = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnAudioDeviceDialog = new System.Windows.Forms.Button();
            this.tbrAudioInputLevel = new System.Windows.Forms.TrackBar();
            this.tbrAudioInputBalance = new System.Windows.Forms.TrackBar();
            this.cboAudioDevices = new System.Windows.Forms.ComboBox();
            this.cboAudioInputs = new System.Windows.Forms.ComboBox();
            this.chkAudioInputMono = new System.Windows.Forms.CheckBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.grbVuMeters.SuspendLayout();
            this.grbAudioRendering.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioBalance)).BeginInit();
            this.grbAudioCaptureDevice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // chkRenderAudioDevice
            // 
            this.chkRenderAudioDevice.BackColor = System.Drawing.SystemColors.Control;
            this.chkRenderAudioDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkRenderAudioDevice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRenderAudioDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkRenderAudioDevice.Location = new System.Drawing.Point(12, 8);
            this.chkRenderAudioDevice.Name = "chkRenderAudioDevice";
            this.chkRenderAudioDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkRenderAudioDevice.Size = new System.Drawing.Size(272, 18);
            this.chkRenderAudioDevice.TabIndex = 26;
            this.chkRenderAudioDevice.Text = "AUDIO DEVICE RENDERING";
            this.chkRenderAudioDevice.CheckedChanged += new System.EventHandler(this.chkRenderAudioDevice_CheckedChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnStopAudio);
            this.GroupBox1.Controls.Add(this.btnStartWMVRecording);
            this.GroupBox1.Controls.Add(this.btnSartMP3Recording);
            this.GroupBox1.Controls.Add(this.btnStartWavRecording);
            this.GroupBox1.Controls.Add(this.btnStartAudioRendering);
            this.GroupBox1.Controls.Add(this.chkUseAudioOfVideoCaptureDevice);
            this.GroupBox1.Location = new System.Drawing.Point(332, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(577, 49);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "AUDIO rendering / recording / streaming ONLY  (you can activate the streaming in " +
                "the \"network streaming\" tab)";
            // 
            // btnStopAudio
            // 
            this.btnStopAudio.Location = new System.Drawing.Point(350, 18);
            this.btnStopAudio.Name = "btnStopAudio";
            this.btnStopAudio.Size = new System.Drawing.Size(50, 24);
            this.btnStopAudio.TabIndex = 4;
            this.btnStopAudio.Text = "stop";
            this.btnStopAudio.Click += new System.EventHandler(this.btnStopAudio_Click);
            // 
            // btnStartWMVRecording
            // 
            this.btnStartWMVRecording.Location = new System.Drawing.Point(264, 18);
            this.btnStartWMVRecording.Name = "btnStartWMVRecording";
            this.btnStartWMVRecording.Size = new System.Drawing.Size(80, 24);
            this.btnStartWMVRecording.TabIndex = 3;
            this.btnStartWMVRecording.Text = "record WMV";
            this.btnStartWMVRecording.Click += new System.EventHandler(this.btnStartWMVRecording_Click);
            // 
            // btnSartMP3Recording
            // 
            this.btnSartMP3Recording.Location = new System.Drawing.Point(186, 18);
            this.btnSartMP3Recording.Name = "btnSartMP3Recording";
            this.btnSartMP3Recording.Size = new System.Drawing.Size(72, 24);
            this.btnSartMP3Recording.TabIndex = 2;
            this.btnSartMP3Recording.Text = "record MP3";
            this.btnSartMP3Recording.Click += new System.EventHandler(this.btnSartMP3Recording_Click);
            // 
            // btnStartWavRecording
            // 
            this.btnStartWavRecording.Location = new System.Drawing.Point(100, 18);
            this.btnStartWavRecording.Name = "btnStartWavRecording";
            this.btnStartWavRecording.Size = new System.Drawing.Size(80, 24);
            this.btnStartWavRecording.TabIndex = 1;
            this.btnStartWavRecording.Text = "record WAV";
            this.btnStartWavRecording.Click += new System.EventHandler(this.btnStartWavRecording_Click);
            // 
            // btnStartAudioRendering
            // 
            this.btnStartAudioRendering.Location = new System.Drawing.Point(6, 18);
            this.btnStartAudioRendering.Name = "btnStartAudioRendering";
            this.btnStartAudioRendering.Size = new System.Drawing.Size(88, 24);
            this.btnStartAudioRendering.TabIndex = 0;
            this.btnStartAudioRendering.Text = "start rendering";
            this.btnStartAudioRendering.Click += new System.EventHandler(this.btnStartAudioRendering_Click);
            // 
            // chkUseAudioOfVideoCaptureDevice
            // 
            this.chkUseAudioOfVideoCaptureDevice.Location = new System.Drawing.Point(406, 12);
            this.chkUseAudioOfVideoCaptureDevice.Name = "chkUseAudioOfVideoCaptureDevice";
            this.chkUseAudioOfVideoCaptureDevice.Size = new System.Drawing.Size(165, 35);
            this.chkUseAudioOfVideoCaptureDevice.TabIndex = 5;
            this.chkUseAudioOfVideoCaptureDevice.Text = "use the audio out of the video capture device, if any";
            this.chkUseAudioOfVideoCaptureDevice.CheckedChanged += new System.EventHandler(this.chkUseAudioOfVideoCaptureDevice_CheckedChanged);
            // 
            // pnlVUMeterRight
            // 
            this.pnlVUMeterRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVUMeterRight.Location = new System.Drawing.Point(482, 88);
            this.pnlVUMeterRight.Name = "pnlVUMeterRight";
            this.pnlVUMeterRight.Size = new System.Drawing.Size(121, 81);
            this.pnlVUMeterRight.TabIndex = 24;
            // 
            // pnlVUMeterLeft
            // 
            this.pnlVUMeterLeft.AccessibleName = "";
            this.pnlVUMeterLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlVUMeterLeft.Location = new System.Drawing.Point(354, 88);
            this.pnlVUMeterLeft.Name = "pnlVUMeterLeft";
            this.pnlVUMeterLeft.Size = new System.Drawing.Size(121, 81);
            this.pnlVUMeterLeft.TabIndex = 23;
            // 
            // grbVuMeters
            // 
            this.grbVuMeters.Controls.Add(this.rdgVUBargraph);
            this.grbVuMeters.Controls.Add(this.rdgVUAnalog);
            this.grbVuMeters.Controls.Add(this.rdgVUDisabled);
            this.grbVuMeters.Location = new System.Drawing.Point(354, 48);
            this.grbVuMeters.Name = "grbVuMeters";
            this.grbVuMeters.Size = new System.Drawing.Size(249, 35);
            this.grbVuMeters.TabIndex = 22;
            this.grbVuMeters.TabStop = false;
            this.grbVuMeters.Text = "VU-Meters";
            // 
            // rdgVUBargraph
            // 
            this.rdgVUBargraph.Location = new System.Drawing.Point(166, 13);
            this.rdgVUBargraph.Name = "rdgVUBargraph";
            this.rdgVUBargraph.Size = new System.Drawing.Size(77, 18);
            this.rdgVUBargraph.TabIndex = 2;
            this.rdgVUBargraph.Tag = "2";
            this.rdgVUBargraph.Text = "bargraph";
            this.rdgVUBargraph.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // rdgVUAnalog
            // 
            this.rdgVUAnalog.Location = new System.Drawing.Point(95, 13);
            this.rdgVUAnalog.Name = "rdgVUAnalog";
            this.rdgVUAnalog.Size = new System.Drawing.Size(65, 18);
            this.rdgVUAnalog.TabIndex = 1;
            this.rdgVUAnalog.Tag = "1";
            this.rdgVUAnalog.Text = "analog";
            this.rdgVUAnalog.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // rdgVUDisabled
            // 
            this.rdgVUDisabled.Checked = true;
            this.rdgVUDisabled.Location = new System.Drawing.Point(12, 13);
            this.rdgVUDisabled.Name = "rdgVUDisabled";
            this.rdgVUDisabled.Size = new System.Drawing.Size(72, 18);
            this.rdgVUDisabled.TabIndex = 0;
            this.rdgVUDisabled.TabStop = true;
            this.rdgVUDisabled.Tag = "0";
            this.rdgVUDisabled.Text = "disabled";
            this.rdgVUDisabled.CheckedChanged += new System.EventHandler(this.rdgVUMeter_CheckedChanged);
            // 
            // grbAudioRendering
            // 
            this.grbAudioRendering.BackColor = System.Drawing.SystemColors.Control;
            this.grbAudioRendering.Controls.Add(this.cboAudioRenderers);
            this.grbAudioRendering.Controls.Add(this.tbrAudioVolume);
            this.grbAudioRendering.Controls.Add(this.tbrAudioBalance);
            this.grbAudioRendering.Controls.Add(this.chkMuteAudioRendering);
            this.grbAudioRendering.Controls.Add(this.Label5);
            this.grbAudioRendering.Controls.Add(this.Label6);
            this.grbAudioRendering.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbAudioRendering.Location = new System.Drawing.Point(636, 48);
            this.grbAudioRendering.Name = "grbAudioRendering";
            this.grbAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbAudioRendering.Size = new System.Drawing.Size(273, 127);
            this.grbAudioRendering.TabIndex = 21;
            this.grbAudioRendering.TabStop = false;
            this.grbAudioRendering.Text = "audio rendering";
            // 
            // cboAudioRenderers
            // 
            this.cboAudioRenderers.Location = new System.Drawing.Point(65, 15);
            this.cboAudioRenderers.Name = "cboAudioRenderers";
            this.cboAudioRenderers.Size = new System.Drawing.Size(202, 22);
            this.cboAudioRenderers.TabIndex = 18;
            this.cboAudioRenderers.Text = "default (AudioRenderer = -1)";
            this.cboAudioRenderers.SelectedIndexChanged += new System.EventHandler(this.cboAudioRenderers_SelectedIndexChanged);
            // 
            // tbrAudioVolume
            // 
            this.tbrAudioVolume.AutoSize = false;
            this.tbrAudioVolume.Location = new System.Drawing.Point(12, 56);
            this.tbrAudioVolume.Maximum = 65535;
            this.tbrAudioVolume.Name = "tbrAudioVolume";
            this.tbrAudioVolume.Size = new System.Drawing.Size(255, 18);
            this.tbrAudioVolume.TabIndex = 17;
            this.tbrAudioVolume.TickFrequency = 7300;
            this.tbrAudioVolume.Scroll += new System.EventHandler(this.tbrAudioVolume_Scroll);
            // 
            // tbrAudioBalance
            // 
            this.tbrAudioBalance.AutoSize = false;
            this.tbrAudioBalance.Location = new System.Drawing.Point(12, 95);
            this.tbrAudioBalance.Maximum = 32767;
            this.tbrAudioBalance.Minimum = -32768;
            this.tbrAudioBalance.Name = "tbrAudioBalance";
            this.tbrAudioBalance.Size = new System.Drawing.Size(255, 18);
            this.tbrAudioBalance.TabIndex = 17;
            this.tbrAudioBalance.TickFrequency = 7300;
            this.tbrAudioBalance.Scroll += new System.EventHandler(this.tbrAudioBalance_Scroll);
            // 
            // chkMuteAudioRendering
            // 
            this.chkMuteAudioRendering.BackColor = System.Drawing.SystemColors.Control;
            this.chkMuteAudioRendering.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMuteAudioRendering.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMuteAudioRendering.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMuteAudioRendering.Location = new System.Drawing.Point(12, 17);
            this.chkMuteAudioRendering.Name = "chkMuteAudioRendering";
            this.chkMuteAudioRendering.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMuteAudioRendering.Size = new System.Drawing.Size(66, 18);
            this.chkMuteAudioRendering.TabIndex = 12;
            this.chkMuteAudioRendering.Text = "mute";
            this.chkMuteAudioRendering.CheckedChanged += new System.EventHandler(this.chkMuteAudioRendering_CheckedChanged);
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(16, 40);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(97, 17);
            this.Label5.TabIndex = 15;
            this.Label5.Text = "volume";
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(16, 80);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(97, 17);
            this.Label6.TabIndex = 14;
            this.Label6.Text = "balance";
            // 
            // grbAudioCaptureDevice
            // 
            this.grbAudioCaptureDevice.BackColor = System.Drawing.SystemColors.Control;
            this.grbAudioCaptureDevice.Controls.Add(this.Label2);
            this.grbAudioCaptureDevice.Controls.Add(this.btnAudioDeviceDialog);
            this.grbAudioCaptureDevice.Controls.Add(this.tbrAudioInputLevel);
            this.grbAudioCaptureDevice.Controls.Add(this.tbrAudioInputBalance);
            this.grbAudioCaptureDevice.Controls.Add(this.cboAudioDevices);
            this.grbAudioCaptureDevice.Controls.Add(this.cboAudioInputs);
            this.grbAudioCaptureDevice.Controls.Add(this.chkAudioInputMono);
            this.grbAudioCaptureDevice.Controls.Add(this.Label7);
            this.grbAudioCaptureDevice.Controls.Add(this.Label8);
            this.grbAudioCaptureDevice.Controls.Add(this.Label9);
            this.grbAudioCaptureDevice.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAudioCaptureDevice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbAudioCaptureDevice.Location = new System.Drawing.Point(4, 32);
            this.grbAudioCaptureDevice.Name = "grbAudioCaptureDevice";
            this.grbAudioCaptureDevice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbAudioCaptureDevice.Size = new System.Drawing.Size(321, 143);
            this.grbAudioCaptureDevice.TabIndex = 20;
            this.grbAudioCaptureDevice.TabStop = false;
            this.grbAudioCaptureDevice.Text = "Audio capture device";
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Label2.Location = new System.Drawing.Point(7, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(307, 28);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "to programmatically select an item by name in a list, use the FindIndexInListByNa" +
                "me function";
            // 
            // btnAudioDeviceDialog
            // 
            this.btnAudioDeviceDialog.Location = new System.Drawing.Point(230, 38);
            this.btnAudioDeviceDialog.Name = "btnAudioDeviceDialog";
            this.btnAudioDeviceDialog.Size = new System.Drawing.Size(80, 23);
            this.btnAudioDeviceDialog.TabIndex = 19;
            this.btnAudioDeviceDialog.Text = "device dialog";
            this.btnAudioDeviceDialog.Click += new System.EventHandler(this.btnAudioDeviceDialog_Click);
            // 
            // tbrAudioInputLevel
            // 
            this.tbrAudioInputLevel.AutoSize = false;
            this.tbrAudioInputLevel.Location = new System.Drawing.Point(126, 93);
            this.tbrAudioInputLevel.Maximum = 65535;
            this.tbrAudioInputLevel.Name = "tbrAudioInputLevel";
            this.tbrAudioInputLevel.Size = new System.Drawing.Size(171, 18);
            this.tbrAudioInputLevel.TabIndex = 17;
            this.tbrAudioInputLevel.TickFrequency = 7300;
            this.tbrAudioInputLevel.Scroll += new System.EventHandler(this.tbrAudioInputLevel_Scroll);
            // 
            // tbrAudioInputBalance
            // 
            this.tbrAudioInputBalance.AutoSize = false;
            this.tbrAudioInputBalance.Location = new System.Drawing.Point(126, 117);
            this.tbrAudioInputBalance.Maximum = 32767;
            this.tbrAudioInputBalance.Minimum = -32768;
            this.tbrAudioInputBalance.Name = "tbrAudioInputBalance";
            this.tbrAudioInputBalance.Size = new System.Drawing.Size(171, 18);
            this.tbrAudioInputBalance.TabIndex = 17;
            this.tbrAudioInputBalance.TickFrequency = 7300;
            this.tbrAudioInputBalance.Scroll += new System.EventHandler(this.tbrAudioInputBalance_Scroll);
            // 
            // cboAudioDevices
            // 
            this.cboAudioDevices.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioDevices.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioDevices.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAudioDevices.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioDevices.Location = new System.Drawing.Point(79, 13);
            this.cboAudioDevices.Name = "cboAudioDevices";
            this.cboAudioDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioDevices.Size = new System.Drawing.Size(236, 22);
            this.cboAudioDevices.TabIndex = 4;
            this.cboAudioDevices.Text = "SELECT AN AUDIO CAPTURE DEVICE IN THIS LIST";
            this.cboAudioDevices.SelectedIndexChanged += new System.EventHandler(this.cboAudioDevices_SelectedIndexChanged);
            // 
            // cboAudioInputs
            // 
            this.cboAudioInputs.BackColor = System.Drawing.SystemColors.Window;
            this.cboAudioInputs.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboAudioInputs.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAudioInputs.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboAudioInputs.Location = new System.Drawing.Point(8, 38);
            this.cboAudioInputs.Name = "cboAudioInputs";
            this.cboAudioInputs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cboAudioInputs.Size = new System.Drawing.Size(128, 22);
            this.cboAudioInputs.TabIndex = 3;
            this.cboAudioInputs.SelectedIndexChanged += new System.EventHandler(this.cboAudioInputs_SelectedIndexChanged);
            // 
            // chkAudioInputMono
            // 
            this.chkAudioInputMono.BackColor = System.Drawing.SystemColors.Control;
            this.chkAudioInputMono.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAudioInputMono.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAudioInputMono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkAudioInputMono.Location = new System.Drawing.Point(155, 41);
            this.chkAudioInputMono.Name = "chkAudioInputMono";
            this.chkAudioInputMono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAudioInputMono.Size = new System.Drawing.Size(56, 17);
            this.chkAudioInputMono.TabIndex = 2;
            this.chkAudioInputMono.Text = "mono";
            this.chkAudioInputMono.CheckedChanged += new System.EventHandler(this.chkAudioInputMono_CheckedChanged);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.SystemColors.Control;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(8, 23);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(65, 17);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "audio input";
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.SystemColors.Control;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(8, 93);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(114, 18);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "audio input level";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.SystemColors.Control;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(5, 111);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(117, 18);
            this.Label9.TabIndex = 7;
            this.Label9.Text = "audio input balance";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Audio
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(941, 212);
            this.ControlBox = false;
            this.Controls.Add(this.chkRenderAudioDevice);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.pnlVUMeterRight);
            this.Controls.Add(this.pnlVUMeterLeft);
            this.Controls.Add(this.grbVuMeters);
            this.Controls.Add(this.grbAudioRendering);
            this.Controls.Add(this.grbAudioCaptureDevice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Audio";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Audio_VisibleChanged);
            this.GroupBox1.ResumeLayout(false);
            this.grbVuMeters.ResumeLayout(false);
            this.grbAudioRendering.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioBalance)).EndInit();
            this.grbAudioCaptureDevice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrAudioInputBalance)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        public void RefreshControls()
        {
            AssignListToComboBox(cboAudioDevices, cMainForm.axVideoGrabberNET1.AudioDevices, cMainForm.axVideoGrabberNET1.AudioDevice);

            if (cMainForm.axVideoGrabberNET1.AudioDevice >= 0) { // if an audio capture device has been selected
                AssignListToComboBox(cboAudioInputs, cMainForm.axVideoGrabberNET1.AudioInputs, cMainForm.axVideoGrabberNET1.AudioInput);
            }

            tbrAudioInputLevel.Value = cMainForm.axVideoGrabberNET1.AudioInputLevel;
            tbrAudioInputBalance.Value = cMainForm.axVideoGrabberNET1.AudioInputBalance;
            chkAudioInputMono.Checked = cMainForm.axVideoGrabberNET1.AudioInputMono;
		
			AssignListToComboBox(cboAudioRenderers, cMainForm.axVideoGrabberNET1.AudioRenderers, cMainForm.axVideoGrabberNET1.AudioRenderer);

			chkRenderAudioDevice.Checked = cMainForm.axVideoGrabberNET1.AudioDeviceRendering;
			chkMuteAudioRendering.Checked = cMainForm.axVideoGrabberNET1.MuteAudioRendering;

			if (cMainForm.axVideoGrabberNET1.AudioDevice == -1)
			{
				cboAudioDevices.Text = "SELECT AND AUDIO CAPTURE DEVICE IN THIS LIST";
			}
			if (cMainForm.axVideoGrabberNET1.AudioRenderer == -1) {
				cboAudioRenderers.Text = "default (AudioRenderer = -1)";
			}
		}

		private void cboAudioDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioDevice = cboAudioDevices.SelectedIndex;
		}

		private void btnAudioDeviceDialog_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_AudioDevice);
		}

		private void cboAudioInputs_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioInput = cboAudioInputs.SelectedIndex;
		}

		private void chkAudioInputMono_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioInputMono = chkAudioInputMono.Checked;

		}

		private void chkRenderAudioDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioDeviceRendering = chkRenderAudioDevice.Checked;
		}

		private void chkMuteAudioRendering_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MuteAudioRendering = chkMuteAudioRendering.Checked;
		}

		private void cboAudioRenderers_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioRenderer = cboAudioRenderers.SelectedIndex;
		}

		private void tbrAudioVolume_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioVolume = tbrAudioVolume.Value;
		}

		private void tbrAudioInputLevel_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioInputLevel = tbrAudioInputLevel.Value;
		}

		private void tbrAudioInputBalance_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioInputBalance = tbrAudioInputBalance.Value;
		}

		private void tbrAudioBalance_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.AudioBalance = tbrAudioBalance.Value;
		}

		private void rdgVUMeter_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				switch (Convert.ToInt32((sender as RadioButton).Tag))
				{
					case 0:
						cMainForm.axVideoGrabberNET1.VuMeter = Vidgrab_NET.TxVuMeter.vu_Disabled;
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(0)); // VU_LEFT = 0, VU_RIGHT = 1;
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(0));
					break;
					case 1:
						cMainForm.axVideoGrabberNET1.VuMeter = Vidgrab_NET.TxVuMeter.vu_Analog;
			
						pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 4) / 3;
						pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 4) / 3;
			
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), Vidgrab_NET.TxVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(0)); // VU_LEFT = 0, VU_RIGHT = 1
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), Vidgrab_NET.TxVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(0));
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32())); // VU_LEFT = 0, VU_RIGHT = 1
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32()));
						break;
					case 2:
						cMainForm.axVideoGrabberNET1.VuMeter = Vidgrab_NET.TxVuMeter.vu_Bargraph;
			
						pnlVUMeterLeft.Width = (pnlVUMeterLeft.Height * 2) / 10;
						pnlVUMeterRight.Width = (pnlVUMeterRight.Height * 2) / 10;
			
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), Vidgrab_NET.TxVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(0x404040)); // VU_LEFT = 0, VU_RIGHT = 1
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), Vidgrab_NET.TxVUMeterSetting.vu_BkgndColor, Convert.ToUInt32(0x404040));
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_LEFT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterLeft.Handle.ToInt32())); // VU_LEFT = 0, VU_RIGHT = 1
						cMainForm.axVideoGrabberNET1.SetVUMeterSetting(Convert.ToUInt32(VU_RIGHT), Vidgrab_NET.TxVUMeterSetting.vu_Handle, Convert.ToUInt32(pnlVUMeterRight.Handle.ToInt32()));
						break;
				}
			}
		}

		private void btnStartAudioRendering_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.StartAudioRendering();
			if (! cMainForm.axVideoGrabberNET1.AudioDeviceRendering) {
				if (btnStartAudioRendering.Tag.ToString() == "0") 
				{
					btnStartAudioRendering.Tag = 1; //' to show the popup only one time
					MessageBox.Show ("StartAudioRendering acts as 'preview', e.g. for the VU-Meters, if AudioDeviceRendering (on the left) is not enabled, the audio will not be heard in the speakers",
                                "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
				}
            }
		}

		private void btnStartWavRecording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.CompressionMode = Vidgrab_NET.TxCompressionMode.cm_NoCompression;
			cMainForm.axVideoGrabberNET1.RecordingMethod = Vidgrab_NET.TxRecordingMethod.rm_AVI;
			cMainForm.axVideoGrabberNET1.StartAudioRecording();
		}

		private void btnSartMP3Recording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.CompressionMode = Vidgrab_NET.TxCompressionMode.cm_CompressOnTheFly;
			cMainForm.axVideoGrabberNET1.CompressionType = Vidgrab_NET.TxCompressionType.ct_Audio;
			cMainForm.axVideoGrabberNET1.RecordingMethod = Vidgrab_NET.TxRecordingMethod.rm_AVI;
			
			cMainForm.axVideoGrabberNET1.AudioCompressor = cMainForm.axVideoGrabberNET1.FindIndexInListByName (cMainForm.axVideoGrabberNET1.AudioCompressors, "LAME Audio Encoder", false, true);
			if (cMainForm.axVideoGrabberNET1.AudioCompressor == -1) 
			{
				MessageBox.Show ("The LAME Audio Encoder is required, download it from http://www.elecard.com/download/",
                            "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
			}
			else {
				cMainForm.axVideoGrabberNET1.StartAudioRecording();
			}
		}

		private void btnStartWMVRecording_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.CompressionMode = Vidgrab_NET.TxCompressionMode.cm_NoCompression;
			cMainForm.axVideoGrabberNET1.RecordingMethod = Vidgrab_NET.TxRecordingMethod.rm_ASF;
			cMainForm.axVideoGrabberNET1.StartAudioRecording();
		}

		private void btnStopAudio_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Stop();
		}

		private void chkUseAudioOfVideoCaptureDevice_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkUseAudioOfVideoCaptureDevice.Checked)
			{
				cMainForm.axVideoGrabberNET1.VideoDevice = 0; // in this demo, by default we choose the 1st
			}
			else {
				cMainForm.axVideoGrabberNET1.VideoDevice = -1; // this deactivates the video capture device
			}
		}

		private void Audio_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

	}
}
