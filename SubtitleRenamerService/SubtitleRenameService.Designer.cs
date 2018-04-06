using System.Configuration;

namespace SubtitleRenamerService
{
    partial class SubtitleRenameService
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
            this.subtitleWatcher = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.subtitleWatcher)).BeginInit();
            // 
            // subtitleWatcher
            // 
            this.subtitleWatcher.EnableRaisingEvents = true;
            this.subtitleWatcher.IncludeSubdirectories = true;
            this.subtitleWatcher.NotifyFilter = System.IO.NotifyFilters.FileName;
            this.subtitleWatcher.Path = ConfigurationManager.AppSettings["RootDirectoryOfFileWatcher"];
            // 
            // SubtitleRenameService
            // 
            this.ServiceName = "SubtitleRenameService";
            ((System.ComponentModel.ISupportInitialize)(this.subtitleWatcher)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher subtitleWatcher;
    }
}
