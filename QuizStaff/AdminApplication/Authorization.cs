using AdminApplication.LoginForm;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApplication
{
    public class Authorization
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        public static extern bool LogonUser(
                  string lpszUsername,
                  string lpszDomain,
                  string lpszPassword,
                  int dwLogonType,
                  int dwLogonProvider,
                  out IntPtr phToken);

        public static Testee AuthorizedTeste { get; set; }

        public static string AuthorizedTesteeName { get; set; }

        /// <summary>
        /// Try to log in
        /// </summary>
        /// <param name="failMessage">message for user, when login has been failed</param>
        /// <returns>status of logging in attempt</returns>
        public static LoginResult Login(ref string failMessage)
        {
            UserLoginForm dlg = new UserLoginForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string login = dlg.Login;
                string password = dlg.Password;
                string domain = Environment.UserDomainName;
                const int LOGON32_PROVIDER_DEFAULT = 0;
                const int LOGON32_LOGON_INTERACTIVE = 2;
                IntPtr userToken = IntPtr.Zero;

                bool returnValue = LogonUser(login, domain, password, LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT, out userToken);

                if (returnValue)
                {
                    //LoginApplication.ServiceReference1.ApplicationServerClient serviceClient = new LoginApplication.ServiceReference1.ApplicationServerClient();
                    //var loadedUser = serviceClient.FindByLogin(login);
                    //AuthorizedTeste.UserSetting = new Setting();
                    //Conversion.CopyProperty(loadedUser, AuthorizedTeste);
                    //Conversion.CopyProperty(loadedUser.UserSetting, AuthorizedTeste.UserSetting);

                    AuthorizedTesteeName = login;
                    return LoginResult.LoggedIn;
                }

                else
                {
                    return LoginResult.Failed;
                }
            }

            else
            {
                System.Environment.Exit(0);
            }

            return LoginResult.Failed;
        }
    }
}
