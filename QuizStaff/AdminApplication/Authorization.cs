﻿using AdminApplication.LoginForm;
using DomainModel;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;

namespace AdminApplication
{
    public class Authorization
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(Authorization));

        public static Testee AuthorizedTeste { get; set; }

        public static string AuthorizedTesteeName { get; set; }

        static string login;
        static string password;
        static string domain;

        public static bool LogonUser()
        {
            using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, domain))
            {
                //validate the credentials
                return pc.ValidateCredentials(login, password);
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
                    login = dlg.Login;
                    password = dlg.Password;
                    domain = dlg.Domain;

                    bool logonResult = LogonUser();

                    if (logonResult)
                    {
                        AuthorizedTesteeName = login;
                        Program.GetTestee(AuthorizedTesteeName);
                        Program.GetUserPermissions(AuthorizedTesteeName);

                        Testee loadTestee = Program.currentTestee;

                        if (loadTestee.Id != Guid.Empty)
                        {
                            return LoginResult.LoggedIn;
                            if (Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTestee)
                                || Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTraining)
                                || Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditSetUp))
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
                log.Error("Error message "+ex.Message);
                return LoginResult.Failed;
            }
        }
    }
}