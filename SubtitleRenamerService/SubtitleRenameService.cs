using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text.RegularExpressions;

namespace SubtitleRenamerService
{
    public partial class SubtitleRenameService : ServiceBase
    {
        private static readonly HashSet<string> videoExtensions = new HashSet<string>(new string[] { ".avi", ".mkv" });

        public SubtitleRenameService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            this.subtitleWatcher.Created += new FileSystemEventHandler(this.OnFileCreated);
        }

        private void OnFileCreated(object sender, FileSystemEventArgs eventArgs)
        {
            try
            {
                if (Path.GetExtension(eventArgs.FullPath).EndsWith(".srt"))
                {
                    string subtitlePath = eventArgs.FullPath;
                    string matchingVideoPath = SearchForMatchingVideo(subtitlePath);

                    if (matchingVideoPath == null)
                    {
                        return;
                    }

                    string videoName = Path.GetFileNameWithoutExtension(matchingVideoPath);
                    RenameSubtitleFile(subtitlePath, videoName);
                }
            }
            catch(Exception e)
            {
                Trace.TraceError("Unexpected exception happened while renaming subtitle: " + e);
            }
        }

        private void RenameSubtitleFile(string filePath, string newName)
        {
            Microsoft.VisualBasic.FileIO.FileSystem.RenameFile(filePath, newName + ".srt");
        }

        private string SearchForMatchingVideo(string subtitlePath)
        {
            string subtitleSeasonAndEpisode = GetSeasonAndEpisode(subtitlePath);

            if (subtitleSeasonAndEpisode == null)
            {
                return null;
            }

            string directoryPath = Path.GetDirectoryName(subtitlePath);
            IEnumerable<string> videoPaths = GetVideosFromDirectory(directoryPath);

            return SearchForMatchingVideo(subtitleSeasonAndEpisode, videoPaths);
        }

        private IEnumerable<string> GetVideosFromDirectory(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath);

            return files.Where(f => videoExtensions.Contains(Path.GetExtension(f)));
        }

        private string SearchForMatchingVideo(string subtitleSeasonAndEpisode, IEnumerable<string> videoPaths)
        {
            foreach (string videoPath in videoPaths)
            {
                string videoSeasonAndEpisode = GetSeasonAndEpisode(videoPath);
                if (string.Equals(subtitleSeasonAndEpisode, videoSeasonAndEpisode, StringComparison.CurrentCultureIgnoreCase))
                {
                    return videoPath;
                }
            }

            return null;
        }

        private string GetSeasonAndEpisode(string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            Regex regex = new Regex(@"(s\d{0,3}e\d{0,3})", RegexOptions.IgnoreCase);
            Match match = regex.Match(fileName);

            if (match.Success)
            {
                return match.ToString();
            }

            return null;
        }
    }
}
