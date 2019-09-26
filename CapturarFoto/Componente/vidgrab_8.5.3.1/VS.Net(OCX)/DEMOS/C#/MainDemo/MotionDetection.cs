using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for MotionDetection.
	/// </summary>
	public class MotionDetection : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal System.Windows.Forms.ToolTip ToolTip1;
        internal Label Label1;
        internal Button btn_TriggerNow;
        public CheckBox chk_GreyScale;
        public CheckBox chkCompareBlue;
        public CheckBox chkCompareGreen;
        public CheckBox chkCompareRed;
        public Button btnShowGridDialog;
        public CheckBox chkReduceVideoNoise;
        internal CheckBox chk_triggered;
        public PictureBox imgMotionDetected;
        public CheckBox chkMotionDetectionEnabled;
        public GroupBox grbGridString;
        internal NumericUpDown updGlobalGridSensitivity;
        public TextBox edtGrid;
        public Label Label39;
        public Label lblGridValid;
        public GroupBox Frame13;
        internal NumericUpDown updGridRowCount;
        internal NumericUpDown updGridColCount;
        public Button btnApplyGridSize;
        public Label Label41;
        public GroupBox Frame14;
        internal NumericUpDown updCellSensitivity;
        internal NumericUpDown updYCell;
        internal NumericUpDown updXCell;
        public Button btnSetCellsSensitivity;
        public Label Label42;
        public GroupBox grbXYMaxMotion;
        public TextBox edtMaxMotionXY;
        public TextBox edtMaxMotionCoord;
        public GroupBox grbMotionRatio;
        public TextBox edtMotionRatio;
        public TextBox mmoSensitivityGrid;
        public TextBox mmoMotionGrid;
        public Label Label36;
        public Label lblMotionDetectorRequiresFrameGrabber;
		private System.ComponentModel.IContainer components;

		public MotionDetection()
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
            this.Label1 = new System.Windows.Forms.Label();
            this.btn_TriggerNow = new System.Windows.Forms.Button();
            this.chk_GreyScale = new System.Windows.Forms.CheckBox();
            this.chkCompareBlue = new System.Windows.Forms.CheckBox();
            this.chkCompareGreen = new System.Windows.Forms.CheckBox();
            this.chkCompareRed = new System.Windows.Forms.CheckBox();
            this.btnShowGridDialog = new System.Windows.Forms.Button();
            this.chkReduceVideoNoise = new System.Windows.Forms.CheckBox();
            this.chk_triggered = new System.Windows.Forms.CheckBox();
            this.imgMotionDetected = new System.Windows.Forms.PictureBox();
            this.chkMotionDetectionEnabled = new System.Windows.Forms.CheckBox();
            this.grbGridString = new System.Windows.Forms.GroupBox();
            this.updGlobalGridSensitivity = new System.Windows.Forms.NumericUpDown();
            this.edtGrid = new System.Windows.Forms.TextBox();
            this.Label39 = new System.Windows.Forms.Label();
            this.lblGridValid = new System.Windows.Forms.Label();
            this.Frame13 = new System.Windows.Forms.GroupBox();
            this.updGridRowCount = new System.Windows.Forms.NumericUpDown();
            this.updGridColCount = new System.Windows.Forms.NumericUpDown();
            this.btnApplyGridSize = new System.Windows.Forms.Button();
            this.Label41 = new System.Windows.Forms.Label();
            this.Frame14 = new System.Windows.Forms.GroupBox();
            this.updCellSensitivity = new System.Windows.Forms.NumericUpDown();
            this.updYCell = new System.Windows.Forms.NumericUpDown();
            this.updXCell = new System.Windows.Forms.NumericUpDown();
            this.btnSetCellsSensitivity = new System.Windows.Forms.Button();
            this.Label42 = new System.Windows.Forms.Label();
            this.grbXYMaxMotion = new System.Windows.Forms.GroupBox();
            this.edtMaxMotionXY = new System.Windows.Forms.TextBox();
            this.edtMaxMotionCoord = new System.Windows.Forms.TextBox();
            this.grbMotionRatio = new System.Windows.Forms.GroupBox();
            this.edtMotionRatio = new System.Windows.Forms.TextBox();
            this.mmoSensitivityGrid = new System.Windows.Forms.TextBox();
            this.mmoMotionGrid = new System.Windows.Forms.TextBox();
            this.Label36 = new System.Windows.Forms.Label();
            this.lblMotionDetectorRequiresFrameGrabber = new System.Windows.Forms.Label();
#if (!VS2003) 
			((System.ComponentModel.ISupportInitialize)(this.imgMotionDetected)).BeginInit();
#endif
			this.grbGridString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updGlobalGridSensitivity)).BeginInit();
            this.Frame13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updGridRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGridColCount)).BeginInit();
            this.Frame14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCellSensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updYCell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updXCell)).BeginInit();
            this.grbXYMaxMotion.SuspendLayout();
            this.grbMotionRatio.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(4, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 13);
            this.Label1.TabIndex = 61;
            this.Label1.Text = "detection method:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_TriggerNow
            // 
            this.btn_TriggerNow.Location = new System.Drawing.Point(328, 39);
            this.btn_TriggerNow.Name = "btn_TriggerNow";
            this.btn_TriggerNow.Size = new System.Drawing.Size(75, 20);
            this.btn_TriggerNow.TabIndex = 60;
            this.btn_TriggerNow.Text = "trigger now";
            this.btn_TriggerNow.Click += new System.EventHandler(this.btn_TriggerNow_Click);
            // 
            // chk_GreyScale
            // 
            this.chk_GreyScale.BackColor = System.Drawing.SystemColors.Control;
            this.chk_GreyScale.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_GreyScale.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_GreyScale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_GreyScale.Location = new System.Drawing.Point(249, 40);
            this.chk_GreyScale.Name = "chk_GreyScale";
            this.chk_GreyScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_GreyScale.Size = new System.Drawing.Size(80, 17);
            this.chk_GreyScale.TabIndex = 51;
            this.chk_GreyScale.Text = "greyscale";
            this.chk_GreyScale.CheckedChanged += new System.EventHandler(this.chk_GreyScale_CheckedChanged);
            // 
            // chkCompareBlue
            // 
            this.chkCompareBlue.BackColor = System.Drawing.SystemColors.Control;
            this.chkCompareBlue.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCompareBlue.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompareBlue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCompareBlue.Location = new System.Drawing.Point(199, 40);
            this.chkCompareBlue.Name = "chkCompareBlue";
            this.chkCompareBlue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCompareBlue.Size = new System.Drawing.Size(46, 17);
            this.chkCompareBlue.TabIndex = 50;
            this.chkCompareBlue.Text = "blue";
            this.chkCompareBlue.CheckedChanged += new System.EventHandler(this.chkCompareBlue_CheckedChanged);
            // 
            // chkCompareGreen
            // 
            this.chkCompareGreen.BackColor = System.Drawing.SystemColors.Control;
            this.chkCompareGreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCompareGreen.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompareGreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCompareGreen.Location = new System.Drawing.Point(142, 38);
            this.chkCompareGreen.Name = "chkCompareGreen";
            this.chkCompareGreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCompareGreen.Size = new System.Drawing.Size(63, 20);
            this.chkCompareGreen.TabIndex = 49;
            this.chkCompareGreen.Text = "green";
            this.chkCompareGreen.CheckedChanged += new System.EventHandler(this.chkCompareGreen_CheckedChanged);
            // 
            // chkCompareRed
            // 
            this.chkCompareRed.BackColor = System.Drawing.SystemColors.Control;
            this.chkCompareRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkCompareRed.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCompareRed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCompareRed.Location = new System.Drawing.Point(97, 40);
            this.chkCompareRed.Name = "chkCompareRed";
            this.chkCompareRed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkCompareRed.Size = new System.Drawing.Size(49, 17);
            this.chkCompareRed.TabIndex = 52;
            this.chkCompareRed.Text = "red";
            this.chkCompareRed.CheckedChanged += new System.EventHandler(this.chkCompareRed_CheckedChanged);
            // 
            // btnShowGridDialog
            // 
            this.btnShowGridDialog.BackColor = System.Drawing.SystemColors.Control;
            this.btnShowGridDialog.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowGridDialog.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGridDialog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShowGridDialog.Location = new System.Drawing.Point(301, 0);
            this.btnShowGridDialog.Name = "btnShowGridDialog";
            this.btnShowGridDialog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowGridDialog.Size = new System.Drawing.Size(102, 20);
            this.btnShowGridDialog.TabIndex = 53;
            this.btnShowGridDialog.Text = "show grid dialog";
            this.btnShowGridDialog.Click += new System.EventHandler(this.btnShowGridDialog_Click);
            // 
            // chkReduceVideoNoise
            // 
            this.chkReduceVideoNoise.BackColor = System.Drawing.SystemColors.Control;
            this.chkReduceVideoNoise.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkReduceVideoNoise.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReduceVideoNoise.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkReduceVideoNoise.Location = new System.Drawing.Point(188, 22);
            this.chkReduceVideoNoise.Name = "chkReduceVideoNoise";
            this.chkReduceVideoNoise.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkReduceVideoNoise.Size = new System.Drawing.Size(128, 17);
            this.chkReduceVideoNoise.TabIndex = 54;
            this.chkReduceVideoNoise.Text = "reduce video noise";
            // 
            // chk_triggered
            // 
            this.chk_triggered.Location = new System.Drawing.Point(332, 22);
            this.chk_triggered.Name = "chk_triggered";
            this.chk_triggered.Size = new System.Drawing.Size(72, 17);
            this.chk_triggered.TabIndex = 59;
            this.chk_triggered.Text = "triggered";
            this.chk_triggered.CheckedChanged += new System.EventHandler(this.chk_triggered_CheckedChanged);
            // 
            // imgMotionDetected
            // 
            this.imgMotionDetected.BackColor = System.Drawing.SystemColors.Control;
            this.imgMotionDetected.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgMotionDetected.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgMotionDetected.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgMotionDetected.ForeColor = System.Drawing.SystemColors.ControlText;
            this.imgMotionDetected.Location = new System.Drawing.Point(408, 0);
            this.imgMotionDetected.Name = "imgMotionDetected";
            this.imgMotionDetected.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.imgMotionDetected.Size = new System.Drawing.Size(113, 81);
            this.imgMotionDetected.TabIndex = 58;
            this.imgMotionDetected.TabStop = false;
            // 
            // chkMotionDetectionEnabled
            // 
            this.chkMotionDetectionEnabled.BackColor = System.Drawing.SystemColors.Control;
            this.chkMotionDetectionEnabled.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkMotionDetectionEnabled.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMotionDetectionEnabled.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMotionDetectionEnabled.Location = new System.Drawing.Point(4, 22);
            this.chkMotionDetectionEnabled.Name = "chkMotionDetectionEnabled";
            this.chkMotionDetectionEnabled.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkMotionDetectionEnabled.Size = new System.Drawing.Size(192, 17);
            this.chkMotionDetectionEnabled.TabIndex = 55;
            this.chkMotionDetectionEnabled.Text = "ENABLE MOTION DETECTION";
            this.chkMotionDetectionEnabled.CheckedChanged += new System.EventHandler(this.chkMotionDetectionEnabled_CheckedChanged);
            // 
            // grbGridString
            // 
            this.grbGridString.BackColor = System.Drawing.SystemColors.Control;
            this.grbGridString.Controls.Add(this.updGlobalGridSensitivity);
            this.grbGridString.Controls.Add(this.edtGrid);
            this.grbGridString.Controls.Add(this.Label39);
            this.grbGridString.Controls.Add(this.lblGridValid);
            this.grbGridString.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGridString.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbGridString.Location = new System.Drawing.Point(4, 58);
            this.grbGridString.Name = "grbGridString";
            this.grbGridString.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbGridString.Size = new System.Drawing.Size(400, 57);
            this.grbGridString.TabIndex = 48;
            this.grbGridString.TabStop = false;
            this.grbGridString.Text = "grid string";
            // 
            // updGlobalGridSensitivity
            // 
            this.updGlobalGridSensitivity.Location = new System.Drawing.Point(57, 28);
            this.updGlobalGridSensitivity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.updGlobalGridSensitivity.Name = "updGlobalGridSensitivity";
            this.updGlobalGridSensitivity.Size = new System.Drawing.Size(16, 20);
            this.updGlobalGridSensitivity.TabIndex = 28;
            this.updGlobalGridSensitivity.Tag = "0";
            this.updGlobalGridSensitivity.ValueChanged += new System.EventHandler(this.updGlobalGridSensitivity_ValueChanged);
            // 
            // edtGrid
            // 
            this.edtGrid.AcceptsReturn = true;
            this.edtGrid.BackColor = System.Drawing.SystemColors.Window;
            this.edtGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtGrid.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtGrid.Location = new System.Drawing.Point(72, 28);
            this.edtGrid.MaxLength = 0;
            this.edtGrid.Name = "edtGrid";
            this.edtGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtGrid.Size = new System.Drawing.Size(320, 20);
            this.edtGrid.TabIndex = 24;
            this.edtGrid.TextChanged += new System.EventHandler(this.edtGrid_TextChanged);
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.BackColor = System.Drawing.SystemColors.Control;
            this.Label39.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label39.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label39.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label39.Location = new System.Drawing.Point(55, 14);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label39.Size = new System.Drawing.Size(71, 14);
            this.Label39.TabIndex = 27;
            this.Label39.Text = "sensitivity +/-";
            // 
            // lblGridValid
            // 
            this.lblGridValid.BackColor = System.Drawing.SystemColors.Control;
            this.lblGridValid.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblGridValid.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGridValid.ForeColor = System.Drawing.Color.Gray;
            this.lblGridValid.Location = new System.Drawing.Point(6, 26);
            this.lblGridValid.Name = "lblGridValid";
            this.lblGridValid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGridValid.Size = new System.Drawing.Size(45, 14);
            this.lblGridValid.TabIndex = 25;
            this.lblGridValid.Text = "valid";
            this.lblGridValid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frame13
            // 
            this.Frame13.BackColor = System.Drawing.SystemColors.Control;
            this.Frame13.Controls.Add(this.updGridRowCount);
            this.Frame13.Controls.Add(this.updGridColCount);
            this.Frame13.Controls.Add(this.btnApplyGridSize);
            this.Frame13.Controls.Add(this.Label41);
            this.Frame13.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame13.Location = new System.Drawing.Point(4, 115);
            this.Frame13.Name = "Frame13";
            this.Frame13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame13.Size = new System.Drawing.Size(137, 62);
            this.Frame13.TabIndex = 47;
            this.Frame13.TabStop = false;
            this.Frame13.Text = "grid size";
            // 
            // updGridRowCount
            // 
            this.updGridRowCount.Location = new System.Drawing.Point(53, 32);
            this.updGridRowCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updGridRowCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updGridRowCount.Name = "updGridRowCount";
            this.updGridRowCount.Size = new System.Drawing.Size(40, 20);
            this.updGridRowCount.TabIndex = 22;
            this.updGridRowCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updGridColCount
            // 
            this.updGridColCount.Location = new System.Drawing.Point(8, 32);
            this.updGridColCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updGridColCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updGridColCount.Name = "updGridColCount";
            this.updGridColCount.Size = new System.Drawing.Size(40, 20);
            this.updGridColCount.TabIndex = 21;
            this.updGridColCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnApplyGridSize
            // 
            this.btnApplyGridSize.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplyGridSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnApplyGridSize.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyGridSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplyGridSize.Location = new System.Drawing.Point(98, 32);
            this.btnApplyGridSize.Name = "btnApplyGridSize";
            this.btnApplyGridSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnApplyGridSize.Size = new System.Drawing.Size(32, 22);
            this.btnApplyGridSize.TabIndex = 17;
            this.btnApplyGridSize.Text = "OK";
            this.btnApplyGridSize.Click += new System.EventHandler(this.btnApplyGridSize_Click);
            // 
            // Label41
            // 
            this.Label41.BackColor = System.Drawing.SystemColors.Control;
            this.Label41.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label41.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label41.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label41.Location = new System.Drawing.Point(8, 16);
            this.Label41.Name = "Label41";
            this.Label41.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label41.Size = new System.Drawing.Size(105, 17);
            this.Label41.TabIndex = 20;
            this.Label41.Text = "col count/row count";
            // 
            // Frame14
            // 
            this.Frame14.BackColor = System.Drawing.SystemColors.Control;
            this.Frame14.Controls.Add(this.updCellSensitivity);
            this.Frame14.Controls.Add(this.updYCell);
            this.Frame14.Controls.Add(this.updXCell);
            this.Frame14.Controls.Add(this.btnSetCellsSensitivity);
            this.Frame14.Controls.Add(this.Label42);
            this.Frame14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame14.Location = new System.Drawing.Point(147, 115);
            this.Frame14.Name = "Frame14";
            this.Frame14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame14.Size = new System.Drawing.Size(199, 62);
            this.Frame14.TabIndex = 46;
            this.Frame14.TabStop = false;
            this.Frame14.Text = "cells sensitivity  (0 based index)";
            // 
            // updCellSensitivity
            // 
            this.updCellSensitivity.Location = new System.Drawing.Point(102, 32);
            this.updCellSensitivity.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.updCellSensitivity.Name = "updCellSensitivity";
            this.updCellSensitivity.Size = new System.Drawing.Size(40, 20);
            this.updCellSensitivity.TabIndex = 25;
            this.updCellSensitivity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updYCell
            // 
            this.updYCell.Location = new System.Drawing.Point(56, 32);
            this.updYCell.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updYCell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updYCell.Name = "updYCell";
            this.updYCell.Size = new System.Drawing.Size(40, 20);
            this.updYCell.TabIndex = 24;
            this.updYCell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updXCell
            // 
            this.updXCell.Location = new System.Drawing.Point(8, 32);
            this.updXCell.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updXCell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updXCell.Name = "updXCell";
            this.updXCell.Size = new System.Drawing.Size(40, 20);
            this.updXCell.TabIndex = 23;
            this.updXCell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSetCellsSensitivity
            // 
            this.btnSetCellsSensitivity.BackColor = System.Drawing.SystemColors.Control;
            this.btnSetCellsSensitivity.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSetCellsSensitivity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetCellsSensitivity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSetCellsSensitivity.Location = new System.Drawing.Point(148, 32);
            this.btnSetCellsSensitivity.Name = "btnSetCellsSensitivity";
            this.btnSetCellsSensitivity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSetCellsSensitivity.Size = new System.Drawing.Size(43, 22);
            this.btnSetCellsSensitivity.TabIndex = 9;
            this.btnSetCellsSensitivity.Text = "SET";
            this.btnSetCellsSensitivity.Click += new System.EventHandler(this.btnSetCellsSensitivity_Click);
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.BackColor = System.Drawing.SystemColors.Control;
            this.Label42.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label42.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label42.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label42.Location = new System.Drawing.Point(6, 16);
            this.Label42.Name = "Label42";
            this.Label42.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label42.Size = new System.Drawing.Size(179, 14);
            this.Label42.TabIndex = 13;
            this.Label42.Text = "X cell       Y cell     sensitivity (0 .. 9)";
            // 
            // grbXYMaxMotion
            // 
            this.grbXYMaxMotion.BackColor = System.Drawing.SystemColors.Control;
            this.grbXYMaxMotion.Controls.Add(this.edtMaxMotionXY);
            this.grbXYMaxMotion.Controls.Add(this.edtMaxMotionCoord);
            this.grbXYMaxMotion.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbXYMaxMotion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbXYMaxMotion.Location = new System.Drawing.Point(352, 133);
            this.grbXYMaxMotion.Name = "grbXYMaxMotion";
            this.grbXYMaxMotion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbXYMaxMotion.Size = new System.Drawing.Size(169, 44);
            this.grbXYMaxMotion.TabIndex = 45;
            this.grbXYMaxMotion.TabStop = false;
            this.grbXYMaxMotion.Text = "max motion location";
            // 
            // edtMaxMotionXY
            // 
            this.edtMaxMotionXY.AcceptsReturn = true;
            this.edtMaxMotionXY.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtMaxMotionXY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtMaxMotionXY.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMaxMotionXY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtMaxMotionXY.Location = new System.Drawing.Point(9, 17);
            this.edtMaxMotionXY.MaxLength = 0;
            this.edtMaxMotionXY.Name = "edtMaxMotionXY";
            this.edtMaxMotionXY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtMaxMotionXY.Size = new System.Drawing.Size(65, 20);
            this.edtMaxMotionXY.TabIndex = 6;
            // 
            // edtMaxMotionCoord
            // 
            this.edtMaxMotionCoord.AcceptsReturn = true;
            this.edtMaxMotionCoord.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtMaxMotionCoord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtMaxMotionCoord.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMaxMotionCoord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtMaxMotionCoord.Location = new System.Drawing.Point(80, 17);
            this.edtMaxMotionCoord.MaxLength = 0;
            this.edtMaxMotionCoord.Name = "edtMaxMotionCoord";
            this.edtMaxMotionCoord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtMaxMotionCoord.Size = new System.Drawing.Size(81, 20);
            this.edtMaxMotionCoord.TabIndex = 5;
            // 
            // grbMotionRatio
            // 
            this.grbMotionRatio.BackColor = System.Drawing.SystemColors.Control;
            this.grbMotionRatio.Controls.Add(this.edtMotionRatio);
            this.grbMotionRatio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMotionRatio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grbMotionRatio.Location = new System.Drawing.Point(408, 86);
            this.grbMotionRatio.Name = "grbMotionRatio";
            this.grbMotionRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbMotionRatio.Size = new System.Drawing.Size(113, 45);
            this.grbMotionRatio.TabIndex = 44;
            this.grbMotionRatio.TabStop = false;
            this.grbMotionRatio.Text = "global motion ratio";
            this.grbMotionRatio.Paint += new System.Windows.Forms.PaintEventHandler(this.grbMotionRatio_Paint);
            // 
            // edtMotionRatio
            // 
            this.edtMotionRatio.AcceptsReturn = true;
            this.edtMotionRatio.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.edtMotionRatio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.edtMotionRatio.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMotionRatio.ForeColor = System.Drawing.SystemColors.WindowText;
            this.edtMotionRatio.Location = new System.Drawing.Point(33, 18);
            this.edtMotionRatio.MaxLength = 0;
            this.edtMotionRatio.Name = "edtMotionRatio";
            this.edtMotionRatio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edtMotionRatio.Size = new System.Drawing.Size(72, 20);
            this.edtMotionRatio.TabIndex = 3;
            // 
            // mmoSensitivityGrid
            // 
            this.mmoSensitivityGrid.AcceptsReturn = true;
            this.mmoSensitivityGrid.BackColor = System.Drawing.SystemColors.Window;
            this.mmoSensitivityGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoSensitivityGrid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoSensitivityGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoSensitivityGrid.Location = new System.Drawing.Point(527, 0);
            this.mmoSensitivityGrid.MaxLength = 0;
            this.mmoSensitivityGrid.Multiline = true;
            this.mmoSensitivityGrid.Name = "mmoSensitivityGrid";
            this.mmoSensitivityGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoSensitivityGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mmoSensitivityGrid.Size = new System.Drawing.Size(190, 177);
            this.mmoSensitivityGrid.TabIndex = 43;
            this.mmoSensitivityGrid.WordWrap = false;
            // 
            // mmoMotionGrid
            // 
            this.mmoMotionGrid.AcceptsReturn = true;
            this.mmoMotionGrid.BackColor = System.Drawing.SystemColors.Window;
            this.mmoMotionGrid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmoMotionGrid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoMotionGrid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mmoMotionGrid.Location = new System.Drawing.Point(723, 0);
            this.mmoMotionGrid.MaxLength = 0;
            this.mmoMotionGrid.Multiline = true;
            this.mmoMotionGrid.Name = "mmoMotionGrid";
            this.mmoMotionGrid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mmoMotionGrid.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mmoMotionGrid.Size = new System.Drawing.Size(190, 177);
            this.mmoMotionGrid.TabIndex = 42;
            this.mmoMotionGrid.WordWrap = false;
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.BackColor = System.Drawing.SystemColors.Control;
            this.Label36.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label36.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label36.Location = new System.Drawing.Point(4, 0);
            this.Label36.Name = "Label36";
            this.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label36.Size = new System.Drawing.Size(100, 14);
            this.Label36.TabIndex = 57;
            this.Label36.Text = "Motion detection";
            // 
            // lblMotionDetectorRequiresFrameGrabber
            // 
            this.lblMotionDetectorRequiresFrameGrabber.AutoSize = true;
            this.lblMotionDetectorRequiresFrameGrabber.BackColor = System.Drawing.SystemColors.Control;
            this.lblMotionDetectorRequiresFrameGrabber.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMotionDetectorRequiresFrameGrabber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotionDetectorRequiresFrameGrabber.ForeColor = System.Drawing.Color.Red;
            this.lblMotionDetectorRequiresFrameGrabber.Location = new System.Drawing.Point(122, 0);
            this.lblMotionDetectorRequiresFrameGrabber.Name = "lblMotionDetectorRequiresFrameGrabber";
            this.lblMotionDetectorRequiresFrameGrabber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMotionDetectorRequiresFrameGrabber.Size = new System.Drawing.Size(158, 14);
            this.lblMotionDetectorRequiresFrameGrabber.TabIndex = 56;
            this.lblMotionDetectorRequiresFrameGrabber.Text = "frame grabber must be enabled";
            // 
            // MotionDetection
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(959, 225);
            this.ControlBox = false;
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_TriggerNow);
            this.Controls.Add(this.chk_GreyScale);
            this.Controls.Add(this.chkCompareBlue);
            this.Controls.Add(this.chkCompareGreen);
            this.Controls.Add(this.chkCompareRed);
            this.Controls.Add(this.btnShowGridDialog);
            this.Controls.Add(this.chkReduceVideoNoise);
            this.Controls.Add(this.chk_triggered);
            this.Controls.Add(this.imgMotionDetected);
            this.Controls.Add(this.chkMotionDetectionEnabled);
            this.Controls.Add(this.grbGridString);
            this.Controls.Add(this.Frame13);
            this.Controls.Add(this.Frame14);
            this.Controls.Add(this.grbXYMaxMotion);
            this.Controls.Add(this.grbMotionRatio);
            this.Controls.Add(this.mmoSensitivityGrid);
            this.Controls.Add(this.mmoMotionGrid);
            this.Controls.Add(this.Label36);
            this.Controls.Add(this.lblMotionDetectorRequiresFrameGrabber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MotionDetection";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.MotionDetection_VisibleChanged);
#if (!VS2003) 
			((System.ComponentModel.ISupportInitialize)(this.imgMotionDetected)).EndInit();
#endif
			this.grbGridString.ResumeLayout(false);
            this.grbGridString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updGlobalGridSensitivity)).EndInit();
            this.Frame13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.updGridRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updGridColCount)).EndInit();
            this.Frame14.ResumeLayout(false);
            this.Frame14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updCellSensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updYCell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updXCell)).EndInit();
            this.grbXYMaxMotion.ResumeLayout(false);
            this.grbXYMaxMotion.PerformLayout();
            this.grbMotionRatio.ResumeLayout(false);
            this.grbMotionRatio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{
			chkMotionDetectionEnabled.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_Enabled;
			chkCompareRed.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_CompareRed;
			chkCompareGreen.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_CompareGreen;
			chkCompareBlue.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_CompareBlue;
			chk_GreyScale.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_GreyScale;
			chkReduceVideoNoise.Checked = cMainForm.axVideoGrabberNET1.MotionDetector_ReduceVideoNoise;
			edtGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Get2DTextGrid();
			updGridColCount.Value = cMainForm.axVideoGrabberNET1.MotionDetector_GridXCount;
			updGridRowCount.Value = cMainForm.axVideoGrabberNET1.MotionDetector_GridYCount;
			lblMotionDetectorRequiresFrameGrabber.Visible = cMainForm.axVideoGrabberNET1.FrameGrabber == Vidgrab_NET.TxFrameGrabber.fg_Disabled;
			updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value;
		}

		private void btnApplyGridSize_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_SetGridSize(Convert.ToInt32(updGridColCount.Value), Convert.ToInt32(updGridRowCount.Value));
			edtGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Get2DTextGrid();
		}

		private void btnSetCellsSensitivity_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_SetCellSensitivity(Convert.ToInt32(updXCell.Value), Convert.ToInt32(updYCell.Value), Convert.ToInt32(updCellSensitivity.Value));
			edtGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Get2DTextGrid();
		}

		private void btnShowGridDialog_Click(object sender, System.EventArgs e)
		{
			if ((cMainForm.axVideoGrabberNET1.CurrentState != Vidgrab_NET.TxCurrentState.cs_Preview) && (cMainForm.axVideoGrabberNET1.CurrentState != Vidgrab_NET.TxCurrentState.cs_Recording)) 
			{
				MessageBox.Show ("you should start preview or recording to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo",MessageBoxButtons.OK);
			}
			if (! cMainForm.axVideoGrabberNET1.MotionDetector_Enabled) 
			{
                MessageBox.Show("you should enable the motion detector first (MotionDetector_Enabled = true) to see the video frame under the grid",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			};
			if ((cMainForm.axVideoGrabberNET1.MotionDetector_GridXCount > 30) || (cMainForm.axVideoGrabberNET1.MotionDetector_GridYCount > 30)) 
			{
                MessageBox.Show("the grid will be too dense to be edited through the dialog, you should use SetGridCell",
                            "DataStead TVideoGrabber C#.NET OCX Demo", MessageBoxButtons.OK);
			}
			cMainForm.axVideoGrabberNET1.MotionDetector_ShowGridDialog();
			edtGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Grid;
			mmoSensitivityGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Get2DTextGrid();
		}

		private void chk_triggered_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_Triggered = chk_triggered.Checked;
		}

		private void btn_TriggerNow_Click(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_TriggerNow();
		}

		private void chk_GreyScale_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_GreyScale = chk_GreyScale.Checked;
		}

		private void chkCompareBlue_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_CompareBlue = chkCompareBlue.Checked;
		}

		private void chkCompareGreen_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_CompareGreen = chkCompareGreen.Checked;
		}

		private void chkCompareRed_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_CompareRed = chkCompareRed.Checked;
		}

		private void chkMotionDetectionEnabled_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_Enabled = chkMotionDetectionEnabled.Checked;
            MotionDetected = false;
		}

		private void chkReduceVideoNoise_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_ReduceVideoNoise = chkReduceVideoNoise.Checked;
		}

		private void edtGrid_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.axVideoGrabberNET1.MotionDetector_Grid = edtGrid.Text;
			if (cMainForm.axVideoGrabberNET1.MotionDetector_IsGridValid) 
			{
				lblGridValid.Text = "valid";
                lblGridValid.ForeColor = Color.Green;
			}
			else {
				lblGridValid.Text = "invalid";
                lblGridValid.ForeColor = Color.Red;
			}
			mmoSensitivityGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Get2DTextGrid();
		}

		private void updGlobalGridSensitivity_ValueChanged(object sender, System.EventArgs e)
		{
			if (updGlobalGridSensitivity.Value > Convert.ToInt32(updGlobalGridSensitivity.Tag)) 
			{
				cMainForm.axVideoGrabberNET1.MotionDetector_GloballyIncOrDecSensitivity(1);
			}
			else 
			{
				cMainForm.axVideoGrabberNET1.MotionDetector_GloballyIncOrDecSensitivity(-1);
			}
			updGlobalGridSensitivity.Tag = updGlobalGridSensitivity.Value;
			edtGrid.Text = cMainForm.axVideoGrabberNET1.MotionDetector_Grid;
		}

		private void MotionDetection_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void grbMotionRatio_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = null;
            g = e.Graphics;
            g.FillEllipse((cMainForm.boolMotionRatio ? cMainForm.brushMotionRatio : Brushes.DarkGreen), 10, 20, 15, 15);
            g.DrawEllipse(Pens.Blue, 10, 20, 15, 15);
        }

        
        public bool MotionDetected
        {
            get
            {
                return cMainForm.boolMotionRatio;
            }
            set
            {
                cMainForm.boolMotionRatio = value;
                cMainForm.brushMotionRatio = (cMainForm.boolMotionRatio ? Brushes.SpringGreen : Brushes.DarkGreen);
                grbMotionRatio.Refresh();
            }
        }
        

	}
}
