using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.ComponentModel;
using LoginApplication;

namespace AdminApplication
{
    static class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        //Global data
        public static string СurrentLang { get; set; }
        public static Testee СurrentTestee { get; set; }
        public static BindingList<Permission> CurrentUserPermissions { get; set; }
        public static MainForm ApplicationMainForm { get; set; }

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
                loginResult = Authorization.LoginForAdminApplication();
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
                        СurrentTestee = Authorization.СurrentTestee;
                        CurrentUserPermissions = Authorization.CurrentUserPermissions;
                        log.Info("User " + СurrentTestee.Login + " was successfully login");
                        break;
                    default:
                        XtraMessageBox.Show("Authentication error. Please, contact to IT administrator");
                        log.Error("Authentication error. You have no permissions to access the database. Please, contact to IT administrator");
                        break;
                }
            }

            СurrentLang = ConfigurationManager.AppSettings["Lang"];
         
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(СurrentLang);
            Application.EnableVisualStyles();
            ApplicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }
    }
}
