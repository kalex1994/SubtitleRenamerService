SubtitleRenamerService
======================

A simple Windows service that renames subtitle files, when they appear in a folder.

Installation:

1. In the App.config set the RootDirectoryOfFileWatcher setting to your root directory of videos.
2. Build the project in Release mode.
3. Open the Visual Studio Developer Command Prompt, and navigate to the folder containing the executable from the previous step.
4. Run the following: installutil SubtitleRenamerService.exe
5. Now open services.msc, locate the service and start it. After that it should run automatically after a system restart.
