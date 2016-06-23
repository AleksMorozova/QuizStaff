using AdminApplication;
using DataTransferObject;
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
            var user = ServiceClient.FindByLogin("omor");
            Application.Run(new MainForm());
        }
        private static AdminApplication.ServiceReference.ApplicationServerClient serviceClient;
        public static AdminApplication.ServiceReference.ApplicationServerClient ServiceClient
        {
            get
            {
                if (serviceClient == null)
                    serviceClient = new AdminApplication.ServiceReference.ApplicationServerClient();
                return serviceClient;
            }
        }
    }
}
