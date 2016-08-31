using AdminApplication.LoginForm;
using DomainModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.ComponentModel;
using DataTransferObject;

namespace TesteeApplication
{
    public class Authorization
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Authorization));

        private static BindingList<Permission> CurrentUserPermissions = new BindingList<Permission>();

        /// <summary>
        /// Domain authorization
        /// </summary>
        /// <param name="login">Authorized users login</param>
        /// <param name="password">Authorized users password</param>
        /// <param name="domain">Authorized users domain</param>
        /// <returns>Authorization Result</returns>
        public static bool LogonUser(string login, string password, string domain)
        {
            try
            {
                using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domain))
                {
                    //validate the credentials
                    return principalContext.ValidateCredentials(login, password, ContextOptions.Negotiate);
                }
            }
            catch (PrincipalServerDownException ex)
            {
                log.Error("Error at LogonUser. Problem with ValidateCredentials(). Error Message " + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Try to log in
        /// </summary>
        /// <param name="failMessage">message for user, when login has been failed</param>
        /// <returns>status of logging in attempt</returns>
        public static LoginResult Login(ref string failMessage)
        {
            try
            {
                UserLoginForm dlg = new UserLoginForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    bool logonResult = LogonUser(dlg.Login, dlg.Password, dlg.Domain);

                    if (LogonUser(dlg.Login, dlg.Password, dlg.Domain))
                    {
                        Program.СurrentTestee = GetTestee(dlg.Login);
                        Testee loadTestee = Program.СurrentTestee;
                        GetUserPermissions(dlg.Login);

                        if (loadTestee.Id != Guid.Empty)
                        {
                            if (CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.GetQuestion))
                            {
                                return LoginResult.LoggedIn;
                            }
                            else
                            {
                                return LoginResult.NoPermissions;
                            } 
                        }
                        else
                        {
                            return LoginResult.NotExist;
                        }
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

            catch (Exception ex)
            {
                log.Error("Error message " + ex.Message);
                return LoginResult.Failed;
            }
        }

        private static void GetUserPermissions(string login)
        {
            var userRolePermission = Program.СurrentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var rolePermission in userRolePermission)
                foreach (var permission in rolePermission.Select(_ => _.Permission))
                    CurrentUserPermissions.Add(permission);
        }

        private static Testee GetTestee(string login)
        {
            var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
            return Conversion.ConvertTesteeFromDTO(loadedUser);
        }
    }
}
