using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tesztecske
{
    class Program
    {
        static HashSet<string> videoExtensions = new HashSet<string>(new string[] { ".avi", ".mkv" });

        static void Main(string[] args)
        {
            renameFile(@"D:\sorozatok\Altered.Carbon.S01.WEBRip.x264.AAC.5.1-NO\lols01e02.srt", "kecske");

            //Console.ReadKey();
        }



        
    }
}
