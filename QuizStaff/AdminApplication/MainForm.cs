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

        private void testBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formSets = new TesteeSettings.TesteeSettingsForm();
            formSets.ShowDialog();
        }

        private void testeesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TesteesListForm testeesform = new TesteesListForm();
            FormManager.Instance.OpenChildForm(testeesform, "Testees");
            FormManager.LocalizedFormList.Add(testeesform);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CheckPermission();
        }

        private void CheckPermission()
        {
            if (!Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.CreateAdministrator))
            {       
                testeesBarButton.Enabled = Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTestee);
                trainingsBarButton.Enabled = Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditTraining);
                adminSettingsBarButtonItem.Enabled = Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditSetUp);
                roleBarButton.Enabled = Program.CurrentUserPermissions.Select(_ => _.Type).Contains(DomainModel.PermissionType.EditSetUp);
            }
        }

        private void trainingsBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TrainingsListForm.TrainingListForm trainingsform = new TrainingsListForm.TrainingListForm();
            FormManager.Instance.OpenChildForm(trainingsform, "Trainings");
            FormManager.LocalizedFormList.Add(trainingsform);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        private void loginBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new LoginForm.UserLoginForm();
            f.ShowDialog();
        }

        public void Localized(string language) 
        {
            var resources = new ComponentResourceManager(typeof(MainForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(testeesBarButton, "testeesBarButton", newCultureInfo);
            resources.ApplyResources(trainingsBarButton, "trainingsBarButton", newCultureInfo);
            resources.ApplyResources(settingsBarButton, "settingsBarButton", newCultureInfo);
            resources.ApplyResources(languageBarSubItem, "languageBarSubItem", newCultureInfo);
            resources.ApplyResources(russianBarButtonItem, "russianBarButtonItem", newCultureInfo);
            resources.ApplyResources(englishBarButtonItem, "englishBarButtonItem", newCultureInfo);
            resources.ApplyResources(adminSettingsBarButtonItem, "adminSettingsBarButtonItem", newCultureInfo);
            resources.ApplyResources(questionBarButton, "questionBarButton", newCultureInfo);
            resources.ApplyResources(roleBarButton, "roleBarButton", newCultureInfo);
        }

        private void russianBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("ru-RU");
            Localized("ru-RU");
            Program.currentLang = "ru-RU";
        }

        private void englishBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("en-US");
            Localized("en-US");
            Program.currentLang = "en-US";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Lang");
            config.AppSettings.Settings.Add("Lang", Program.currentLang);
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void adminSettingsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AdminSettingsForm trainingsform = new AdminSettingsForm();
            FormManager.Instance.OpenChildForm(trainingsform, "Settings");
            FormManager.LocalizedFormList.Add(trainingsform);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }

        private void settingsBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var formSets = new TesteeSettings.TesteeSettingsForm();
            formSets.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditeRoleForm testeesform = new EditeRoleForm();
            FormManager.Instance.OpenChildForm(testeesform, "Role");
            FormManager.LocalizedFormList.Add(testeesform);
            FormManager.Instance.LocalizedForms(Program.currentLang);
        }
    }
}