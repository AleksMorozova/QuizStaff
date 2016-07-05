using Client.LoginForm;
using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
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
                IntPtr userToken = IntPtr.Zero;

                bool returnValue = LogonUser(login, domain, password, 2, 0, out userToken);

                if (returnValue)
                
                {
                    var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
                    Program.currentTestee.UserSetting = new Setting();
                    Conversion.CopyProperty(loadedUser, Program.currentTestee);
                    Conversion.CopyProperty(loadedUser.UserSetting, Program.currentTestee.UserSetting);
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
