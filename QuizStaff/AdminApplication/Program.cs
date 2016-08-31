using ApplicationServer.DAL;
using AdminApplication.LoginForm;
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

namespace AdminApplication
{
    static class Program
    {
        //Global data
        public static string СurrentLang = "ru-RU";
        public static Testee СurrentTestee = new Testee() { IsActive = true, IsSelected = false, UserSetting = new Setting() { TimeOfStart = DateTime.Now } };
        public static BindingList<Permission> CurrentUserPermissions = new BindingList<Permission>();

        private static MainForm applicationMainForm;
        public static MainForm ApplicationMainForm { get { return applicationMainForm; } }
       
        static Program()
        {
            log4net.Config.XmlConfigurator.Configure();

        }
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
                        XtraMessageBox.Show("Authentication error. You have no permissions to access the database");
                        break;
                }
            }

            СurrentLang = ConfigurationManager.AppSettings["Lang"];
         
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(СurrentLang);
            Application.EnableVisualStyles();
            applicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }
    }
}
