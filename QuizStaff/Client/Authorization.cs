using Client.LoginForm;
using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class Authorization
    {
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
                
                var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
                Program.currentTestee.UserSetting = new Setting();
                Conversion.CopyProperty(loadedUser, Program.currentTestee);
                Conversion.CopyProperty(loadedUser.UserSetting, Program.currentTestee.UserSetting);

                if (Program.currentTestee == null)
                    return LoginResult.Failed;

                if (Program.currentTestee.Password != password)
                    return LoginResult.Failed;

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
