using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for miscCameraControl.
	/// </summary>
	public class miscCameraControl : SubForm  // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.CheckBox chkFocus;
		internal System.Windows.Forms.CheckBox chkIris;
		internal System.Windows.Forms.CheckBox chkExposure;
		internal System.Windows.Forms.CheckBox chkRoll;
		internal System.Windows.Forms.CheckBox chkTilt;
		internal System.Windows.Forms.CheckBox chkPan;
		internal System.Windows.Forms.CheckBox chkZoom;
		internal System.Windows.Forms.Button btnFocus;
		internal System.Windows.Forms.Button btnIris;
		internal System.Windows.Forms.Button btnExposure;
		internal System.Windows.Forms.Button btnRoll;
		internal System.Windows.Forms.Button btnTilt;
		internal System.Windows.Forms.Button btnPan;
		internal System.Windows.Forms.Button btnZoom;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TrackBar tbrPan;
		internal System.Windows.Forms.TrackBar tbrRoll;
		internal System.Windows.Forms.TrackBar tbrTilt;
		internal System.Windows.Forms.TrackBar tbrFocus;
		internal System.Windows.Forms.TrackBar tbrExposure;
		internal System.Windows.Forms.TrackBar tbrIris;
		internal System.Windows.Forms.TrackBar tbrZoom;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public miscCameraControl()
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
            this.btnClose = new System.Windows.Forms.Button();
            this.chkFocus = new System.Windows.Forms.CheckBox();
            this.chkIris = new System.Windows.Forms.CheckBox();
            this.chkExposure = new System.Windows.Forms.CheckBox();
            this.chkRoll = new System.Windows.Forms.CheckBox();
            this.chkTilt = new System.Windows.Forms.CheckBox();
            this.chkPan = new System.Windows.Forms.CheckBox();
            this.chkZoom = new System.Windows.Forms.CheckBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnIris = new System.Windows.Forms.Button();
            this.btnExposure = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.btnTilt = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tbrPan = new System.Windows.Forms.TrackBar();
            this.tbrRoll = new System.Windows.Forms.TrackBar();
            this.tbrTilt = new System.Windows.Forms.TrackBar();
            this.tbrFocus = new System.Windows.Forms.TrackBar();
            this.tbrExposure = new System.Windows.Forms.TrackBar();
            this.tbrIris = new System.Windows.Forms.TrackBar();
            this.tbrZoom = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbrPan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRoll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTilt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFocus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrExposure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(168, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 24);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkFocus
            // 
            this.chkFocus.Location = new System.Drawing.Point(352, 240);
            this.chkFocus.Name = "chkFocus";
            this.chkFocus.Size = new System.Drawing.Size(48, 16);
            this.chkFocus.TabIndex = 57;
            this.chkFocus.Tag = "6";
            this.chkFocus.Text = "auto";
            // 
            // chkIris
            // 
            this.chkIris.Location = new System.Drawing.Point(296, 240);
            this.chkIris.Name = "chkIris";
            this.chkIris.Size = new System.Drawing.Size(48, 16);
            this.chkIris.TabIndex = 56;
            this.chkIris.Tag = "5";
            this.chkIris.Text = "auto";
            // 
            // chkExposure
            // 
            this.chkExposure.Location = new System.Drawing.Point(240, 240);
            this.chkExposure.Name = "chkExposure";
            this.chkExposure.Size = new System.Drawing.Size(48, 16);
            this.chkExposure.TabIndex = 55;
            this.chkExposure.Tag = "4";
            this.chkExposure.Text = "auto";
            // 
            // chkRoll
            // 
            this.chkRoll.Location = new System.Drawing.Point(184, 240);
            this.chkRoll.Name = "chkRoll";
            this.chkRoll.Size = new System.Drawing.Size(48, 16);
            this.chkRoll.TabIndex = 54;
            this.chkRoll.Tag = "3";
            this.chkRoll.Text = "auto";
            // 
            // chkTilt
            // 
            this.chkTilt.Location = new System.Drawing.Point(128, 240);
            this.chkTilt.Name = "chkTilt";
            this.chkTilt.Size = new System.Drawing.Size(48, 16);
            this.chkTilt.TabIndex = 53;
            this.chkTilt.Tag = "2";
            this.chkTilt.Text = "auto";
            // 
            // chkPan
            // 
            this.chkPan.Location = new System.Drawing.Point(72, 240);
            this.chkPan.Name = "chkPan";
            this.chkPan.Size = new System.Drawing.Size(48, 16);
            this.chkPan.TabIndex = 52;
            this.chkPan.Tag = "1";
            this.chkPan.Text = "auto";
            // 
            // chkZoom
            // 
            this.chkZoom.Location = new System.Drawing.Point(16, 240);
            this.chkZoom.Name = "chkZoom";
            this.chkZoom.Size = new System.Drawing.Size(48, 16);
            this.chkZoom.TabIndex = 51;
            this.chkZoom.Tag = "0";
            this.chkZoom.Text = "auto";
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(352, 216);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(48, 16);
            this.btnFocus.TabIndex = 50;
            this.btnFocus.Tag = "6";
            this.btnFocus.Text = "default";
            // 
            // btnIris
            // 
            this.btnIris.Location = new System.Drawing.Point(296, 216);
            this.btnIris.Name = "btnIris";
            this.btnIris.Size = new System.Drawing.Size(48, 16);
            this.btnIris.TabIndex = 49;
            this.btnIris.Tag = "5";
            this.btnIris.Text = "default";
            // 
            // btnExposure
            // 
            this.btnExposure.Location = new System.Drawing.Point(240, 216);
            this.btnExposure.Name = "btnExposure";
            this.btnExposure.Size = new System.Drawing.Size(48, 16);
            this.btnExposure.TabIndex = 48;
            this.btnExposure.Tag = "4";
            this.btnExposure.Text = "default";
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(184, 216);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(48, 16);
            this.btnRoll.TabIndex = 47;
            this.btnRoll.Tag = "3";
            this.btnRoll.Text = "default";
            // 
            // btnTilt
            // 
            this.btnTilt.Location = new System.Drawing.Point(128, 216);
            this.btnTilt.Name = "btnTilt";
            this.btnTilt.Size = new System.Drawing.Size(48, 16);
            this.btnTilt.TabIndex = 46;
            this.btnTilt.Tag = "2";
            this.btnTilt.Text = "default";
            // 
            // btnPan
            // 
            this.btnPan.Location = new System.Drawing.Point(72, 216);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(48, 16);
            this.btnPan.TabIndex = 45;
            this.btnPan.Tag = "1";
            this.btnPan.Text = "default";
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(16, 216);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(48, 16);
            this.btnZoom.TabIndex = 44;
            this.btnZoom.Tag = "0";
            this.btnZoom.Text = "default";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(32, 16);
            this.Label1.TabIndex = 43;
            this.Label1.Text = "zoom";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(360, 8);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(32, 16);
            this.Label7.TabIndex = 42;
            this.Label7.Text = "focus";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(312, 8);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(32, 16);
            this.Label6.TabIndex = 41;
            this.Label6.Text = "iris";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(232, 8);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(56, 16);
            this.Label5.TabIndex = 40;
            this.Label5.Text = "exposure";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(192, 8);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(32, 16);
            this.Label4.TabIndex = 39;
            this.Label4.Text = "roll";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(144, 8);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(24, 16);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "tilt";
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(80, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(32, 16);
            this.Label2.TabIndex = 37;
            this.Label2.Text = "pan";
            // 
            // tbrPan
            // 
            this.tbrPan.Location = new System.Drawing.Point(72, 24);
            this.tbrPan.Name = "tbrPan";
            this.tbrPan.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrPan.Size = new System.Drawing.Size(45, 184);
            this.tbrPan.TabIndex = 36;
            this.tbrPan.Tag = "1";
            this.tbrPan.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrRoll
            // 
            this.tbrRoll.Location = new System.Drawing.Point(184, 24);
            this.tbrRoll.Name = "tbrRoll";
            this.tbrRoll.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrRoll.Size = new System.Drawing.Size(45, 184);
            this.tbrRoll.TabIndex = 35;
            this.tbrRoll.Tag = "3";
            this.tbrRoll.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrTilt
            // 
            this.tbrTilt.Location = new System.Drawing.Point(128, 24);
            this.tbrTilt.Name = "tbrTilt";
            this.tbrTilt.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrTilt.Size = new System.Drawing.Size(45, 184);
            this.tbrTilt.TabIndex = 34;
            this.tbrTilt.Tag = "2";
            this.tbrTilt.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrFocus
            // 
            this.tbrFocus.Location = new System.Drawing.Point(352, 24);
            this.tbrFocus.Name = "tbrFocus";
            this.tbrFocus.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrFocus.Size = new System.Drawing.Size(45, 184);
            this.tbrFocus.TabIndex = 33;
            this.tbrFocus.Tag = "6";
            this.tbrFocus.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrExposure
            // 
            this.tbrExposure.Location = new System.Drawing.Point(240, 24);
            this.tbrExposure.Name = "tbrExposure";
            this.tbrExposure.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrExposure.Size = new System.Drawing.Size(45, 184);
            this.tbrExposure.TabIndex = 32;
            this.tbrExposure.Tag = "4";
            this.tbrExposure.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrIris
            // 
            this.tbrIris.Location = new System.Drawing.Point(296, 24);
            this.tbrIris.Name = "tbrIris";
            this.tbrIris.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrIris.Size = new System.Drawing.Size(45, 184);
            this.tbrIris.TabIndex = 31;
            this.tbrIris.Tag = "5";
            this.tbrIris.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // tbrZoom
            // 
            this.tbrZoom.Location = new System.Drawing.Point(16, 24);
            this.tbrZoom.Name = "tbrZoom";
            this.tbrZoom.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrZoom.Size = new System.Drawing.Size(45, 184);
            this.tbrZoom.TabIndex = 30;
            this.tbrZoom.Tag = "0";
            this.tbrZoom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbrZoom.Scroll += new System.EventHandler(this.tbrZoom_Scroll);
            // 
            // miscCameraControl
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(416, 317);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkFocus);
            this.Controls.Add(this.chkIris);
            this.Controls.Add(this.chkExposure);
            this.Controls.Add(this.chkRoll);
            this.Controls.Add(this.chkTilt);
            this.Controls.Add(this.chkPan);
            this.Controls.Add(this.chkZoom);
            this.Controls.Add(this.btnFocus);
            this.Controls.Add(this.btnIris);
            this.Controls.Add(this.btnExposure);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.btnTilt);
            this.Controls.Add(this.btnPan);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tbrPan);
            this.Controls.Add(this.tbrRoll);
            this.Controls.Add(this.tbrTilt);
            this.Controls.Add(this.tbrFocus);
            this.Controls.Add(this.tbrExposure);
            this.Controls.Add(this.tbrIris);
            this.Controls.Add(this.tbrZoom);
            this.Name = "miscCameraControl";
            this.Text = "miscCameraControl";
            this.Load += new System.EventHandler(this.miscCameraControl_Load);
            this.VisibleChanged += new System.EventHandler(this.miscCameraControl_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tbrPan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrRoll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrTilt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrFocus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrExposure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrIris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrZoom)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion
		public struct SettingGroup 
		{
			public TrackBar tbrValue;
			public CheckBox chkAuto;
			public Button  btnDefault;
		}
		public SettingGroup[] FSettingGroup;

		private void miscCameraControl_Load(object sender, System.EventArgs e)
		{
			FSettingGroup = new SettingGroup[7];
			}

		public void RefreshControls()
		{
			if (FSettingGroup == null) return; // not yet loaded
			
			InitTrackBar(chkPan, btnPan, tbrPan, VidGrab.TCameraControl.cc_Pan);
			InitTrackBar(chkTilt, btnTilt, tbrTilt, VidGrab.TCameraControl.cc_Tilt);
			InitTrackBar(chkRoll, btnRoll, tbrRoll, VidGrab.TCameraControl.cc_Roll);
			InitTrackBar(chkZoom, btnZoom, tbrZoom, VidGrab.TCameraControl.cc_Zoom);
			InitTrackBar(chkExposure, btnExposure, tbrExposure, VidGrab.TCameraControl.cc_Exposure);
			InitTrackBar(chkIris, btnIris, tbrIris, VidGrab.TCameraControl.cc_Iris);
			InitTrackBar(chkFocus, btnFocus, tbrFocus, VidGrab.TCameraControl.cc_Focus);
		}
		
		private void InitTrackBar(CheckBox chkAuto, Button btnDefault, TrackBar tbrValue, VidGrab.TCameraControl Setting)
		{
			tbrValue.Tag = Setting;

			tbrValue.Scroll += new System.EventHandler (tbrSetValue);
			btnDefault.Click += new System.EventHandler (btnSetDefault);
			chkAuto.CheckedChanged += new System.EventHandler (tbrSetValue);

			tbrValue.Tag = Setting;
			chkAuto.Tag = Setting;
			btnDefault.Tag = Setting;
			
			int iSetting = Convert.ToInt32 (Setting);

			FSettingGroup[iSetting].tbrValue = tbrValue;
			FSettingGroup[iSetting].chkAuto = chkAuto;
			FSettingGroup[iSetting].btnDefault = btnDefault;

			if (! cMainForm.VideoGrabber1.IsCameraControlSettingAvailable(Setting)) 
			{
				tbrValue.Enabled = false;
				tbrValue.TickFrequency = 0;
				tbrValue.Minimum = 0;
				tbrValue.Maximum = 1;
				tbrValue.Value = 1;
				chkAuto.Enabled = false;
				btnDefault.Enabled = false;
			}
			else 
			{
				chkAuto.Enabled = true;
				chkAuto.Checked = cMainForm.VideoGrabber1.CameraControlAuto(Setting);
				tbrValue.Enabled = ! chkAuto.Checked;
				btnDefault.Enabled = ! chkAuto.Checked;

                int MinValue = cMainForm.VideoGrabber1.CameraControlMin(Setting);
                int MaxValue = cMainForm.VideoGrabber1.CameraControlMax(Setting);
                int CurrentValue = cMainForm.VideoGrabber1.CameraControlValue(Setting);

                if (MinValue < CurrentValue)
                {
                    MinValue = CurrentValue;
                }

                if (CurrentValue > MaxValue)
                {
                    MaxValue = CurrentValue;
                }
                tbrValue.Minimum = MinValue;
                tbrValue.Maximum = MaxValue;
                tbrValue.TickFrequency = cMainForm.VideoGrabber1.CameraControlStep(Setting);
                tbrValue.Value = CurrentValue;
            }
		}
		
		private void tbrSetValue (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			cMainForm.VideoGrabber1.SetCameraControl((VidGrab.TCameraControl) Setting, FSettingGroup[Setting].chkAuto.Checked, false, FSettingGroup[Setting].tbrValue.Value);

			FSettingGroup[Setting].tbrValue.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
			FSettingGroup[Setting].btnDefault.Enabled = ! FSettingGroup[Setting].chkAuto.Checked;
		}

		private void btnSetDefault (System.Object sender, System.EventArgs e)
		{
			int Setting = Convert.ToInt32 ((sender as Control).Tag);

			cMainForm.VideoGrabber1.SetCameraControl((VidGrab.TCameraControl) Setting, FSettingGroup[Setting].chkAuto.Checked, true, FSettingGroup[Setting].tbrValue.Value);
			FSettingGroup[Setting].tbrValue.Value = cMainForm.VideoGrabber1.CameraControlValue((VidGrab.TCameraControl) Setting);
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void miscCameraControl_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}

        private void tbrZoom_Scroll(object sender, System.EventArgs e)
        {
        
        }
	}
}
