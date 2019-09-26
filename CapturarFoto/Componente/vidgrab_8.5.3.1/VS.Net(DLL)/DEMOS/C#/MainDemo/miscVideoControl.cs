using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for miscVideoControl.
	/// </summary>
	public class miscVideoControl : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
		internal System.Windows.Forms.CheckBox chkEmulateTrigger;
		internal System.Windows.Forms.CheckBox chkExternalTrigger;
		internal System.Windows.Forms.CheckBox chkFlipHorz;
		internal System.Windows.Forms.CheckBox chkFlipVert;
		internal System.Windows.Forms.Button btnClose;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public miscVideoControl()
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
			this.chkEmulateTrigger = new System.Windows.Forms.CheckBox();
			this.chkExternalTrigger = new System.Windows.Forms.CheckBox();
			this.chkFlipHorz = new System.Windows.Forms.CheckBox();
			this.chkFlipVert = new System.Windows.Forms.CheckBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// chkEmulateTrigger
			// 
			this.chkEmulateTrigger.Location = new System.Drawing.Point(8, 80);
			this.chkEmulateTrigger.Name = "chkEmulateTrigger";
			this.chkEmulateTrigger.Size = new System.Drawing.Size(248, 16);
			this.chkEmulateTrigger.TabIndex = 39;
			this.chkEmulateTrigger.Text = "emulate trigger (enable external trigger first)";
			this.chkEmulateTrigger.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
			// 
			// chkExternalTrigger
			// 
			this.chkExternalTrigger.Location = new System.Drawing.Point(8, 56);
			this.chkExternalTrigger.Name = "chkExternalTrigger";
			this.chkExternalTrigger.Size = new System.Drawing.Size(208, 16);
			this.chkExternalTrigger.TabIndex = 38;
			this.chkExternalTrigger.Text = "external trigger";
			this.chkExternalTrigger.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
			// 
			// chkFlipHorz
			// 
			this.chkFlipHorz.Location = new System.Drawing.Point(8, 32);
			this.chkFlipHorz.Name = "chkFlipHorz";
			this.chkFlipHorz.Size = new System.Drawing.Size(208, 16);
			this.chkFlipHorz.TabIndex = 37;
			this.chkFlipHorz.Text = "flip horizontally";
			this.chkFlipHorz.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
			// 
			// chkFlipVert
			// 
			this.chkFlipVert.Location = new System.Drawing.Point(8, 8);
			this.chkFlipVert.Name = "chkFlipVert";
			this.chkFlipVert.Size = new System.Drawing.Size(208, 16);
			this.chkFlipVert.TabIndex = 36;
			this.chkFlipVert.Text = "flip vertically";
			this.chkFlipVert.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(88, 112);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(72, 24);
			this.btnClose.TabIndex = 35;
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// miscVideoControl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(248, 149);
			this.Controls.Add(this.chkEmulateTrigger);
			this.Controls.Add(this.chkExternalTrigger);
			this.Controls.Add(this.chkFlipHorz);
			this.Controls.Add(this.chkFlipVert);
			this.Controls.Add(this.btnClose);
			this.Name = "miscVideoControl";
			this.Text = "miscVideoControl";
			this.VisibleChanged += new System.EventHandler(this.miscVideoControl_VisibleChanged);
			this.ResumeLayout(false);

		}
		#endregion

		public void RefreshControls()
		{
			chkFlipVert.Enabled = cMainForm.VideoGrabber1.IsVideoControlModeAvailable(VidGrab.TVideoControl.vc_FlipHorizontal);
			chkFlipHorz.Enabled = cMainForm.VideoGrabber1.IsVideoControlModeAvailable(VidGrab.TVideoControl.vc_FlipVertical);
			chkExternalTrigger.Enabled = cMainForm.VideoGrabber1.IsVideoControlModeAvailable(VidGrab.TVideoControl.vc_ExternalTriggerEnable);
			chkEmulateTrigger.Enabled = cMainForm.VideoGrabber1.IsVideoControlModeAvailable(VidGrab.TVideoControl.vc_Trigger);
		}

		private void chk_CheckedChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.SetVideoControlMode(chkFlipHorz.Checked, chkFlipVert.Checked, chkExternalTrigger.Checked, chkEmulateTrigger.Checked);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miscVideoControl_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}
	}
}
