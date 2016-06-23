using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteeApplication
{
    static class Program
    {
        private static MainForm applicationMainForm;
        public static string currentLang = "ru-RU";
        public static MainForm ApplicationMainForm { get { return applicationMainForm; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            applicationMainForm = new MainForm();
            Application.Run(new MainForm());
        }
    }
}
