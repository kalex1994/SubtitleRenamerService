SubtitleRenamerService
======================

A simple Windows service that automatically renames subtitle files to match the corresponding video file's name. The renaming happens when the subtitle file appears in the folder containing the corresponding video.

Installation:

1. In the App.config set the RootDirectoryOfFileWatcher setting to your root directory of videos.
2. Build the project in Release mode.
3. Open the Visual Studio Developer Command Prompt, and navigate to the folder containing the executable from the previous step.
4. Run the following: installutil SubtitleRenamerService.exe
5. Now open services.msc, locate the service and start it.
