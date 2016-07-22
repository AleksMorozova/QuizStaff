using AdminApplication;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteeApplication
{
    static class Program
    {
        private static MainForm applicationMainForm;
        public static string currentLang = "ru-RU";
        public static Testee currentTestee = new Testee() { IsActive = true, IsSelected = false, UserSetting = new Setting() { TimeOfStart = DateTime.Now } };
        public static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();

        public static MainForm ApplicationMainForm { get { return applicationMainForm; } }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            string failMessage = String.Empty;
            LoginResult loginResult = LoginResult.None;
            while (loginResult != LoginResult.LoggedIn)
            {
                loginResult = Authorization.Login(ref failMessage);
                switch (loginResult)
                {
                    case LoginResult.Failed:
                        XtraMessageBox.Show("Login is failed");
                        break;
                    case LoginResult.LoggedIn:
                        GetTestee(Authorization.AuthorizedTesteeName);
                        break;
                }
            }

            currentLang = ConfigurationManager.AppSettings["Lang"];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            Application.EnableVisualStyles();
            applicationMainForm = new MainForm();
            Application.Run(applicationMainForm);
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

        static void GetTestee(string login)
        {
            var loadedUser = ServiceClient.FindByLogin(login);
            currentTestee = Conversion.ConvertTesteeFromDTO(loadedUser);
        }
    }
}
