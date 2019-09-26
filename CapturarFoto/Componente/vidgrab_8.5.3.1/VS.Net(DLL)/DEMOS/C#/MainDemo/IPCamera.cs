using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for IPCamera.
	/// </summary>
	public class IPCamera : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
    {
        internal Button btnIPCamSendCommand;
        internal TextBox edtIPCamCommand;
        internal Label Label9;
        internal Label Label7;
        internal Label Label6;
        internal TextBox textBox1;
        internal TextBox edtIPCamReceiveTimeout;
        internal TextBox edtIPCamConnectionTimeout;
        internal TextBox edtIPCameraURL;
        internal Label label5;
        internal Label label4;
        internal Label label3;
        internal GroupBox groupBox1;
        internal Label label2;
        internal Label label1;
        public TextBox edtIPCamPassword;
        public TextBox edtIPCamUserName;
        internal Button btnIPCamStartPreview;
        internal Button btnIPCamera;
        internal Label lblFirstSelectIPCamera;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IPCamera()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPCamera));
            this.btnIPCamSendCommand = new System.Windows.Forms.Button();
            this.edtIPCamCommand = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.edtIPCamReceiveTimeout = new System.Windows.Forms.TextBox();
            this.edtIPCamConnectionTimeout = new System.Windows.Forms.TextBox();
            this.edtIPCameraURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edtIPCamPassword = new System.Windows.Forms.TextBox();
            this.edtIPCamUserName = new System.Windows.Forms.TextBox();
            this.btnIPCamStartPreview = new System.Windows.Forms.Button();
            this.btnIPCamera = new System.Windows.Forms.Button();
            this.lblFirstSelectIPCamera = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIPCamSendCommand
            // 
            this.btnIPCamSendCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIPCamSendCommand.Location = new System.Drawing.Point(605, 134);
            this.btnIPCamSendCommand.Name = "btnIPCamSendCommand";
            this.btnIPCamSendCommand.Size = new System.Drawing.Size(52, 22);
            this.btnIPCamSendCommand.TabIndex = 41;
            this.btnIPCamSendCommand.Text = "SEND";
            this.btnIPCamSendCommand.Click += new System.EventHandler(this.btnIPCamSendCommand_Click);
            // 
            // edtIPCamCommand
            // 
            this.edtIPCamCommand.Location = new System.Drawing.Point(336, 136);
            this.edtIPCamCommand.Name = "edtIPCamCommand";
            this.edtIPCamCommand.Size = new System.Drawing.Size(271, 20);
            this.edtIPCamCommand.TabIndex = 40;
            this.edtIPCamCommand.Text = "http://x.x.x.x/axis-cgi/com/ptz.cgi?move=home";
            // 
            // Label9
            // 
            this.Label9.Location = new System.Drawing.Point(333, 65);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(240, 16);
            this.Label9.TabIndex = 44;
            this.Label9.Text = "Start the recording in the \"Recording\" form";
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(8, 160);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(648, 16);
            this.Label7.TabIndex = 43;
            this.Label7.Text = "(e.g. for Axis PTZ commands, replace the last word of the the sample command abov" +
                "e with \"home\", \"up\", \"down\", \"left\" or \"right\")";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(0, 136);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(338, 15);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Send an IP camera command (replace x.x.x.x by the real IP address):";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(664, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(244, 177);
            this.textBox1.TabIndex = 39;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // edtIPCamReceiveTimeout
            // 
            this.edtIPCamReceiveTimeout.Location = new System.Drawing.Point(200, 85);
            this.edtIPCamReceiveTimeout.Name = "edtIPCamReceiveTimeout";
            this.edtIPCamReceiveTimeout.Size = new System.Drawing.Size(67, 20);
            this.edtIPCamReceiveTimeout.TabIndex = 33;
            this.edtIPCamReceiveTimeout.Text = "5000";
            this.edtIPCamReceiveTimeout.TextChanged += new System.EventHandler(this.edtIPCamReceiveTimeout_TextChanged);
            // 
            // edtIPCamConnectionTimeout
            // 
            this.edtIPCamConnectionTimeout.Location = new System.Drawing.Point(200, 61);
            this.edtIPCamConnectionTimeout.Name = "edtIPCamConnectionTimeout";
            this.edtIPCamConnectionTimeout.Size = new System.Drawing.Size(67, 20);
            this.edtIPCamConnectionTimeout.TabIndex = 32;
            this.edtIPCamConnectionTimeout.Text = "10000";
            this.edtIPCamConnectionTimeout.TextChanged += new System.EventHandler(this.edtIPCamConnectionTimeout_TextChanged);
            // 
            // edtIPCameraURL
            // 
            this.edtIPCameraURL.Location = new System.Drawing.Point(200, 38);
            this.edtIPCameraURL.Name = "edtIPCameraURL";
            this.edtIPCameraURL.Size = new System.Drawing.Size(458, 20);
            this.edtIPCameraURL.TabIndex = 31;
            this.edtIPCameraURL.Text = "enter the MJPG or JPG URL of the IP camera (RTSP requires an additional filter)";
            this.edtIPCameraURL.TextChanged += new System.EventHandler(this.edtIPCameraURL_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Receive timeout (in milliseconds):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Connection timeout  (in milliseconds):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "URL of the IP camera:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edtIPCamPassword);
            this.groupBox1.Controls.Add(this.edtIPCamUserName);
            this.groupBox1.Location = new System.Drawing.Point(336, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 43);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "if authentication needed: ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(169, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "user name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // edtIPCamPassword
            // 
            this.edtIPCamPassword.Location = new System.Drawing.Point(229, 15);
            this.edtIPCamPassword.Name = "edtIPCamPassword";
            this.edtIPCamPassword.Size = new System.Drawing.Size(82, 20);
            this.edtIPCamPassword.TabIndex = 2;
            this.edtIPCamPassword.TextChanged += new System.EventHandler(this.edtIPCamPassword_TextChanged);
            // 
            // edtIPCamUserName
            // 
            this.edtIPCamUserName.Location = new System.Drawing.Point(76, 15);
            this.edtIPCamUserName.Name = "edtIPCamUserName";
            this.edtIPCamUserName.Size = new System.Drawing.Size(82, 20);
            this.edtIPCamUserName.TabIndex = 1;
            this.edtIPCamUserName.TextChanged += new System.EventHandler(this.edtIPCamUserName_TextChanged);
            // 
            // btnIPCamStartPreview
            // 
            this.btnIPCamStartPreview.Location = new System.Drawing.Point(200, 110);
            this.btnIPCamStartPreview.Name = "btnIPCamStartPreview";
            this.btnIPCamStartPreview.Size = new System.Drawing.Size(113, 22);
            this.btnIPCamStartPreview.TabIndex = 34;
            this.btnIPCamStartPreview.Text = "Start preview";
            this.btnIPCamStartPreview.Click += new System.EventHandler(this.btnIPCamStartPreview_Click);
            // 
            // btnIPCamera
            // 
            this.btnIPCamera.Location = new System.Drawing.Point(200, 16);
            this.btnIPCamera.Name = "btnIPCamera";
            this.btnIPCamera.Size = new System.Drawing.Size(458, 20);
            this.btnIPCamera.TabIndex = 30;
            this.btnIPCamera.Text = "e.g. URL of a public IP camera currently available (just copy the URL and paste i" +
                "t below)";
            this.btnIPCamera.Click += new System.EventHandler(this.btnIPCamera_Click);
            // 
            // lblFirstSelectIPCamera
            // 
            this.lblFirstSelectIPCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSelectIPCamera.ForeColor = System.Drawing.Color.Red;
            this.lblFirstSelectIPCamera.Location = new System.Drawing.Point(4, 0);
            this.lblFirstSelectIPCamera.Name = "lblFirstSelectIPCamera";
            this.lblFirstSelectIPCamera.Size = new System.Drawing.Size(545, 14);
            this.lblFirstSelectIPCamera.TabIndex = 29;
            this.lblFirstSelectIPCamera.Text = "first select VideoSource = vs_IPCamera in the Video Sources list of the  \"video s" +
                "ource\" tab";
            // 
            // IPCamera
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(960, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnIPCamSendCommand);
            this.Controls.Add(this.edtIPCamCommand);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.edtIPCamReceiveTimeout);
            this.Controls.Add(this.edtIPCamConnectionTimeout);
            this.Controls.Add(this.edtIPCameraURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIPCamStartPreview);
            this.Controls.Add(this.btnIPCamera);
            this.Controls.Add(this.lblFirstSelectIPCamera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPCamera";
            this.ShowInTaskbar = false;
            this.VisibleChanged += new System.EventHandler(this.IPCamera_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public void RefreshControls()
		{	
			lblFirstSelectIPCamera.Visible = (cMainForm.VideoGrabber1.VideoSource != VidGrab.TVideoSource.vs_IPCamera);
		}

		private void btnIPCamera_Click(object sender, System.EventArgs e)
		{
			ShellExecute((System.IntPtr) 0, "open", "http://www.datastead.com/demo/IPCam.htm", "", "", ShowCommands.SW_SHOWNORMAL);
		}

		private void edtIPCameraURL_TextChanged(object sender, System.EventArgs e)
		{
			cMainForm.VideoGrabber1.IPCameraURL = edtIPCameraURL.Text;
		}

        private void edtIPCamUserName_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.SetAuthentication (VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
        }

        private void edtIPCamPassword_TextChanged(object sender, System.EventArgs e)
        {
            cMainForm.VideoGrabber1.SetAuthentication (VidGrab.TAuthenticationType.at_IPCamera, edtIPCamUserName.Text, edtIPCamPassword.Text);
        }

        private void edtIPCamConnectionTimeout_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtIPCamConnectionTimeout.Text)) 
			{
				cMainForm.VideoGrabber1.SetIPCameraSetting (VidGrab.TIPCameraSetting.ips_ConnectionTimeout , Convert.ToInt32 (edtIPCamConnectionTimeout.Text));
			}
		}

		private void edtIPCamReceiveTimeout_TextChanged(object sender, System.EventArgs e)
		{
			if (IsNumeric(edtIPCamReceiveTimeout.Text)) 
			{
				cMainForm.VideoGrabber1.SetIPCameraSetting (VidGrab.TIPCameraSetting.ips_ReceiveTimeout , Convert.ToInt32 (edtIPCamReceiveTimeout.Text));
			}
		}

		private void btnIPCamStartPreview_Click(object sender, System.EventArgs e)
		{
            if (cMainForm.VideoGrabber1.VideoSource != VidGrab.TVideoSource.vs_IPCamera) {
                cMainForm.VideoGrabber1.VideoSource = VidGrab.TVideoSource.vs_IPCamera;
                AddLog(cMainForm.mmoLog, "VideoSource set to 'vs_IPCamera'");
            }
			cMainForm.VideoGrabber1.StartPreview();	
		}

        private void btnIPCamSendCommand_Click(object sender, System.EventArgs e)
        {
            if (cMainForm.VideoGrabber1.SendIPCameraCommand(edtIPCamCommand.Text)) 
            {
                AddLog(cMainForm.mmoLog, "IP camera command successfully sent.");
            }
            else 
            {
                AddLog(cMainForm.mmoLog, "failed to send the IP camera command (wrong IP address, command not supported or authentication failed)");
            }
        }

        private void IPCamera_VisibleChanged(object sender, System.EventArgs e)
		{
			if (Visible) 
			{
				RefreshControls();
			}
		}
	}
}
