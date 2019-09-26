using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Reecoding.
	/// </summary>
	public class Reencoding : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal Label Label7;
        public Button btnStopReencoding;
        public Button btnStartReencoding;
        public GroupBox rdgReencodingMethod;
        public RadioButton rdgReencodingMethod2;
        public RadioButton rdgReencodingMethod1;
        public GroupBox grbReencodingSettings;
        public CheckBox chkWMVOutput;
        public CheckBox chkUseFrameGrabber;
        public CheckBox chkIncludeAudioStream;
        public CheckBox chkUseCurrentVideoCompressor;
        public CheckBox chkIncludeVideoStream;
        public CheckBox chkUseCurrentAudioCompressor;
        public GroupBox grbStartStopTime;
        internal Label Label8;
        internal Label Label6;
        internal Label Label5;
        public TextBox edtStartFrame;
        public TextBox edtStopFrame;
        public TextBox edtFrameCount;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        public TextBox edtDuration;
        public TextBox edtStartTime;
        public TextBox edtStopTime;
        public Button btnDuration;
        public TextBox edtDestinationVideoClip;
        public TextBox edtSourceVideoClip;
        public Button btnSourceVideoClip;
        public Label Label33;
        public Label Label32;
		private System.ComponentModel.IContainer components;

		public Reencoding()
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
            this.Label7 = new System.Windows.Forms.Label();
            this.btnStopReencoding = new System.Windows.Forms.Button();
            this.btnStartReencoding = new System.Windows.Forms.Button();
            this.rdgReencodingMethod = new System.Windows.Forms.GroupBox();
            this.rdgReencodingMethod2 = new System.Windows.Forms.RadioButton();
            this.rdgReencodingMethod1 = new System.Windows.Forms.RadioButton();
            this.grbReencodingSettings = new System.Windows.Forms.GroupBox();
            this.chkWMVOutput = new System.Windows.Forms.CheckBox();
            this.chkUseFrameGrabber = new System.Windows.Forms.CheckBox();
            this.chkIncludeAudioStream = new System.Windows.Forms.CheckBox();
            this.chkUseCurrentVideoCompressor = new System.Windows.Forms.CheckBox();
            this.chkIncludeVideoStream = new System.Windows.Forms.CheckBox();
            this.chkUseCurrentAudioCompressor = new System.Windows.Forms.CheckBox();
            this.grbStartStopTime = new System.Windows.Forms.GroupBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.edtStartFrame = new System.Windows.Forms.TextBox();
            this.edtStopFrame = new System.Windows.Forms.TextBox();
            this.edtFrameCount = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.edtDuration = new System.Windows.Forms.TextBox();
            this.edtStartTime = new System.Windows.Forms.TextBox();
            this.edtStopTime = new System.Windows.Forms.TextBox();
            this.btnDuration = new System.Windows.Forms.Button();
            this.edtDestinationVideoClip = new System.Windows.Forms.TextBox();
            this.edtSourceVideoClip = new System.Windows.Forms.TextBox();
            this.btnSourceVideoClip = new System.Windows.Forms.Button();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.rdgReencodingMethod.SuspendLayout();
            this.grbReencodingSettings.SuspendLayout();
            this.grbStartStopTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(72, 14);
            this.Label7.TabIndex = 35;
            this.Label7.Text = "Reencoding";
            // 
            // btnStopReencoding
            // 
            this.btnStopReencoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopReencoding.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopReencoding.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopReencoding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopReencoding.Location = new System.Drawing.Point(805, 145);
            this.btnStopReencoding.Name = "btnStopReencoding";
            this.btnStopReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopReencoding.Size = new System.Drawing.Size(81, 25);
            this.btnStopReencoding.TabIndex = 34;
            this.btnStopReencoding.Text = "Stop";
            this.btnStopReencoding.Click += new System.EventHandler(this.btnStopReencoding_Click);
            // 
            // btnStartReencoding
            // 
            this.btnStartReencoding.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartReencoding.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartReencoding.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartReencoding.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartReencoding.Location = new System.Drawing.Point(718, 145);
            this.btnStartReencoding.Name = "btnStartReencoding";
            this.btnStartReencoding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartReencoding.Size = new System.Drawing.Size(81, 25);
            this.btnStartReencoding.TabIndex = 33;
            this.btnStartReencoding.Text = "Start";
            this.btnStartReencoding.Click += new System.EventHandler(this.btnStartReencoding_Click);
            // 
            // rdgReencodingMethod
            // 
            this.rdgReencodingMethod.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod.Controls.Add(this.rdgReencodingMethod2);
            this.rdgReencodingMethod.Controls.Add(this.rdgReencodingMethod1);
            this.rdgReencodingMethod.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgReencodingMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod.Location = new System.Drawing.Point(508, 135);
            this.rdgReencodingMethod.Name = "rdgReencodingMethod";
            this.rdgReencodingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod.Size = new System.Drawing.Size(185, 43);
            this.rdgReencodingMethod.TabIndex = 32;
            this.rdgReencodingMethod.TabStop = false;
            this.rdgReencodingMethod.Text = "reencoding method";
            // 
            // rdgReencodingMethod2
            // 
            this.rdgReencodingMethod2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgReencodingMethod2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgReencodingMethod2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod2.Location = new System.Drawing.Point(91, 14);
            this.rdgReencodingMethod2.Name = "rdgReencodingMethod2";
            this.rdgReencodingMethod2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod2.Size = new System.Drawing.Size(88, 25);
            this.rdgReencodingMethod2.TabIndex = 20;
            this.rdgReencodingMethod2.TabStop = true;
            this.rdgReencodingMethod2.Tag = "1";
            this.rdgReencodingMethod2.Text = "ASF (WMV)";
            // 
            // rdgReencodingMethod1
            // 
            this.rdgReencodingMethod1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgReencodingMethod1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgReencodingMethod1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgReencodingMethod1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgReencodingMethod1.Location = new System.Drawing.Point(8, 16);
            this.rdgReencodingMethod1.Name = "rdgReencodingMethod1";
            this.rdgReencodingMethod1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgReencodingMethod1.Size = new System.Drawing.Size(97, 17);
            this.rdgReencodingMethod1.TabIndex = 21;
            this.rdgReencodingMethod1.TabStop = true;
            this.rdgReencodingMethod1.Tag = "0";
            this.rdgReencodingMethod1.Text = "AVI / MPEG";
            // 
            // grbReencodingSettings
            // 
            this.grbReencodingSettings.BackColor = System.Drawing.SystemColors.Control;
            this.grbReencodingSettings.Controls.Add(this.chkWMVOutput);
            this.grbReencodingSettings.Controls.Add(this.chkUseFrameGrabber);
            this.grbReencodingSettings.Controls.Add(this.chkIncludeAudioStream);
            this.grbReencodingSettings.Controls.Add(this.chkUseCurrentVideoCompressor);
            this.grbReencodingSettings.Controls.Add(this.chkIncludeVideoStream);
            this.grbReencodingSettings.Controls.Add(this.chkUseCurrentAudioCompressor);
            this.grbReencodingSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbReencodingSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbReencodingSettings.Location = new System.Drawing.Point(507, 0);
            this.grbReencodingSettings.Name = "grbReencodingSettings";
            this.grbReencodingSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbReencodingSettings.Size = new System.Drawing.Size(401, 132);
            this.grbReencodingSettings.TabIndex = 31;
            this.grbReencodingSettings.TabStop = false;
            this.grbReencodingSettings.Text = "reencoding settings";
            // 
            // chkWMVOutput
            // 
            this.chkWMVOutput.BackColor = System.Drawing.SystemColors.Control;
            this.chkWMVOutput.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkWMVOutput.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWMVOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkWMVOutput.Location = new System.Drawing.Point(11, 19);
            this.chkWMVOutput.Name = "chkWMVOutput";
            this.chkWMVOutput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkWMVOutput.Size = new System.Drawing.Size(359, 17);
            this.chkWMVOutput.TabIndex = 18;
            this.chkWMVOutput.Text = "WMV output  (Windows Media Video)";
            // 
            // chkUseFrameGrabber
            // 
            this.chkUseFrameGrabber.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseFrameGrabber.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseFrameGrabber.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseFrameGrabber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseFrameGrabber.Location = new System.Drawing.Point(11, 103);
            this.chkUseFrameGrabber.Name = "chkUseFrameGrabber";
            this.chkUseFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseFrameGrabber.Size = new System.Drawing.Size(386, 17);
            this.chkUseFrameGrabber.TabIndex = 17;
            this.chkUseFrameGrabber.Text = "use the frame grabber (allows text/graphics overlays, video processing...)";
            // 
            // chkIncludeAudioStream
            // 
            this.chkIncludeAudioStream.BackColor = System.Drawing.SystemColors.Control;
            this.chkIncludeAudioStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIncludeAudioStream.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeAudioStream.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIncludeAudioStream.Location = new System.Drawing.Point(192, 40);
            this.chkIncludeAudioStream.Name = "chkIncludeAudioStream";
            this.chkIncludeAudioStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIncludeAudioStream.Size = new System.Drawing.Size(160, 17);
            this.chkIncludeAudioStream.TabIndex = 16;
            this.chkIncludeAudioStream.Text = "includes the audio stream";
            // 
            // chkUseCurrentVideoCompressor
            // 
            this.chkUseCurrentVideoCompressor.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseCurrentVideoCompressor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseCurrentVideoCompressor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseCurrentVideoCompressor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseCurrentVideoCompressor.Location = new System.Drawing.Point(11, 61);
            this.chkUseCurrentVideoCompressor.Name = "chkUseCurrentVideoCompressor";
            this.chkUseCurrentVideoCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseCurrentVideoCompressor.Size = new System.Drawing.Size(345, 17);
            this.chkUseCurrentVideoCompressor.TabIndex = 15;
            this.chkUseCurrentVideoCompressor.Text = "use the current video compressor (selected in the \"recording\" tab)";
            // 
            // chkIncludeVideoStream
            // 
            this.chkIncludeVideoStream.BackColor = System.Drawing.SystemColors.Control;
            this.chkIncludeVideoStream.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkIncludeVideoStream.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeVideoStream.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkIncludeVideoStream.Location = new System.Drawing.Point(11, 40);
            this.chkIncludeVideoStream.Name = "chkIncludeVideoStream";
            this.chkIncludeVideoStream.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkIncludeVideoStream.Size = new System.Drawing.Size(152, 17);
            this.chkIncludeVideoStream.TabIndex = 14;
            this.chkIncludeVideoStream.Text = "includes the video stream";
            // 
            // chkUseCurrentAudioCompressor
            // 
            this.chkUseCurrentAudioCompressor.BackColor = System.Drawing.SystemColors.Control;
            this.chkUseCurrentAudioCompressor.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkUseCurrentAudioCompressor.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUseCurrentAudioCompressor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkUseCurrentAudioCompressor.Location = new System.Drawing.Point(11, 82);
            this.chkUseCurrentAudioCompressor.Name = "chkUseCurrentAudioCompressor";
            this.chkUseCurrentAudioCompressor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUseCurrentAudioCompressor.Size = new System.Drawing.Size(345, 17);
            this.chkUseCurrentAudioCompressor.TabIndex = 13;
            this.chkUseCurrentAudioCompressor.Text = "use the current audio compressor (selected in the \"recording\" tab)";
            // 
            // grbStartStopTime
            // 
            this.grbStartStopTime.BackColor = System.Drawing.SystemColors.Control;
            this.grbStartStopTime.Controls.Add(this.Label8);
            this.grbStartStopTime.Controls.Add(this.Label6);
            this.grbStartStopTime.Controls.Add(this.Label5);
            this.grbStartStopTime.Controls.Add(this.edtStartFrame);
            this.grbStartStopTime.Controls.Add(this.edtStopFrame);
            this.grbStartStopTime.Controls.Add(this.edtFrameCount);
            this.grbStartStopTime.Controls.Add(this.Label4);
            this.grbStartStopTime.Controls.Add(this.Label3);
            this.grbStartStopTime.Controls.Add(this.Label2);
            this.grbStartStopTime.Controls.Add(this.Label1);
            this.grbStartStopTime.Controls.Add(this.edtDuration);
            this.grbStartStopTime.Controls.Add(this.edtStartTime);
            this.grbStartStopTime.Controls.Add(this.edtStopTime);
            this.grbStartStopTime.Controls.Add(this.btnDuration);
            this.grbStartStopTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStartStopTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbStartStopTime.Location = new System.Drawing.Point(4, 61);
            this.grbStartStopTime.Name = "grbStartStopTime";
            this.grbStartStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbStartStopTime.Size = new System.Drawing.Size(497, 117);
            this.grbStartStopTime.TabIndex = 30;
            this.grbStartStopTime.TabStop = false;
            this.grbStartStopTime.Text = "START / STOP   (optional)";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.Color.Navy;
            this.Label8.Location = new System.Drawing.Point(160, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(317, 14);
            this.Label8.TabIndex = 34;
            this.Label8.Text = "Times are expressed in 100ns units, e.g. 3 seconds = 30000000";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(67, 90);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(160, 14);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "STOP position (-1 = end of clip):";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(32, 63);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(195, 14);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "START position (-1 = beginning of clip):";
            // 
            // edtStartFrame
            // 
            this.edtStartFrame.AcceptsReturn = true;
            this.edtStartFrame.BackColor = System.Drawing.SystemColors.Window;
            this.edtStartFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStartFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStartFrame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStartFrame.Location = new System.Drawing.Point(368, 61);
            this.edtStartFrame.MaxLength = 0;
            this.edtStartFrame.Name = "edtStartFrame";
            this.edtStartFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStartFrame.Size = new System.Drawing.Size(106, 20);
            this.edtStartFrame.TabIndex = 31;
            this.edtStartFrame.Text = "-1";
            // 
            // edtStopFrame
            // 
            this.edtStopFrame.AcceptsReturn = true;
            this.edtStopFrame.BackColor = System.Drawing.SystemColors.Window;
            this.edtStopFrame.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStopFrame.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStopFrame.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStopFrame.Location = new System.Drawing.Point(368, 88);
            this.edtStopFrame.MaxLength = 0;
            this.edtStopFrame.Name = "edtStopFrame";
            this.edtStopFrame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStopFrame.Size = new System.Drawing.Size(106, 20);
            this.edtStopFrame.TabIndex = 30;
            this.edtStopFrame.Text = "-1";
            // 
            // edtFrameCount
            // 
            this.edtFrameCount.AcceptsReturn = true;
            this.edtFrameCount.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtFrameCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtFrameCount.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtFrameCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtFrameCount.Location = new System.Drawing.Point(368, 34);
            this.edtFrameCount.MaxLength = 0;
            this.edtFrameCount.Name = "edtFrameCount";
            this.edtFrameCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtFrameCount.Size = new System.Drawing.Size(106, 20);
            this.edtFrameCount.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(365, 17);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(105, 14);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "the FRAME NUMBER";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(342, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(22, 14);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "OR";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(217, 17);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 14);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "the TIME (in 100ns units)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(169, 17);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(51, 14);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "SPECIFY";
            // 
            // edtDuration
            // 
            this.edtDuration.AcceptsReturn = true;
            this.edtDuration.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtDuration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDuration.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDuration.Location = new System.Drawing.Point(233, 34);
            this.edtDuration.MaxLength = 0;
            this.edtDuration.Name = "edtDuration";
            this.edtDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDuration.Size = new System.Drawing.Size(106, 20);
            this.edtDuration.TabIndex = 24;
            // 
            // edtStartTime
            // 
            this.edtStartTime.AcceptsReturn = true;
            this.edtStartTime.BackColor = System.Drawing.SystemColors.Window;
            this.edtStartTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStartTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStartTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStartTime.Location = new System.Drawing.Point(233, 61);
            this.edtStartTime.MaxLength = 0;
            this.edtStartTime.Name = "edtStartTime";
            this.edtStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStartTime.Size = new System.Drawing.Size(106, 20);
            this.edtStartTime.TabIndex = 8;
            this.edtStartTime.Text = "-1";
            // 
            // edtStopTime
            // 
            this.edtStopTime.AcceptsReturn = true;
            this.edtStopTime.BackColor = System.Drawing.SystemColors.Window;
            this.edtStopTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtStopTime.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtStopTime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtStopTime.Location = new System.Drawing.Point(233, 88);
            this.edtStopTime.MaxLength = 0;
            this.edtStopTime.Name = "edtStopTime";
            this.edtStopTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtStopTime.Size = new System.Drawing.Size(106, 20);
            this.edtStopTime.TabIndex = 7;
            this.edtStopTime.Text = "-1";
            // 
            // btnDuration
            // 
            this.btnDuration.BackColor = System.Drawing.SystemColors.Control;
            this.btnDuration.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDuration.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDuration.Location = new System.Drawing.Point(20, 34);
            this.btnDuration.Name = "btnDuration";
            this.btnDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDuration.Size = new System.Drawing.Size(207, 20);
            this.btnDuration.TabIndex = 6;
            this.btnDuration.Text = "source duration and/or frame count?";
            this.btnDuration.Click += new System.EventHandler(this.btnDuration_Click);
            // 
            // edtDestinationVideoClip
            // 
            this.edtDestinationVideoClip.AcceptsReturn = true;
            this.edtDestinationVideoClip.BackColor = System.Drawing.SystemColors.Window;
            this.edtDestinationVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtDestinationVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDestinationVideoClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtDestinationVideoClip.Location = new System.Drawing.Point(260, 30);
            this.edtDestinationVideoClip.MaxLength = 0;
            this.edtDestinationVideoClip.Name = "edtDestinationVideoClip";
            this.edtDestinationVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtDestinationVideoClip.Size = new System.Drawing.Size(241, 20);
            this.edtDestinationVideoClip.TabIndex = 27;
            // 
            // edtSourceVideoClip
            // 
            this.edtSourceVideoClip.AcceptsReturn = true;
            this.edtSourceVideoClip.BackColor = System.Drawing.SystemColors.Window;
            this.edtSourceVideoClip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtSourceVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSourceVideoClip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtSourceVideoClip.Location = new System.Drawing.Point(260, 2);
            this.edtSourceVideoClip.MaxLength = 0;
            this.edtSourceVideoClip.Name = "edtSourceVideoClip";
            this.edtSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtSourceVideoClip.Size = new System.Drawing.Size(241, 20);
            this.edtSourceVideoClip.TabIndex = 26;
            // 
            // btnSourceVideoClip
            // 
            this.btnSourceVideoClip.BackColor = System.Drawing.SystemColors.Control;
            this.btnSourceVideoClip.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSourceVideoClip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSourceVideoClip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSourceVideoClip.ImageIndex = 0;
            this.btnSourceVideoClip.Location = new System.Drawing.Point(108, 0);
            this.btnSourceVideoClip.Name = "btnSourceVideoClip";
            this.btnSourceVideoClip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSourceVideoClip.Size = new System.Drawing.Size(145, 22);
            this.btnSourceVideoClip.TabIndex = 25;
            this.btnSourceVideoClip.Text = " source video clip...";
#if (!VS2003) 
			this.btnSourceVideoClip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
#endif
			this.btnSourceVideoClip.Click += new System.EventHandler(this.btnSourceVideoClip_Click);
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.BackColor = System.Drawing.SystemColors.Control;
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label33.Location = new System.Drawing.Point(101, 27);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(161, 14);
            this.Label33.TabIndex = 29;
            this.Label33.Text = "file name for the new video clip:";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.BackColor = System.Drawing.SystemColors.Control;
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label32.Location = new System.Drawing.Point(14, 43);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(246, 14);
            this.Label32.TabIndex = 28;
            this.Label32.Text = "(extension will be \".wmv\" if WMV output enabled)";
            // 
            // Reencoding
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(936, 206);
            this.ControlBox = false;
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.btnStopReencoding);
            this.Controls.Add(this.btnStartReencoding);
            this.Controls.Add(this.rdgReencodingMethod);
            this.Controls.Add(this.grbReencodingSettings);
            this.Controls.Add(this.grbStartStopTime);
            this.Controls.Add(this.edtDestinationVideoClip);
            this.Controls.Add(this.edtSourceVideoClip);
            this.Controls.Add(this.btnSourceVideoClip);
            this.Controls.Add(this.Label33);
            this.Controls.Add(this.Label32);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reencoding";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.Reencoding_VisibleChanged);
            this.rdgReencodingMethod.ResumeLayout(false);
            this.grbReencodingSettings.ResumeLayout(false);
            this.grbStartStopTime.ResumeLayout(false);
            this.grbStartStopTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{
			SetRadioButtonInGroupUsingTag((rdgReencodingMethod), (short) cMainForm.axVideoGrabberNET1.Reencoding_Method);
			chkWMVOutput.Checked = cMainForm.axVideoGrabberNET1.Reencoding_WMVOutput;
			chkIncludeVideoStream.Checked = cMainForm.axVideoGrabberNET1.Reencoding_IncludeVideoStream;
			chkIncludeAudioStream.Checked = cMainForm.axVideoGrabberNET1.Reencoding_IncludeAudioStream;
			chkUseFrameGrabber.Checked = cMainForm.axVideoGrabberNET1.Reencoding_UseFrameGrabber;
			chkUseCurrentVideoCompressor.Checked = cMainForm.axVideoGrabberNET1.Reencoding_UseVideoCompressor;
			chkUseCurrentAudioCompressor.Checked = cMainForm.axVideoGrabberNET1.Reencoding_UseAudioCompressor;
			edtStartTime.Text = cMainForm.axVideoGrabberNET1.Reencoding_StartTime.ToString();
			edtStopTime.Text = cMainForm.axVideoGrabberNET1.Reencoding_StopTime.ToString();
		}

		private void btnDuration_Click(object sender, System.EventArgs e)
		{
			double AVIDuration;
			double AVIFrameCount;

			if (cMainForm.axVideoGrabberNET1.AVIDuration(edtSourceVideoClip.Text,out AVIDuration,out AVIFrameCount)) 
			{
				edtDuration.Text = AVIDuration.ToString();
				edtFrameCount.Text = AVIFrameCount.ToString();
			}
		}

		private void btnSourceVideoClip_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			edtSourceVideoClip.Text = "";
			fd.Filter = OPEN_MEDIA_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				edtSourceVideoClip.Text = fd.FileName;
			}
		}

		private void btnStartReencoding_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.Reencoding_SourceVideoClip = edtSourceVideoClip.Text;
			cMainForm.axVideoGrabberNET1.Reencoding_NewVideoClip = edtDestinationVideoClip.Text;

			cMainForm.axVideoGrabberNET1.Reencoding_WMVOutput = chkWMVOutput.Checked;
			cMainForm.axVideoGrabberNET1.Reencoding_IncludeVideoStream = chkIncludeVideoStream.Checked;
			cMainForm.axVideoGrabberNET1.Reencoding_IncludeAudioStream = chkIncludeAudioStream.Checked;
			cMainForm.axVideoGrabberNET1.Reencoding_UseFrameGrabber = chkUseFrameGrabber.Checked;
			cMainForm.axVideoGrabberNET1.Reencoding_UseVideoCompressor = chkUseCurrentVideoCompressor.Checked;
			cMainForm.axVideoGrabberNET1.Reencoding_UseAudioCompressor = chkUseCurrentAudioCompressor.Checked;

			if (rdgReencodingMethod1.Checked) 
			{
				cMainForm.axVideoGrabberNET1.Reencoding_Method = Vidgrab_NET.TxRecordingMethod.rm_AVI;
			}

			if (rdgReencodingMethod2.Checked) 
			{
				;
				cMainForm.axVideoGrabberNET1.Reencoding_Method = Vidgrab_NET.TxRecordingMethod.rm_ASF;
			};

			if (IsNumeric(edtStartTime.Text)) 
			{
				;
				cMainForm.axVideoGrabberNET1.Reencoding_StartTime = Convert.ToDouble (edtStartTime.Text);
			};

			if (IsNumeric(edtStopTime.Text)) 
			{
				;
				cMainForm.axVideoGrabberNET1.Reencoding_StopTime = Convert.ToDouble (edtStopTime.Text);
			};

			if (IsNumeric(edtStartFrame.Text)) 
			{
				;
				cMainForm.axVideoGrabberNET1.Reencoding_StartFrame = Convert.ToDouble (edtStartFrame.Text);
			};

			if (IsNumeric(edtStopFrame.Text)) 
			{
				;
				cMainForm.axVideoGrabberNET1.Reencoding_StopFrame = Convert.ToDouble (edtStopFrame.Text);
			};

			cMainForm.axVideoGrabberNET1.StartReencoding();
		}

		private void btnStopReencoding_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.StopReencoding();
		}

		private void Reencoding_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void btnStartReencoding_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStopReencoding_Click_1(object sender, EventArgs e)
        {

        }

	}
}
