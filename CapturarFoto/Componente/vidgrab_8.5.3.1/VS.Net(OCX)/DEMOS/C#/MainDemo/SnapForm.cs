using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for SnapForm.
	/// </summary>
	public class SnapForm : SubForm // SubForm is declared in CSUtil. Unlike default forms, it is not destroyed when closed, and includes also some additional tools.
	{
		internal System.Windows.Forms.PictureBox SnapImage;
		public System.Windows.Forms.ToolTip ToolTip1;
		private System.ComponentModel.IContainer components;

		public SnapForm()
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
			this.SnapImage = new System.Windows.Forms.PictureBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// SnapImage
			// 
			this.SnapImage.Location = new System.Drawing.Point(8, 8);
			this.SnapImage.Name = "SnapImage";
			this.SnapImage.Size = new System.Drawing.Size(288, 224);
			this.SnapImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.SnapImage.TabIndex = 1;
			this.SnapImage.TabStop = false;
			this.SnapImage.Resize += new System.EventHandler(this.SnapImage_Resize);
			// 
			// SnapForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 237);
			this.Controls.Add(this.SnapImage);
			this.Name = "SnapForm";
			this.Text = "Captured frame";
			this.ResumeLayout(false);

		}
		#endregion

		private void SnapImage_Resize(object sender, System.EventArgs e)
		{
			this.Width = SnapImage.Width + 25;
			this.Height = SnapImage.Height + 40;
		}

	}
}
