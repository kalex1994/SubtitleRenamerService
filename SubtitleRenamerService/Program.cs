using System.ServiceProcess;

namespace SubtitleRenamerService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun = new ServiceBase[]
            {
                new SubtitleRenameService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
