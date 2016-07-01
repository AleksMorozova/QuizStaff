using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public class LoginRealization: ILogin
    {
        public LoginResult Login(Testee currentTestee)
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

                var loadedUser = new Testee();//ServicesHolder.ServiceClient.FindByLogin(login);
                currentTestee.UserSetting = new Setting();
                //Conversion.CopyProperty(loadedUser, currentTestee);
                //Conversion.CopyProperty(loadedUser.UserSetting, currentTestee.UserSetting);

                if (currentTestee == null)
                    return LoginResult.Failed;

                if (currentTestee.Password != password)
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
