namespace VideoGrabberService
{
    partial class VidgrabInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VidgrabProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.VidgrabServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // VidgrabProcessInstaller
            // 
            this.VidgrabProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.VidgrabProcessInstaller.Password = null;
            this.VidgrabProcessInstaller.Username = null;
            // 
            // VidgrabServiceInstaller
            // 
            this.VidgrabServiceInstaller.ServiceName = "VidgrabService";
            // 
            // VidgrabInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.VidgrabProcessInstaller,
            this.VidgrabServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller VidgrabProcessInstaller;
        private System.ServiceProcess.ServiceInstaller VidgrabServiceInstaller;
    }
}