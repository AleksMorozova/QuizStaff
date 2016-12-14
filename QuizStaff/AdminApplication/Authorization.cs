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

namespace AdminApplication
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
        public static LoginResult Login()
        {
            try
            {
                UserLoginForm dlg = new UserLoginForm();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (LogonUser(dlg.Login, dlg.Password, dlg.Domain))
                    {
                        Program.СurrentTestee = GetTestee(dlg.Login);
                        GetUserPermissions(dlg.Login);

                        return (Program.СurrentTestee.Id != Guid.Empty) ?
                            CheckPermission() ? LoginResult.LoggedIn : LoginResult.Failed
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
                log.Error("Error message " + ex.Message);
                //TODO: return error that somtings was wrong with server
                return LoginResult.Failed;
            }
        }

        private static bool CheckPermission()
        {
            bool permission = (CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.CreateAdministrator)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditSetUp)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTestee)
                || CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTraining));

            //TODO: return permissions
            return true;
        }

        private static void GetUserPermissions(string login)
        {
            var userRolePermission = Program.СurrentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var rolePermission in userRolePermission)
                foreach (var permission in rolePermission.Select(_ => _.Permission))
                    CurrentUserPermissions.Add(permission);

            Program.CurrentUserPermissions = CurrentUserPermissions;
        }

        private static Testee GetTestee(string login)
        {
            var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
            return Conversion.ConvertTesteeFromDTO(loadedUser);
        }
    }
}
