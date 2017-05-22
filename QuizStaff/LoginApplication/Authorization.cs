using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApplication
{
    public class Authorization
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Authorization));

        public static BindingList<Permission> CurrentUserPermissions { get; set; }
        public static Testee СurrentTestee { get; set; }

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
        public static LoginResult LoginForTesteeApplication()
        {
            try
            {
                CurrentUserPermissions = new BindingList<Permission>();
                UserLoginForm dlg = new UserLoginForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (true)//LogonUser(dlg.Login, dlg.Password, dlg.Domain)
                    {
                        СurrentTestee = GetTestee(dlg.Login);
                        GetUserPermissions(dlg.Login);

                        return (СurrentTestee.Id != Guid.Empty) ?
                            CheckTesteePermission() ? LoginResult.LoggedIn : LoginResult.Failed
                            : LoginResult.NotExist;
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
                //log.Error("Error message " + ex.Message);
                return LoginResult.Failed;
            }
        }

        private static bool CheckTesteePermission()
        {
            return (CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.GetQuestion));
        }

        /// <summary>
        /// Try to log in
        /// </summary>
        public static LoginResult LoginForAdminApplication()
        {
            try
            {
                CurrentUserPermissions = new BindingList<Permission>();
                UserLoginForm dlg = new UserLoginForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var domain = Environment.UserDomainName;

                    if (dlg.Login == "admin")
                    {
                        LoginAdmin(dlg.Login);
                        return (dlg.Password == "admin") ? LoginResult.LoggedIn : LoginResult.Failed;
                    }
                    else
                    {
                        if (LogonUser(dlg.Login, dlg.Password, dlg.Domain))
                        {
                            СurrentTestee = GetTestee(dlg.Login);
                            GetUserPermissions(dlg.Login);

                            return (СurrentTestee.Id != Guid.Empty) ?
                                CheckAdminPermission() ? LoginResult.LoggedIn : LoginResult.Failed
                                : LoginResult.NotExist;
                        }

                        else
                        {
                            return LoginResult.Failed;
                        }
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

        private static bool CheckAdminPermission()
        {
            return (CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.CreateAdministrator)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditSetUp)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTestee)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTraining)
                || СurrentTestee.Login == "admin");
        }

        private static void GetUserPermissions(string login)
        {
            var userRolePermission = СurrentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var rolePermission in userRolePermission)
                foreach (var permission in rolePermission)
                    CurrentUserPermissions.Add(permission);
        }

        private static Testee GetTestee(string login)
        {
            var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
            return Conversion.ConvertTesteeFromDTO(loadedUser);
        }

        private static void LoginAdmin(string login)
        {
            СurrentTestee = new Testee() { Login = login };
        }
    }
}
