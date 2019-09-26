using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for miscSpecialControl.
	/// </summary>
	public class miscSpecialControl : SubForm  // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.RadioButton rdgGpio1on;
		internal System.Windows.Forms.RadioButton rdgGpio1off;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.RadioButton rdgGpio0on;
		internal System.Windows.Forms.RadioButton rdgGpio0off;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.RadioButton rdgGpio3on;
		internal System.Windows.Forms.RadioButton rdgGpio3off;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Button btnPanTiltRight;
		internal System.Windows.Forms.Button btnPanTiltDown;
		internal System.Windows.Forms.Button btnPanTiltLeft;
		internal System.Windows.Forms.Button btnPanTiltUp;
		internal System.Windows.Forms.Button btnPanTiltHome;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.RadioButton rdgGpio2on;
		internal System.Windows.Forms.RadioButton rdgGpio2off;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public miscSpecialControl()
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
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.rdgGpio1on = new System.Windows.Forms.RadioButton();
			this.rdgGpio1off = new System.Windows.Forms.RadioButton();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.rdgGpio0on = new System.Windows.Forms.RadioButton();
			this.rdgGpio0off = new System.Windows.Forms.RadioButton();
			this.GroupBox5 = new System.Windows.Forms.GroupBox();
			this.rdgGpio3on = new System.Windows.Forms.RadioButton();
			this.rdgGpio3off = new System.Windows.Forms.RadioButton();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPanTiltRight = new System.Windows.Forms.Button();
			this.btnPanTiltDown = new System.Windows.Forms.Button();
			this.btnPanTiltLeft = new System.Windows.Forms.Button();
			this.btnPanTiltUp = new System.Windows.Forms.Button();
			this.btnPanTiltHome = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.rdgGpio2on = new System.Windows.Forms.RadioButton();
			this.rdgGpio2off = new System.Windows.Forms.RadioButton();
			this.GroupBox3.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox5.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox3
			// 
			this.GroupBox3.Controls.Add(this.rdgGpio1on);
			this.GroupBox3.Controls.Add(this.rdgGpio1off);
			this.GroupBox3.Location = new System.Drawing.Point(224, 56);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(112, 40);
			this.GroupBox3.TabIndex = 39;
			this.GroupBox3.TabStop = false;
			this.GroupBox3.Text = "GPIO 0";
			// 
			// rdgGpio1on
			// 
			this.rdgGpio1on.Location = new System.Drawing.Point(64, 12);
			this.rdgGpio1on.Name = "rdgGpio1on";
			this.rdgGpio1on.Size = new System.Drawing.Size(40, 24);
			this.rdgGpio1on.TabIndex = 1;
			this.rdgGpio1on.Text = "on";
			this.rdgGpio1on.CheckedChanged += new System.EventHandler(this.rdgGpio1_CheckedChanged);
			// 
			// rdgGpio1off
			// 
			this.rdgGpio1off.Location = new System.Drawing.Point(16, 12);
			this.rdgGpio1off.Name = "rdgGpio1off";
			this.rdgGpio1off.Size = new System.Drawing.Size(56, 24);
			this.rdgGpio1off.TabIndex = 0;
			this.rdgGpio1off.Text = "off";
			this.rdgGpio1off.CheckedChanged += new System.EventHandler(this.rdgGpio1_CheckedChanged);
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.rdgGpio0on);
			this.GroupBox2.Controls.Add(this.rdgGpio0off);
			this.GroupBox2.Location = new System.Drawing.Point(224, 8);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(112, 40);
			this.GroupBox2.TabIndex = 38;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "GPIO 0";
			// 
			// rdgGpio0on
			// 
			this.rdgGpio0on.Location = new System.Drawing.Point(64, 12);
			this.rdgGpio0on.Name = "rdgGpio0on";
			this.rdgGpio0on.Size = new System.Drawing.Size(40, 24);
			this.rdgGpio0on.TabIndex = 1;
			this.rdgGpio0on.Text = "on";
			this.rdgGpio0on.CheckedChanged += new System.EventHandler(this.rdgGpio0_CheckedChanged);
			// 
			// rdgGpio0off
			// 
			this.rdgGpio0off.Location = new System.Drawing.Point(16, 12);
			this.rdgGpio0off.Name = "rdgGpio0off";
			this.rdgGpio0off.Size = new System.Drawing.Size(56, 24);
			this.rdgGpio0off.TabIndex = 0;
			this.rdgGpio0off.Text = "off";
			this.rdgGpio0off.CheckedChanged += new System.EventHandler(this.rdgGpio0_CheckedChanged);
			// 
			// GroupBox5
			// 
			this.GroupBox5.Controls.Add(this.rdgGpio3on);
			this.GroupBox5.Controls.Add(this.rdgGpio3off);
			this.GroupBox5.Location = new System.Drawing.Point(224, 152);
			this.GroupBox5.Name = "GroupBox5";
			this.GroupBox5.Size = new System.Drawing.Size(112, 40);
			this.GroupBox5.TabIndex = 41;
			this.GroupBox5.TabStop = false;
			this.GroupBox5.Text = "GPIO 0";
			// 
			// rdgGpio3on
			// 
			this.rdgGpio3on.Location = new System.Drawing.Point(64, 12);
			this.rdgGpio3on.Name = "rdgGpio3on";
			this.rdgGpio3on.Size = new System.Drawing.Size(40, 24);
			this.rdgGpio3on.TabIndex = 1;
			this.rdgGpio3on.Text = "on";
			this.rdgGpio3on.CheckedChanged += new System.EventHandler(this.rdgGpio3_CheckedChanged);
			// 
			// rdgGpio3off
			// 
			this.rdgGpio3off.Location = new System.Drawing.Point(16, 12);
			this.rdgGpio3off.Name = "rdgGpio3off";
			this.rdgGpio3off.Size = new System.Drawing.Size(56, 24);
			this.rdgGpio3off.TabIndex = 0;
			this.rdgGpio3off.Text = "off";
			this.rdgGpio3off.CheckedChanged += new System.EventHandler(this.rdgGpio3_CheckedChanged);
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.btnPanTiltRight);
			this.GroupBox1.Controls.Add(this.btnPanTiltDown);
			this.GroupBox1.Controls.Add(this.btnPanTiltLeft);
			this.GroupBox1.Controls.Add(this.btnPanTiltUp);
			this.GroupBox1.Controls.Add(this.btnPanTiltHome);
			this.GroupBox1.Location = new System.Drawing.Point(16, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(184, 184);
			this.GroupBox1.TabIndex = 37;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "PAN/TILT (motorized)";
			// 
			// btnPanTiltRight
			// 
			this.btnPanTiltRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPanTiltRight.Location = new System.Drawing.Point(120, 72);
			this.btnPanTiltRight.Name = "btnPanTiltRight";
			this.btnPanTiltRight.Size = new System.Drawing.Size(40, 40);
			this.btnPanTiltRight.TabIndex = 4;
			this.btnPanTiltRight.Text = ">";
			this.btnPanTiltRight.Click += new System.EventHandler(this.btnPanTiltRight_Click);
			// 
			// btnPanTiltDown
			// 
			this.btnPanTiltDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPanTiltDown.Location = new System.Drawing.Point(72, 120);
			this.btnPanTiltDown.Name = "btnPanTiltDown";
			this.btnPanTiltDown.Size = new System.Drawing.Size(40, 40);
			this.btnPanTiltDown.TabIndex = 3;
			this.btnPanTiltDown.Text = "v";
			this.btnPanTiltDown.Click += new System.EventHandler(this.btnPanTiltDown_Click);
			// 
			// btnPanTiltLeft
			// 
			this.btnPanTiltLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPanTiltLeft.Location = new System.Drawing.Point(24, 72);
			this.btnPanTiltLeft.Name = "btnPanTiltLeft";
			this.btnPanTiltLeft.Size = new System.Drawing.Size(40, 40);
			this.btnPanTiltLeft.TabIndex = 2;
			this.btnPanTiltLeft.Text = "<";
			this.btnPanTiltLeft.Click += new System.EventHandler(this.btnPanTiltLeft_Click);
			// 
			// btnPanTiltUp
			// 
			this.btnPanTiltUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnPanTiltUp.Location = new System.Drawing.Point(72, 24);
			this.btnPanTiltUp.Name = "btnPanTiltUp";
			this.btnPanTiltUp.Size = new System.Drawing.Size(40, 40);
			this.btnPanTiltUp.TabIndex = 1;
			this.btnPanTiltUp.Text = "^";
			this.btnPanTiltUp.Click += new System.EventHandler(this.btnPanTiltUp_Click);
			// 
			// btnPanTiltHome
			// 
			this.btnPanTiltHome.Location = new System.Drawing.Point(72, 72);
			this.btnPanTiltHome.Name = "btnPanTiltHome";
			this.btnPanTiltHome.Size = new System.Drawing.Size(40, 40);
			this.btnPanTiltHome.TabIndex = 0;
			this.btnPanTiltHome.Text = "home";
			this.btnPanTiltHome.Click += new System.EventHandler(this.btnPanTiltHome_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(144, 208);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(72, 24);
			this.btnClose.TabIndex = 36;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.rdgGpio2on);
			this.GroupBox4.Controls.Add(this.rdgGpio2off);
			this.GroupBox4.Location = new System.Drawing.Point(224, 104);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(112, 40);
			this.GroupBox4.TabIndex = 40;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "GPIO 0";
			// 
			// rdgGpio2on
			// 
			this.rdgGpio2on.Location = new System.Drawing.Point(64, 12);
			this.rdgGpio2on.Name = "rdgGpio2on";
			this.rdgGpio2on.Size = new System.Drawing.Size(40, 24);
			this.rdgGpio2on.TabIndex = 1;
			this.rdgGpio2on.Text = "on";
			this.rdgGpio2on.CheckedChanged += new System.EventHandler(this.rdgGpio2_CheckedChanged);
			// 
			// rdgGpio2off
			// 
			this.rdgGpio2off.Location = new System.Drawing.Point(16, 12);
			this.rdgGpio2off.Name = "rdgGpio2off";
			this.rdgGpio2off.Size = new System.Drawing.Size(56, 24);
			this.rdgGpio2off.TabIndex = 0;
			this.rdgGpio2off.Text = "off";
			this.rdgGpio2off.CheckedChanged += new System.EventHandler(this.rdgGpio2_CheckedChanged);
			// 
			// miscSpecialControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 245);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox5);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.GroupBox4);
			this.Name = "miscSpecialControl";
			this.Text = "miscSpecialControl";
			this.VisibleChanged += new System.EventHandler(this.miscSpecialControl_VisibleChanged);
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox5.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public void RefreshControls()
		{
		}

		private void btnPanTiltHome_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SendCameraCommand(0, 0, false);
		}

		private void btnPanTiltUp_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SendCameraCommand(0, 1, true);
		}

		private void btnPanTiltDown_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SendCameraCommand(0, -1, true);
		}

		private void btnPanTiltLeft_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SendCameraCommand(-1, 0, true);
		}

		private void btnPanTiltRight_Click(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SendCameraCommand(1, 0, true);
		}

		private void rdgGpio0_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				if (Convert.ToInt32 ((sender as Control).Tag) == 0) {
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 0, 0);
				}
				else {
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 0, 1);
				}
			}
		}

		private void rdgGpio1_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				if (Convert.ToInt32 ((sender as Control).Tag) == 0) 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 1, 0);
				}
				else 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 1, 1);
				}
			}
		}

		private void rdgGpio2_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				if (Convert.ToInt32 ((sender as Control).Tag) == 0) 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 2, 0);
				}
				else 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 2, 1);
				}
			}
		}

		private void rdgGpio3_CheckedChanged(object sender, System.EventArgs e)
		{
			if ((sender as RadioButton).Checked) 
			{
				if (Convert.ToInt32 ((sender as Control).Tag) == 0) 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 3, 0);
				}
				else 
				{
					cMainForm.VideoGrabber1.PutMiscDeviceControl (VidGrab.TMiscDeviceControl.mdc_GPIO, 3, 1);
				}
			}
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miscSpecialControl_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}
	}
}
