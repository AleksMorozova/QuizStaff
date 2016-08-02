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
        public static string currentLang = "ru-RU";
        public static Testee currentTestee = new Testee();
        public static bool AsAdmin = true;
        public static BindingList<Permission> CurrentUserPermissions = new BindingList<Permission>();
        //Global data
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
                    case LoginResult.LoggedIn:
                        GetTestee(Authorization.AuthorizedTesteeName);
                        GetUserPermissions(Authorization.AuthorizedTesteeName);
                        break;
                }
            }

            currentLang = ConfigurationManager.AppSettings["Lang"];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            Application.EnableVisualStyles();
            applicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }

        public static void GetTestee(string login)
        {
            var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
            currentTestee = Conversion.ConvertTesteeFromDTO(loadedUser);
        }

        public static void GetUserPermissions(string login)
        {
            var userPermission = Program.currentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var p in userPermission)
                foreach (var p1 in p.Select(_ => _.Permission))
                    CurrentUserPermissions.Add(p1);
        }
    }
}
