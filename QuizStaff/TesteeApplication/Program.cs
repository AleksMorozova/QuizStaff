using AdminApplication;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteeApplication.TesteeSettings;

namespace TesteeApplication
{
    static class Program
    {
        //REmember question form position
        public static bool FirstShow = true;
        public static int LeftPosition = 0;
        public static int TopPosition = 0;

        private static TesteeSettingsForm applicationMainForm;
        public static string СurrentLang = "ru-RU";
        public static Testee СurrentTestee = new Testee() { IsActive = true, IsSelected = false, UserSetting = new Setting() { TimeOfStart = DateTime.Now }};

        public static TesteeSettingsForm ApplicationMainForm { get { return applicationMainForm; } }
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
                        XtraMessageBox.Show("Authorization error. User authentication failed");
                        break;
                    case LoginResult.NotExist:
                        XtraMessageBox.Show("Authorization error. There is no match of login and password in database. Please, contact to IT administrator");
                        break;
                    case LoginResult.NoPermissions:
                        XtraMessageBox.Show("Authentication error. You have no permissions to access the database. Please, contact to IT administrator");
                        break;
                }
            }

            СurrentLang = ConfigurationManager.AppSettings["Lang"];
            
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(СurrentLang);
            Application.EnableVisualStyles();
            applicationMainForm = new TesteeSettingsForm();
            Application.Run(applicationMainForm);
        }
    }
}
