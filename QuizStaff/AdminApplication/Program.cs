﻿using ApplicationServer.DAL;
using AdminApplication.LoginForm;
using DataTransferObject;
using DevExpress.XtraEditors;
using DomainModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginApplication;
using System.ComponentModel;

namespace AdminApplication
{
    static class Program
    {
        public static string currentLang = "ru-RU";
        public static Testee currentTestee = new Testee();
        public static bool AsAdmin = true;
        public static BindingList<Permission> CurrentUserPermissions = new BindingList<Permission>();

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
                loginResult = LoginApplication.Authorization.Login(ref failMessage);
                switch (loginResult)
                {
                    case LoginResult.Failed:
                        XtraMessageBox.Show("Login is failed");
                        break;
                    case LoginResult.LoggedIn:
                        GetTestee(LoginApplication.Authorization.AuthorizedTesteeName);
                        GetUserPermissions(LoginApplication.Authorization.AuthorizedTesteeName);
                        break;
                }
            }

            currentLang = ConfigurationManager.AppSettings["Lang"];
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(currentLang);

            Application.EnableVisualStyles();
            applicationMainForm = new MainForm();
            Application.Run(ApplicationMainForm);
        }

        static void GetTestee(string login)
        {
            var loadedUser = ServicesHolder.ServiceClient.FindByLogin(login);
            currentTestee = Conversion.ConvertTesteeFromDTO(loadedUser);
        }

        static void GetUserPermissions(string login)
        {
            var userPermission = Program.currentTestee.Roles.Select(_ => _.Role.Permissions);
            foreach (var p in userPermission)
                foreach (var p1 in p.Select(_ => _.Permission))
                    CurrentUserPermissions.Add(p1);

        }
    }
}
