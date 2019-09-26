using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for TVTuner.
	/// </summary>
	public class TVTuner : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal Button btnTunerDialog;
        public GroupBox grbTVScan;
        public Button btnStartScan;
        public Button btnStopScan;
        internal Label lblTVTunerAvailable;
        public TextBox mmoChannelLog;
        public GroupBox grbTVChannel;
        public TextBox edtTVChannel;
        public Button btnSelect;
        public GroupBox grbFrequencyOverride;
        public Button btnResetAllOverrides;
        public TextBox edtChannelFrequency;
        public Button btnSetOverride;
        public Button btnDeleteOverride;
        public CheckBox chkEnableFrequencyOverrides;
        public GroupBox grbTunerCountryCode;
        internal Label lblTVTuner;
        internal GroupBox rdgTunerMode;
        internal RadioButton rdgTunerModeDigitalSatellite;
        internal RadioButton rdgTunerModeAMRadio;
        internal RadioButton rdgTunerModeFMRadio;
        internal RadioButton rdgTunerModeTV;
        public GroupBox rdgTunerInputType;
        public RadioButton rdgTunerInputTypeCable;
        public RadioButton rdgTunerInputTypeAntenna;
        public GroupBox grbCountryCode;
        public TextBox edtCountryCode;
        public Button btnSetCountryCode;
		private System.ComponentModel.IContainer components;

		public TVTuner()
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
            this.btnTunerDialog = new System.Windows.Forms.Button();
            this.grbTVScan = new System.Windows.Forms.GroupBox();
            this.btnStartScan = new System.Windows.Forms.Button();
            this.btnStopScan = new System.Windows.Forms.Button();
            this.lblTVTunerAvailable = new System.Windows.Forms.Label();
            this.mmoChannelLog = new System.Windows.Forms.TextBox();
            this.grbTVChannel = new System.Windows.Forms.GroupBox();
            this.edtTVChannel = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.grbFrequencyOverride = new System.Windows.Forms.GroupBox();
            this.btnResetAllOverrides = new System.Windows.Forms.Button();
            this.edtChannelFrequency = new System.Windows.Forms.TextBox();
            this.btnSetOverride = new System.Windows.Forms.Button();
            this.btnDeleteOverride = new System.Windows.Forms.Button();
            this.chkEnableFrequencyOverrides = new System.Windows.Forms.CheckBox();
            this.grbTunerCountryCode = new System.Windows.Forms.GroupBox();
            this.lblTVTuner = new System.Windows.Forms.Label();
            this.rdgTunerMode = new System.Windows.Forms.GroupBox();
            this.rdgTunerModeDigitalSatellite = new System.Windows.Forms.RadioButton();
            this.rdgTunerModeAMRadio = new System.Windows.Forms.RadioButton();
            this.rdgTunerModeFMRadio = new System.Windows.Forms.RadioButton();
            this.rdgTunerModeTV = new System.Windows.Forms.RadioButton();
            this.rdgTunerInputType = new System.Windows.Forms.GroupBox();
            this.rdgTunerInputTypeCable = new System.Windows.Forms.RadioButton();
            this.rdgTunerInputTypeAntenna = new System.Windows.Forms.RadioButton();
            this.grbCountryCode = new System.Windows.Forms.GroupBox();
            this.edtCountryCode = new System.Windows.Forms.TextBox();
            this.btnSetCountryCode = new System.Windows.Forms.Button();
            this.grbTVScan.SuspendLayout();
            this.grbTVChannel.SuspendLayout();
            this.grbFrequencyOverride.SuspendLayout();
            this.grbTunerCountryCode.SuspendLayout();
            this.rdgTunerMode.SuspendLayout();
            this.rdgTunerInputType.SuspendLayout();
            this.grbCountryCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTunerDialog
            // 
            this.btnTunerDialog.Location = new System.Drawing.Point(354, 27);
            this.btnTunerDialog.Name = "btnTunerDialog";
            this.btnTunerDialog.Size = new System.Drawing.Size(92, 27);
            this.btnTunerDialog.TabIndex = 28;
            this.btnTunerDialog.Text = "tuner dialog";
            this.btnTunerDialog.Click += new System.EventHandler(this.btnTunerDialog_Click);
            // 
            // grbTVScan
            // 
            this.grbTVScan.BackColor = System.Drawing.SystemColors.Control;
            this.grbTVScan.Controls.Add(this.btnStartScan);
            this.grbTVScan.Controls.Add(this.btnStopScan);
            this.grbTVScan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTVScan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTVScan.Location = new System.Drawing.Point(354, 67);
            this.grbTVScan.Name = "grbTVScan";
            this.grbTVScan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTVScan.Size = new System.Drawing.Size(93, 75);
            this.grbTVScan.TabIndex = 27;
            this.grbTVScan.TabStop = false;
            this.grbTVScan.Text = "Autoscan";
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartScan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartScan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartScan.Location = new System.Drawing.Point(8, 16);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStartScan.Size = new System.Drawing.Size(76, 22);
            this.btnStartScan.TabIndex = 11;
            this.btnStartScan.Text = "start";
            this.btnStartScan.Click += new System.EventHandler(this.btnStartScan_Click_1);
            // 
            // btnStopScan
            // 
            this.btnStopScan.BackColor = System.Drawing.SystemColors.Control;
            this.btnStopScan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopScan.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopScan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStopScan.Location = new System.Drawing.Point(8, 45);
            this.btnStopScan.Name = "btnStopScan";
            this.btnStopScan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStopScan.Size = new System.Drawing.Size(76, 22);
            this.btnStopScan.TabIndex = 10;
            this.btnStopScan.Text = "stop";
            this.btnStopScan.Click += new System.EventHandler(this.btnStopScan_Click_1);
            // 
            // lblTVTunerAvailable
            // 
            this.lblTVTunerAvailable.AutoSize = true;
            this.lblTVTunerAvailable.ForeColor = System.Drawing.Color.Red;
            this.lblTVTunerAvailable.Location = new System.Drawing.Point(354, -1);
            this.lblTVTunerAvailable.Name = "lblTVTunerAvailable";
            this.lblTVTunerAvailable.Size = new System.Drawing.Size(263, 13);
            this.lblTVTunerAvailable.TabIndex = 26;
            this.lblTVTunerAvailable.Text = "The tuner is not available for this video capture device";
            // 
            // mmoChannelLog
            // 
            this.mmoChannelLog.AcceptsReturn = true;
            this.mmoChannelLog.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mmoChannelLog.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoChannelLog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoChannelLog.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoChannelLog.Location = new System.Drawing.Point(453, 16);
            this.mmoChannelLog.MaxLength = 0;
            this.mmoChannelLog.Multiline = true;
            this.mmoChannelLog.Name = "mmoChannelLog";
            this.mmoChannelLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoChannelLog.Size = new System.Drawing.Size(456, 161);
            this.mmoChannelLog.TabIndex = 25;
            // 
            // grbTVChannel
            // 
            this.grbTVChannel.BackColor = System.Drawing.SystemColors.Control;
            this.grbTVChannel.Controls.Add(this.edtTVChannel);
            this.grbTVChannel.Controls.Add(this.btnSelect);
            this.grbTVChannel.Controls.Add(this.grbFrequencyOverride);
            this.grbTVChannel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTVChannel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTVChannel.Location = new System.Drawing.Point(4, 97);
            this.grbTVChannel.Name = "grbTVChannel";
            this.grbTVChannel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTVChannel.Size = new System.Drawing.Size(344, 81);
            this.grbTVChannel.TabIndex = 24;
            this.grbTVChannel.TabStop = false;
            this.grbTVChannel.Text = "TV channel";
            // 
            // edtTVChannel
            // 
            this.edtTVChannel.AcceptsReturn = true;
            this.edtTVChannel.BackColor = System.Drawing.SystemColors.Window;
            this.edtTVChannel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTVChannel.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTVChannel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTVChannel.Location = new System.Drawing.Point(10, 27);
            this.edtTVChannel.MaxLength = 0;
            this.edtTVChannel.Name = "edtTVChannel";
            this.edtTVChannel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTVChannel.Size = new System.Drawing.Size(43, 20);
            this.edtTVChannel.TabIndex = 18;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSelect.Location = new System.Drawing.Point(61, 26);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelect.Size = new System.Drawing.Size(43, 22);
            this.btnSelect.TabIndex = 17;
            this.btnSelect.Text = "set";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // grbFrequencyOverride
            // 
            this.grbFrequencyOverride.BackColor = System.Drawing.SystemColors.Control;
            this.grbFrequencyOverride.Controls.Add(this.btnResetAllOverrides);
            this.grbFrequencyOverride.Controls.Add(this.edtChannelFrequency);
            this.grbFrequencyOverride.Controls.Add(this.btnSetOverride);
            this.grbFrequencyOverride.Controls.Add(this.btnDeleteOverride);
            this.grbFrequencyOverride.Controls.Add(this.chkEnableFrequencyOverrides);
            this.grbFrequencyOverride.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFrequencyOverride.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFrequencyOverride.Location = new System.Drawing.Point(119, 9);
            this.grbFrequencyOverride.Name = "grbFrequencyOverride";
            this.grbFrequencyOverride.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbFrequencyOverride.Size = new System.Drawing.Size(217, 67);
            this.grbFrequencyOverride.TabIndex = 12;
            this.grbFrequencyOverride.TabStop = false;
            this.grbFrequencyOverride.Text = "frequency override";
            // 
            // btnResetAllOverrides
            // 
            this.btnResetAllOverrides.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetAllOverrides.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnResetAllOverrides.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetAllOverrides.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnResetAllOverrides.Location = new System.Drawing.Point(146, 12);
            this.btnResetAllOverrides.Name = "btnResetAllOverrides";
            this.btnResetAllOverrides.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnResetAllOverrides.Size = new System.Drawing.Size(65, 22);
            this.btnResetAllOverrides.TabIndex = 17;
            this.btnResetAllOverrides.Text = "clear all";
            this.btnResetAllOverrides.Click += new System.EventHandler(this.btnResetAllOverrides_Click);
            // 
            // edtChannelFrequency
            // 
            this.edtChannelFrequency.AcceptsReturn = true;
            this.edtChannelFrequency.BackColor = System.Drawing.SystemColors.Window;
            this.edtChannelFrequency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtChannelFrequency.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtChannelFrequency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtChannelFrequency.Location = new System.Drawing.Point(8, 39);
            this.edtChannelFrequency.MaxLength = 0;
            this.edtChannelFrequency.Name = "edtChannelFrequency";
            this.edtChannelFrequency.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtChannelFrequency.Size = new System.Drawing.Size(61, 20);
            this.edtChannelFrequency.TabIndex = 16;
            // 
            // btnSetOverride
            // 
            this.btnSetOverride.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetOverride.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetOverride.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetOverride.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetOverride.Location = new System.Drawing.Point(75, 39);
            this.btnSetOverride.Name = "btnSetOverride";
            this.btnSetOverride.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetOverride.Size = new System.Drawing.Size(65, 22);
            this.btnSetOverride.TabIndex = 15;
            this.btnSetOverride.Text = "set";
            this.btnSetOverride.Click += new System.EventHandler(this.btnSetOverride_Click);
            // 
            // btnDeleteOverride
            // 
            this.btnDeleteOverride.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteOverride.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteOverride.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOverride.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteOverride.Location = new System.Drawing.Point(146, 39);
            this.btnDeleteOverride.Name = "btnDeleteOverride";
            this.btnDeleteOverride.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteOverride.Size = new System.Drawing.Size(65, 22);
            this.btnDeleteOverride.TabIndex = 14;
            this.btnDeleteOverride.Text = "delete";
            this.btnDeleteOverride.Click += new System.EventHandler(this.btnDeleteOverride_Click);
            // 
            // chkEnableFrequencyOverrides
            // 
            this.chkEnableFrequencyOverrides.BackColor = System.Drawing.SystemColors.Control;
            this.chkEnableFrequencyOverrides.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkEnableFrequencyOverrides.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableFrequencyOverrides.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEnableFrequencyOverrides.Location = new System.Drawing.Point(16, 17);
            this.chkEnableFrequencyOverrides.Name = "chkEnableFrequencyOverrides";
            this.chkEnableFrequencyOverrides.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkEnableFrequencyOverrides.Size = new System.Drawing.Size(97, 17);
            this.chkEnableFrequencyOverrides.TabIndex = 13;
            this.chkEnableFrequencyOverrides.Text = "enabled";
            this.chkEnableFrequencyOverrides.CheckedChanged += new System.EventHandler(this.chkEnableFrequencyOverrides_CheckedChanged);
            // 
            // grbTunerCountryCode
            // 
            this.grbTunerCountryCode.BackColor = System.Drawing.SystemColors.Control;
            this.grbTunerCountryCode.Controls.Add(this.lblTVTuner);
            this.grbTunerCountryCode.Controls.Add(this.rdgTunerMode);
            this.grbTunerCountryCode.Controls.Add(this.rdgTunerInputType);
            this.grbTunerCountryCode.Controls.Add(this.grbCountryCode);
            this.grbTunerCountryCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTunerCountryCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTunerCountryCode.Location = new System.Drawing.Point(4, 0);
            this.grbTunerCountryCode.Name = "grbTunerCountryCode";
            this.grbTunerCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTunerCountryCode.Size = new System.Drawing.Size(344, 93);
            this.grbTunerCountryCode.TabIndex = 23;
            this.grbTunerCountryCode.TabStop = false;
            this.grbTunerCountryCode.Text = "TV Tuner";
            // 
            // lblTVTuner
            // 
            this.lblTVTuner.AutoSize = true;
            this.lblTVTuner.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTVTuner.Location = new System.Drawing.Point(82, 0);
            this.lblTVTuner.Name = "lblTVTuner";
            this.lblTVTuner.Size = new System.Drawing.Size(205, 14);
            this.lblTVTuner.TabIndex = 7;
            this.lblTVTuner.Text = "Tuner mode, input type and country code";
            // 
            // rdgTunerMode
            // 
            this.rdgTunerMode.Controls.Add(this.rdgTunerModeDigitalSatellite);
            this.rdgTunerMode.Controls.Add(this.rdgTunerModeAMRadio);
            this.rdgTunerMode.Controls.Add(this.rdgTunerModeFMRadio);
            this.rdgTunerMode.Controls.Add(this.rdgTunerModeTV);
            this.rdgTunerMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTunerMode.Location = new System.Drawing.Point(8, 13);
            this.rdgTunerMode.Name = "rdgTunerMode";
            this.rdgTunerMode.Size = new System.Drawing.Size(121, 75);
            this.rdgTunerMode.TabIndex = 6;
            this.rdgTunerMode.TabStop = false;
            this.rdgTunerMode.Text = "tuner mode";
            // 
            // rdgTunerModeDigitalSatellite
            // 
            this.rdgTunerModeDigitalSatellite.Location = new System.Drawing.Point(8, 56);
            this.rdgTunerModeDigitalSatellite.Name = "rdgTunerModeDigitalSatellite";
            this.rdgTunerModeDigitalSatellite.Size = new System.Drawing.Size(107, 17);
            this.rdgTunerModeDigitalSatellite.TabIndex = 3;
            this.rdgTunerModeDigitalSatellite.Tag = "3";
            this.rdgTunerModeDigitalSatellite.Text = "Digital Satellite";
            this.rdgTunerModeDigitalSatellite.CheckedChanged += new System.EventHandler(this.rdgTunerMode_CheckedChanged);
            // 
            // rdgTunerModeAMRadio
            // 
            this.rdgTunerModeAMRadio.Location = new System.Drawing.Point(8, 42);
            this.rdgTunerModeAMRadio.Name = "rdgTunerModeAMRadio";
            this.rdgTunerModeAMRadio.Size = new System.Drawing.Size(107, 17);
            this.rdgTunerModeAMRadio.TabIndex = 2;
            this.rdgTunerModeAMRadio.Tag = "2";
            this.rdgTunerModeAMRadio.Text = "AM Radio";
            this.rdgTunerModeAMRadio.CheckedChanged += new System.EventHandler(this.rdgTunerMode_CheckedChanged);
            // 
            // rdgTunerModeFMRadio
            // 
            this.rdgTunerModeFMRadio.Location = new System.Drawing.Point(8, 28);
            this.rdgTunerModeFMRadio.Name = "rdgTunerModeFMRadio";
            this.rdgTunerModeFMRadio.Size = new System.Drawing.Size(107, 18);
            this.rdgTunerModeFMRadio.TabIndex = 1;
            this.rdgTunerModeFMRadio.Tag = "1";
            this.rdgTunerModeFMRadio.Text = "FM Radio";
            this.rdgTunerModeFMRadio.CheckedChanged += new System.EventHandler(this.rdgTunerMode_CheckedChanged);
            // 
            // rdgTunerModeTV
            // 
            this.rdgTunerModeTV.Location = new System.Drawing.Point(8, 14);
            this.rdgTunerModeTV.Name = "rdgTunerModeTV";
            this.rdgTunerModeTV.Size = new System.Drawing.Size(107, 16);
            this.rdgTunerModeTV.TabIndex = 0;
            this.rdgTunerModeTV.Tag = "0";
            this.rdgTunerModeTV.Text = "TV";
            this.rdgTunerModeTV.CheckedChanged += new System.EventHandler(this.rdgTunerMode_CheckedChanged);
            // 
            // rdgTunerInputType
            // 
            this.rdgTunerInputType.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTunerInputType.Controls.Add(this.rdgTunerInputTypeCable);
            this.rdgTunerInputType.Controls.Add(this.rdgTunerInputTypeAntenna);
            this.rdgTunerInputType.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTunerInputType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTunerInputType.Location = new System.Drawing.Point(135, 27);
            this.rdgTunerInputType.Name = "rdgTunerInputType";
            this.rdgTunerInputType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTunerInputType.Size = new System.Drawing.Size(105, 57);
            this.rdgTunerInputType.TabIndex = 5;
            this.rdgTunerInputType.TabStop = false;
            this.rdgTunerInputType.Text = "tuner input type";
            // 
            // rdgTunerInputTypeCable
            // 
            this.rdgTunerInputTypeCable.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTunerInputTypeCable.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTunerInputTypeCable.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTunerInputTypeCable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTunerInputTypeCable.Location = new System.Drawing.Point(8, 16);
            this.rdgTunerInputTypeCable.Name = "rdgTunerInputTypeCable";
            this.rdgTunerInputTypeCable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTunerInputTypeCable.Size = new System.Drawing.Size(65, 17);
            this.rdgTunerInputTypeCable.TabIndex = 7;
            this.rdgTunerInputTypeCable.TabStop = true;
            this.rdgTunerInputTypeCable.Tag = "0";
            this.rdgTunerInputTypeCable.Text = "cable";
            this.rdgTunerInputTypeCable.CheckedChanged += new System.EventHandler(this.rdgTunerInputType_CheckedChanged);
            // 
            // rdgTunerInputTypeAntenna
            // 
            this.rdgTunerInputTypeAntenna.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTunerInputTypeAntenna.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTunerInputTypeAntenna.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTunerInputTypeAntenna.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTunerInputTypeAntenna.Location = new System.Drawing.Point(8, 32);
            this.rdgTunerInputTypeAntenna.Name = "rdgTunerInputTypeAntenna";
            this.rdgTunerInputTypeAntenna.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTunerInputTypeAntenna.Size = new System.Drawing.Size(65, 17);
            this.rdgTunerInputTypeAntenna.TabIndex = 6;
            this.rdgTunerInputTypeAntenna.TabStop = true;
            this.rdgTunerInputTypeAntenna.Tag = "1";
            this.rdgTunerInputTypeAntenna.Text = "antenna";
            this.rdgTunerInputTypeAntenna.CheckedChanged += new System.EventHandler(this.rdgTunerInputType_CheckedChanged);
            // 
            // grbCountryCode
            // 
            this.grbCountryCode.BackColor = System.Drawing.SystemColors.Control;
            this.grbCountryCode.Controls.Add(this.edtCountryCode);
            this.grbCountryCode.Controls.Add(this.btnSetCountryCode);
            this.grbCountryCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCountryCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbCountryCode.Location = new System.Drawing.Point(246, 27);
            this.grbCountryCode.Name = "grbCountryCode";
            this.grbCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbCountryCode.Size = new System.Drawing.Size(90, 57);
            this.grbCountryCode.TabIndex = 2;
            this.grbCountryCode.TabStop = false;
            this.grbCountryCode.Text = "country code";
            // 
            // edtCountryCode
            // 
            this.edtCountryCode.AcceptsReturn = true;
            this.edtCountryCode.BackColor = System.Drawing.SystemColors.Window;
            this.edtCountryCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtCountryCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCountryCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtCountryCode.Location = new System.Drawing.Point(8, 24);
            this.edtCountryCode.MaxLength = 0;
            this.edtCountryCode.Name = "edtCountryCode";
            this.edtCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtCountryCode.Size = new System.Drawing.Size(33, 20);
            this.edtCountryCode.TabIndex = 4;
            // 
            // btnSetCountryCode
            // 
            this.btnSetCountryCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetCountryCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetCountryCode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCountryCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetCountryCode.Location = new System.Drawing.Point(48, 24);
            this.btnSetCountryCode.Name = "btnSetCountryCode";
            this.btnSetCountryCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetCountryCode.Size = new System.Drawing.Size(32, 20);
            this.btnSetCountryCode.TabIndex = 3;
            this.btnSetCountryCode.Text = "set";
            this.btnSetCountryCode.Click += new System.EventHandler(this.btnSetCountryCode_Click);
            // 
            // TVTuner
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(945, 219);
            this.ControlBox = false;
            this.Controls.Add(this.btnTunerDialog);
            this.Controls.Add(this.grbTVScan);
            this.Controls.Add(this.lblTVTunerAvailable);
            this.Controls.Add(this.mmoChannelLog);
            this.Controls.Add(this.grbTVChannel);
            this.Controls.Add(this.grbTunerCountryCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TVTuner";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.TVTuner_VisibleChanged);
            this.grbTVScan.ResumeLayout(false);
            this.grbTVChannel.ResumeLayout(false);
            this.grbTVChannel.PerformLayout();
            this.grbFrequencyOverride.ResumeLayout(false);
            this.grbFrequencyOverride.PerformLayout();
            this.grbTunerCountryCode.ResumeLayout(false);
            this.grbTunerCountryCode.PerformLayout();
            this.rdgTunerMode.ResumeLayout(false);
            this.rdgTunerInputType.ResumeLayout(false);
            this.grbCountryCode.ResumeLayout(false);
            this.grbCountryCode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{
			SetRadioButtonInGroupUsingTag(rdgTunerMode, (short) cMainForm.axVideoGrabberNET1.TunerMode);
			SetRadioButtonInGroupUsingTag(rdgTunerInputType, (short) cMainForm.axVideoGrabberNET1.TVTunerInputType);
			edtCountryCode.Text = cMainForm.axVideoGrabberNET1.TVCountryCode.ToString();
			edtTVChannel.Text = cMainForm.axVideoGrabberNET1.TVChannel.ToString();
			chkEnableFrequencyOverrides.Checked = cMainForm.axVideoGrabberNET1.TVUseFrequencyOverrides;
            lblTVTunerAvailable.Visible = !cMainForm.axVideoGrabberNET1.IsTVTunerAvailable;
		}

		private void btnSelect_Click(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtTVChannel.Text)) 
			{
				cMainForm.axVideoGrabberNET1.TVChannel = Convert.ToInt32 (edtTVChannel.Text);
			}
		}

		private void btnSetCountryCode_Click(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtCountryCode.Text)) 
			{
				cMainForm.axVideoGrabberNET1.TVCountryCode = Convert.ToInt32(edtCountryCode.Text);
			}
		}

		private void btnStartScan_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.TVStartAutoScan();
		}

		private void btnStopScan_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.TVStopAutoScan();
		}

		private void chkEnableFrequencyOverrides_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.TVUseFrequencyOverrides = chkEnableFrequencyOverrides.Checked;
		}

		private void btnSetOverride_Click(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtTVChannel.Text) && IsNumeric(edtChannelFrequency.Text)) 
			{
				cMainForm.axVideoGrabberNET1.TVSetChannelFrequencyOverride(Convert.ToInt32 (edtTVChannel.Text), Convert.ToInt32 (edtChannelFrequency.Text));
			}
		}

		private void btnDeleteOverride_Click(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtTVChannel.Text)) 
			{
				cMainForm.axVideoGrabberNET1.TVSetChannelFrequencyOverride(Convert.ToInt32 (edtTVChannel.Text), -1);
			};
		}

		private void rdgTunerMode_CheckedChanged (object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.TunerMode = (Vidgrab_NET.TxTunerMode) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

		private void btnResetAllOverrides_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.TVClearFrequencyOverrides();
		}

		private void rdgTunerInputType_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.axVideoGrabberNET1.TVTunerInputType = (Vidgrab_NET.TxTunerInputType) Convert.ToInt32((sender as Control).Tag);
			}
		}

		private void TVTuner_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void btnTunerDialog_Click(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.ShowDialog(Vidgrab_NET.TxDialog.dlg_TVTuner);
            RefreshControls();
        }

        private void btnStartScan_Click_1(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.TVStartAutoScan();
        }

        private void btnStopScan_Click_1(object sender, EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.TVStopAutoScan();
        }

	}
}
