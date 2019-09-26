using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for Overlays.
	/// </summary>
	public class Overlays : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal GroupBox grbDrawGrid;
        internal Button btnDrawGridColor;
        internal Label Label5;
        internal TextBox edtDrawGrid;
        public GroupBox grbTextOverlay;
        public TextBox edtTextOverlayLeft;
        internal Button btnSelectShadowColor;
        internal GroupBox rgdTextOverlayShadowDirection;
        internal RadioButton rgdShadow7;
        internal RadioButton rgdShadow6;
        internal RadioButton rgdShadow5;
        internal RadioButton rgdShadow4;
        internal RadioButton rgdShadow3;
        internal RadioButton rgdShadow2;
        internal RadioButton rgdShadow1;
        internal RadioButton rgdShadow0;
        internal GroupBox grbOverlaySelector;
        internal RadioButton TextSelector4;
        internal RadioButton TextSelector3;
        internal RadioButton TextSelector2;
        internal RadioButton TextSelector1;
        internal RadioButton TextSelector0;
        internal Button btnBackColor;
        internal Button btnSelectFontColor;
        internal CheckBox chkTextOverlayShadow;
        internal Button btnSelectFont;
        public TextBox mmoTextOverlayString;
        public CheckBox chkTextOverlayEnabled;
        public TextBox edtTextOverlayTop;
        public TextBox edtTextOverlayRight;
        public CheckBox chkTextOverlayTransparent;
        public Label Label43;
        public GroupBox grbFreeHand;
        public CheckBox chkFreeHandEnabled;
        public Button btnFreeHandErase;
        internal Button btnFreeHandColor;
        public GroupBox grbBitmapOverlay;
        internal TrackBar tbrChromaKeyLeeway;
        internal Label Label4;
        internal Label Label3;
        internal Button btnImageOverlayPickupChromaKeyColorHelp;
        internal Button btnImageOverlayPickupChromaKeyColor;
        internal TextBox edtImageOverlayChromaKeyColorValue;
        public CheckBox chkImageOverlayChromaKey;
        internal TrackBar tbrImageOverlayAlphaBlending;
        internal Button btnImageOverlayPickupTransparentColorHelp;
        internal Button btnImageOverlayPickupTransparentColor;
        internal GroupBox grpImageOverlaySelector;
        internal RadioButton ImageSelector9;
        internal RadioButton ImageSelector8;
        internal RadioButton ImageSelector7;
        internal RadioButton ImageSelector6;
        internal RadioButton ImageSelector5;
        internal RadioButton ImageSelector4;
        internal RadioButton ImageSelector3;
        internal RadioButton ImageSelector2;
        internal RadioButton ImageSelector1;
        internal RadioButton ImageSelector0;
        public TextBox edtImageOverlayWidth;
        public TextBox edtImageOverlayHeight;
        public Label Label1;
        public Label Label2;
        internal TextBox edtImageOverlayTransparentColorValue;
        internal Button btnImageOverlayFromFile;
        internal CheckBox chkImageOverlayAlphaBlend;
        internal CheckBox chkImageOverlayUseTransparentColor;
        public CheckBox chkImageOverlayEnabled;
        public CheckBox chkImageOverlayTransparent;
        public TextBox edtImageOverlayLeft;
        public TextBox edtImageOverlayTop;
        public Label Label48;
        public Label Label49;
        internal ImageList ImageList1;
        internal Button btnPIP;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label6;
		public System.Windows.Forms.CheckBox chkTargetAtMouseLocation;
        private CheckBox chkTextOverlayScrolling;
        public Label label7;
        private TextBox edtTextOverlayScrollingSpeed;
        public CheckBox chkAdjustOverlayAspectRatio;
        public RadioButton rdgTextOverlayAlignLeft;
        public RadioButton rdgTextOverlayAlignRight;
        public RadioButton rdgTextOverlayAlignCenter;
        private GroupBox rdgTextOverlayAlign;

        private VidGrab.VideoGrabber PIPVideoGrabber;
        //private VidGrab.VideoGrabberNET PIPVideoGrabber = null;

		public Overlays()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlays));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDrawGridColor = new System.Windows.Forms.Button();
            this.edtDrawGrid = new System.Windows.Forms.TextBox();
            this.btnFreeHandColor = new System.Windows.Forms.Button();
            this.grbDrawGrid = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.grbTextOverlay = new System.Windows.Forms.GroupBox();
            this.chkAdjustOverlayAspectRatio = new System.Windows.Forms.CheckBox();
            this.chkTextOverlayScrolling = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtTextOverlayScrollingSpeed = new System.Windows.Forms.TextBox();
            this.edtTextOverlayLeft = new System.Windows.Forms.TextBox();
            this.btnSelectShadowColor = new System.Windows.Forms.Button();
            this.rgdTextOverlayShadowDirection = new System.Windows.Forms.GroupBox();
            this.rgdShadow7 = new System.Windows.Forms.RadioButton();
            this.rgdShadow6 = new System.Windows.Forms.RadioButton();
            this.rgdShadow5 = new System.Windows.Forms.RadioButton();
            this.rgdShadow4 = new System.Windows.Forms.RadioButton();
            this.rgdShadow3 = new System.Windows.Forms.RadioButton();
            this.rgdShadow2 = new System.Windows.Forms.RadioButton();
            this.rgdShadow1 = new System.Windows.Forms.RadioButton();
            this.rgdShadow0 = new System.Windows.Forms.RadioButton();
            this.grbOverlaySelector = new System.Windows.Forms.GroupBox();
            this.TextSelector4 = new System.Windows.Forms.RadioButton();
            this.TextSelector3 = new System.Windows.Forms.RadioButton();
            this.TextSelector2 = new System.Windows.Forms.RadioButton();
            this.TextSelector1 = new System.Windows.Forms.RadioButton();
            this.TextSelector0 = new System.Windows.Forms.RadioButton();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnSelectFontColor = new System.Windows.Forms.Button();
            this.chkTextOverlayShadow = new System.Windows.Forms.CheckBox();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.mmoTextOverlayString = new System.Windows.Forms.TextBox();
            this.chkTextOverlayEnabled = new System.Windows.Forms.CheckBox();
            this.edtTextOverlayTop = new System.Windows.Forms.TextBox();
            this.edtTextOverlayRight = new System.Windows.Forms.TextBox();
            this.chkTextOverlayTransparent = new System.Windows.Forms.CheckBox();
            this.Label43 = new System.Windows.Forms.Label();
            this.grbFreeHand = new System.Windows.Forms.GroupBox();
            this.chkFreeHandEnabled = new System.Windows.Forms.CheckBox();
            this.btnFreeHandErase = new System.Windows.Forms.Button();
            this.grbBitmapOverlay = new System.Windows.Forms.GroupBox();
            this.tbrChromaKeyLeeway = new System.Windows.Forms.TrackBar();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnImageOverlayPickupChromaKeyColorHelp = new System.Windows.Forms.Button();
            this.btnImageOverlayPickupChromaKeyColor = new System.Windows.Forms.Button();
            this.edtImageOverlayChromaKeyColorValue = new System.Windows.Forms.TextBox();
            this.chkImageOverlayChromaKey = new System.Windows.Forms.CheckBox();
            this.tbrImageOverlayAlphaBlending = new System.Windows.Forms.TrackBar();
            this.btnImageOverlayPickupTransparentColorHelp = new System.Windows.Forms.Button();
            this.btnImageOverlayPickupTransparentColor = new System.Windows.Forms.Button();
            this.grpImageOverlaySelector = new System.Windows.Forms.GroupBox();
            this.ImageSelector9 = new System.Windows.Forms.RadioButton();
            this.ImageSelector8 = new System.Windows.Forms.RadioButton();
            this.ImageSelector7 = new System.Windows.Forms.RadioButton();
            this.ImageSelector6 = new System.Windows.Forms.RadioButton();
            this.ImageSelector5 = new System.Windows.Forms.RadioButton();
            this.ImageSelector4 = new System.Windows.Forms.RadioButton();
            this.ImageSelector3 = new System.Windows.Forms.RadioButton();
            this.ImageSelector2 = new System.Windows.Forms.RadioButton();
            this.ImageSelector1 = new System.Windows.Forms.RadioButton();
            this.ImageSelector0 = new System.Windows.Forms.RadioButton();
            this.edtImageOverlayWidth = new System.Windows.Forms.TextBox();
            this.edtImageOverlayHeight = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.edtImageOverlayTransparentColorValue = new System.Windows.Forms.TextBox();
            this.btnImageOverlayFromFile = new System.Windows.Forms.Button();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chkImageOverlayAlphaBlend = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayUseTransparentColor = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayEnabled = new System.Windows.Forms.CheckBox();
            this.chkImageOverlayTransparent = new System.Windows.Forms.CheckBox();
            this.edtImageOverlayLeft = new System.Windows.Forms.TextBox();
            this.edtImageOverlayTop = new System.Windows.Forms.TextBox();
            this.Label48 = new System.Windows.Forms.Label();
            this.Label49 = new System.Windows.Forms.Label();
            this.btnPIP = new System.Windows.Forms.Button();
            this.chkTargetAtMouseLocation = new System.Windows.Forms.CheckBox();
            this.rdgTextOverlayAlignLeft = new System.Windows.Forms.RadioButton();
            this.rdgTextOverlayAlignRight = new System.Windows.Forms.RadioButton();
            this.rdgTextOverlayAlignCenter = new System.Windows.Forms.RadioButton();
            this.rdgTextOverlayAlign = new System.Windows.Forms.GroupBox();
            this.grbDrawGrid.SuspendLayout();
            this.grbTextOverlay.SuspendLayout();
            this.rgdTextOverlayShadowDirection.SuspendLayout();
            this.grbOverlaySelector.SuspendLayout();
            this.grbFreeHand.SuspendLayout();
            this.grbBitmapOverlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrChromaKeyLeeway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImageOverlayAlphaBlending)).BeginInit();
            this.grpImageOverlaySelector.SuspendLayout();
            this.rdgTextOverlayAlign.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDrawGridColor
            // 
            this.btnDrawGridColor.Location = new System.Drawing.Point(33, 13);
            this.btnDrawGridColor.Name = "btnDrawGridColor";
            this.btnDrawGridColor.Size = new System.Drawing.Size(16, 20);
            this.btnDrawGridColor.TabIndex = 46;
            this.ToolTip1.SetToolTip(this.btnDrawGridColor, "select grid color from a color dialog");
            this.btnDrawGridColor.Click += new System.EventHandler(this.btnDrawGridColor_Click);
            // 
            // edtDrawGrid
            // 
            this.edtDrawGrid.Location = new System.Drawing.Point(48, 14);
            this.edtDrawGrid.Name = "edtDrawGrid";
            this.edtDrawGrid.Size = new System.Drawing.Size(25, 20);
            this.edtDrawGrid.TabIndex = 44;
            this.edtDrawGrid.Text = "0";
            this.ToolTip1.SetToolTip(this.edtDrawGrid, "enter a number between 2 and 100 to activate grid drawing");
            this.edtDrawGrid.TextChanged += new System.EventHandler(this.edtDrawGrid_TextChanged);
            // 
            // btnFreeHandColor
            // 
            this.btnFreeHandColor.Location = new System.Drawing.Point(86, 17);
            this.btnFreeHandColor.Name = "btnFreeHandColor";
            this.btnFreeHandColor.Size = new System.Drawing.Size(16, 22);
            this.btnFreeHandColor.TabIndex = 16;
            this.ToolTip1.SetToolTip(this.btnFreeHandColor, "select \"free hand\" drawng color from a color dialog");
            this.btnFreeHandColor.Click += new System.EventHandler(this.btnFreeHandColor_Click);
            // 
            // grbDrawGrid
            // 
            this.grbDrawGrid.Controls.Add(this.label6);
            this.grbDrawGrid.Controls.Add(this.btnDrawGridColor);
            this.grbDrawGrid.Controls.Add(this.Label5);
            this.grbDrawGrid.Controls.Add(this.edtDrawGrid);
            this.grbDrawGrid.Location = new System.Drawing.Point(585, 16);
            this.grbDrawGrid.Name = "grbDrawGrid";
            this.grbDrawGrid.Size = new System.Drawing.Size(119, 37);
            this.grbDrawGrid.TabIndex = 49;
            this.grbDrawGrid.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "grid:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(80, 17);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(36, 13);
            this.Label5.TabIndex = 45;
            this.Label5.Text = "facets";
            // 
            // grbTextOverlay
            // 
            this.grbTextOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.grbTextOverlay.Controls.Add(this.mmoTextOverlayString);
            this.grbTextOverlay.Controls.Add(this.rdgTextOverlayAlign);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayScrolling);
            this.grbTextOverlay.Controls.Add(this.label7);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayScrollingSpeed);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayLeft);
            this.grbTextOverlay.Controls.Add(this.btnSelectShadowColor);
            this.grbTextOverlay.Controls.Add(this.rgdTextOverlayShadowDirection);
            this.grbTextOverlay.Controls.Add(this.grbOverlaySelector);
            this.grbTextOverlay.Controls.Add(this.btnBackColor);
            this.grbTextOverlay.Controls.Add(this.btnSelectFontColor);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayShadow);
            this.grbTextOverlay.Controls.Add(this.btnSelectFont);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayEnabled);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayTop);
            this.grbTextOverlay.Controls.Add(this.edtTextOverlayRight);
            this.grbTextOverlay.Controls.Add(this.chkTextOverlayTransparent);
            this.grbTextOverlay.Controls.Add(this.Label43);
            this.grbTextOverlay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTextOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbTextOverlay.Location = new System.Drawing.Point(4, 0);
            this.grbTextOverlay.Name = "grbTextOverlay";
            this.grbTextOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbTextOverlay.Size = new System.Drawing.Size(361, 178);
            this.grbTextOverlay.TabIndex = 47;
            this.grbTextOverlay.TabStop = false;
            this.grbTextOverlay.Text = "text overlay (up to 1000 different simultaneous text overlays)";
            // 
            // chkAdjustOverlayAspectRatio
            // 
            this.chkAdjustOverlayAspectRatio.AutoSize = true;
            this.chkAdjustOverlayAspectRatio.BackColor = System.Drawing.SystemColors.Control;
            this.chkAdjustOverlayAspectRatio.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkAdjustOverlayAspectRatio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdjustOverlayAspectRatio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkAdjustOverlayAspectRatio.Location = new System.Drawing.Point(593, 7);
            this.chkAdjustOverlayAspectRatio.Name = "chkAdjustOverlayAspectRatio";
            this.chkAdjustOverlayAspectRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkAdjustOverlayAspectRatio.Size = new System.Drawing.Size(171, 18);
            this.chkAdjustOverlayAspectRatio.TabIndex = 40;
            this.chkAdjustOverlayAspectRatio.Text = "adjust overlay aspect ratio";
            this.chkAdjustOverlayAspectRatio.UseVisualStyleBackColor = false;
            this.chkAdjustOverlayAspectRatio.CheckedChanged += new System.EventHandler(this.chkAdjustOverlayAspectRatio_CheckedChanged);
            // 
            // chkTextOverlayScrolling
            // 
            this.chkTextOverlayScrolling.AutoSize = true;
            this.chkTextOverlayScrolling.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTextOverlayScrolling.Location = new System.Drawing.Point(178, 16);
            this.chkTextOverlayScrolling.Name = "chkTextOverlayScrolling";
            this.chkTextOverlayScrolling.Size = new System.Drawing.Size(66, 18);
            this.chkTextOverlayScrolling.TabIndex = 39;
            this.chkTextOverlayScrolling.Text = "scrolling";
            this.chkTextOverlayScrolling.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTextOverlayScrolling.UseVisualStyleBackColor = true;
            this.chkTextOverlayScrolling.CheckedChanged += new System.EventHandler(this.chkTextOverlayScrolling_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(209, 16);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 38;
            this.label7.Text = "-> speed(+-)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edtTextOverlayScrollingSpeed
            // 
            this.edtTextOverlayScrollingSpeed.Location = new System.Drawing.Point(307, 15);
            this.edtTextOverlayScrollingSpeed.Name = "edtTextOverlayScrollingSpeed";
            this.edtTextOverlayScrollingSpeed.Size = new System.Drawing.Size(31, 20);
            this.edtTextOverlayScrollingSpeed.TabIndex = 37;
            this.edtTextOverlayScrollingSpeed.TextChanged += new System.EventHandler(this.edtTextOverlayScrollingSpeed_TextChanged);
            // 
            // edtTextOverlayLeft
            // 
            this.edtTextOverlayLeft.AcceptsReturn = true;
            this.edtTextOverlayLeft.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayLeft.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTextOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayLeft.Location = new System.Drawing.Point(193, 50);
            this.edtTextOverlayLeft.MaxLength = 0;
            this.edtTextOverlayLeft.Name = "edtTextOverlayLeft";
            this.edtTextOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayLeft.Size = new System.Drawing.Size(33, 20);
            this.edtTextOverlayLeft.TabIndex = 20;
            this.edtTextOverlayLeft.Text = "5";
            this.edtTextOverlayLeft.TextChanged += new System.EventHandler(this.edtTextOverlayLeft_TextChanged);
            // 
            // btnSelectShadowColor
            // 
            this.btnSelectShadowColor.Location = new System.Drawing.Point(265, 76);
            this.btnSelectShadowColor.Name = "btnSelectShadowColor";
            this.btnSelectShadowColor.Size = new System.Drawing.Size(86, 21);
            this.btnSelectShadowColor.TabIndex = 36;
            this.btnSelectShadowColor.Text = "shadow color";
            this.btnSelectShadowColor.Click += new System.EventHandler(this.btnSelectShadowColor_Click);
            // 
            // rgdTextOverlayShadowDirection
            // 
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow7);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow6);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow5);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow4);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow3);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow2);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow1);
            this.rgdTextOverlayShadowDirection.Controls.Add(this.rgdShadow0);
            this.rgdTextOverlayShadowDirection.Location = new System.Drawing.Point(249, 101);
            this.rgdTextOverlayShadowDirection.Name = "rgdTextOverlayShadowDirection";
            this.rgdTextOverlayShadowDirection.Size = new System.Drawing.Size(106, 73);
            this.rgdTextOverlayShadowDirection.TabIndex = 35;
            this.rgdTextOverlayShadowDirection.TabStop = false;
            this.rgdTextOverlayShadowDirection.Text = "shadow direction";
            // 
            // rgdShadow7
            // 
            this.rgdShadow7.Location = new System.Drawing.Point(57, 55);
            this.rgdShadow7.Name = "rgdShadow7";
            this.rgdShadow7.Size = new System.Drawing.Size(45, 16);
            this.rgdShadow7.TabIndex = 17;
            this.rgdShadow7.Tag = "7";
            this.rgdShadow7.Text = "n-w";
            this.rgdShadow7.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow6
            // 
            this.rgdShadow6.Location = new System.Drawing.Point(57, 41);
            this.rgdShadow6.Name = "rgdShadow6";
            this.rgdShadow6.Size = new System.Drawing.Size(45, 16);
            this.rgdShadow6.TabIndex = 16;
            this.rgdShadow6.Tag = "6";
            this.rgdShadow6.Text = "w";
            this.rgdShadow6.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow5
            // 
            this.rgdShadow5.Location = new System.Drawing.Point(57, 27);
            this.rgdShadow5.Name = "rgdShadow5";
            this.rgdShadow5.Size = new System.Drawing.Size(45, 16);
            this.rgdShadow5.TabIndex = 15;
            this.rgdShadow5.Tag = "5";
            this.rgdShadow5.Text = "s-w";
            this.rgdShadow5.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow4
            // 
            this.rgdShadow4.Location = new System.Drawing.Point(57, 13);
            this.rgdShadow4.Name = "rgdShadow4";
            this.rgdShadow4.Size = new System.Drawing.Size(45, 16);
            this.rgdShadow4.TabIndex = 14;
            this.rgdShadow4.Tag = "4";
            this.rgdShadow4.Text = "s";
            this.rgdShadow4.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow3
            // 
            this.rgdShadow3.Location = new System.Drawing.Point(8, 55);
            this.rgdShadow3.Name = "rgdShadow3";
            this.rgdShadow3.Size = new System.Drawing.Size(48, 16);
            this.rgdShadow3.TabIndex = 13;
            this.rgdShadow3.Tag = "3";
            this.rgdShadow3.Text = "s-e";
            this.rgdShadow3.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow2
            // 
            this.rgdShadow2.Location = new System.Drawing.Point(8, 41);
            this.rgdShadow2.Name = "rgdShadow2";
            this.rgdShadow2.Size = new System.Drawing.Size(48, 16);
            this.rgdShadow2.TabIndex = 12;
            this.rgdShadow2.Tag = "2";
            this.rgdShadow2.Text = "e";
            this.rgdShadow2.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow1
            // 
            this.rgdShadow1.Location = new System.Drawing.Point(8, 27);
            this.rgdShadow1.Name = "rgdShadow1";
            this.rgdShadow1.Size = new System.Drawing.Size(48, 16);
            this.rgdShadow1.TabIndex = 11;
            this.rgdShadow1.Tag = "1";
            this.rgdShadow1.Text = "n-e";
            this.rgdShadow1.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // rgdShadow0
            // 
            this.rgdShadow0.Checked = true;
            this.rgdShadow0.Location = new System.Drawing.Point(8, 13);
            this.rgdShadow0.Name = "rgdShadow0";
            this.rgdShadow0.Size = new System.Drawing.Size(48, 16);
            this.rgdShadow0.TabIndex = 10;
            this.rgdShadow0.TabStop = true;
            this.rgdShadow0.Tag = "0";
            this.rgdShadow0.Text = "n";
            this.rgdShadow0.CheckedChanged += new System.EventHandler(this.rgdShadow_CheckedChanged);
            // 
            // grbOverlaySelector
            // 
            this.grbOverlaySelector.Controls.Add(this.TextSelector4);
            this.grbOverlaySelector.Controls.Add(this.TextSelector3);
            this.grbOverlaySelector.Controls.Add(this.TextSelector2);
            this.grbOverlaySelector.Controls.Add(this.TextSelector1);
            this.grbOverlaySelector.Controls.Add(this.TextSelector0);
            this.grbOverlaySelector.Location = new System.Drawing.Point(6, 39);
            this.grbOverlaySelector.Name = "grbOverlaySelector";
            this.grbOverlaySelector.Size = new System.Drawing.Size(181, 34);
            this.grbOverlaySelector.TabIndex = 34;
            this.grbOverlaySelector.TabStop = false;
            this.grbOverlaySelector.Text = "text selector [0 - n]  0 = default";
            // 
            // TextSelector4
            // 
            this.TextSelector4.Location = new System.Drawing.Point(142, 14);
            this.TextSelector4.Name = "TextSelector4";
            this.TextSelector4.Size = new System.Drawing.Size(24, 16);
            this.TextSelector4.TabIndex = 4;
            this.TextSelector4.Tag = "4";
            this.TextSelector4.Text = "4";
            this.TextSelector4.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector3
            // 
            this.TextSelector3.Location = new System.Drawing.Point(110, 14);
            this.TextSelector3.Name = "TextSelector3";
            this.TextSelector3.Size = new System.Drawing.Size(24, 16);
            this.TextSelector3.TabIndex = 3;
            this.TextSelector3.Tag = "3";
            this.TextSelector3.Text = "3";
            this.TextSelector3.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector2
            // 
            this.TextSelector2.Location = new System.Drawing.Point(78, 14);
            this.TextSelector2.Name = "TextSelector2";
            this.TextSelector2.Size = new System.Drawing.Size(24, 16);
            this.TextSelector2.TabIndex = 2;
            this.TextSelector2.Tag = "2";
            this.TextSelector2.Text = "2";
            this.TextSelector2.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector1
            // 
            this.TextSelector1.Location = new System.Drawing.Point(46, 14);
            this.TextSelector1.Name = "TextSelector1";
            this.TextSelector1.Size = new System.Drawing.Size(24, 16);
            this.TextSelector1.TabIndex = 1;
            this.TextSelector1.Tag = "1";
            this.TextSelector1.Text = "1";
            this.TextSelector1.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // TextSelector0
            // 
            this.TextSelector0.Location = new System.Drawing.Point(14, 14);
            this.TextSelector0.Name = "TextSelector0";
            this.TextSelector0.Size = new System.Drawing.Size(24, 16);
            this.TextSelector0.TabIndex = 0;
            this.TextSelector0.Tag = "0";
            this.TextSelector0.Text = "0";
            this.TextSelector0.CheckedChanged += new System.EventHandler(this.OverlaySelector_CheckedChanged);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Location = new System.Drawing.Point(193, 152);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(51, 21);
            this.btnBackColor.TabIndex = 33;
            this.btnBackColor.Text = "bkgnd";
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // btnSelectFontColor
            // 
            this.btnSelectFontColor.Location = new System.Drawing.Point(193, 129);
            this.btnSelectFontColor.Name = "btnSelectFontColor";
            this.btnSelectFontColor.Size = new System.Drawing.Size(51, 21);
            this.btnSelectFontColor.TabIndex = 32;
            this.btnSelectFontColor.Text = "color";
            this.btnSelectFontColor.Click += new System.EventHandler(this.btnSelectFontColor_Click);
            // 
            // chkTextOverlayShadow
            // 
            this.chkTextOverlayShadow.Location = new System.Drawing.Point(196, 79);
            this.chkTextOverlayShadow.Name = "chkTextOverlayShadow";
            this.chkTextOverlayShadow.Size = new System.Drawing.Size(67, 15);
            this.chkTextOverlayShadow.TabIndex = 31;
            this.chkTextOverlayShadow.Text = "shadow";
            this.chkTextOverlayShadow.CheckedChanged += new System.EventHandler(this.chkTextOverlayShadow_CheckedChanged);
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(193, 106);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(51, 21);
            this.btnSelectFont.TabIndex = 30;
            this.btnSelectFont.Text = "font dlg";
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // mmoTextOverlayString
            // 
            this.mmoTextOverlayString.AcceptsReturn = true;
            this.mmoTextOverlayString.BackColor = System.Drawing.SystemColors.Window;
            this.mmoTextOverlayString.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoTextOverlayString.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoTextOverlayString.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoTextOverlayString.Location = new System.Drawing.Point(6, 73);
            this.mmoTextOverlayString.MaxLength = 0;
            this.mmoTextOverlayString.Multiline = true;
            this.mmoTextOverlayString.Name = "mmoTextOverlayString";
            this.mmoTextOverlayString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoTextOverlayString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmoTextOverlayString.Size = new System.Drawing.Size(181, 70);
            this.mmoTextOverlayString.TabIndex = 26;
            this.mmoTextOverlayString.TextChanged += new System.EventHandler(this.mmoTextOverlayString_TextChanged);
            // 
            // chkTextOverlayEnabled
            // 
            this.chkTextOverlayEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkTextOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTextOverlayEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTextOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkTextOverlayEnabled.Location = new System.Drawing.Point(6, 18);
            this.chkTextOverlayEnabled.Name = "chkTextOverlayEnabled";
            this.chkTextOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkTextOverlayEnabled.Size = new System.Drawing.Size(72, 16);
            this.chkTextOverlayEnabled.TabIndex = 25;
            this.chkTextOverlayEnabled.Text = "enabled";
            this.chkTextOverlayEnabled.UseVisualStyleBackColor = false;
            this.chkTextOverlayEnabled.CheckedChanged += new System.EventHandler(this.chkTextOverlayEnabled_CheckedChanged);
            // 
            // edtTextOverlayTop
            // 
            this.edtTextOverlayTop.AcceptsReturn = true;
            this.edtTextOverlayTop.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayTop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTextOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayTop.Location = new System.Drawing.Point(265, 51);
            this.edtTextOverlayTop.MaxLength = 0;
            this.edtTextOverlayTop.Name = "edtTextOverlayTop";
            this.edtTextOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayTop.Size = new System.Drawing.Size(33, 20);
            this.edtTextOverlayTop.TabIndex = 19;
            this.edtTextOverlayTop.Text = "5";
            this.edtTextOverlayTop.TextChanged += new System.EventHandler(this.edtTextOverlayTop_TextChanged);
            // 
            // edtTextOverlayRight
            // 
            this.edtTextOverlayRight.AcceptsReturn = true;
            this.edtTextOverlayRight.BackColor = System.Drawing.SystemColors.Window;
            this.edtTextOverlayRight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtTextOverlayRight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTextOverlayRight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtTextOverlayRight.Location = new System.Drawing.Point(229, 50);
            this.edtTextOverlayRight.MaxLength = 0;
            this.edtTextOverlayRight.Name = "edtTextOverlayRight";
            this.edtTextOverlayRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtTextOverlayRight.Size = new System.Drawing.Size(33, 20);
            this.edtTextOverlayRight.TabIndex = 18;
            this.edtTextOverlayRight.Text = "-1";
            this.edtTextOverlayRight.TextChanged += new System.EventHandler(this.edtTextOverlayRight_TextChanged);
            // 
            // chkTextOverlayTransparent
            // 
            this.chkTextOverlayTransparent.BackColor = System.Drawing.SystemColors.Control;
            this.chkTextOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkTextOverlayTransparent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTextOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkTextOverlayTransparent.Location = new System.Drawing.Point(90, 18);
            this.chkTextOverlayTransparent.Name = "chkTextOverlayTransparent";
            this.chkTextOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkTextOverlayTransparent.Size = new System.Drawing.Size(82, 16);
            this.chkTextOverlayTransparent.TabIndex = 17;
            this.chkTextOverlayTransparent.Text = "transparent";
            this.chkTextOverlayTransparent.UseVisualStyleBackColor = false;
            this.chkTextOverlayTransparent.CheckedChanged += new System.EventHandler(this.chkTextOverlayTransparent_CheckedChanged);
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.BackColor = System.Drawing.SystemColors.Control;
            this.Label43.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label43.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label43.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label43.Location = new System.Drawing.Point(193, 35);
            this.Label43.Name = "Label43";
            this.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label43.Size = new System.Drawing.Size(94, 14);
            this.Label43.TabIndex = 29;
            this.Label43.Text = "left      right      top";
            // 
            // grbFreeHand
            // 
            this.grbFreeHand.BackColor = System.Drawing.SystemColors.Control;
            this.grbFreeHand.Controls.Add(this.chkFreeHandEnabled);
            this.grbFreeHand.Controls.Add(this.btnFreeHandErase);
            this.grbFreeHand.Controls.Add(this.btnFreeHandColor);
            this.grbFreeHand.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFreeHand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbFreeHand.Location = new System.Drawing.Point(371, 0);
            this.grbFreeHand.Name = "grbFreeHand";
            this.grbFreeHand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbFreeHand.Size = new System.Drawing.Size(209, 49);
            this.grbFreeHand.TabIndex = 46;
            this.grbFreeHand.TabStop = false;
            this.grbFreeHand.Text = "\"free hand\" mouse overlay USING DC";
            // 
            // chkFreeHandEnabled
            // 
            this.chkFreeHandEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkFreeHandEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFreeHandEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFreeHandEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFreeHandEnabled.Location = new System.Drawing.Point(16, 20);
            this.chkFreeHandEnabled.Name = "chkFreeHandEnabled";
            this.chkFreeHandEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFreeHandEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkFreeHandEnabled.TabIndex = 15;
            this.chkFreeHandEnabled.Text = "enabled";
            this.chkFreeHandEnabled.UseVisualStyleBackColor = false;
            this.chkFreeHandEnabled.CheckedChanged += new System.EventHandler(this.chkFreeHandEnabled_CheckedChanged);
            // 
            // btnFreeHandErase
            // 
            this.btnFreeHandErase.BackColor = System.Drawing.SystemColors.Control;
            this.btnFreeHandErase.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnFreeHandErase.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreeHandErase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFreeHandErase.Location = new System.Drawing.Point(102, 17);
            this.btnFreeHandErase.Name = "btnFreeHandErase";
            this.btnFreeHandErase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFreeHandErase.Size = new System.Drawing.Size(98, 22);
            this.btnFreeHandErase.TabIndex = 14;
            this.btnFreeHandErase.Text = "erase drawing";
            this.btnFreeHandErase.UseVisualStyleBackColor = false;
            this.btnFreeHandErase.Click += new System.EventHandler(this.btnFreeHandErase_Click);
            // 
            // grbBitmapOverlay
            // 
            this.grbBitmapOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.grbBitmapOverlay.Controls.Add(this.tbrChromaKeyLeeway);
            this.grbBitmapOverlay.Controls.Add(this.Label4);
            this.grbBitmapOverlay.Controls.Add(this.Label3);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupChromaKeyColorHelp);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupChromaKeyColor);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayChromaKeyColorValue);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayChromaKey);
            this.grbBitmapOverlay.Controls.Add(this.tbrImageOverlayAlphaBlending);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupTransparentColorHelp);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayPickupTransparentColor);
            this.grbBitmapOverlay.Controls.Add(this.grpImageOverlaySelector);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayWidth);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayHeight);
            this.grbBitmapOverlay.Controls.Add(this.Label1);
            this.grbBitmapOverlay.Controls.Add(this.Label2);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayTransparentColorValue);
            this.grbBitmapOverlay.Controls.Add(this.btnImageOverlayFromFile);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayAlphaBlend);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayUseTransparentColor);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayEnabled);
            this.grbBitmapOverlay.Controls.Add(this.chkImageOverlayTransparent);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayLeft);
            this.grbBitmapOverlay.Controls.Add(this.edtImageOverlayTop);
            this.grbBitmapOverlay.Controls.Add(this.Label48);
            this.grbBitmapOverlay.Controls.Add(this.Label49);
            this.grbBitmapOverlay.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBitmapOverlay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbBitmapOverlay.Location = new System.Drawing.Point(371, 47);
            this.grbBitmapOverlay.Name = "grbBitmapOverlay";
            this.grbBitmapOverlay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbBitmapOverlay.Size = new System.Drawing.Size(539, 131);
            this.grbBitmapOverlay.TabIndex = 45;
            this.grbBitmapOverlay.TabStop = false;
            this.grbBitmapOverlay.Text = "image overlay";
            // 
            // tbrChromaKeyLeeway
            // 
            this.tbrChromaKeyLeeway.AutoSize = false;
            this.tbrChromaKeyLeeway.Location = new System.Drawing.Point(433, 82);
            this.tbrChromaKeyLeeway.Maximum = 100;
            this.tbrChromaKeyLeeway.Name = "tbrChromaKeyLeeway";
            this.tbrChromaKeyLeeway.Size = new System.Drawing.Size(88, 16);
            this.tbrChromaKeyLeeway.TabIndex = 44;
            this.tbrChromaKeyLeeway.TickFrequency = 10;
            this.tbrChromaKeyLeeway.Scroll += new System.EventHandler(this.tbrChromaKeyLeeway_Scroll);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(333, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(118, 14);
            this.Label4.TabIndex = 46;
            this.Label4.Text = "chroma key RGB color:";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(333, 83);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(115, 16);
            this.Label3.TabIndex = 45;
            this.Label3.Text = "chroma key leeway:";
            // 
            // btnImageOverlayPickupChromaKeyColorHelp
            // 
            this.btnImageOverlayPickupChromaKeyColorHelp.Location = new System.Drawing.Point(492, 102);
            this.btnImageOverlayPickupChromaKeyColorHelp.Name = "btnImageOverlayPickupChromaKeyColorHelp";
            this.btnImageOverlayPickupChromaKeyColorHelp.Size = new System.Drawing.Size(24, 21);
            this.btnImageOverlayPickupChromaKeyColorHelp.TabIndex = 43;
            this.btnImageOverlayPickupChromaKeyColorHelp.Text = "?";
            this.btnImageOverlayPickupChromaKeyColorHelp.Click += new System.EventHandler(this.btnImageOverlayPickupChromaKeyColorHelp_Click);
            // 
            // btnImageOverlayPickupChromaKeyColor
            // 
            this.btnImageOverlayPickupChromaKeyColor.Location = new System.Drawing.Point(336, 102);
            this.btnImageOverlayPickupChromaKeyColor.Name = "btnImageOverlayPickupChromaKeyColor";
            this.btnImageOverlayPickupChromaKeyColor.Size = new System.Drawing.Size(150, 21);
            this.btnImageOverlayPickupChromaKeyColor.TabIndex = 42;
            this.btnImageOverlayPickupChromaKeyColor.Text = "pick up chroma key color";
            this.btnImageOverlayPickupChromaKeyColor.Click += new System.EventHandler(this.btnImageOverlayPickupChromaKeyColor_Click);
            // 
            // edtImageOverlayChromaKeyColorValue
            // 
            this.edtImageOverlayChromaKeyColorValue.Location = new System.Drawing.Point(460, 61);
            this.edtImageOverlayChromaKeyColorValue.Name = "edtImageOverlayChromaKeyColorValue";
            this.edtImageOverlayChromaKeyColorValue.Size = new System.Drawing.Size(56, 20);
            this.edtImageOverlayChromaKeyColorValue.TabIndex = 41;
            this.edtImageOverlayChromaKeyColorValue.Text = "0";
            this.edtImageOverlayChromaKeyColorValue.TextChanged += new System.EventHandler(this.edtImageOverlayChromaKeyColorValue_TextChanged);
            // 
            // chkImageOverlayChromaKey
            // 
            this.chkImageOverlayChromaKey.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayChromaKey.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayChromaKey.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImageOverlayChromaKey.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkImageOverlayChromaKey.Location = new System.Drawing.Point(336, 46);
            this.chkImageOverlayChromaKey.Name = "chkImageOverlayChromaKey";
            this.chkImageOverlayChromaKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayChromaKey.Size = new System.Drawing.Size(117, 18);
            this.chkImageOverlayChromaKey.TabIndex = 39;
            this.chkImageOverlayChromaKey.Text = "chroma key";
            this.chkImageOverlayChromaKey.UseVisualStyleBackColor = false;
            this.chkImageOverlayChromaKey.CheckedChanged += new System.EventHandler(this.chkImageOverlayChromaKey_CheckedChanged);
            // 
            // tbrImageOverlayAlphaBlending
            // 
            this.tbrImageOverlayAlphaBlending.AutoSize = false;
            this.tbrImageOverlayAlphaBlending.Location = new System.Drawing.Point(211, 82);
            this.tbrImageOverlayAlphaBlending.Maximum = 255;
            this.tbrImageOverlayAlphaBlending.Name = "tbrImageOverlayAlphaBlending";
            this.tbrImageOverlayAlphaBlending.Size = new System.Drawing.Size(96, 16);
            this.tbrImageOverlayAlphaBlending.TabIndex = 38;
            this.tbrImageOverlayAlphaBlending.TickFrequency = 26;
            this.tbrImageOverlayAlphaBlending.Scroll += new System.EventHandler(this.tbrImageOverlayAlphaBlending_Scroll);
            // 
            // btnImageOverlayPickupTransparentColorHelp
            // 
            this.btnImageOverlayPickupTransparentColorHelp.Location = new System.Drawing.Point(276, 102);
            this.btnImageOverlayPickupTransparentColorHelp.Name = "btnImageOverlayPickupTransparentColorHelp";
            this.btnImageOverlayPickupTransparentColorHelp.Size = new System.Drawing.Size(27, 21);
            this.btnImageOverlayPickupTransparentColorHelp.TabIndex = 37;
            this.btnImageOverlayPickupTransparentColorHelp.Text = "?";
            this.btnImageOverlayPickupTransparentColorHelp.Click += new System.EventHandler(this.btnImageOverlayPickupTransparentColorHelp_Click);
            // 
            // btnImageOverlayPickupTransparentColor
            // 
            this.btnImageOverlayPickupTransparentColor.Location = new System.Drawing.Point(116, 102);
            this.btnImageOverlayPickupTransparentColor.Name = "btnImageOverlayPickupTransparentColor";
            this.btnImageOverlayPickupTransparentColor.Size = new System.Drawing.Size(154, 21);
            this.btnImageOverlayPickupTransparentColor.TabIndex = 36;
            this.btnImageOverlayPickupTransparentColor.Text = "pick up transparent color";
            this.btnImageOverlayPickupTransparentColor.Click += new System.EventHandler(this.btnImageOverlayPickupTransparentColor_Click);
            // 
            // grpImageOverlaySelector
            // 
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector9);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector8);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector7);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector6);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector5);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector4);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector3);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector2);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector1);
            this.grpImageOverlaySelector.Controls.Add(this.ImageSelector0);
            this.grpImageOverlaySelector.Location = new System.Drawing.Point(195, 11);
            this.grpImageOverlaySelector.Name = "grpImageOverlaySelector";
            this.grpImageOverlaySelector.Size = new System.Drawing.Size(337, 34);
            this.grpImageOverlaySelector.TabIndex = 35;
            this.grpImageOverlaySelector.TabStop = false;
            this.grpImageOverlaySelector.Text = "image selector [0..9] 0 = default";
            // 
            // ImageSelector9
            // 
            this.ImageSelector9.Location = new System.Drawing.Point(302, 15);
            this.ImageSelector9.Name = "ImageSelector9";
            this.ImageSelector9.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector9.TabIndex = 9;
            this.ImageSelector9.Tag = "9";
            this.ImageSelector9.Text = "9";
            this.ImageSelector9.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector8
            // 
            this.ImageSelector8.Location = new System.Drawing.Point(270, 15);
            this.ImageSelector8.Name = "ImageSelector8";
            this.ImageSelector8.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector8.TabIndex = 8;
            this.ImageSelector8.Tag = "8";
            this.ImageSelector8.Text = "8";
            this.ImageSelector8.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector7
            // 
            this.ImageSelector7.Location = new System.Drawing.Point(238, 15);
            this.ImageSelector7.Name = "ImageSelector7";
            this.ImageSelector7.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector7.TabIndex = 7;
            this.ImageSelector7.Tag = "7";
            this.ImageSelector7.Text = "7";
            this.ImageSelector7.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector6
            // 
            this.ImageSelector6.Location = new System.Drawing.Point(206, 15);
            this.ImageSelector6.Name = "ImageSelector6";
            this.ImageSelector6.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector6.TabIndex = 6;
            this.ImageSelector6.Tag = "6";
            this.ImageSelector6.Text = "6";
            this.ImageSelector6.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector5
            // 
            this.ImageSelector5.Location = new System.Drawing.Point(174, 15);
            this.ImageSelector5.Name = "ImageSelector5";
            this.ImageSelector5.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector5.TabIndex = 5;
            this.ImageSelector5.Tag = "5";
            this.ImageSelector5.Text = "5";
            this.ImageSelector5.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector4
            // 
            this.ImageSelector4.Location = new System.Drawing.Point(144, 15);
            this.ImageSelector4.Name = "ImageSelector4";
            this.ImageSelector4.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector4.TabIndex = 4;
            this.ImageSelector4.Tag = "4";
            this.ImageSelector4.Text = "4";
            this.ImageSelector4.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector3
            // 
            this.ImageSelector3.Location = new System.Drawing.Point(112, 15);
            this.ImageSelector3.Name = "ImageSelector3";
            this.ImageSelector3.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector3.TabIndex = 3;
            this.ImageSelector3.Tag = "3";
            this.ImageSelector3.Text = "3";
            this.ImageSelector3.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector2
            // 
            this.ImageSelector2.Location = new System.Drawing.Point(80, 15);
            this.ImageSelector2.Name = "ImageSelector2";
            this.ImageSelector2.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector2.TabIndex = 2;
            this.ImageSelector2.Tag = "2";
            this.ImageSelector2.Text = "2";
            this.ImageSelector2.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector1
            // 
            this.ImageSelector1.Location = new System.Drawing.Point(48, 15);
            this.ImageSelector1.Name = "ImageSelector1";
            this.ImageSelector1.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector1.TabIndex = 1;
            this.ImageSelector1.Tag = "1";
            this.ImageSelector1.Text = "1";
            this.ImageSelector1.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // ImageSelector0
            // 
            this.ImageSelector0.Location = new System.Drawing.Point(16, 15);
            this.ImageSelector0.Name = "ImageSelector0";
            this.ImageSelector0.Size = new System.Drawing.Size(24, 16);
            this.ImageSelector0.TabIndex = 0;
            this.ImageSelector0.Tag = "0";
            this.ImageSelector0.Text = "0";
            this.ImageSelector0.CheckedChanged += new System.EventHandler(this.ImageSelector_CheckedChanged);
            // 
            // edtImageOverlayWidth
            // 
            this.edtImageOverlayWidth.AcceptsReturn = true;
            this.edtImageOverlayWidth.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayWidth.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtImageOverlayWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayWidth.Location = new System.Drawing.Point(19, 95);
            this.edtImageOverlayWidth.MaxLength = 0;
            this.edtImageOverlayWidth.Name = "edtImageOverlayWidth";
            this.edtImageOverlayWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayWidth.Size = new System.Drawing.Size(33, 20);
            this.edtImageOverlayWidth.TabIndex = 19;
            this.edtImageOverlayWidth.Text = "-1";
            this.edtImageOverlayWidth.TextChanged += new System.EventHandler(this.edtImageOverlayWidth_TextChanged);
            // 
            // edtImageOverlayHeight
            // 
            this.edtImageOverlayHeight.AcceptsReturn = true;
            this.edtImageOverlayHeight.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayHeight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtImageOverlayHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayHeight.Location = new System.Drawing.Point(61, 95);
            this.edtImageOverlayHeight.MaxLength = 0;
            this.edtImageOverlayHeight.Name = "edtImageOverlayHeight";
            this.edtImageOverlayHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayHeight.Size = new System.Drawing.Size(33, 20);
            this.edtImageOverlayHeight.TabIndex = 18;
            this.edtImageOverlayHeight.Text = "-1";
            this.edtImageOverlayHeight.TextChanged += new System.EventHandler(this.edtImageOverlayHeight_TextChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(18, 82);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(34, 14);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "width";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(58, 82);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(36, 14);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "height";
            // 
            // edtImageOverlayTransparentColorValue
            // 
            this.edtImageOverlayTransparentColorValue.Location = new System.Drawing.Point(247, 61);
            this.edtImageOverlayTransparentColorValue.Name = "edtImageOverlayTransparentColorValue";
            this.edtImageOverlayTransparentColorValue.Size = new System.Drawing.Size(56, 20);
            this.edtImageOverlayTransparentColorValue.TabIndex = 17;
            this.edtImageOverlayTransparentColorValue.Text = "0";
            this.edtImageOverlayTransparentColorValue.TextChanged += new System.EventHandler(this.edtImageOverlayTransparentColorValue_TextChanged);
            // 
            // btnImageOverlayFromFile
            // 
            this.btnImageOverlayFromFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImageOverlayFromFile.ImageIndex = 0;
            this.btnImageOverlayFromFile.ImageList = this.ImageList1;
            this.btnImageOverlayFromFile.Location = new System.Drawing.Point(96, 15);
            this.btnImageOverlayFromFile.Name = "btnImageOverlayFromFile";
            this.btnImageOverlayFromFile.Size = new System.Drawing.Size(91, 24);
            this.btnImageOverlayFromFile.TabIndex = 16;
            this.btnImageOverlayFromFile.Text = " load image...";
            this.btnImageOverlayFromFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImageOverlayFromFile.Click += new System.EventHandler(this.btnImageOverlayFromFile_Click);
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Fuchsia;
            this.ImageList1.Images.SetKeyName(0, "");
            // 
            // chkImageOverlayAlphaBlend
            // 
            this.chkImageOverlayAlphaBlend.Location = new System.Drawing.Point(116, 80);
            this.chkImageOverlayAlphaBlend.Name = "chkImageOverlayAlphaBlend";
            this.chkImageOverlayAlphaBlend.Size = new System.Drawing.Size(106, 18);
            this.chkImageOverlayAlphaBlend.TabIndex = 14;
            this.chkImageOverlayAlphaBlend.Text = "alpha blending:";
            this.chkImageOverlayAlphaBlend.CheckedChanged += new System.EventHandler(this.chkImageOverlayAlphaBlend_CheckedChanged);
            // 
            // chkImageOverlayUseTransparentColor
            // 
            this.chkImageOverlayUseTransparentColor.Location = new System.Drawing.Point(116, 63);
            this.chkImageOverlayUseTransparentColor.Name = "chkImageOverlayUseTransparentColor";
            this.chkImageOverlayUseTransparentColor.Size = new System.Drawing.Size(139, 18);
            this.chkImageOverlayUseTransparentColor.TabIndex = 12;
            this.chkImageOverlayUseTransparentColor.Text = "use transparent color:";
            this.chkImageOverlayUseTransparentColor.CheckedChanged += new System.EventHandler(this.chkImageOverlayUseTransparentColor_CheckedChanged);
            // 
            // chkImageOverlayEnabled
            // 
            this.chkImageOverlayEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayEnabled.Font = new System.Drawing.Font("Arial", 8F);
            this.chkImageOverlayEnabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkImageOverlayEnabled.Location = new System.Drawing.Point(16, 16);
            this.chkImageOverlayEnabled.Name = "chkImageOverlayEnabled";
            this.chkImageOverlayEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkImageOverlayEnabled.TabIndex = 6;
            this.chkImageOverlayEnabled.Text = "enabled";
            this.chkImageOverlayEnabled.UseVisualStyleBackColor = false;
            this.chkImageOverlayEnabled.CheckedChanged += new System.EventHandler(this.chkImageOverlayEnabled_CheckedChanged);
            // 
            // chkImageOverlayTransparent
            // 
            this.chkImageOverlayTransparent.BackColor = System.Drawing.SystemColors.Control;
            this.chkImageOverlayTransparent.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkImageOverlayTransparent.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImageOverlayTransparent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkImageOverlayTransparent.Location = new System.Drawing.Point(116, 46);
            this.chkImageOverlayTransparent.Name = "chkImageOverlayTransparent";
            this.chkImageOverlayTransparent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkImageOverlayTransparent.Size = new System.Drawing.Size(131, 18);
            this.chkImageOverlayTransparent.TabIndex = 5;
            this.chkImageOverlayTransparent.Text = "transparent";
            this.chkImageOverlayTransparent.UseVisualStyleBackColor = false;
            this.chkImageOverlayTransparent.CheckedChanged += new System.EventHandler(this.chkImageOverlayTransparent_CheckedChanged);
            // 
            // edtImageOverlayLeft
            // 
            this.edtImageOverlayLeft.AcceptsReturn = true;
            this.edtImageOverlayLeft.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayLeft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayLeft.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtImageOverlayLeft.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayLeft.Location = new System.Drawing.Point(19, 59);
            this.edtImageOverlayLeft.MaxLength = 0;
            this.edtImageOverlayLeft.Name = "edtImageOverlayLeft";
            this.edtImageOverlayLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayLeft.Size = new System.Drawing.Size(33, 20);
            this.edtImageOverlayLeft.TabIndex = 4;
            this.edtImageOverlayLeft.Text = "10";
            this.edtImageOverlayLeft.TextChanged += new System.EventHandler(this.edtImageOverlayLeft_TextChanged);
            // 
            // edtImageOverlayTop
            // 
            this.edtImageOverlayTop.AcceptsReturn = true;
            this.edtImageOverlayTop.BackColor = System.Drawing.SystemColors.Window;
            this.edtImageOverlayTop.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtImageOverlayTop.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtImageOverlayTop.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtImageOverlayTop.Location = new System.Drawing.Point(61, 59);
            this.edtImageOverlayTop.MaxLength = 0;
            this.edtImageOverlayTop.Name = "edtImageOverlayTop";
            this.edtImageOverlayTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtImageOverlayTop.Size = new System.Drawing.Size(33, 20);
            this.edtImageOverlayTop.TabIndex = 3;
            this.edtImageOverlayTop.Text = "10";
            this.edtImageOverlayTop.TextChanged += new System.EventHandler(this.edtImageOverlayTop_TextChanged);
            // 
            // Label48
            // 
            this.Label48.AutoSize = true;
            this.Label48.BackColor = System.Drawing.SystemColors.Control;
            this.Label48.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label48.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label48.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label48.Location = new System.Drawing.Point(18, 46);
            this.Label48.Name = "Label48";
            this.Label48.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label48.Size = new System.Drawing.Size(22, 14);
            this.Label48.TabIndex = 10;
            this.Label48.Text = "left";
            // 
            // Label49
            // 
            this.Label49.AutoSize = true;
            this.Label49.BackColor = System.Drawing.SystemColors.Control;
            this.Label49.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label49.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label49.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label49.Location = new System.Drawing.Point(58, 46);
            this.Label49.Name = "Label49";
            this.Label49.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label49.Size = new System.Drawing.Size(22, 14);
            this.Label49.TabIndex = 9;
            this.Label49.Text = "top";
            // 
            // btnPIP
            // 
            this.btnPIP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPIP.ImageIndex = 0;
            this.btnPIP.ImageList = this.ImageList1;
            this.btnPIP.Location = new System.Drawing.Point(707, 30);
            this.btnPIP.Name = "btnPIP";
            this.btnPIP.Size = new System.Drawing.Size(227, 22);
            this.btnPIP.TabIndex = 51;
            this.btnPIP.Text = "PIP from another TVideoGrabber control";
            this.btnPIP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPIP.Click += new System.EventHandler(this.btnPIP_Click);
            // 
            // chkTargetAtMouseLocation
            // 
            this.chkTargetAtMouseLocation.Location = new System.Drawing.Point(775, 8);
            this.chkTargetAtMouseLocation.Name = "chkTargetAtMouseLocation";
            this.chkTargetAtMouseLocation.Size = new System.Drawing.Size(152, 16);
            this.chkTargetAtMouseLocation.TabIndex = 52;
            this.chkTargetAtMouseLocation.Text = "target at mouse location";
            this.chkTargetAtMouseLocation.CheckedChanged += new System.EventHandler(this.chkTargetAtMouseLocation_CheckedChanged);
            // 
            // rdgTextOverlayAlignLeft
            // 
            this.rdgTextOverlayAlignLeft.AutoSize = true;
            this.rdgTextOverlayAlignLeft.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignLeft.Checked = true;
            this.rdgTextOverlayAlignLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignLeft.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTextOverlayAlignLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignLeft.Location = new System.Drawing.Point(6, 12);
            this.rdgTextOverlayAlignLeft.Name = "rdgTextOverlayAlignLeft";
            this.rdgTextOverlayAlignLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignLeft.Size = new System.Drawing.Size(40, 18);
            this.rdgTextOverlayAlignLeft.TabIndex = 42;
            this.rdgTextOverlayAlignLeft.TabStop = true;
            this.rdgTextOverlayAlignLeft.Tag = "0";
            this.rdgTextOverlayAlignLeft.Text = "left";
            this.rdgTextOverlayAlignLeft.UseVisualStyleBackColor = false;
            // 
            // rdgTextOverlayAlignRight
            // 
            this.rdgTextOverlayAlignRight.AutoSize = true;
            this.rdgTextOverlayAlignRight.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignRight.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTextOverlayAlignRight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignRight.Location = new System.Drawing.Point(114, 12);
            this.rdgTextOverlayAlignRight.Name = "rdgTextOverlayAlignRight";
            this.rdgTextOverlayAlignRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignRight.Size = new System.Drawing.Size(46, 18);
            this.rdgTextOverlayAlignRight.TabIndex = 40;
            this.rdgTextOverlayAlignRight.TabStop = true;
            this.rdgTextOverlayAlignRight.Tag = "2";
            this.rdgTextOverlayAlignRight.Text = "right";
            this.rdgTextOverlayAlignRight.UseVisualStyleBackColor = false;
            // 
            // rdgTextOverlayAlignCenter
            // 
            this.rdgTextOverlayAlignCenter.AutoSize = true;
            this.rdgTextOverlayAlignCenter.BackColor = System.Drawing.SystemColors.Control;
            this.rdgTextOverlayAlignCenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdgTextOverlayAlignCenter.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdgTextOverlayAlignCenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdgTextOverlayAlignCenter.Location = new System.Drawing.Point(52, 12);
            this.rdgTextOverlayAlignCenter.Name = "rdgTextOverlayAlignCenter";
            this.rdgTextOverlayAlignCenter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdgTextOverlayAlignCenter.Size = new System.Drawing.Size(56, 18);
            this.rdgTextOverlayAlignCenter.TabIndex = 41;
            this.rdgTextOverlayAlignCenter.TabStop = true;
            this.rdgTextOverlayAlignCenter.Tag = "1";
            this.rdgTextOverlayAlignCenter.Text = "center";
            this.rdgTextOverlayAlignCenter.UseVisualStyleBackColor = false;
            // 
            // rdgTextOverlayAlign
            // 
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignCenter);
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignLeft);
            this.rdgTextOverlayAlign.Controls.Add(this.rdgTextOverlayAlignRight);
            this.rdgTextOverlayAlign.Location = new System.Drawing.Point(8, 140);
            this.rdgTextOverlayAlign.Name = "rdgTextOverlayAlign";
            this.rdgTextOverlayAlign.Size = new System.Drawing.Size(179, 34);
            this.rdgTextOverlayAlign.TabIndex = 43;
            this.rdgTextOverlayAlign.TabStop = false;
            // 
            // Overlays
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(939, 221);
            this.ControlBox = false;
            this.Controls.Add(this.chkAdjustOverlayAspectRatio);
            this.Controls.Add(this.chkTargetAtMouseLocation);
            this.Controls.Add(this.btnPIP);
            this.Controls.Add(this.grbDrawGrid);
            this.Controls.Add(this.grbTextOverlay);
            this.Controls.Add(this.grbFreeHand);
            this.Controls.Add(this.grbBitmapOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Overlays";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.Overlays_Load);
            this.VisibleChanged += new System.EventHandler(this.Overlays_VisibleChanged);
            this.grbDrawGrid.ResumeLayout(false);
            this.grbDrawGrid.PerformLayout();
            this.grbTextOverlay.ResumeLayout(false);
            this.grbTextOverlay.PerformLayout();
            this.rgdTextOverlayShadowDirection.ResumeLayout(false);
            this.grbOverlaySelector.ResumeLayout(false);
            this.grbFreeHand.ResumeLayout(false);
            this.grbBitmapOverlay.ResumeLayout(false);
            this.grbBitmapOverlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrChromaKeyLeeway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrImageOverlayAlphaBlending)).EndInit();
            this.grpImageOverlaySelector.ResumeLayout(false);
            this.rdgTextOverlayAlign.ResumeLayout(false);
            this.rdgTextOverlayAlign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{
			btnDrawGridColor.BackColor = cMainForm.frmOverlays_btnDrawGridColor;
            btnFreeHandColor.BackColor = cMainForm.frmOverlays_btnFreeHandColor;
            chkAdjustOverlayAspectRatio.Checked = cMainForm.VideoGrabber1.AdjustOverlayAspectRatio;
		}

		private void Overlays_Load(object sender, System.EventArgs e)
		{
			TextSelector0.Checked = true;
			ImageSelector0.Checked = true;
		}

        private void chkFreeHandEnabled_CheckedChanged(object sender, System.EventArgs e)
        {
            // the sample code is located in the OnMouse... events and the overlay is performed in the OnFrameBitmap event of MainForm
        }

		private void btnFreeHandErase_Click(object sender, System.EventArgs e)
		{
			cMainForm.cFreeHandDrawing.iArrayCoordinates = 0;
            cMainForm.VideoGrabber1.RefreshPlayerOverlays();
        }

		private void chkTextOverlayEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.TextOverlay_Enabled = chkTextOverlayEnabled.Checked;
			if (chkTextOverlayEnabled.Checked) 
			{
				chkTextOverlayEnabled.ForeColor = System.Drawing.Color.Black;
			}
			else 
			{
				chkTextOverlayEnabled.ForeColor = System.Drawing.Color.Red;
			}
		}

        private void chkAdjustOverlayAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoGrabber1.AdjustOverlayAspectRatio = chkAdjustOverlayAspectRatio.Checked;
        }

        private void chkTextOverlayTransparent_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoGrabber1.TextOverlay_Transparent = chkTextOverlayTransparent.Checked;
        }

        private void chkTextOverlayShadow_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.TextOverlay_Shadow = chkTextOverlayShadow.Checked;
		}

        private void btnSelectShadowColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cMainForm.VideoGrabber1.TextOverlay_ShadowColor = ColorTranslator.ToWin32 (cd.Color);
            }
        }

        private void edtTextOverlayTop_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtTextOverlayTop.Text)) 
			{
				cMainForm.VideoGrabber1.TextOverlay_Top = Convert.ToInt32 (edtTextOverlayTop.Text);
			}
		}

		private void edtTextOverlayLeft_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtTextOverlayLeft.Text)) 
			{
				cMainForm.VideoGrabber1.TextOverlay_Left = Convert.ToInt32 (edtTextOverlayLeft.Text);
			}
		}

        private void edtTextOverlayRight_TextChanged(object sender, System.EventArgs e)
        {
            if (IsNumeric(edtTextOverlayRight.Text)) 
            {
                cMainForm.VideoGrabber1.TextOverlay_Right = Convert.ToInt32 (edtTextOverlayRight.Text);
            }
        }

    	private void mmoTextOverlayString_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.TextOverlay_String = mmoTextOverlayString.Text;
		}

		private void rdgTextOverlayAlign_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
				cMainForm.VideoGrabber1.TextOverlay_Align = (VidGrab.TTextOverlayAlign) Convert.ToInt32 ((sender as Control).Tag);
			}

		private void btnSelectFont_Click(object sender, System.EventArgs e)
		{
			FontDialog fd = new FontDialog();
			if (fd.ShowDialog()== DialogResult.OK) 
			{
				cMainForm.VideoGrabber1.TextOverlay_Font = fd.Font.ToHfont().ToInt32();
			}
        }
		
		private void btnSelectFontColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) 
			{
				cMainForm.VideoGrabber1.TextOverlay_FontColor = ColorTranslator.ToWin32 (cd.Color);
			}
		}

		private void btnBackColor_Click(object sender, System.EventArgs e)
		{
			ColorDialog cd = new ColorDialog();
			if (cd.ShowDialog() == DialogResult.OK) 
			{
				cMainForm.VideoGrabber1.TextOverlay_BkColor = ColorTranslator.ToWin32 (cd.Color);
			}
		}

        private void edtTextOverlayScrollingSpeed_TextChanged(object sender, EventArgs e)
        {
            if (IsNumeric(edtTextOverlayScrollingSpeed.Text))
            {
                cMainForm.VideoGrabber1.TextOverlay_ScrollingSpeed = Convert.ToInt32(edtTextOverlayScrollingSpeed.Text);
            }

        }

        private void chkTextOverlayScrolling_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoGrabber1.TextOverlay_Scrolling = chkTextOverlayScrolling.Checked;
        }

		private void OverlaySelector_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.VideoGrabber1.TextOverlay_Selector = Convert.ToInt32 ((sender as Control).Tag);

				// as we have selected another set, let's reload the corresponding values;
				chkTextOverlayEnabled.Checked = cMainForm.VideoGrabber1.TextOverlay_Enabled;

				mmoTextOverlayString.Text = cMainForm.VideoGrabber1.TextOverlay_String;
				edtTextOverlayLeft.Text = cMainForm.VideoGrabber1.TextOverlay_Left.ToString();
				edtTextOverlayTop.Text = cMainForm.VideoGrabber1.TextOverlay_Top.ToString();
				edtTextOverlayRight.Text = cMainForm.VideoGrabber1.TextOverlay_Right.ToString();
                edtTextOverlayScrollingSpeed.Text = cMainForm.VideoGrabber1.TextOverlay_ScrollingSpeed.ToString();

				SetRadioButtonInGroupUsingTag(rdgTextOverlayAlign, (short) cMainForm.VideoGrabber1.TextOverlay_Align);
				chkTextOverlayTransparent.Checked = cMainForm.VideoGrabber1.TextOverlay_Transparent;
                chkAdjustOverlayAspectRatio.Checked = cMainForm.VideoGrabber1.AdjustOverlayAspectRatio;
				chkTextOverlayShadow.Checked = cMainForm.VideoGrabber1.TextOverlay_Shadow;
                chkTextOverlayScrolling.Checked = cMainForm.VideoGrabber1.TextOverlay_Scrolling;
				SetRadioButtonInGroupUsingTag(rgdTextOverlayShadowDirection, (short) cMainForm.VideoGrabber1.TextOverlay_ShadowDirection);
			}	
        }

		private void rgdShadow_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				cMainForm.VideoGrabber1.TextOverlay_ShadowDirection = (VidGrab.TCardinalDirection) Convert.ToInt32 ((sender as Control).Tag);
			}
		}

        private void btnPIP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = OPEN_MEDIA_FILES;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                if (PIPVideoGrabber == null)
                {
                    PIPVideoGrabber = new VidGrab.VideoGrabber();
                    this.Controls.Add(this.PIPVideoGrabber);
                    PIPVideoGrabber.VideoRenderer = VidGrab.TVideoRenderer.vr_None;
                    PIPVideoGrabber.Visible = false;
                    cMainForm.VideoGrabber1.Mixer_SetupPIPFromSource(PIPVideoGrabber.UniqueID, 0, 0, 0, 0, true, 10, 10, 200, 150, false);
                }
                PIPVideoGrabber.PlayerFileName = dlgOpen.FileName;
                PIPVideoGrabber.OpenPlayer();
            }
        }

		private void Overlays_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

		private void btnImageOverlayFromFile_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();

			fd.Filter = OPEN_PICTURE_FILES;
			if (fd.ShowDialog() == DialogResult.OK) 
			{
				cMainForm.VideoGrabber1.SetImageOverlayFromImageFile(fd.FileName);
			}
		}

		private void chkImageOverlayEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
            cMainForm.VideoGrabber1.ImageOverlayEnabled = chkImageOverlayEnabled.Checked;
		}

		private void ImageSelector_CheckedChanged(object sender, System.EventArgs e)
		{
            cMainForm.VideoGrabber1.ImageOverlaySelector = Convert.ToInt32 ((sender as Control).Tag);

            chkImageOverlayEnabled.Checked = cMainForm.VideoGrabber1.ImageOverlayEnabled;
            edtImageOverlayLeft.Text = cMainForm.VideoGrabber1.ImageOverlay_LeftLocation.ToString();
            edtImageOverlayTop.Text = cMainForm.VideoGrabber1.ImageOverlay_TopLocation.ToString();
            edtImageOverlayWidth.Text = cMainForm.VideoGrabber1.ImageOverlay_Width.ToString();
            edtImageOverlayHeight.Text = cMainForm.VideoGrabber1.ImageOverlay_Height.ToString();

            chkImageOverlayTransparent.Checked = cMainForm.VideoGrabber1.ImageOverlay_Transparent;
            chkImageOverlayUseTransparentColor.Checked = cMainForm.VideoGrabber1.ImageOverlay_UseTransparentColor;
            edtImageOverlayTransparentColorValue.Text = "0x" + cMainForm.VideoGrabber1.ImageOverlay_TransparentColorValue.ToString("X000000");
            chkImageOverlayAlphaBlend.Checked = cMainForm.VideoGrabber1.ImageOverlay_AlphaBlend;
            tbrImageOverlayAlphaBlending.Value = cMainForm.VideoGrabber1.ImageOverlay_AlphaBlendValue;

            chkImageOverlayChromaKey.Checked = cMainForm.VideoGrabber1.ImageOverlay_ChromaKey;
            edtImageOverlayChromaKeyColorValue.Text = "0x" + cMainForm.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor.ToString("X000000");
            tbrChromaKeyLeeway.Value = cMainForm.VideoGrabber1.ImageOverlay_ChromaKeyLeewayPercent;
		}

		private void edtImageOverlayLeft_TextChanged(object sender, System.EventArgs e)
		{
        if (IsNumeric(edtImageOverlayLeft.Text)) {
            cMainForm.VideoGrabber1.ImageOverlay_LeftLocation = Convert.ToInt32 (edtImageOverlayLeft.Text);
        }
		
		}

		private void edtImageOverlayTop_TextChanged(object sender, System.EventArgs e)
		{
        if (IsNumeric(edtImageOverlayTop.Text)) {
            cMainForm.VideoGrabber1.ImageOverlay_TopLocation = Convert.ToInt32 (edtImageOverlayTop.Text);
        }
		}

		private void edtImageOverlayWidth_TextChanged(object sender, System.EventArgs e)
		{
        if (IsNumeric(edtImageOverlayWidth.Text)) {
            cMainForm.VideoGrabber1.ImageOverlay_Width = Convert.ToInt32(edtImageOverlayWidth.Text);
        }
		}

		private void edtImageOverlayHeight_TextChanged(object sender, System.EventArgs e)
		{
            if (IsNumeric(edtImageOverlayHeight.Text)) {
                cMainForm.VideoGrabber1.ImageOverlay_Height = Convert.ToInt32(edtImageOverlayHeight.Text);
            }
		}

        private void chkImageOverlayTransparent_CheckedChanged(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_Transparent = chkImageOverlayTransparent.Checked;
        }

        private void chkImageOverlayUseTransparentColor_CheckedChanged(object sender, EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_UseTransparentColor = chkImageOverlayUseTransparentColor.Checked;
        }
        
        private void edtImageOverlayTransparentColorValue_TextChanged(object sender, System.EventArgs e)
        {
            if (IsNumeric(edtImageOverlayTransparentColorValue.Text)) 
            {
                cMainForm.VideoGrabber1.ImageOverlay_TransparentColorValue = Convert.ToInt32(edtImageOverlayTransparentColorValue.Text);
            }
        }

        private void btnImageOverlayPickupTransparentColor_Click(object sender, System.EventArgs e)
        {
            if (cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition != -1) 
            {
                cMainForm.VideoGrabber1.ImageOverlay_TransparentColorValue = cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition;
                edtImageOverlayTransparentColorValue.Text = "0x" + cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000");
            }
        }

        private void btnImageOverlayPickupTransparentColorHelp_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("while the preview is running:\n- load the image overlay\n- enable 'transparent' and 'use transp. color value'\n- in the video window, click on the video frame on the color of the overlayed image you want to be transparent\n- click on 'pickup the transparent color'",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
        }

        private void chkImageOverlayAlphaBlend_CheckedChanged(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_AlphaBlend = chkImageOverlayAlphaBlend.Checked;
        }

        private void tbrImageOverlayAlphaBlending_Scroll(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_AlphaBlendValue = Convert.ToInt32(tbrImageOverlayAlphaBlending.Value);
        }

        private void chkImageOverlayChromaKey_CheckedChanged(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_ChromaKey = chkImageOverlayChromaKey.Checked;
        }

        private void edtImageOverlayChromaKeyColorValue_TextChanged(object sender, System.EventArgs e)
        {
            if (IsNumeric(edtImageOverlayChromaKeyColorValue.Text)) 
            {
                cMainForm.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor = Convert.ToInt32(edtImageOverlayChromaKeyColorValue.Text);
            }
        }

        private void btnImageOverlayPickupChromaKeyColor_Click(object sender, System.EventArgs e)
        {
            if (cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition != -1) 
            {
                cMainForm.VideoGrabber1.ImageOverlay_ChromaKeyRGBColor = cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition;
                edtImageOverlayChromaKeyColorValue.Text = "0x" + cMainForm.cPickupColor.LastRGBPixelValueAtMousePosition.ToString("X000000");
            }
        }

        private void btnImageOverlayPickupChromaKeyColorHelp_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("while the clip is playing:\n- in the video window, click on the video frame on the background color you want to be used as chroma key\n- click on the 'pickup the chroma key' button to select it as chroma key\n - load the image overlay and check the 'enabled' button\n- enable 'chroma key' then adjust the leeway percent (default = 25%)",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
        }

        private void tbrChromaKeyLeeway_Scroll(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.ImageOverlay_ChromaKeyLeewayPercent = tbrChromaKeyLeeway.Value;
        }

        private void edtDrawGrid_TextChanged(object sender, EventArgs e)
        {
            if (edtDrawGrid.Text.Length > 0)
            {
                if (Convert.ToInt32(edtDrawGrid.Text) > 100)
                {
                    cMainForm.frmOverlays_edtDrawGrid = 100;
                }
                else if (Convert.ToInt32(edtDrawGrid.Text) > 1)
                {
                    cMainForm.frmOverlays_edtDrawGrid = Convert.ToInt32(edtDrawGrid.Text);
                }
                else
                {
                    cMainForm.frmOverlays_edtDrawGrid = 0;
                }
            }
            else
            {
                cMainForm.frmOverlays_edtDrawGrid = 0;
            }
		// frmOverlays_edtDrawGrid is tested in the OnFrameOverlayUsingDC event of MainForm        
        }

        private void btnDrawGridColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cMainForm.frmOverlays_btnDrawGridColor = cd.Color;
                btnDrawGridColor.BackColor = cd.Color;
            }
        }

        private void btnFreeHandColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                cMainForm.frmOverlays_btnFreeHandColor = cd.Color;
                btnFreeHandColor.BackColor = cd.Color;
            }
        }

		private void chkTargetAtMouseLocation_CheckedChanged(object sender, System.EventArgs e)
		{
			if (! chkTargetAtMouseLocation.Checked) 
			{
				cMainForm.frmOverlays_drawTarget = false;
			}
		}
	}
}
