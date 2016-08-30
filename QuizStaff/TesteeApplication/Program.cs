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
        public static bool FirstShow = true;
        public static int LeftPosition = 0;
        public static int TopPosition = 0;

        private static TesteeSettingsForm applicationMainForm;
        public static string currentLang = "ru-RU";
        public static Testee currentTestee = new Testee() { IsActive = true, IsSelected = false, UserSetting = new Setting() { TimeOfStart = DateTime.Now } };
        public static System.Windows.Forms.Timer Timer = new System.Windows.Forms.Timer();
        public static BindingList<Permission> CurrentUserPermissions = new BindingList<Permission>();

        public static DateTime AskedTime = DateTime.Now;
        public static DateTime UserTime = DateTime.Now;
        public static int QuestionAmount = 0;

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
                    case LoginResult.LoggedIn:
                        GetTestee(Authorization.AuthorizedTesteeName);
                        GetUserPermissions(Authorization.AuthorizedTesteeName);
                        break;
                }
            }

            SetUpStartTime();

            currentLang = ConfigurationManager.AppSettings["Lang"];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            Application.EnableVisualStyles();
            applicationMainForm = new TesteeSettingsForm();
            Application.Run(applicationMainForm);
            applicationMainForm.Hide();
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
       
        public static void GetUserPermissions(string login)
        {
            var userPermission = Program.currentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var p in userPermission)
                foreach (var p1 in p.Select(_ => _.Permission))
                    CurrentUserPermissions.Add(p1);

        }

        public static void GetTestee(string login)
        {
            var loadedUser = ServiceClient.FindByLogin(login);
            currentTestee = Conversion.ConvertTesteeFromDTO(loadedUser);
        }

        public static void SetUpStartTime()
        {
            AskedTime = (DateTime.Now.Hour >= Program.currentTestee.UserSetting.TimeOfStart.Hour
                && DateTime.Now.Minute >= Program.currentTestee.UserSetting.TimeOfStart.Minute)
                ? Program.currentTestee.UserSetting.TimeOfStart
                : DateTime.Now;

            UserTime = Program.currentTestee.UserSetting.TimeOfStart;
        }

        public static void SetUpStartTime(int hours, int minutes, int seconds)
        {
            AskedTime = DateTime.Now.AddHours(hours);
            AskedTime = DateTime.Now.AddMinutes(minutes);
            AskedTime = DateTime.Now.AddSeconds(seconds);
        }
    }
}
