using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DomainModel;
using DataTransferObject;
using System.Globalization;
using System.Windows;
using System.Configuration;
using AdminApplication.AdminSettings;
using AdminApplication.TesteesForms.TesteesList;
using System.Reflection;
using AdminApplication.Settings;

namespace AdminApplication
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        public MainForm()
        {
            InitializeComponent();

            FormManager.LocalizedFormList = new List<System.Windows.Forms.Form>();
            FormManager.LocalizedFormList.Add(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetUpControlAccess();
        }

        private void SetUpControlAccess()
        {
            if (Program.СurrentTestee.Login != "admin")
                if (!CheckPermission(DomainModel.PermissionType.CreateAdministrator))
                {
                    testeesBarButton.Enabled = CheckPermission(DomainModel.PermissionType.EditTestee);
                    trainingsBarButton.Enabled = CheckPermission(DomainModel.PermissionType.EditTraining);
                    adminSettingsBarButtonItem.Enabled = CheckPermission(DomainModel.PermissionType.EditSetUp);
                    roleBarButton.Enabled = CheckPermission(DomainModel.PermissionType.EditSetUp);
                }
        }

        private bool CheckPermission(DomainModel.PermissionType permissionType)
        {
            return Program.CurrentUserPermissions.Select(_ => _.Type).Contains(permissionType);
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(MainForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(testeesBarButton, "testeesBarButton", newCultureInfo);
            resources.ApplyResources(trainingsBarButton, "trainingsBarButton", newCultureInfo);
            resources.ApplyResources(settingsBarButton, "settingsBarButton", newCultureInfo);
            resources.ApplyResources(reportBarButton, "reportBarButton", newCultureInfo);
            resources.ApplyResources(languageBarSubItem, "languageBarSubItem", newCultureInfo);
            resources.ApplyResources(russianBarButtonItem, "russianBarButtonItem", newCultureInfo);
            resources.ApplyResources(englishBarButtonItem, "englishBarButtonItem", newCultureInfo);
            resources.ApplyResources(adminSettingsBarButtonItem, "adminSettingsBarButtonItem", newCultureInfo);
            resources.ApplyResources(questionBarButton, "questionBarButton", newCultureInfo);
            resources.ApplyResources(roleBarButton, "roleBarButton", newCultureInfo);
            resources.ApplyResources(aboutBarButtonItem, "aboutBarButtonItem", newCultureInfo);
        }

        private void trainingsBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrainingsListForm.TrainingListForm trainingsform = new TrainingsListForm.TrainingListForm();
            FormManager.Instance.OpenChildForm(trainingsform, "Trainings");
            FormManager.LocalizedFormList.Add(trainingsform);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        private void testeesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TesteesListForm testeesform = new TesteesListForm();
            FormManager.Instance.OpenChildForm(testeesform, "Testees");
            FormManager.LocalizedFormList.Add(testeesform);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        private void russianBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("ru-RU");
            Localized("ru-RU");
            Program.СurrentLang = "ru-RU";
        }

        private void englishBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("en-US");
            Localized("en-US");
            Program.СurrentLang = "en-US";
        }

        private void adminSettingsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminSettingsForm trainingsform = new AdminSettingsForm();
            FormManager.Instance.OpenChildForm(trainingsform, "Settings");
            FormManager.LocalizedFormList.Add(trainingsform);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        private void roleBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditeRoleForm testeesform = new EditeRoleForm();
            FormManager.Instance.OpenChildForm(testeesform, "Role");
            FormManager.LocalizedFormList.Add(testeesform);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Lang");
            config.AppSettings.Settings.Add("Lang", Program.СurrentLang);
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void aboutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void reportBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reports.ReportsForm reportsForm = new Reports.ReportsForm();
            FormManager.Instance.OpenChildForm(reportsForm, "Report");
            FormManager.LocalizedFormList.Add(reportsForm);
            FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            SettingsForm testeesform = new SettingsForm();
            FormManager.Instance.OpenChildForm(testeesform, "Application settings");
            //FormManager.LocalizedFormList.Add(testeesform);
            //FormManager.Instance.LocalizedForms(Program.СurrentLang);
        }
    }
}