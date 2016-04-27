using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        //Global data
        private static MainForm applicationMainForm;
        /// <summary>
        /// Global access to main form need to update statusbar texts
        /// </summary>
        public static MainForm ApplicationMainForm { get { return applicationMainForm; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var service = ServicesHolder.ServiceHolderObject;

            service.ServiceClient.GetData(7);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            applicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }
    }
}
