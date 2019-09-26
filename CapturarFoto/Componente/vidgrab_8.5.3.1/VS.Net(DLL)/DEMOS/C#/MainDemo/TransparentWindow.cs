using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace MainDemo
{
	/// <summary>
	/// Summary description for TransparentWindow.
	/// </summary>
	public class TransparentWindow : System.Windows.Forms.Form
	{
        internal System.Windows.Forms.Label TransparentLabel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TransparentWindow()
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
            this.TransparentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TransparentLabel
            // 
            this.TransparentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
                | System.Windows.Forms.AnchorStyles.Right)));
            this.TransparentLabel.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.TransparentLabel.Location = new System.Drawing.Point(8, 50);
            this.TransparentLabel.Name = "TransparentLabel";
            this.TransparentLabel.Size = new System.Drawing.Size(416, 40);
            this.TransparentLabel.TabIndex = 2;
            this.TransparentLabel.Text = "transparent window";
            this.TransparentLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TransparentWindow
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(432, 140);
            this.Controls.Add(this.TransparentLabel);
            this.Name = "TransparentWindow";
            this.Text = "transparent window";
            this.ResumeLayout(false);

        }
		#endregion
	}
}
