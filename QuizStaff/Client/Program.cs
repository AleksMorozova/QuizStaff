using ApplicationServer.DAL;
using Client.ClientsForms.LoginForm;
using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        public static string currentLang = "ru-RU";
        public static TesteeDTO currentTestee = new TesteeDTO();
        public static bool AsAdmin = true;

        private enum LoginResult { None = -1, LoggedIn = 0, Failed = 1 }
        //Global data
        private static MainForm applicationMainForm;
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
                loginResult = Login(ref failMessage);
                switch (loginResult)
                {
                    case LoginResult.Failed:
                        XtraMessageBox.Show("Login is failed");
                        break;
                }
            }

            currentLang = ConfigurationManager.AppSettings["Lang"];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            Application.EnableVisualStyles();
            applicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }

        /// <summary>
        /// Try to log in
        /// </summary>
        /// <param name="failMessage">message for user, when login has been failed</param>
        /// <returns>status of logging in attempt</returns>
        private static LoginResult Login(ref string failMessage)
        {
            UserLoginForm dlg = new UserLoginForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string login = dlg.Login;
                string password = dlg.Password;

#if DEBUG
                if (string.IsNullOrWhiteSpace(dlg.Login) && string.IsNullOrWhiteSpace(dlg.Password))
                {
                    login = "admin";
                    password = "admin";
                }
#endif

                TesteeDTO user = ServicesHolder.ServiceClient.FindByLogin(login);

                    if (user == null)
                        return LoginResult.Failed;

                    if (user.Password != password)
                        return LoginResult.Failed;

                    //TODO: uncomment after implementation roles for users 
                    //DialogResult m = XtraMessageBox.Show("As admin?", "Select", MessageBoxButtons.YesNo);
                    //if (m == DialogResult.Yes)
                    //{
                    //    AsAdmin = true;
                    //}
                    //else if (m == DialogResult.No)
                    //{
                    //    AsAdmin = false;
                    //}

                return LoginResult.LoggedIn;
            }
            else
            {
                System.Environment.Exit(0);
            }

            return LoginResult.Failed;
        }
    }
}
