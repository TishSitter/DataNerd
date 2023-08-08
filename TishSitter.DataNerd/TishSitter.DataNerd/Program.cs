using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using log4net;
using log4net.Config;

using TishSitter.DataNerd.Database;
using TishSitter.DataNerd.Forms;

namespace TishSitter.DataNerd
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BasicConfigurator.Configure();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
