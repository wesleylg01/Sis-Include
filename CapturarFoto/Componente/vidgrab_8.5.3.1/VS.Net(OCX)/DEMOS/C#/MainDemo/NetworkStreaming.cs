using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for NetworkStreaming.
	/// </summary>
	public class NetworkStreaming : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        public GroupBox grbWMV9profiles;
        internal Button btnSelectWMV9Profile;
        internal TextBox edtWMV9profile;
        internal GroupBox rdgNetworkStreamingType;
        internal RadioButton rdgNetworkStreamingTypeAudio;
        internal RadioButton rdgNetworkStreamingTypeVideo;
        internal RadioButton rdgNetworkStreamingTypeAudioVideo;
        public GroupBox rdgNetworkStreaming;
        public Button btnViewDirectNetworkStreaming;
        public RadioButton rdgNetworkStreamingDisabled;
        public RadioButton rdgNetworkStreamingDirect;
        public RadioButton rdgNetworkStreamingPublishingPoint;
        public GroupBox grbASFSettings;
        internal GroupBox grbWMVversion;
        internal RadioButton rdgWMV9;
        internal RadioButton rgdWMV8;
        public Label Label19;
        public CheckBox chkASFFixedFrameRate;
        public ComboBox cmbASFDeinterlaceMode;
        public TextBox edtASFVideoWidth;
        public TextBox edtASFVideoBitRate;
        public TextBox edtASFVideoQuality;
        public TextBox edtASFVideoMaxKeyFrameSpacing;
        public TextBox edtASFAudioChannels;
        public TextBox edtASFVideoHeight;
        public Label Label20;
        public Label Label21;
        public Label Label22;
        public Label Label23;
        public Label Label24;
        public Label Label25;
        public Label Label26;
        public GroupBox grbASFProfiles;
        public ListBox lsbProfiles;
        public Button btnShowProfilesList;
        public TextBox edtProfileIndex;
        public Label Label27;
        public GroupBox grbDirectASFStreaming;
        public TextBox edtNetworkPort;
        public TextBox edtNetworkMaxUsers;
        public Label Label16;
        public Label Label17;
        public GroupBox grbASFStreamingToWMServer;
        internal TextBox edtPublishingPointPassword;
        internal TextBox edtPublishingPointUsername;
        internal Label Label2;
        internal Label Label1;
        public TextBox edtPublishingPoint;
        public Label Label18;
        internal ImageList ImageList1;
		private System.ComponentModel.IContainer components;

		public NetworkStreaming()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkStreaming));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbWMV9profiles = new System.Windows.Forms.GroupBox();
            this.btnSelectWMV9Profile = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.edtWMV9profile = new System.Windows.Forms.TextBox();
            this.rdgNetworkStreamingType = new System.Windows.Forms.GroupBox();
            this.rdgNetworkStreamingTypeAudio = new System.Windows.Forms.RadioButton();
            this.rdgNetworkStreamingTypeVideo = new System.Windows.Forms.RadioButton();
            this.rdgNetworkStreamingTypeAudioVideo = new System.Windows.Forms.RadioButton();
            this.rdgNetworkStreaming = new System.Windows.Forms.GroupBox();
            this.btnViewDirectNetworkStreaming = new System.Windows.Forms.Button();
            this.rdgNetworkStreamingDisabled = new System.Windows.Forms.RadioButton();
            this.rdgNetworkStreamingDirect = new System.Windows.Forms.RadioButton();
            this.rdgNetworkStreamingPublishingPoint = new System.Windows.Forms.RadioButton();
            this.grbASFSettings = new System.Windows.Forms.GroupBox();
            this.grbWMVversion = new System.Windows.Forms.GroupBox();
            this.rdgWMV9 = new System.Windows.Forms.RadioButton();
            this.rgdWMV8 = new System.Windows.Forms.RadioButton();
            this.Label19 = new System.Windows.Forms.Label();
            this.chkASFFixedFrameRate = new System.Windows.Forms.CheckBox();
            this.cmbASFDeinterlaceMode = new System.Windows.Forms.ComboBox();
            this.edtASFVideoWidth = new System.Windows.Forms.TextBox();
            this.edtASFVideoBitRate = new System.Windows.Forms.TextBox();
            this.edtASFVideoQuality = new System.Windows.Forms.TextBox();
            this.edtASFVideoMaxKeyFrameSpacing = new System.Windows.Forms.TextBox();
            this.edtASFAudioChannels = new System.Windows.Forms.TextBox();
            this.edtASFVideoHeight = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.Label24 = new System.Windows.Forms.Label();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.grbASFProfiles = new System.Windows.Forms.GroupBox();
            this.lsbProfiles = new System.Windows.Forms.ListBox();
            this.btnShowProfilesList = new System.Windows.Forms.Button();
            this.edtProfileIndex = new System.Windows.Forms.TextBox();
            this.Label27 = new System.Windows.Forms.Label();
            this.grbDirectASFStreaming = new System.Windows.Forms.GroupBox();
            this.edtNetworkPort = new System.Windows.Forms.TextBox();
            this.edtNetworkMaxUsers = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.grbASFStreamingToWMServer = new System.Windows.Forms.GroupBox();
            this.edtPublishingPointPassword = new System.Windows.Forms.TextBox();
            this.edtPublishingPointUsername = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.edtPublishingPoint = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.grbWMV9profiles.SuspendLayout();
            this.rdgNetworkStreamingType.SuspendLayout();
            this.rdgNetworkStreaming.SuspendLayout();
            this.grbASFSettings.SuspendLayout();
            this.grbWMVversion.SuspendLayout();
            this.grbASFProfiles.SuspendLayout();
            this.grbDirectASFStreaming.SuspendLayout();
            this.grbASFStreamingToWMServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbWMV9profiles
            // 
            this.grbWMV9profiles.BackColor = System.Drawing.SystemColors.Control;
            this.grbWMV9profiles.Controls.Add(this.btnSelectWMV9Profile);
            this.grbWMV9profiles.Controls.Add(this.edtWMV9profile);
            this.grbWMV9profiles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbWMV9profiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbWMV9profiles.Location = new System.Drawing.Point(682, 0);
            this.grbWMV9profiles.Name = "grbWMV9profiles";
            this.grbWMV9profiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbWMV9profiles.Size = new System.Drawing.Size(232, 49);
            this.grbWMV9profiles.TabIndex = 45;
            this.grbWMV9profiles.TabStop = false;
            this.grbWMV9profiles.Text = "WMV 9 profiles";
            // 
            // btnSelectWMV9Profile
            // 
            this.btnSelectWMV9Profile.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectWMV9Profile.ImageIndex  = 0; //"OpenFolder.bmp";
            this.btnSelectWMV9Profile.ImageList = this.ImageList1;
            this.btnSelectWMV9Profile.Location = new System.Drawing.Point(8, 16);
            this.btnSelectWMV9Profile.Name = "btnSelectWMV9Profile";
            this.btnSelectWMV9Profile.Size = new System.Drawing.Size(45, 22);
            this.btnSelectWMV9Profile.TabIndex = 1;
            this.btnSelectWMV9Profile.Click += new System.EventHandler(this.btnSelectWMV9Profile_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            // 
            // edtWMV9profile
            // 
            this.edtWMV9profile.Location = new System.Drawing.Point(59, 16);
            this.edtWMV9profile.Name = "edtWMV9profile";
            this.edtWMV9profile.Size = new System.Drawing.Size(167, 20);
            this.edtWMV9profile.TabIndex = 0;
            this.edtWMV9profile.Text = "<- select a WMV9 profile...";
            this.edtWMV9profile.TextChanged += new System.EventHandler(this.edtWMV9profile_TextChanged);
            // 
            // rdgNetworkStreamingType
            // 
            this.rdgNetworkStreamingType.Controls.Add(this.rdgNetworkStreamingTypeAudio);
            this.rdgNetworkStreamingType.Controls.Add(this.rdgNetworkStreamingTypeVideo);
            this.rdgNetworkStreamingType.Controls.Add(this.rdgNetworkStreamingTypeAudioVideo);
            this.rdgNetworkStreamingType.Location = new System.Drawing.Point(204, 0);
            this.rdgNetworkStreamingType.Name = "rdgNetworkStreamingType";
            this.rdgNetworkStreamingType.Size = new System.Drawing.Size(97, 76);
            this.rdgNetworkStreamingType.TabIndex = 44;
            this.rdgNetworkStreamingType.TabStop = false;
            this.rdgNetworkStreamingType.Text = "streaming type";
            // 
            // rdgNetworkStreamingTypeAudio
            // 
            this.rdgNetworkStreamingTypeAudio.Location = new System.Drawing.Point(6, 52);
            this.rdgNetworkStreamingTypeAudio.Name = "rdgNetworkStreamingTypeAudio";
            this.rdgNetworkStreamingTypeAudio.Size = new System.Drawing.Size(87, 17);
            this.rdgNetworkStreamingTypeAudio.TabIndex = 2;
            this.rdgNetworkStreamingTypeAudio.Tag = "2";
            this.rdgNetworkStreamingTypeAudio.Text = "Audio ONLY";
            this.rdgNetworkStreamingTypeAudio.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingTypeAudio_CheckedChanged);
            // 
            // rdgNetworkStreamingTypeVideo
            // 
            this.rdgNetworkStreamingTypeVideo.Location = new System.Drawing.Point(6, 34);
            this.rdgNetworkStreamingTypeVideo.Name = "rdgNetworkStreamingTypeVideo";
            this.rdgNetworkStreamingTypeVideo.Size = new System.Drawing.Size(87, 17);
            this.rdgNetworkStreamingTypeVideo.TabIndex = 1;
            this.rdgNetworkStreamingTypeVideo.Tag = "1";
            this.rdgNetworkStreamingTypeVideo.Text = "Video ONLY";
            this.rdgNetworkStreamingTypeVideo.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingTypeVideo_CheckedChanged);
            // 
            // rdgNetworkStreamingTypeAudioVideo
            // 
            this.rdgNetworkStreamingTypeAudioVideo.Location = new System.Drawing.Point(6, 16);
            this.rdgNetworkStreamingTypeAudioVideo.Name = "rdgNetworkStreamingTypeAudioVideo";
            this.rdgNetworkStreamingTypeAudioVideo.Size = new System.Drawing.Size(87, 17);
            this.rdgNetworkStreamingTypeAudioVideo.TabIndex = 0;
            this.rdgNetworkStreamingTypeAudioVideo.Tag = "0";
            this.rdgNetworkStreamingTypeAudioVideo.Text = "Audio Video";
            this.rdgNetworkStreamingTypeAudioVideo.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingTypeAudioVideo_CheckedChanged);
            // 
            // rdgNetworkStreaming
            // 
            this.rdgNetworkStreaming.BackColor = System.Drawing.SystemColors.Control;
            this.rdgNetworkStreaming.Controls.Add(this.btnViewDirectNetworkStreaming);
            this.rdgNetworkStreaming.Controls.Add(this.rdgNetworkStreamingDisabled);
            this.rdgNetworkStreaming.Controls.Add(this.rdgNetworkStreamingDirect);
            this.rdgNetworkStreaming.Controls.Add(this.rdgNetworkStreamingPublishingPoint);
            this.rdgNetworkStreaming.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgNetworkStreaming.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgNetworkStreaming.Location = new System.Drawing.Point(4, 0);
            this.rdgNetworkStreaming.Name = "rdgNetworkStreaming";
            this.rdgNetworkStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgNetworkStreaming.Size = new System.Drawing.Size(193, 76);
            this.rdgNetworkStreaming.TabIndex = 43;
            this.rdgNetworkStreaming.TabStop = false;
            this.rdgNetworkStreaming.Text = "Network streaming";
            // 
            // btnViewDirectNetworkStreaming
            // 
            this.btnViewDirectNetworkStreaming.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewDirectNetworkStreaming.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewDirectNetworkStreaming.Enabled = false;
            this.btnViewDirectNetworkStreaming.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDirectNetworkStreaming.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnViewDirectNetworkStreaming.Location = new System.Drawing.Point(148, 28);
            this.btnViewDirectNetworkStreaming.Name = "btnViewDirectNetworkStreaming";
            this.btnViewDirectNetworkStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewDirectNetworkStreaming.Size = new System.Drawing.Size(39, 22);
            this.btnViewDirectNetworkStreaming.TabIndex = 30;
            this.btnViewDirectNetworkStreaming.Text = "view";
            this.btnViewDirectNetworkStreaming.Click += new System.EventHandler(this.btnViewDirectNetworkStreaming_Click);
            // 
            // rdgNetworkStreamingDisabled
            // 
            this.rdgNetworkStreamingDisabled.BackColor = System.Drawing.SystemColors.Control;
            this.rdgNetworkStreamingDisabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgNetworkStreamingDisabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgNetworkStreamingDisabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgNetworkStreamingDisabled.Location = new System.Drawing.Point(6, 16);
            this.rdgNetworkStreamingDisabled.Name = "rdgNetworkStreamingDisabled";
            this.rdgNetworkStreamingDisabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgNetworkStreamingDisabled.Size = new System.Drawing.Size(104, 17);
            this.rdgNetworkStreamingDisabled.TabIndex = 33;
            this.rdgNetworkStreamingDisabled.TabStop = true;
            this.rdgNetworkStreamingDisabled.Tag = "0";
            this.rdgNetworkStreamingDisabled.Text = "disabled";
            this.rdgNetworkStreamingDisabled.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingDisabled_CheckedChanged);
            // 
            // rdgNetworkStreamingDirect
            // 
            this.rdgNetworkStreamingDirect.BackColor = System.Drawing.SystemColors.Control;
            this.rdgNetworkStreamingDirect.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgNetworkStreamingDirect.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgNetworkStreamingDirect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgNetworkStreamingDirect.Location = new System.Drawing.Point(6, 34);
            this.rdgNetworkStreamingDirect.Name = "rdgNetworkStreamingDirect";
            this.rdgNetworkStreamingDirect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgNetworkStreamingDirect.Size = new System.Drawing.Size(147, 18);
            this.rdgNetworkStreamingDirect.TabIndex = 32;
            this.rdgNetworkStreamingDirect.TabStop = true;
            this.rdgNetworkStreamingDirect.Tag = "1";
            this.rdgNetworkStreamingDirect.Text = "direct network streaming";
            this.rdgNetworkStreamingDirect.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingDirect_CheckedChanged);
            // 
            // rdgNetworkStreamingPublishingPoint
            // 
            this.rdgNetworkStreamingPublishingPoint.BackColor = System.Drawing.SystemColors.Control;
            this.rdgNetworkStreamingPublishingPoint.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgNetworkStreamingPublishingPoint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgNetworkStreamingPublishingPoint.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgNetworkStreamingPublishingPoint.Location = new System.Drawing.Point(6, 52);
            this.rdgNetworkStreamingPublishingPoint.Name = "rdgNetworkStreamingPublishingPoint";
            this.rdgNetworkStreamingPublishingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgNetworkStreamingPublishingPoint.Size = new System.Drawing.Size(179, 17);
            this.rdgNetworkStreamingPublishingPoint.TabIndex = 31;
            this.rdgNetworkStreamingPublishingPoint.TabStop = true;
            this.rdgNetworkStreamingPublishingPoint.Tag = "2";
            this.rdgNetworkStreamingPublishingPoint.Text = "stream to a WM publishing point";
            this.rdgNetworkStreamingPublishingPoint.CheckedChanged += new System.EventHandler(this.rdgNetworkStreamingPublishingPoint_CheckedChanged);
            // 
            // grbASFSettings
            // 
            this.grbASFSettings.BackColor = System.Drawing.SystemColors.Control;
            this.grbASFSettings.Controls.Add(this.grbWMVversion);
            this.grbASFSettings.Controls.Add(this.Label19);
            this.grbASFSettings.Controls.Add(this.chkASFFixedFrameRate);
            this.grbASFSettings.Controls.Add(this.cmbASFDeinterlaceMode);
            this.grbASFSettings.Controls.Add(this.edtASFVideoWidth);
            this.grbASFSettings.Controls.Add(this.edtASFVideoBitRate);
            this.grbASFSettings.Controls.Add(this.edtASFVideoQuality);
            this.grbASFSettings.Controls.Add(this.edtASFVideoMaxKeyFrameSpacing);
            this.grbASFSettings.Controls.Add(this.edtASFAudioChannels);
            this.grbASFSettings.Controls.Add(this.edtASFVideoHeight);
            this.grbASFSettings.Controls.Add(this.Label20);
            this.grbASFSettings.Controls.Add(this.Label21);
            this.grbASFSettings.Controls.Add(this.Label22);
            this.grbASFSettings.Controls.Add(this.Label23);
            this.grbASFSettings.Controls.Add(this.Label24);
            this.grbASFSettings.Controls.Add(this.Label25);
            this.grbASFSettings.Controls.Add(this.Label26);
            this.grbASFSettings.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbASFSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbASFSettings.Location = new System.Drawing.Point(307, 0);
            this.grbASFSettings.Name = "grbASFSettings";
            this.grbASFSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbASFSettings.Size = new System.Drawing.Size(369, 132);
            this.grbASFSettings.TabIndex = 40;
            this.grbASFSettings.TabStop = false;
            this.grbASFSettings.Text = "WMV settings";
            // 
            // grbWMVversion
            // 
            this.grbWMVversion.Controls.Add(this.rdgWMV9);
            this.grbWMVversion.Controls.Add(this.rgdWMV8);
            this.grbWMVversion.Location = new System.Drawing.Point(131, 26);
            this.grbWMVversion.Name = "grbWMVversion";
            this.grbWMVversion.Size = new System.Drawing.Size(80, 60);
            this.grbWMVversion.TabIndex = 22;
            this.grbWMVversion.TabStop = false;
            this.grbWMVversion.Text = "WMV version";
            // 
            // rdgWMV9
            // 
            this.rdgWMV9.Location = new System.Drawing.Point(8, 34);
            this.rdgWMV9.Name = "rdgWMV9";
            this.rdgWMV9.Size = new System.Drawing.Size(64, 16);
            this.rdgWMV9.TabIndex = 1;
            this.rdgWMV9.Text = "WMV 9";
            this.rdgWMV9.CheckedChanged += new System.EventHandler(this.rdgWMV9_CheckedChanged);
            // 
            // rgdWMV8
            // 
            this.rgdWMV8.Location = new System.Drawing.Point(8, 16);
            this.rgdWMV8.Name = "rgdWMV8";
            this.rgdWMV8.Size = new System.Drawing.Size(64, 16);
            this.rgdWMV8.TabIndex = 0;
            this.rgdWMV8.Text = "WMV 8";
            this.rgdWMV8.CheckedChanged += new System.EventHandler(this.rgdWMV8_CheckedChanged);
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.SystemColors.Control;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Label19.Location = new System.Drawing.Point(128, 8);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(168, 17);
            this.Label19.TabIndex = 21;
            this.Label19.Text = "(-1 = use default or profile value)";
            // 
            // chkASFFixedFrameRate
            // 
            this.chkASFFixedFrameRate.BackColor = System.Drawing.SystemColors.Control;
            this.chkASFFixedFrameRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkASFFixedFrameRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkASFFixedFrameRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkASFFixedFrameRate.Location = new System.Drawing.Point(17, 72);
            this.chkASFFixedFrameRate.Name = "chkASFFixedFrameRate";
            this.chkASFFixedFrameRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkASFFixedFrameRate.Size = new System.Drawing.Size(104, 17);
            this.chkASFFixedFrameRate.TabIndex = 12;
            this.chkASFFixedFrameRate.Text = "fixed frame rate";
            this.chkASFFixedFrameRate.CheckedChanged += new System.EventHandler(this.chkASFFixedFrameRate_CheckedChanged);
            // 
            // cmbASFDeinterlaceMode
            // 
            this.cmbASFDeinterlaceMode.BackColor = System.Drawing.SystemColors.Window;
            this.cmbASFDeinterlaceMode.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbASFDeinterlaceMode.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbASFDeinterlaceMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbASFDeinterlaceMode.Items.AddRange(new object[] {
            "adm_NotInterlaced",
            "adm_DeinterlaceNormal",
            "adm_DeinterlaceHalfSize",
            "adm_DeinterlaceHalfSizeDoubleRate",
            "adm_DeinterlaceInverseTelecine",
            "adm_DeinterlaceVerticalHalfSizeDoubleRate"});
            this.cmbASFDeinterlaceMode.Location = new System.Drawing.Point(17, 103);
            this.cmbASFDeinterlaceMode.Name = "cmbASFDeinterlaceMode";
            this.cmbASFDeinterlaceMode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbASFDeinterlaceMode.Size = new System.Drawing.Size(209, 22);
            this.cmbASFDeinterlaceMode.TabIndex = 11;
            this.cmbASFDeinterlaceMode.SelectedIndexChanged += new System.EventHandler(this.cmbASFDeinterlaceMode_SelectedIndexChanged);
            // 
            // edtASFVideoWidth
            // 
            this.edtASFVideoWidth.AcceptsReturn = true;
            this.edtASFVideoWidth.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFVideoWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFVideoWidth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFVideoWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFVideoWidth.Location = new System.Drawing.Point(88, 24);
            this.edtASFVideoWidth.MaxLength = 0;
            this.edtASFVideoWidth.Name = "edtASFVideoWidth";
            this.edtASFVideoWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFVideoWidth.Size = new System.Drawing.Size(33, 20);
            this.edtASFVideoWidth.TabIndex = 10;
            this.edtASFVideoWidth.TextChanged += new System.EventHandler(this.edtASFVideoWidth_TextChanged);
            // 
            // edtASFVideoBitRate
            // 
            this.edtASFVideoBitRate.AcceptsReturn = true;
            this.edtASFVideoBitRate.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFVideoBitRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFVideoBitRate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFVideoBitRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFVideoBitRate.Location = new System.Drawing.Point(322, 19);
            this.edtASFVideoBitRate.MaxLength = 0;
            this.edtASFVideoBitRate.Name = "edtASFVideoBitRate";
            this.edtASFVideoBitRate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFVideoBitRate.Size = new System.Drawing.Size(39, 20);
            this.edtASFVideoBitRate.TabIndex = 9;
            this.edtASFVideoBitRate.TextChanged += new System.EventHandler(this.edtASFVideoBitRate_TextChanged);
            // 
            // edtASFVideoQuality
            // 
            this.edtASFVideoQuality.AcceptsReturn = true;
            this.edtASFVideoQuality.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFVideoQuality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFVideoQuality.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFVideoQuality.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFVideoQuality.Location = new System.Drawing.Point(322, 43);
            this.edtASFVideoQuality.MaxLength = 0;
            this.edtASFVideoQuality.Name = "edtASFVideoQuality";
            this.edtASFVideoQuality.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFVideoQuality.Size = new System.Drawing.Size(39, 20);
            this.edtASFVideoQuality.TabIndex = 8;
            this.edtASFVideoQuality.TextChanged += new System.EventHandler(this.edtASFVideoQuality_TextChanged);
            // 
            // edtASFVideoMaxKeyFrameSpacing
            // 
            this.edtASFVideoMaxKeyFrameSpacing.AcceptsReturn = true;
            this.edtASFVideoMaxKeyFrameSpacing.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFVideoMaxKeyFrameSpacing.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFVideoMaxKeyFrameSpacing.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFVideoMaxKeyFrameSpacing.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFVideoMaxKeyFrameSpacing.Location = new System.Drawing.Point(322, 67);
            this.edtASFVideoMaxKeyFrameSpacing.MaxLength = 0;
            this.edtASFVideoMaxKeyFrameSpacing.Name = "edtASFVideoMaxKeyFrameSpacing";
            this.edtASFVideoMaxKeyFrameSpacing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFVideoMaxKeyFrameSpacing.Size = new System.Drawing.Size(39, 20);
            this.edtASFVideoMaxKeyFrameSpacing.TabIndex = 7;
            this.edtASFVideoMaxKeyFrameSpacing.TextChanged += new System.EventHandler(this.edtASFVideoMaxKeyFrameSpacing_TextChanged);
            // 
            // edtASFAudioChannels
            // 
            this.edtASFAudioChannels.AcceptsReturn = true;
            this.edtASFAudioChannels.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFAudioChannels.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFAudioChannels.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFAudioChannels.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFAudioChannels.Location = new System.Drawing.Point(322, 91);
            this.edtASFAudioChannels.MaxLength = 0;
            this.edtASFAudioChannels.Name = "edtASFAudioChannels";
            this.edtASFAudioChannels.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFAudioChannels.Size = new System.Drawing.Size(39, 20);
            this.edtASFAudioChannels.TabIndex = 6;
            this.edtASFAudioChannels.TextChanged += new System.EventHandler(this.edtASFAudioChannels_TextChanged);
            // 
            // edtASFVideoHeight
            // 
            this.edtASFVideoHeight.AcceptsReturn = true;
            this.edtASFVideoHeight.BackColor = System.Drawing.SystemColors.Window;
            this.edtASFVideoHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtASFVideoHeight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtASFVideoHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtASFVideoHeight.Location = new System.Drawing.Point(88, 50);
            this.edtASFVideoHeight.MaxLength = 0;
            this.edtASFVideoHeight.Name = "edtASFVideoHeight";
            this.edtASFVideoHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtASFVideoHeight.Size = new System.Drawing.Size(33, 20);
            this.edtASFVideoHeight.TabIndex = 5;
            this.edtASFVideoHeight.TextChanged += new System.EventHandler(this.edtASFVideoHeight_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.BackColor = System.Drawing.SystemColors.Control;
            this.Label20.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label20.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label20.Location = new System.Drawing.Point(19, 26);
            this.Label20.Name = "Label20";
            this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label20.Size = new System.Drawing.Size(66, 14);
            this.Label20.TabIndex = 19;
            this.Label20.Text = "video width:";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.BackColor = System.Drawing.SystemColors.Control;
            this.Label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label21.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label21.Location = new System.Drawing.Point(252, 24);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(72, 14);
            this.Label21.TabIndex = 18;
            this.Label21.Text = "video bit rate:";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.BackColor = System.Drawing.SystemColors.Control;
            this.Label22.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label22.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label22.Location = new System.Drawing.Point(17, 52);
            this.Label22.Name = "Label22";
            this.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label22.Size = new System.Drawing.Size(68, 14);
            this.Label22.TabIndex = 17;
            this.Label22.Text = "video height:";
            this.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.BackColor = System.Drawing.SystemColors.Control;
            this.Label23.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label23.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label23.Location = new System.Drawing.Point(254, 49);
            this.Label23.Name = "Label23";
            this.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label23.Size = new System.Drawing.Size(70, 14);
            this.Label23.TabIndex = 16;
            this.Label23.Text = "video quality:";
            this.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.BackColor = System.Drawing.SystemColors.Control;
            this.Label24.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label24.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label24.Location = new System.Drawing.Point(225, 72);
            this.Label24.Name = "Label24";
            this.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label24.Size = new System.Drawing.Size(99, 14);
            this.Label24.TabIndex = 15;
            this.Label24.Text = "key frame spacing:";
            this.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.BackColor = System.Drawing.SystemColors.Control;
            this.Label25.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label25.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label25.Location = new System.Drawing.Point(241, 95);
            this.Label25.Name = "Label25";
            this.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label25.Size = new System.Drawing.Size(83, 14);
            this.Label25.TabIndex = 14;
            this.Label25.Text = "audio channels:";
            this.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.BackColor = System.Drawing.SystemColors.Control;
            this.Label26.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label26.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label26.Location = new System.Drawing.Point(14, 90);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(92, 14);
            this.Label26.TabIndex = 13;
            this.Label26.Text = "deinterlace mode:";
            // 
            // grbASFProfiles
            // 
            this.grbASFProfiles.BackColor = System.Drawing.SystemColors.Control;
            this.grbASFProfiles.Controls.Add(this.lsbProfiles);
            this.grbASFProfiles.Controls.Add(this.btnShowProfilesList);
            this.grbASFProfiles.Controls.Add(this.edtProfileIndex);
            this.grbASFProfiles.Controls.Add(this.Label27);
            this.grbASFProfiles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbASFProfiles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbASFProfiles.Location = new System.Drawing.Point(682, 52);
            this.grbASFProfiles.Name = "grbASFProfiles";
            this.grbASFProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbASFProfiles.Size = new System.Drawing.Size(232, 125);
            this.grbASFProfiles.TabIndex = 39;
            this.grbASFProfiles.TabStop = false;
            this.grbASFProfiles.Text = "WMV 8 Profiles";
            // 
            // lsbProfiles
            // 
            this.lsbProfiles.BackColor = System.Drawing.SystemColors.Window;
            this.lsbProfiles.Cursor = System.Windows.Forms.Cursors.Default;
            this.lsbProfiles.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbProfiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lsbProfiles.ItemHeight = 14;
            this.lsbProfiles.Location = new System.Drawing.Point(8, 58);
            this.lsbProfiles.Name = "lsbProfiles";
            this.lsbProfiles.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lsbProfiles.Size = new System.Drawing.Size(218, 60);
            this.lsbProfiles.TabIndex = 34;
            this.lsbProfiles.SelectedIndexChanged += new System.EventHandler(this.lsbProfiles_SelectedIndexChanged);
            // 
            // btnShowProfilesList
            // 
            this.btnShowProfilesList.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowProfilesList.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowProfilesList.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProfilesList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowProfilesList.Location = new System.Drawing.Point(8, 33);
            this.btnShowProfilesList.Name = "btnShowProfilesList";
            this.btnShowProfilesList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowProfilesList.Size = new System.Drawing.Size(187, 21);
            this.btnShowProfilesList.TabIndex = 2;
            this.btnShowProfilesList.Text = "show WMV 8 profiles list";
            this.btnShowProfilesList.Click += new System.EventHandler(this.btnShowProfilesList_Click);
            // 
            // edtProfileIndex
            // 
            this.edtProfileIndex.AcceptsReturn = true;
            this.edtProfileIndex.BackColor = System.Drawing.SystemColors.Window;
            this.edtProfileIndex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtProfileIndex.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtProfileIndex.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtProfileIndex.Location = new System.Drawing.Point(201, 14);
            this.edtProfileIndex.MaxLength = 0;
            this.edtProfileIndex.Name = "edtProfileIndex";
            this.edtProfileIndex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtProfileIndex.Size = new System.Drawing.Size(25, 20);
            this.edtProfileIndex.TabIndex = 1;
            this.edtProfileIndex.TextChanged += new System.EventHandler(this.edtProfileIndex_TextChanged);
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.BackColor = System.Drawing.SystemColors.Control;
            this.Label27.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label27.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label27.Location = new System.Drawing.Point(8, 16);
            this.Label27.Name = "Label27";
            this.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label27.Size = new System.Drawing.Size(193, 14);
            this.Label27.TabIndex = 3;
            this.Label27.Text = "index of current profile: (-1 = disabled)";
            // 
            // grbDirectASFStreaming
            // 
            this.grbDirectASFStreaming.BackColor = System.Drawing.SystemColors.Control;
            this.grbDirectASFStreaming.Controls.Add(this.edtNetworkPort);
            this.grbDirectASFStreaming.Controls.Add(this.edtNetworkMaxUsers);
            this.grbDirectASFStreaming.Controls.Add(this.Label16);
            this.grbDirectASFStreaming.Controls.Add(this.Label17);
            this.grbDirectASFStreaming.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDirectASFStreaming.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbDirectASFStreaming.Location = new System.Drawing.Point(4, 80);
            this.grbDirectASFStreaming.Name = "grbDirectASFStreaming";
            this.grbDirectASFStreaming.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbDirectASFStreaming.Size = new System.Drawing.Size(297, 52);
            this.grbDirectASFStreaming.TabIndex = 42;
            this.grbDirectASFStreaming.TabStop = false;
            this.grbDirectASFStreaming.Text = "direct ASF network streaming";
            // 
            // edtNetworkPort
            // 
            this.edtNetworkPort.AcceptsReturn = true;
            this.edtNetworkPort.BackColor = System.Drawing.SystemColors.Window;
            this.edtNetworkPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNetworkPort.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNetworkPort.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtNetworkPort.Location = new System.Drawing.Point(120, 24);
            this.edtNetworkPort.MaxLength = 0;
            this.edtNetworkPort.Name = "edtNetworkPort";
            this.edtNetworkPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtNetworkPort.Size = new System.Drawing.Size(41, 20);
            this.edtNetworkPort.TabIndex = 26;
            this.edtNetworkPort.Text = "0";
            this.edtNetworkPort.TextChanged += new System.EventHandler(this.edtNetworkPort_TextChanged);
            // 
            // edtNetworkMaxUsers
            // 
            this.edtNetworkMaxUsers.AcceptsReturn = true;
            this.edtNetworkMaxUsers.BackColor = System.Drawing.SystemColors.Window;
            this.edtNetworkMaxUsers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtNetworkMaxUsers.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtNetworkMaxUsers.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtNetworkMaxUsers.Location = new System.Drawing.Point(232, 24);
            this.edtNetworkMaxUsers.MaxLength = 0;
            this.edtNetworkMaxUsers.Name = "edtNetworkMaxUsers";
            this.edtNetworkMaxUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtNetworkMaxUsers.Size = new System.Drawing.Size(56, 20);
            this.edtNetworkMaxUsers.TabIndex = 25;
            this.edtNetworkMaxUsers.TextChanged += new System.EventHandler(this.edtNetworkMaxUsers_TextChanged);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.BackColor = System.Drawing.SystemColors.Control;
            this.Label16.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label16.Location = new System.Drawing.Point(8, 24);
            this.Label16.Name = "Label16";
            this.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label16.Size = new System.Drawing.Size(111, 14);
            this.Label16.TabIndex = 28;
            this.Label16.Text = "Port (0 = auto select):";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.BackColor = System.Drawing.SystemColors.Control;
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(176, 24);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(61, 14);
            this.Label17.TabIndex = 27;
            this.Label17.Text = "Max users:";
            // 
            // grbASFStreamingToWMServer
            // 
            this.grbASFStreamingToWMServer.BackColor = System.Drawing.SystemColors.Control;
            this.grbASFStreamingToWMServer.Controls.Add(this.edtPublishingPointPassword);
            this.grbASFStreamingToWMServer.Controls.Add(this.edtPublishingPointUsername);
            this.grbASFStreamingToWMServer.Controls.Add(this.Label2);
            this.grbASFStreamingToWMServer.Controls.Add(this.Label1);
            this.grbASFStreamingToWMServer.Controls.Add(this.edtPublishingPoint);
            this.grbASFStreamingToWMServer.Controls.Add(this.Label18);
            this.grbASFStreamingToWMServer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbASFStreamingToWMServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbASFStreamingToWMServer.Location = new System.Drawing.Point(4, 134);
            this.grbASFStreamingToWMServer.Name = "grbASFStreamingToWMServer";
            this.grbASFStreamingToWMServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbASFStreamingToWMServer.Size = new System.Drawing.Size(673, 43);
            this.grbASFStreamingToWMServer.TabIndex = 41;
            this.grbASFStreamingToWMServer.TabStop = false;
            this.grbASFStreamingToWMServer.Text = "stream to a WM publishing point with authentication: (e.g. http://myserver.com:80" +
                "80/mypublishingpoint)";
            // 
            // edtPublishingPointPassword
            // 
            this.edtPublishingPointPassword.Location = new System.Drawing.Point(590, 16);
            this.edtPublishingPointPassword.Name = "edtPublishingPointPassword";
            this.edtPublishingPointPassword.Size = new System.Drawing.Size(74, 20);
            this.edtPublishingPointPassword.TabIndex = 27;
            this.edtPublishingPointPassword.TextChanged += new System.EventHandler(this.edtPublishingPointPassword_TextChanged);
            // 
            // edtPublishingPointUsername
            // 
            this.edtPublishingPointUsername.Location = new System.Drawing.Point(442, 16);
            this.edtPublishingPointUsername.Name = "edtPublishingPointUsername";
            this.edtPublishingPointUsername.Size = new System.Drawing.Size(74, 20);
            this.edtPublishingPointUsername.TabIndex = 26;
            this.edtPublishingPointUsername.TextChanged += new System.EventHandler(this.edtPublishingPointUsername_TextChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(530, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(60, 14);
            this.Label2.TabIndex = 25;
            this.Label2.Text = "password:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(384, 19);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 14);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "username:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtPublishingPoint
            // 
            this.edtPublishingPoint.AcceptsReturn = true;
            this.edtPublishingPoint.BackColor = System.Drawing.SystemColors.Window;
            this.edtPublishingPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtPublishingPoint.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPublishingPoint.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtPublishingPoint.Location = new System.Drawing.Point(99, 16);
            this.edtPublishingPoint.MaxLength = 0;
            this.edtPublishingPoint.Name = "edtPublishingPoint";
            this.edtPublishingPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtPublishingPoint.Size = new System.Drawing.Size(273, 20);
            this.edtPublishingPoint.TabIndex = 22;
            this.edtPublishingPoint.TextChanged += new System.EventHandler(this.edtPublishingPoint_TextChanged);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.BackColor = System.Drawing.SystemColors.Control;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(18, 19);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(81, 14);
            this.Label18.TabIndex = 23;
            this.Label18.Text = "publishing URL:";
            // 
            // NetworkStreaming
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(955, 244);
            this.ControlBox = false;
            this.Controls.Add(this.grbWMV9profiles);
            this.Controls.Add(this.rdgNetworkStreamingType);
            this.Controls.Add(this.rdgNetworkStreaming);
            this.Controls.Add(this.grbASFSettings);
            this.Controls.Add(this.grbASFProfiles);
            this.Controls.Add(this.grbDirectASFStreaming);
            this.Controls.Add(this.grbASFStreamingToWMServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkStreaming";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.NetworkStreaming_Load);
            this.VisibleChanged += new System.EventHandler(this.NetworkStreaming_VisibleChanged);
            this.grbWMV9profiles.ResumeLayout(false);
            this.grbWMV9profiles.PerformLayout();
            this.rdgNetworkStreamingType.ResumeLayout(false);
            this.rdgNetworkStreaming.ResumeLayout(false);
            this.grbASFSettings.ResumeLayout(false);
            this.grbASFSettings.PerformLayout();
            this.grbWMVversion.ResumeLayout(false);
            this.grbASFProfiles.ResumeLayout(false);
            this.grbASFProfiles.PerformLayout();
            this.grbDirectASFStreaming.ResumeLayout(false);
            this.grbDirectASFStreaming.PerformLayout();
            this.grbASFStreamingToWMServer.ResumeLayout(false);
            this.grbASFStreamingToWMServer.PerformLayout();
            this.ResumeLayout(false);

        }
		#endregion

		private void NetworkStreaming_Load(object sender, System.EventArgs e)
		{
		
		}

		public void RefreshControls()
		{
			SetRadioButtonInGroupUsingTag((rdgNetworkStreaming), (short) cMainForm.axVideoGrabberNET1.NetworkStreaming);
			SetRadioButtonInGroupUsingTag((rdgNetworkStreamingType), (short) cMainForm.axVideoGrabberNET1.NetworkStreamingType);

			if (cMainForm.axVideoGrabberNET1.ASFProfileVersion == Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_8) 
			{
				rgdWMV8.Checked = true;
			}
			if (cMainForm.axVideoGrabberNET1.ASFProfileVersion == Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9) 
			{
				rdgWMV9.Checked = true;
			}

			if (cMainForm.axVideoGrabberNET1.ASFProfileFromCustomFile !=  null) 
			{
				edtWMV9profile.Text = cMainForm.axVideoGrabberNET1.ASFProfileFromCustomFile;
			}
			edtPublishingPoint.Text = cMainForm.axVideoGrabberNET1.ASFMediaServerPublishingPoint;
			edtNetworkPort.Text = cMainForm.axVideoGrabberNET1.ASFNetworkPort.ToString();
			edtNetworkMaxUsers.Text = cMainForm.axVideoGrabberNET1.ASFNetworkMaxUsers.ToString();

			edtASFVideoWidth.Text = cMainForm.axVideoGrabberNET1.ASFVideoWidth.ToString();
			edtASFVideoHeight.Text = cMainForm.axVideoGrabberNET1.ASFVideoHeight.ToString();
			edtASFVideoBitRate.Text = cMainForm.axVideoGrabberNET1.ASFVideoBitRate.ToString();
			edtASFVideoMaxKeyFrameSpacing.Text = cMainForm.axVideoGrabberNET1.ASFVideoMaxKeyFrameSpacing.ToString();
			edtASFVideoQuality.Text = cMainForm.axVideoGrabberNET1.ASFVideoQuality.ToString();
			edtASFAudioChannels.Text = cMainForm.axVideoGrabberNET1.ASFAudioChannels.ToString();
			chkASFFixedFrameRate.Checked = cMainForm.axVideoGrabberNET1.ASFFixedFrameRate;
			cmbASFDeinterlaceMode.SelectedIndex = (int) cMainForm.axVideoGrabberNET1.ASFDeinterlaceMode;

			edtProfileIndex.Text = cMainForm.axVideoGrabberNET1.ASFProfile.ToString();
		}

		private void btnShowProfilesList_Click(object sender, System.EventArgs e)
		{
			if (cMainForm.axVideoGrabberNET1.ASFProfileVersion == Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_8) 
			{
				LoadTextBox(lsbProfiles, cMainForm.axVideoGrabberNET1.ASFProfiles);
			}
			else 
			{
                MessageBox.Show("select WMV version 8 first",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			}
		}

        private void lsbProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProfiles.Items.Count > 0)
            {
                cMainForm.axVideoGrabberNET1.ASFProfile = lsbProfiles.SelectedIndex;
                edtProfileIndex.Text =Convert.ToString(cMainForm.axVideoGrabberNET1.ASFProfile);
            }
        }

		private void edtProfileIndex_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric (edtProfileIndex.Text))
			{
				cMainForm.axVideoGrabberNET1.ASFProfile = Convert.ToInt32(edtProfileIndex.Text);
			}
		}

		private void rdgNetworkStreamingDisabled_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreaming = Vidgrab_NET.TxNetworkStreaming.ns_Disabled;
            btnViewDirectNetworkStreaming.Enabled = true;
		}

		private void rdgNetworkStreamingDirect_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreaming = Vidgrab_NET.TxNetworkStreaming.ns_ASFDirectNetworkStreaming;
            btnViewDirectNetworkStreaming.Enabled = false;
		}

		private void rdgNetworkStreamingPublishingPoint_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreaming = Vidgrab_NET.TxNetworkStreaming.ns_ASFStreamingToPublishingPoint;
            btnViewDirectNetworkStreaming.Enabled = false;
		}

		private void rdgNetworkStreamingTypeAudioVideo_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreamingType = Vidgrab_NET.TxNetworkStreamingType.nst_AudioVideoStreaming;
		}

		private void rdgNetworkStreamingTypeVideo_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreamingType = Vidgrab_NET.TxNetworkStreamingType.nst_VideoStreaming;
		}

		private void rdgNetworkStreamingTypeAudio_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.NetworkStreamingType = Vidgrab_NET.TxNetworkStreamingType.nst_AudioStreaming;
		}

		private void btnViewDirectNetworkStreaming_Click(object sender, System.EventArgs e)
		{
			if (cMainForm.axVideoGrabberNET1.StreamingURL != "") 
			{
				ShellExecute((System.IntPtr) 0, "open", cMainForm.axVideoGrabberNET1.StreamingURL, "", "", ShowCommands.SW_SHOWNORMAL);
			}
		}

		private void chkASFFixedFrameRate_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFFixedFrameRate = chkASFFixedFrameRate.Checked;
		}

		private void cmbASFDeinterlaceMode_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFDeinterlaceMode = (Vidgrab_NET.TxASFDeinterlaceMode) cmbASFDeinterlaceMode.SelectedIndex;
		}

		private void edtASFAudioChannels_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFAudioChannels.Text)) 
			{
				cMainForm.axVideoGrabberNET1.ASFAudioChannels = Convert.ToInt32 (edtASFAudioChannels.Text);
			}
		}

		private void edtASFVideoBitRate_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFVideoBitRate.Text)) 
			{
				if (Convert.ToDouble(edtASFVideoBitRate.Text) > 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFVideoBitRate = Convert.ToInt32 (edtASFVideoBitRate.Text);
				}
			}
		}

		private void edtASFVideoHeight_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFVideoHeight.Text)) 
			{
				if (Convert.ToDouble(edtASFVideoHeight.Text) > 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFVideoHeight = Convert.ToInt32(edtASFVideoHeight.Text);
				}
			}
		}

		private void edtASFVideoMaxKeyFrameSpacing_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFVideoMaxKeyFrameSpacing.Text)) 
			{
				cMainForm.axVideoGrabberNET1.ASFVideoMaxKeyFrameSpacing = Convert.ToInt32(edtASFVideoMaxKeyFrameSpacing.Text);
			}
		}

		private void edtASFVideoQuality_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFVideoQuality.Text)) 
			{
				if (Convert.ToDouble(edtASFVideoQuality.Text) >= 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFVideoQuality = Convert.ToInt32(edtASFVideoQuality.Text);
				}
			}
		}

		private void edtASFVideoWidth_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtASFVideoWidth.Text)) 
			{
				if (Convert.ToDouble(edtASFVideoWidth.Text) > 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFVideoWidth = Convert.ToInt32(edtASFVideoWidth.Text);
				}
			}
		}

		private void edtNetworkMaxUsers_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtNetworkMaxUsers.Text)) 
			{
				if (Convert.ToDouble(edtNetworkMaxUsers.Text) > 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFNetworkMaxUsers = Convert.ToInt32(edtNetworkMaxUsers.Text);
				}
			}
		}

		private void edtNetworkPort_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtNetworkPort.Text)) 
			{
				if (Convert.ToDouble(edtNetworkPort.Text) >= 0) 
				{
					cMainForm.axVideoGrabberNET1.ASFNetworkPort = Convert.ToInt32(edtNetworkPort.Text);
				}
			}
		}

		private void edtPublishingPoint_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFMediaServerPublishingPoint = edtPublishingPoint.Text;
		}

        private void edtPublishingPointUsername_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.SetAuthentication (Vidgrab_NET.TxAuthenticationType.at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text);
        }

        private void edtPublishingPointPassword_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.axVideoGrabberNET1.SetAuthentication (Vidgrab_NET.TxAuthenticationType.at_PublishingPoint, edtPublishingPointUsername.Text, edtPublishingPointPassword.Text);
        }

		private void btnSelectWMV9Profile_Click(object sender, System.EventArgs e)
		{
			if (cMainForm.axVideoGrabberNET1.ASFProfileVersion == Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9) 
			{
				OpenFileDialog dlgOpen = new OpenFileDialog();

				dlgOpen.Filter = OPEN_PROFILES;
				if (dlgOpen.ShowDialog() == DialogResult.OK) 
				{
					edtWMV9profile.Text = dlgOpen.FileName;
				}
			}
			else 
			{
                MessageBox.Show("select WMV version 9 first",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			}
		}

		private void edtWMV9profile_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFProfileFromCustomFile = edtWMV9profile.Text;
		}

		private void rgdWMV8_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFProfileVersion = Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_8;
		}

		private void rdgWMV9_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.ASFProfileVersion = Vidgrab_NET.TxASFProfileVersion.apv_ProfileVersion_9;
		}

		private void NetworkStreaming_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

	}
}
