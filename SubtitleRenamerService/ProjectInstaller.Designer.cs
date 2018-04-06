﻿namespace SubtitleRenamerService
{
    partial class ProjectInstaller
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
            this.SubtitleRenameServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.SubtitleRenamerServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // SubtitleRenameServiceProcessInstaller
            // 
            this.SubtitleRenameServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.SubtitleRenameServiceProcessInstaller.Password = null;
            this.SubtitleRenameServiceProcessInstaller.Username = null;
            // 
            // SubtitleRenamerServiceInstaller
            // 
            this.SubtitleRenamerServiceInstaller.Description = "Subtitle renamer.";
            this.SubtitleRenamerServiceInstaller.ServiceName = "SubtitleRenameService";
            this.SubtitleRenamerServiceInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.SubtitleRenameServiceProcessInstaller,
            this.SubtitleRenamerServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller SubtitleRenameServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller SubtitleRenamerServiceInstaller;
    }
}