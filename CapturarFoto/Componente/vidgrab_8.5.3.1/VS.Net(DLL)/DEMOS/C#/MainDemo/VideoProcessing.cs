using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for VideoProcessing.
	/// </summary>
	public class VideoProcessing : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal GroupBox grbDetectVideoSignal;
        internal RadioButton rdgConnexantbluescreen;
        internal RadioButton rdgNoVideoSignal;
        internal RadioButton rdgDetectVideoSignalDisabled;
        public GroupBox grbSoftwareVideoProcessing;
        public Label Label1;
        internal NumericUpDown updVideoPixelization;
        internal Label Label3;
        internal TrackBar tbrHue;
        internal TrackBar tbrSaturation;
        internal TrackBar tbrContrast;
        internal TrackBar tbrBrightness;
        public Button btnResetAll;
        public GroupBox rdgVideoRotation;
        internal TextBox edtCustomRotationAngle;
        internal Label Label4;
        public RadioButton rdgVideoRotation9;
        public RadioButton rdgVideoRotation8;
        public RadioButton rdgVideoRotation7;
        public RadioButton rdgVideoRotation6;
        public RadioButton rdgVideoRotation5;
        public RadioButton rdgVideoRotation4;
        public RadioButton rdgVideoRotation0;
        public RadioButton rdgVideoRotation2;
        public RadioButton rdgVideoRotation1;
        public RadioButton rdgVideoRotation3;
        public GroupBox rdgDeinterlacing;
        public RadioButton rdgDeinterlacingFullSize;
        public RadioButton rdgDeinterlacingHalfSize;
        public RadioButton rdgDeinterlacingDisabled;
        public CheckBox chkFlipVertical;
        public CheckBox chkFlipHorizontal;
        public CheckBox chkInvertColors;
        public CheckBox chkGreyScale;
        public GroupBox grbCropping;
        public Label Label32;
        internal TrackBar trkCroppingZoom;
        internal TrackBar trkCroppingY;
        internal TrackBar trkCroppingX;
        public CheckBox chkCroppingEnabled;
        public CheckBox chkCroppingOutbounds;
        public TextBox edtCroppingWidth;
        public TextBox edtCroppingHeight;
        public Button btnCroppingZoomReset;
        public Label Label33;
        public Label Label34;
        public Label Label35;
        public Label Label36;
        public GroupBox grbVMR9Adjust;
        internal Label lblVMR9Available;
        public Label Label2;
        internal Label Label5;
        internal TrackBar tbrVMR9Hue;
        internal TrackBar tbrVMR9Saturation;
        internal TrackBar tbrVMR9Contrast;
        internal TrackBar tbrVMR9Brightness;
        public CheckBox vmr9FixRange;
        internal Label lblSWVideoProcessingRequiresFrameGrabber;
		private System.ComponentModel.IContainer components;

		public VideoProcessing()
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
            this.grbDetectVideoSignal = new System.Windows.Forms.GroupBox();
            this.rdgConnexantbluescreen = new System.Windows.Forms.RadioButton();
            this.rdgNoVideoSignal = new System.Windows.Forms.RadioButton();
            this.rdgDetectVideoSignalDisabled = new System.Windows.Forms.RadioButton();
            this.grbSoftwareVideoProcessing = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.updVideoPixelization = new System.Windows.Forms.NumericUpDown();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbrHue = new System.Windows.Forms.TrackBar();
            this.tbrSaturation = new System.Windows.Forms.TrackBar();
            this.tbrContrast = new System.Windows.Forms.TrackBar();
            this.tbrBrightness = new System.Windows.Forms.TrackBar();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.rdgVideoRotation = new System.Windows.Forms.GroupBox();
            this.edtCustomRotationAngle = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.rdgVideoRotation9 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation7 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation6 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation5 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation4 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation0 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation2 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation1 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation3 = new System.Windows.Forms.RadioButton();
            this.rdgVideoRotation8 = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacing = new System.Windows.Forms.GroupBox();
            this.rdgDeinterlacingFullSize = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacingHalfSize = new System.Windows.Forms.RadioButton();
            this.rdgDeinterlacingDisabled = new System.Windows.Forms.RadioButton();
            this.chkFlipVertical = new System.Windows.Forms.CheckBox();
            this.chkFlipHorizontal = new System.Windows.Forms.CheckBox();
            this.chkInvertColors = new System.Windows.Forms.CheckBox();
            this.chkGreyScale = new System.Windows.Forms.CheckBox();
            this.grbCropping = new System.Windows.Forms.GroupBox();
            this.Label32 = new System.Windows.Forms.Label();
            this.trkCroppingZoom = new System.Windows.Forms.TrackBar();
            this.trkCroppingY = new System.Windows.Forms.TrackBar();
            this.trkCroppingX = new System.Windows.Forms.TrackBar();
            this.chkCroppingEnabled = new System.Windows.Forms.CheckBox();
            this.chkCroppingOutbounds = new System.Windows.Forms.CheckBox();
            this.edtCroppingWidth = new System.Windows.Forms.TextBox();
            this.edtCroppingHeight = new System.Windows.Forms.TextBox();
            this.btnCroppingZoomReset = new System.Windows.Forms.Button();
            this.Label33 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.grbVMR9Adjust = new System.Windows.Forms.GroupBox();
            this.lblVMR9Available = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbrVMR9Hue = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Saturation = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Contrast = new System.Windows.Forms.TrackBar();
            this.tbrVMR9Brightness = new System.Windows.Forms.TrackBar();
            this.vmr9FixRange = new System.Windows.Forms.CheckBox();
            this.lblSWVideoProcessingRequiresFrameGrabber = new System.Windows.Forms.Label();
            this.grbDetectVideoSignal.SuspendLayout();
            this.grbSoftwareVideoProcessing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updVideoPixelization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).BeginInit();
            this.rdgVideoRotation.SuspendLayout();
            this.rdgDeinterlacing.SuspendLayout();
            this.grbCropping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingX)).BeginInit();
            this.grbVMR9Adjust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Brightness)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDetectVideoSignal
            // 
            this.grbDetectVideoSignal.Controls.Add(this.rdgConnexantbluescreen);
            this.grbDetectVideoSignal.Controls.Add(this.rdgNoVideoSignal);
            this.grbDetectVideoSignal.Controls.Add(this.rdgDetectVideoSignalDisabled);
            this.grbDetectVideoSignal.Location = new System.Drawing.Point(484, 131);
            this.grbDetectVideoSignal.Name = "grbDetectVideoSignal";
            this.grbDetectVideoSignal.Size = new System.Drawing.Size(420, 46);
            this.grbDetectVideoSignal.TabIndex = 26;
            this.grbDetectVideoSignal.TabStop = false;
            this.grbDetectVideoSignal.Text = "Detect video signal (adjustable)";
            // 
            // rdgConnexantbluescreen
            // 
#if (!VS2003) 
			this.rdgConnexantbluescreen.AutoSize = true;
#endif
			this.rdgConnexantbluescreen.Location = new System.Drawing.Point(279, 20);
            this.rdgConnexantbluescreen.Name = "rdgConnexantbluescreen";
            this.rdgConnexantbluescreen.Size = new System.Drawing.Size(128, 17);
            this.rdgConnexantbluescreen.TabIndex = 2;
            this.rdgConnexantbluescreen.Text = "Conexant blue screen";
            this.rdgConnexantbluescreen.CheckedChanged += new System.EventHandler(this.rdgConnexantbluescreen_CheckedChanged);
            // 
            // rdgNoVideoSignal
            // 
#if (!VS2003) 
			this.rdgNoVideoSignal.AutoSize = true;
#endif
			this.rdgNoVideoSignal.Location = new System.Drawing.Point(115, 20);
            this.rdgNoVideoSignal.Name = "rdgNoVideoSignal";
            this.rdgNoVideoSignal.Size = new System.Drawing.Size(132, 17);
            this.rdgNoVideoSignal.TabIndex = 1;
            this.rdgNoVideoSignal.Text = "no signal (dark screen)";
            this.rdgNoVideoSignal.CheckedChanged += new System.EventHandler(this.rdgNoVideoSignal_CheckedChanged);
            // 
            // rdgDetectVideoSignalDisabled
            // 
#if (!VS2003) 
			this.rdgDetectVideoSignalDisabled.AutoSize = true;
#endif
			this.rdgDetectVideoSignalDisabled.Checked = true;
            this.rdgDetectVideoSignalDisabled.Location = new System.Drawing.Point(25, 20);
            this.rdgDetectVideoSignalDisabled.Name = "rdgDetectVideoSignalDisabled";
            this.rdgDetectVideoSignalDisabled.Size = new System.Drawing.Size(64, 17);
            this.rdgDetectVideoSignalDisabled.TabIndex = 0;
            this.rdgDetectVideoSignalDisabled.TabStop = true;
            this.rdgDetectVideoSignalDisabled.Text = "disabled";
            this.rdgDetectVideoSignalDisabled.CheckedChanged += new System.EventHandler(this.rdgDetectVideoSignalDisabled_CheckedChanged);
            // 
            // grbSoftwareVideoProcessing
            // 
            this.grbSoftwareVideoProcessing.BackColor = System.Drawing.SystemColors.Control;
            this.grbSoftwareVideoProcessing.Controls.Add(this.lblSWVideoProcessingRequiresFrameGrabber);
            this.grbSoftwareVideoProcessing.Controls.Add(this.Label1);
            this.grbSoftwareVideoProcessing.Controls.Add(this.updVideoPixelization);
            this.grbSoftwareVideoProcessing.Controls.Add(this.Label3);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrHue);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrSaturation);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrContrast);
            this.grbSoftwareVideoProcessing.Controls.Add(this.tbrBrightness);
            this.grbSoftwareVideoProcessing.Controls.Add(this.btnResetAll);
            this.grbSoftwareVideoProcessing.Controls.Add(this.rdgVideoRotation);
            this.grbSoftwareVideoProcessing.Controls.Add(this.rdgDeinterlacing);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkFlipVertical);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkFlipHorizontal);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkInvertColors);
            this.grbSoftwareVideoProcessing.Controls.Add(this.chkGreyScale);
            this.grbSoftwareVideoProcessing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSoftwareVideoProcessing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbSoftwareVideoProcessing.Location = new System.Drawing.Point(4, 0);
            this.grbSoftwareVideoProcessing.Name = "grbSoftwareVideoProcessing";
            this.grbSoftwareVideoProcessing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbSoftwareVideoProcessing.Size = new System.Drawing.Size(473, 177);
            this.grbSoftwareVideoProcessing.TabIndex = 25;
            this.grbSoftwareVideoProcessing.TabStop = false;
            this.grbSoftwareVideoProcessing.Text = "Software video processing";
            // 
            // Label1
            // 
#if (!VS2003) 
			this.Label1.AutoSize = true;
#endif
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(340, 148);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(123, 14);
            this.Label1.TabIndex = 40;
            this.Label1.Text = "bright  contr. satur.  hue";
            // 
            // updVideoPixelization
            // 
            this.updVideoPixelization.Location = new System.Drawing.Point(294, 131);
            this.updVideoPixelization.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updVideoPixelization.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updVideoPixelization.Name = "updVideoPixelization";
            this.updVideoPixelization.Size = new System.Drawing.Size(40, 20);
            this.updVideoPixelization.TabIndex = 45;
            this.updVideoPixelization.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updVideoPixelization.ValueChanged += new System.EventHandler(this.updVideoPixelization_ValueChanged);
            // 
            // Label3
            // 
#if (!VS2003) 
			this.Label3.AutoSize = true;
#endif
			this.Label3.Location = new System.Drawing.Point(229, 133);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 14);
            this.Label3.TabIndex = 46;
            this.Label3.Text = "pixellization:";
            // 
            // tbrHue
            // 
#if (!VS2003) 
			this.tbrHue.AutoSize = false;
#endif
			this.tbrHue.Location = new System.Drawing.Point(444, 17);
            this.tbrHue.Maximum = 180;
            this.tbrHue.Minimum = -180;
            this.tbrHue.Name = "tbrHue";
            this.tbrHue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrHue.Size = new System.Drawing.Size(18, 134);
            this.tbrHue.TabIndex = 44;
            this.tbrHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrHue.Scroll += new System.EventHandler(this.tbrHue_Scroll);
            // 
            // tbrSaturation
            // 
#if (!VS2003) 
			this.tbrSaturation.AutoSize = false;
#endif
			this.tbrSaturation.Location = new System.Drawing.Point(414, 18);
            this.tbrSaturation.Maximum = 64;
            this.tbrSaturation.Minimum = -64;
            this.tbrSaturation.Name = "tbrSaturation";
            this.tbrSaturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrSaturation.Size = new System.Drawing.Size(18, 133);
            this.tbrSaturation.TabIndex = 43;
            this.tbrSaturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrSaturation.Scroll += new System.EventHandler(this.tbrSaturation_Scroll);
            // 
            // tbrContrast
            // 
#if (!VS2003) 
			this.tbrContrast.AutoSize = false;
#endif
			this.tbrContrast.Location = new System.Drawing.Point(384, 18);
            this.tbrContrast.Maximum = 128;
            this.tbrContrast.Minimum = -128;
            this.tbrContrast.Name = "tbrContrast";
            this.tbrContrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrContrast.Size = new System.Drawing.Size(18, 133);
            this.tbrContrast.TabIndex = 42;
            this.tbrContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrContrast.Scroll += new System.EventHandler(this.tbrContrast_Scroll);
            // 
            // tbrBrightness
            // 
#if (!VS2003) 
			this.tbrBrightness.AutoSize = false;
#endif
			this.tbrBrightness.Location = new System.Drawing.Point(354, 18);
            this.tbrBrightness.Maximum = 128;
            this.tbrBrightness.Minimum = -128;
            this.tbrBrightness.Name = "tbrBrightness";
            this.tbrBrightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrBrightness.Size = new System.Drawing.Size(18, 133);
            this.tbrBrightness.TabIndex = 41;
            this.tbrBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrBrightness.Scroll += new System.EventHandler(this.tbrBrightness_Scroll);
            // 
            // btnResetAll
            // 
            this.btnResetAll.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetAll.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetAll.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetAll.Location = new System.Drawing.Point(17, 21);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetAll.Size = new System.Drawing.Size(110, 21);
            this.btnResetAll.TabIndex = 39;
            this.btnResetAll.Text = "reset all";
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // rdgVideoRotation
            // 
            this.rdgVideoRotation.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation.Controls.Add(this.edtCustomRotationAngle);
            this.rdgVideoRotation.Controls.Add(this.Label4);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation9);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation7);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation6);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation5);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation4);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation0);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation2);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation1);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation3);
            this.rdgVideoRotation.Controls.Add(this.rdgVideoRotation8);
            this.rdgVideoRotation.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation.Location = new System.Drawing.Point(8, 48);
            this.rdgVideoRotation.Name = "rdgVideoRotation";
            this.rdgVideoRotation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation.Size = new System.Drawing.Size(215, 123);
            this.rdgVideoRotation.TabIndex = 30;
            this.rdgVideoRotation.TabStop = false;
            this.rdgVideoRotation.Text = "Video rotation (in degrees)";
            // 
            // edtCustomRotationAngle
            // 
            this.edtCustomRotationAngle.Location = new System.Drawing.Point(167, 96);
            this.edtCustomRotationAngle.Name = "edtCustomRotationAngle";
            this.edtCustomRotationAngle.Size = new System.Drawing.Size(40, 20);
            this.edtCustomRotationAngle.TabIndex = 50;
            this.edtCustomRotationAngle.TextChanged += new System.EventHandler(this.edtCustomRotationAngle_TextChanged);
            // 
            // Label4
            // 
#if (!VS2003) 
			this.Label4.AutoSize = true;
#endif
			this.Label4.Location = new System.Drawing.Point(6, 99);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(161, 14);
            this.Label4.TabIndex = 49;
            this.Label4.Text = "custom rotation angle (<= 360°):";
            // 
            // rdgVideoRotation9
            // 
            this.rdgVideoRotation9.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation9.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation9.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation9.Location = new System.Drawing.Point(95, 76);
            this.rdgVideoRotation9.Name = "rdgVideoRotation9";
            this.rdgVideoRotation9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation9.Size = new System.Drawing.Size(104, 17);
            this.rdgVideoRotation9.TabIndex = 40;
            this.rdgVideoRotation9.TabStop = true;
            this.rdgVideoRotation9.Tag = "9";
            this.rdgVideoRotation9.Text = "custom ° mirror";
            this.rdgVideoRotation9.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation7
            // 
            this.rdgVideoRotation7.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation7.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation7.Location = new System.Drawing.Point(95, 60);
            this.rdgVideoRotation7.Name = "rdgVideoRotation7";
            this.rdgVideoRotation7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation7.Size = new System.Drawing.Size(81, 17);
            this.rdgVideoRotation7.TabIndex = 38;
            this.rdgVideoRotation7.TabStop = true;
            this.rdgVideoRotation7.Tag = "7";
            this.rdgVideoRotation7.Text = "270° mirror";
            this.rdgVideoRotation7.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation6
            // 
            this.rdgVideoRotation6.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation6.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation6.Location = new System.Drawing.Point(95, 44);
            this.rdgVideoRotation6.Name = "rdgVideoRotation6";
            this.rdgVideoRotation6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation6.Size = new System.Drawing.Size(81, 17);
            this.rdgVideoRotation6.TabIndex = 37;
            this.rdgVideoRotation6.TabStop = true;
            this.rdgVideoRotation6.Tag = "6";
            this.rdgVideoRotation6.Text = "180° mirror";
            this.rdgVideoRotation6.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation5
            // 
            this.rdgVideoRotation5.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation5.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation5.Location = new System.Drawing.Point(95, 28);
            this.rdgVideoRotation5.Name = "rdgVideoRotation5";
            this.rdgVideoRotation5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation5.Size = new System.Drawing.Size(80, 17);
            this.rdgVideoRotation5.TabIndex = 36;
            this.rdgVideoRotation5.TabStop = true;
            this.rdgVideoRotation5.Tag = "5";
            this.rdgVideoRotation5.Text = "90° mirror";
            this.rdgVideoRotation5.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation4
            // 
            this.rdgVideoRotation4.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation4.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation4.Location = new System.Drawing.Point(95, 12);
            this.rdgVideoRotation4.Name = "rdgVideoRotation4";
            this.rdgVideoRotation4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation4.Size = new System.Drawing.Size(104, 17);
            this.rdgVideoRotation4.TabIndex = 35;
            this.rdgVideoRotation4.TabStop = true;
            this.rdgVideoRotation4.Tag = "4";
            this.rdgVideoRotation4.Text = "0° mirror";
            this.rdgVideoRotation4.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation0
            // 
            this.rdgVideoRotation0.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation0.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation0.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation0.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation0.Location = new System.Drawing.Point(24, 12);
            this.rdgVideoRotation0.Name = "rdgVideoRotation0";
            this.rdgVideoRotation0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation0.Size = new System.Drawing.Size(41, 17);
            this.rdgVideoRotation0.TabIndex = 34;
            this.rdgVideoRotation0.TabStop = true;
            this.rdgVideoRotation0.Tag = "0";
            this.rdgVideoRotation0.Text = "0°";
            this.rdgVideoRotation0.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation2
            // 
            this.rdgVideoRotation2.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation2.Location = new System.Drawing.Point(24, 44);
            this.rdgVideoRotation2.Name = "rdgVideoRotation2";
            this.rdgVideoRotation2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation2.Size = new System.Drawing.Size(48, 17);
            this.rdgVideoRotation2.TabIndex = 33;
            this.rdgVideoRotation2.TabStop = true;
            this.rdgVideoRotation2.Tag = "2";
            this.rdgVideoRotation2.Text = "180°";
            this.rdgVideoRotation2.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation1
            // 
            this.rdgVideoRotation1.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation1.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation1.Location = new System.Drawing.Point(24, 28);
            this.rdgVideoRotation1.Name = "rdgVideoRotation1";
            this.rdgVideoRotation1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation1.Size = new System.Drawing.Size(41, 17);
            this.rdgVideoRotation1.TabIndex = 32;
            this.rdgVideoRotation1.TabStop = true;
            this.rdgVideoRotation1.Tag = "1";
            this.rdgVideoRotation1.Text = "90°";
            this.rdgVideoRotation1.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation3
            // 
            this.rdgVideoRotation3.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation3.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation3.Location = new System.Drawing.Point(24, 60);
            this.rdgVideoRotation3.Name = "rdgVideoRotation3";
            this.rdgVideoRotation3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation3.Size = new System.Drawing.Size(48, 17);
            this.rdgVideoRotation3.TabIndex = 31;
            this.rdgVideoRotation3.TabStop = true;
            this.rdgVideoRotation3.Tag = "3";
            this.rdgVideoRotation3.Text = "270°";
            this.rdgVideoRotation3.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgVideoRotation8
            // 
            this.rdgVideoRotation8.BackColor = System.Drawing.SystemColors.Control;
            this.rdgVideoRotation8.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgVideoRotation8.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgVideoRotation8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgVideoRotation8.Location = new System.Drawing.Point(24, 76);
            this.rdgVideoRotation8.Name = "rdgVideoRotation8";
            this.rdgVideoRotation8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgVideoRotation8.Size = new System.Drawing.Size(96, 17);
            this.rdgVideoRotation8.TabIndex = 39;
            this.rdgVideoRotation8.TabStop = true;
            this.rdgVideoRotation8.Tag = "8";
            this.rdgVideoRotation8.Text = "custom °";
            this.rdgVideoRotation8.CheckedChanged += new System.EventHandler(this.rdgVideoRotation_CheckedChanged);
            // 
            // rdgDeinterlacing
            // 
            this.rdgDeinterlacing.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingFullSize);
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingHalfSize);
            this.rdgDeinterlacing.Controls.Add(this.rdgDeinterlacingDisabled);
            this.rdgDeinterlacing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgDeinterlacing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacing.Location = new System.Drawing.Point(229, 48);
            this.rdgDeinterlacing.Name = "rdgDeinterlacing";
            this.rdgDeinterlacing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacing.Size = new System.Drawing.Size(105, 72);
            this.rdgDeinterlacing.TabIndex = 26;
            this.rdgDeinterlacing.TabStop = false;
            this.rdgDeinterlacing.Text = "deinterlacing";
            // 
            // rdgDeinterlacingFullSize
            // 
            this.rdgDeinterlacingFullSize.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingFullSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingFullSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgDeinterlacingFullSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingFullSize.Location = new System.Drawing.Point(16, 48);
            this.rdgDeinterlacingFullSize.Name = "rdgDeinterlacingFullSize";
            this.rdgDeinterlacingFullSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingFullSize.Size = new System.Drawing.Size(81, 18);
            this.rdgDeinterlacingFullSize.TabIndex = 29;
            this.rdgDeinterlacingFullSize.TabStop = true;
            this.rdgDeinterlacingFullSize.Tag = "2";
            this.rdgDeinterlacingFullSize.Text = "full size";
            this.rdgDeinterlacingFullSize.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // rdgDeinterlacingHalfSize
            // 
            this.rdgDeinterlacingHalfSize.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingHalfSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingHalfSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgDeinterlacingHalfSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingHalfSize.Location = new System.Drawing.Point(16, 32);
            this.rdgDeinterlacingHalfSize.Name = "rdgDeinterlacingHalfSize";
            this.rdgDeinterlacingHalfSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingHalfSize.Size = new System.Drawing.Size(81, 18);
            this.rdgDeinterlacingHalfSize.TabIndex = 28;
            this.rdgDeinterlacingHalfSize.TabStop = true;
            this.rdgDeinterlacingHalfSize.Tag = "1";
            this.rdgDeinterlacingHalfSize.Text = "half-size";
            this.rdgDeinterlacingHalfSize.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // rdgDeinterlacingDisabled
            // 
            this.rdgDeinterlacingDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.rdgDeinterlacingDisabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgDeinterlacingDisabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgDeinterlacingDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgDeinterlacingDisabled.Location = new System.Drawing.Point(16, 16);
            this.rdgDeinterlacingDisabled.Name = "rdgDeinterlacingDisabled";
            this.rdgDeinterlacingDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgDeinterlacingDisabled.Size = new System.Drawing.Size(81, 18);
            this.rdgDeinterlacingDisabled.TabIndex = 27;
            this.rdgDeinterlacingDisabled.TabStop = true;
            this.rdgDeinterlacingDisabled.Tag = "0";
            this.rdgDeinterlacingDisabled.Text = "disabled";
            this.rdgDeinterlacingDisabled.CheckedChanged += new System.EventHandler(this.rdgDeinterlacing_CheckedChanged);
            // 
            // chkFlipVertical
            // 
            this.chkFlipVertical.BackColor = System.Drawing.SystemColors.Control;
            this.chkFlipVertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlipVertical.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlipVertical.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFlipVertical.Location = new System.Drawing.Point(245, 16);
            this.chkFlipVertical.Name = "chkFlipVertical";
            this.chkFlipVertical.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFlipVertical.Size = new System.Drawing.Size(81, 17);
            this.chkFlipVertical.TabIndex = 25;
            this.chkFlipVertical.Text = "flip vertical";
            this.chkFlipVertical.CheckedChanged += new System.EventHandler(this.chkFlipVertical_CheckedChanged);
            // 
            // chkFlipHorizontal
            // 
            this.chkFlipHorizontal.BackColor = System.Drawing.SystemColors.Control;
            this.chkFlipHorizontal.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFlipHorizontal.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFlipHorizontal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFlipHorizontal.Location = new System.Drawing.Point(245, 32);
            this.chkFlipHorizontal.Name = "chkFlipHorizontal";
            this.chkFlipHorizontal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFlipHorizontal.Size = new System.Drawing.Size(89, 17);
            this.chkFlipHorizontal.TabIndex = 24;
            this.chkFlipHorizontal.Text = "flip horizontal";
            this.chkFlipHorizontal.CheckedChanged += new System.EventHandler(this.chkFlipHorizontal_CheckedChanged);
            // 
            // chkInvertColors
            // 
            this.chkInvertColors.BackColor = System.Drawing.SystemColors.Control;
            this.chkInvertColors.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkInvertColors.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvertColors.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkInvertColors.Location = new System.Drawing.Point(152, 32);
            this.chkInvertColors.Name = "chkInvertColors";
            this.chkInvertColors.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInvertColors.Size = new System.Drawing.Size(97, 17);
            this.chkInvertColors.TabIndex = 22;
            this.chkInvertColors.Text = "inverted colors";
            this.chkInvertColors.CheckedChanged += new System.EventHandler(this.chkInvertColors_CheckedChanged);
            // 
            // chkGreyScale
            // 
            this.chkGreyScale.BackColor = System.Drawing.SystemColors.Control;
            this.chkGreyScale.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkGreyScale.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreyScale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkGreyScale.Location = new System.Drawing.Point(152, 16);
            this.chkGreyScale.Name = "chkGreyScale";
            this.chkGreyScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkGreyScale.Size = new System.Drawing.Size(96, 17);
            this.chkGreyScale.TabIndex = 23;
            this.chkGreyScale.Text = "greyscale";
            this.chkGreyScale.CheckedChanged += new System.EventHandler(this.chkGreyScale_CheckedChanged);
            // 
            // grbCropping
            // 
            this.grbCropping.BackColor = System.Drawing.SystemColors.Control;
            this.grbCropping.Controls.Add(this.Label32);
            this.grbCropping.Controls.Add(this.trkCroppingZoom);
            this.grbCropping.Controls.Add(this.trkCroppingY);
            this.grbCropping.Controls.Add(this.trkCroppingX);
            this.grbCropping.Controls.Add(this.chkCroppingEnabled);
            this.grbCropping.Controls.Add(this.chkCroppingOutbounds);
            this.grbCropping.Controls.Add(this.edtCroppingWidth);
            this.grbCropping.Controls.Add(this.edtCroppingHeight);
            this.grbCropping.Controls.Add(this.btnCroppingZoomReset);
            this.grbCropping.Controls.Add(this.Label33);
            this.grbCropping.Controls.Add(this.Label34);
            this.grbCropping.Controls.Add(this.Label35);
            this.grbCropping.Controls.Add(this.Label36);
            this.grbCropping.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCropping.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbCropping.Location = new System.Drawing.Point(645, 1);
            this.grbCropping.Name = "grbCropping";
            this.grbCropping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbCropping.Size = new System.Drawing.Size(259, 129);
            this.grbCropping.TabIndex = 24;
            this.grbCropping.TabStop = false;
            this.grbCropping.Text = "Cropping";
            // 
            // Label32
            // 
#if (!VS2003) 
			this.Label32.AutoSize = true;
#endif
			this.Label32.BackColor = System.Drawing.SystemColors.Control;
            this.Label32.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label32.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label32.Location = new System.Drawing.Point(86, 102);
            this.Label32.Name = "Label32";
            this.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label32.Size = new System.Drawing.Size(35, 14);
            this.Label32.TabIndex = 19;
            this.Label32.Text = "X pos";
            // 
            // trkCroppingZoom
            // 
#if (!VS2003) 
			this.trkCroppingZoom.AutoSize = false;
#endif
			this.trkCroppingZoom.Location = new System.Drawing.Point(11, 73);
            this.trkCroppingZoom.Maximum = 1000;
            this.trkCroppingZoom.Name = "trkCroppingZoom";
            this.trkCroppingZoom.Size = new System.Drawing.Size(184, 20);
            this.trkCroppingZoom.TabIndex = 47;
            this.trkCroppingZoom.TickFrequency = 50;
            this.trkCroppingZoom.Value = 100;
            this.trkCroppingZoom.Scroll += new System.EventHandler(this.trkCroppingZoom_Scroll);
            // 
            // trkCroppingY
            // 
#if (!VS2003) 
			this.trkCroppingY.AutoSize = false;
#endif
			this.trkCroppingY.Location = new System.Drawing.Point(229, 11);
            this.trkCroppingY.Maximum = 30000;
            this.trkCroppingY.Name = "trkCroppingY";
            this.trkCroppingY.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkCroppingY.Size = new System.Drawing.Size(20, 112);
            this.trkCroppingY.TabIndex = 46;
            this.trkCroppingY.TickFrequency = 3000;
            this.trkCroppingY.Scroll += new System.EventHandler(this.trkCroppingY_Scroll);
            // 
            // trkCroppingX
            // 
#if (!VS2003) 
			this.trkCroppingX.AutoSize = false;
#endif
			this.trkCroppingX.Location = new System.Drawing.Point(118, 99);
            this.trkCroppingX.Maximum = 30000;
            this.trkCroppingX.Name = "trkCroppingX";
            this.trkCroppingX.Size = new System.Drawing.Size(105, 20);
            this.trkCroppingX.TabIndex = 20;
            this.trkCroppingX.TickFrequency = 3000;
            this.trkCroppingX.Scroll += new System.EventHandler(this.trkCroppingX_Scroll);
            // 
            // chkCroppingEnabled
            // 
            this.chkCroppingEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkCroppingEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCroppingEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCroppingEnabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCroppingEnabled.Location = new System.Drawing.Point(11, 16);
            this.chkCroppingEnabled.Name = "chkCroppingEnabled";
            this.chkCroppingEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCroppingEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkCroppingEnabled.TabIndex = 12;
            this.chkCroppingEnabled.Text = "enabled";
            this.chkCroppingEnabled.CheckedChanged += new System.EventHandler(this.chkCroppingEnabled_CheckedChanged);
            // 
            // chkCroppingOutbounds
            // 
            this.chkCroppingOutbounds.BackColor = System.Drawing.SystemColors.Control;
            this.chkCroppingOutbounds.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCroppingOutbounds.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCroppingOutbounds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCroppingOutbounds.Location = new System.Drawing.Point(11, 37);
            this.chkCroppingOutbounds.Name = "chkCroppingOutbounds";
            this.chkCroppingOutbounds.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCroppingOutbounds.Size = new System.Drawing.Size(80, 17);
            this.chkCroppingOutbounds.TabIndex = 11;
            this.chkCroppingOutbounds.Text = "out bounds";
            this.chkCroppingOutbounds.CheckedChanged += new System.EventHandler(this.chkCroppingOutbounds_CheckedChanged);
            // 
            // edtCroppingWidth
            // 
            this.edtCroppingWidth.AcceptsReturn = true;
            this.edtCroppingWidth.BackColor = System.Drawing.SystemColors.Window;
            this.edtCroppingWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCroppingWidth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCroppingWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCroppingWidth.Location = new System.Drawing.Point(159, 13);
            this.edtCroppingWidth.MaxLength = 0;
            this.edtCroppingWidth.Name = "edtCroppingWidth";
            this.edtCroppingWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCroppingWidth.Size = new System.Drawing.Size(49, 20);
            this.edtCroppingWidth.TabIndex = 10;
            this.edtCroppingWidth.TextChanged += new System.EventHandler(this.edtCroppingWidth_TextChanged);
            // 
            // edtCroppingHeight
            // 
            this.edtCroppingHeight.AcceptsReturn = true;
            this.edtCroppingHeight.BackColor = System.Drawing.SystemColors.Window;
            this.edtCroppingHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCroppingHeight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCroppingHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCroppingHeight.Location = new System.Drawing.Point(159, 37);
            this.edtCroppingHeight.MaxLength = 0;
            this.edtCroppingHeight.Name = "edtCroppingHeight";
            this.edtCroppingHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCroppingHeight.Size = new System.Drawing.Size(49, 20);
            this.edtCroppingHeight.TabIndex = 9;
            this.edtCroppingHeight.TextChanged += new System.EventHandler(this.edtCroppingHeight_TextChanged);
            // 
            // btnCroppingZoomReset
            // 
            this.btnCroppingZoomReset.BackColor = System.Drawing.SystemColors.Control;
            this.btnCroppingZoomReset.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCroppingZoomReset.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCroppingZoomReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCroppingZoomReset.Location = new System.Drawing.Point(11, 101);
            this.btnCroppingZoomReset.Name = "btnCroppingZoomReset";
            this.btnCroppingZoomReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCroppingZoomReset.Size = new System.Drawing.Size(65, 21);
            this.btnCroppingZoomReset.TabIndex = 7;
            this.btnCroppingZoomReset.Text = "reset";
            this.btnCroppingZoomReset.Click += new System.EventHandler(this.btnCroppingZoomReset_Click);
            // 
            // Label33
            // 
#if (!VS2003) 
			this.Label33.AutoSize = true;
#endif
			this.Label33.BackColor = System.Drawing.SystemColors.Control;
            this.Label33.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label33.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label33.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label33.Location = new System.Drawing.Point(197, 62);
            this.Label33.Name = "Label33";
            this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label33.Size = new System.Drawing.Size(36, 14);
            this.Label33.TabIndex = 18;
            this.Label33.Text = "Y pos";
            // 
            // Label34
            // 
            this.Label34.BackColor = System.Drawing.SystemColors.Control;
            this.Label34.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label34.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label34.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label34.Location = new System.Drawing.Point(8, 59);
            this.Label34.Name = "Label34";
            this.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label34.Size = new System.Drawing.Size(80, 17);
            this.Label34.TabIndex = 17;
            this.Label34.Text = "cropping zoom";
            // 
            // Label35
            // 
#if (!VS2003) 
			this.Label35.AutoSize = true;
#endif
			this.Label35.BackColor = System.Drawing.SystemColors.Control;
            this.Label35.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label35.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label35.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label35.Location = new System.Drawing.Point(97, 17);
            this.Label35.Name = "Label35";
            this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label35.Size = new System.Drawing.Size(59, 14);
            this.Label35.TabIndex = 16;
            this.Label35.Text = "area width";
            // 
            // Label36
            // 
#if (!VS2003) 
			this.Label36.AutoSize = true;
#endif
			this.Label36.BackColor = System.Drawing.SystemColors.Control;
            this.Label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label36.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label36.Location = new System.Drawing.Point(97, 39);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label36.Size = new System.Drawing.Size(61, 14);
            this.Label36.TabIndex = 15;
            this.Label36.Text = "area height";
            // 
            // grbVMR9Adjust
            // 
            this.grbVMR9Adjust.BackColor = System.Drawing.SystemColors.Control;
            this.grbVMR9Adjust.Controls.Add(this.lblVMR9Available);
            this.grbVMR9Adjust.Controls.Add(this.Label2);
            this.grbVMR9Adjust.Controls.Add(this.Label5);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Hue);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Saturation);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Contrast);
            this.grbVMR9Adjust.Controls.Add(this.tbrVMR9Brightness);
            this.grbVMR9Adjust.Controls.Add(this.vmr9FixRange);
            this.grbVMR9Adjust.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbVMR9Adjust.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbVMR9Adjust.Location = new System.Drawing.Point(484, 0);
            this.grbVMR9Adjust.Name = "grbVMR9Adjust";
            this.grbVMR9Adjust.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbVMR9Adjust.Size = new System.Drawing.Size(153, 130);
            this.grbVMR9Adjust.TabIndex = 23;
            this.grbVMR9Adjust.TabStop = false;
            this.grbVMR9Adjust.Text = "VMR9 image adjustment";
            // 
            // lblVMR9Available
            // 
            this.lblVMR9Available.BackColor = System.Drawing.Color.Red;
            this.lblVMR9Available.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVMR9Available.Location = new System.Drawing.Point(17, 90);
            this.lblVMR9Available.Name = "lblVMR9Available";
            this.lblVMR9Available.Size = new System.Drawing.Size(10, 10);
            this.lblVMR9Available.TabIndex = 50;
            // 
            // Label2
            // 
#if (!VS2003) 
			this.Label2.AutoSize = true;
#endif
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(43, 108);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(106, 14);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "bright cont. sat.  hue";
            // 
            // Label5
            // 
#if (!VS2003) 
			this.Label5.AutoSize = true;
#endif
			this.Label5.Location = new System.Drawing.Point(6, 40);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(35, 28);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "fix\r\nrange";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbrVMR9Hue
            // 
            this.tbrVMR9Hue.AutoSize = false;
            this.tbrVMR9Hue.Location = new System.Drawing.Point(129, 13);
            this.tbrVMR9Hue.Maximum = 180;
            this.tbrVMR9Hue.Minimum = -180;
            this.tbrVMR9Hue.Name = "tbrVMR9Hue";
            this.tbrVMR9Hue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Hue.Size = new System.Drawing.Size(18, 101);
            this.tbrVMR9Hue.TabIndex = 48;
            this.tbrVMR9Hue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Hue.Scroll += new System.EventHandler(this.tbrVMR9Hue_Scroll);
            // 
            // tbrVMR9Saturation
            // 
            this.tbrVMR9Saturation.AutoSize = false;
            this.tbrVMR9Saturation.Location = new System.Drawing.Point(105, 13);
            this.tbrVMR9Saturation.Maximum = 64;
            this.tbrVMR9Saturation.Minimum = -64;
            this.tbrVMR9Saturation.Name = "tbrVMR9Saturation";
            this.tbrVMR9Saturation.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Saturation.Size = new System.Drawing.Size(18, 101);
            this.tbrVMR9Saturation.TabIndex = 47;
            this.tbrVMR9Saturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Saturation.Scroll += new System.EventHandler(this.tbrVMR9Saturation_Scroll);
            // 
            // tbrVMR9Contrast
            // 
            this.tbrVMR9Contrast.AutoSize = false;
            this.tbrVMR9Contrast.Location = new System.Drawing.Point(81, 13);
            this.tbrVMR9Contrast.Maximum = 128;
            this.tbrVMR9Contrast.Minimum = -128;
            this.tbrVMR9Contrast.Name = "tbrVMR9Contrast";
            this.tbrVMR9Contrast.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Contrast.Size = new System.Drawing.Size(18, 101);
            this.tbrVMR9Contrast.TabIndex = 46;
            this.tbrVMR9Contrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Contrast.Scroll += new System.EventHandler(this.tbrVMR9Contrast_Scroll);
            // 
            // tbrVMR9Brightness
            // 
            this.tbrVMR9Brightness.AutoSize = false;
            this.tbrVMR9Brightness.Location = new System.Drawing.Point(57, 13);
            this.tbrVMR9Brightness.Maximum = 128;
            this.tbrVMR9Brightness.Minimum = -128;
            this.tbrVMR9Brightness.Name = "tbrVMR9Brightness";
            this.tbrVMR9Brightness.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrVMR9Brightness.Size = new System.Drawing.Size(18, 101);
            this.tbrVMR9Brightness.TabIndex = 45;
            this.tbrVMR9Brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbrVMR9Brightness.Scroll += new System.EventHandler(this.tbrVMR9Brightness_Scroll);
            // 
            // vmr9FixRange
            // 
            this.vmr9FixRange.BackColor = System.Drawing.SystemColors.Control;
            this.vmr9FixRange.Checked = true;
            this.vmr9FixRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vmr9FixRange.Cursor = System.Windows.Forms.Cursors.Default;
            this.vmr9FixRange.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vmr9FixRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vmr9FixRange.Location = new System.Drawing.Point(15, 21);
            this.vmr9FixRange.Name = "vmr9FixRange";
            this.vmr9FixRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vmr9FixRange.Size = new System.Drawing.Size(20, 21);
            this.vmr9FixRange.TabIndex = 1;
            this.vmr9FixRange.CheckedChanged += new System.EventHandler(this.vmr9FixRange_CheckedChanged);
            // 
            // lblSWVideoProcessingRequiresFrameGrabber
            // 
            this.lblSWVideoProcessingRequiresFrameGrabber.AutoSize = true;
            this.lblSWVideoProcessingRequiresFrameGrabber.ForeColor = System.Drawing.Color.Red;
            this.lblSWVideoProcessingRequiresFrameGrabber.Location = new System.Drawing.Point(172, 0);
            this.lblSWVideoProcessingRequiresFrameGrabber.Name = "lblSWVideoProcessingRequiresFrameGrabber";
            this.lblSWVideoProcessingRequiresFrameGrabber.Size = new System.Drawing.Size(176, 14);
            this.lblSWVideoProcessingRequiresFrameGrabber.TabIndex = 48;
            this.lblSWVideoProcessingRequiresFrameGrabber.Text = "the frame grabber must be enabled";
            this.lblSWVideoProcessingRequiresFrameGrabber.Visible = false;
            // 
            // VideoProcessing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(935, 234);
            this.ControlBox = false;
            this.Controls.Add(this.grbDetectVideoSignal);
            this.Controls.Add(this.grbSoftwareVideoProcessing);
            this.Controls.Add(this.grbCropping);
            this.Controls.Add(this.grbVMR9Adjust);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VideoProcessing";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.VideoProcessing_VisibleChanged);
            this.grbDetectVideoSignal.ResumeLayout(false);
            this.grbDetectVideoSignal.PerformLayout();
            this.grbSoftwareVideoProcessing.ResumeLayout(false);
            this.grbSoftwareVideoProcessing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updVideoPixelization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrHue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrSaturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrBrightness)).EndInit();
            this.rdgVideoRotation.ResumeLayout(false);
            this.rdgVideoRotation.PerformLayout();
            this.rdgDeinterlacing.ResumeLayout(false);
            this.grbCropping.ResumeLayout(false);
            this.grbCropping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkCroppingX)).EndInit();
            this.grbVMR9Adjust.ResumeLayout(false);
            this.grbVMR9Adjust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrVMR9Brightness)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		public void RefreshControls()
		{
			SetRadioButtonInGroupUsingTag(rdgVideoRotation, (short) cMainForm.VideoGrabber1.VideoProcessing_Rotation);
			edtCustomRotationAngle.Text = cMainForm.VideoGrabber1.VideoProcessing_RotationCustomAngle.ToString();

			SetRadioButtonInGroupUsingTag(rdgDeinterlacing, (short) cMainForm.VideoGrabber1.VideoProcessing_Deinterlacing);

            updVideoPixelization.Value = cMainForm.VideoGrabber1.VideoProcessing_Pixellization;

            tbrBrightness.Value = cMainForm.VideoGrabber1.VideoProcessing_Brightness;
			tbrContrast.Value = cMainForm.VideoGrabber1.VideoProcessing_Contrast;
			tbrSaturation.Value = cMainForm.VideoGrabber1.VideoProcessing_Saturation;
			tbrHue.Value = cMainForm.VideoGrabber1.VideoProcessing_Hue;

			chkGreyScale.Checked = cMainForm.VideoGrabber1.VideoProcessing_GrayScale;
			chkInvertColors.Checked = cMainForm.VideoGrabber1.VideoProcessing_InvertColors;
			chkFlipVertical.Checked = cMainForm.VideoGrabber1.VideoProcessing_FlipVertical;
			chkFlipHorizontal.Checked = cMainForm.VideoGrabber1.VideoProcessing_FlipHorizontal;

			chkCroppingEnabled.Checked = cMainForm.VideoGrabber1.Cropping_Enabled;
			chkCroppingOutbounds.Checked = cMainForm.VideoGrabber1.Cropping_Outbounds;
			edtCroppingWidth.Text = cMainForm.VideoGrabber1.Cropping_Width.ToString();
			edtCroppingHeight.Text = cMainForm.VideoGrabber1.Cropping_Height.ToString();
			trkCroppingZoom.Value = (int) cMainForm.VideoGrabber1.Cropping_Zoom * 100;

			// trkCroppingX.Max and trkCroppingY.Max are will be set from the OnResizeVideo event;
			trkCroppingY.Value = cMainForm.VideoGrabber1.Cropping_Y;
			trkCroppingX.Value = cMainForm.VideoGrabber1.Cropping_X;

            lblSWVideoProcessingRequiresFrameGrabber.Visible = cMainForm.VideoGrabber1.FrameGrabber == VidGrab.TFrameGrabber.fg_Disabled;

            RefreshVMR9Processing();

		}

        public void RefreshVMR9Processing()
        {
            int MinValue = 0;
            int MaxValue = 0;
            int StepSize = 0;
            int DefaultValue = 0;
            int CurrentValue = 0;

            lblVMR9Available.BackColor = Color.Red;
            if (cMainForm.VideoGrabber1.IsVMR9ImageAdjustmentAvailable(true))
            {
                tbrVMR9Brightness.Enabled = cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness,out MinValue,out MaxValue,out StepSize,out DefaultValue,out CurrentValue);
                if (tbrVMR9Brightness.Enabled)
                {
                    tbrVMR9Brightness.Minimum = MinValue;
                    tbrVMR9Brightness.Maximum = MaxValue;
                    tbrVMR9Brightness.SmallChange = StepSize;
                    tbrVMR9Brightness.LargeChange = StepSize;
                    tbrVMR9Brightness.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Brightness.Value = tbrVMR9Brightness.Minimum + ((tbrVMR9Brightness.Maximum - tbrVMR9Brightness.Minimum) / 2);
                }
                tbrVMR9Contrast.Enabled = cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Contrast.Enabled)
                {
                    tbrVMR9Contrast.Minimum = MinValue;
                    tbrVMR9Contrast.Maximum = MaxValue;
                    tbrVMR9Contrast.SmallChange = StepSize;
                    tbrVMR9Contrast.LargeChange = StepSize;
                    tbrVMR9Contrast.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Contrast.Value = tbrVMR9Contrast.Minimum + ((tbrVMR9Contrast.Maximum - tbrVMR9Contrast.Minimum) / 2);
                }
                tbrVMR9Hue.Enabled = cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Hue.Enabled)
                {
                    tbrVMR9Hue.Minimum = MinValue;
                    tbrVMR9Hue.Maximum = MaxValue;
                    tbrVMR9Hue.SmallChange = StepSize;
                    tbrVMR9Hue.LargeChange = StepSize;
                    tbrVMR9Hue.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Hue.Value = tbrVMR9Hue.Minimum + ((tbrVMR9Hue.Maximum - tbrVMR9Hue.Minimum) / 2);
                }
                tbrVMR9Saturation.Enabled = cMainForm.VideoGrabber1.GetVMR9ImageAdjustmentBounds(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, out MinValue, out MaxValue, out StepSize, out DefaultValue, out CurrentValue);
                if (tbrVMR9Saturation.Enabled)
                {
                    tbrVMR9Saturation.Minimum = MinValue;
                    tbrVMR9Saturation.Maximum = MaxValue;
                    tbrVMR9Saturation.SmallChange = StepSize;
                    tbrVMR9Saturation.LargeChange = StepSize;
                    tbrVMR9Saturation.Value = CurrentValue;
                    lblVMR9Available.BackColor = Color.Green;
                }
                else
                {
                    tbrVMR9Saturation.Value = tbrVMR9Saturation.Minimum + ((tbrVMR9Saturation.Maximum - tbrVMR9Saturation.Minimum) / 2);
                }
            }
            else
            {
                tbrVMR9Brightness.Enabled = false;
                tbrVMR9Contrast.Enabled = false;
                tbrVMR9Hue.Enabled = false;
                tbrVMR9Saturation.Enabled = false;
            }

        }

		private void btnCroppingZoomReset_Click(object sender, System.EventArgs e)
		{
			trkCroppingZoom.Value = 100;
            cMainForm.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100;
		}

		private void btnResetAll_Click(object sender, System.EventArgs e)
		{
			rdgVideoRotation0.Checked = true;
			rdgDeinterlacingDisabled.Checked = true;
			tbrBrightness.Value = 0;
			tbrContrast.Value = 0;
			tbrSaturation.Value = 0;
			tbrHue.Value = 0;
			chkGreyScale.Checked = false;
			chkInvertColors.Checked = false;
			chkFlipVertical.Checked = false;
			chkFlipHorizontal.Checked = false;
		}

		private void chkCroppingEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Cropping_Enabled = chkCroppingEnabled.Checked;
		}

		private void chkCroppingOutbounds_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Cropping_Outbounds = chkCroppingOutbounds.Checked;
		}

		private void chkFlipHorizontal_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_FlipHorizontal = chkFlipHorizontal.Checked;
		}

		private void chkFlipVertical_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_FlipVertical = chkFlipVertical.Checked;
		}

		private void chkGreyScale_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_GrayScale = chkGreyScale.Checked;
		}

		private void chkInvertColors_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_InvertColors = chkInvertColors.Checked;
		}

		private void edtCroppingHeight_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtCroppingHeight.Text)) 
			{
				cMainForm.VideoGrabber1.Cropping_Height = Convert.ToInt32 (edtCroppingHeight.Text);
			}
		}

		private void edtCroppingWidth_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtCroppingWidth.Text)) 
			{
				;
				cMainForm.VideoGrabber1.Cropping_Width = Convert.ToInt32 (edtCroppingWidth.Text);
			};
		}

		private void rdgDeinterlacing_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.VideoGrabber1.VideoProcessing_Deinterlacing = (VidGrab.TVideoDeinterlacing) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void rdgVideoRotation_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.VideoGrabber1.VideoProcessing_Rotation = (VidGrab.TVideoRotation) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void tbrBrightness_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_Brightness = -tbrBrightness.Value;
		}

		private void tbrContrast_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_Contrast = -tbrContrast.Value;
		}

		private void tbrSaturation_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_Hue = -tbrHue.Value;
		}

		private void tbrHue_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.VideoProcessing_Saturation = -tbrSaturation.Value;
		}

		private void tbrVMR9Brightness_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Brightness, tbrVMR9Brightness.Value, false);
		}

		private void tbrVMR9Contrast_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Contrast, tbrVMR9Contrast.Value, vmr9FixRange.Checked);
		}

		private void tbrVMR9Saturation_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Hue, tbrVMR9Hue.Value, false);
		}

		private void tbrVMR9Hue_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SetVMR9ImageAdjustmentValue(true, VidGrab.TVMR9ImageAdjustment.vmr9_Saturation, tbrVMR9Saturation.Value, vmr9FixRange.Checked);
		}

		private void trkCroppingX_Scroll(object sender, System.EventArgs e)
		{
			// trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
			cMainForm.VideoGrabber1.Cropping_X = trkCroppingX.Value;
		}

		private void trkCroppingY_Scroll(object sender, System.EventArgs e)
		{
			// trkCroppingX.Max and trkCroppingY.Max are set from the OnResizeVideo event;
			cMainForm.VideoGrabber1.Cropping_Y = trkCroppingY.Value;
		}

		private void trkCroppingZoom_Scroll(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.Cropping_Zoom = trkCroppingZoom.Value / 100;
		}

		private void vmr9FixRange_CheckedChanged(object sender, System.EventArgs e)
		{
			// fixes a possible problem of constrast and saturation range with some video decoders, passed to the SetVMR9ImageAdjustmentValue function below;
		}

		private void edtCustomRotationAngle_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtCustomRotationAngle.Text)) 
			{
				cMainForm.VideoGrabber1.VideoProcessing_RotationCustomAngle = Convert.ToDouble (edtCustomRotationAngle.Text);
			}
		}

		private void VideoProcessing_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void updVideoPixelization_ValueChanged(object sender, EventArgs e)
        {
            cMainForm.VideoGrabber1.VideoProcessing_Pixellization =Convert.ToInt32(updVideoPixelization.Value);
        }

        private void rdgDetectVideoSignalDisabled_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoProcessing_DetectNoVideoSignal = false;
            cMainForm.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgNoVideoSignal_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoProcessing_DetectNoVideoSignal = true;
            cMainForm.VideoProcessing_DetectConnexantBlueScreen = false;
        }

        private void rdgConnexantbluescreen_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoProcessing_DetectConnexantBlueScreen = true;
            cMainForm.VideoProcessing_DetectNoVideoSignal = false;
        }

	}
}
