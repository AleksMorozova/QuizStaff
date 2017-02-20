using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using LoginApplication;
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
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        //Remember question form position
        public static bool FirstShow = true;
        public static int LeftPosition = 0;
        public static int TopPosition = 0;
        public static int Width = 0;
        public static int Height = 0;

        public static string СurrentLang { get; set; }
        public static Testee СurrentTestee { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            log4net.Config.XmlConfigurator.Configure();

            LoginResult loginResult = LoginResult.None;
            while (loginResult != LoginResult.LoggedIn)
            {
                loginResult = Authorization.LoginForTesteeApplication();
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
                    case LoginResult.LoggedIn: 
                        Program.СurrentTestee = Authorization.СurrentTestee;
                        log.Info("User " + СurrentTestee.Login + " was successfully login");
                        break;
                    default:
                        log.Error("Authentication error. You have no permissions to access the database. Please, contact to IT administrator");
                        break;
                }
            }

            СurrentLang = ConfigurationManager.AppSettings["Lang"];
            
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(СurrentLang);
            Application.EnableVisualStyles();
            Application.Run(new TesteeSettingsForm());
        }
    }
}
