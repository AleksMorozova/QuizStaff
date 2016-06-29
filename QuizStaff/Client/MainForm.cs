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
using Client.AdminSettings;
using Client.TesteesForms.TesteesList;

namespace Client
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        System.Windows.Forms.Timer timer = Program.Timer;

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
            //TODO: uncomment after implementation of users role
            //ProvideAccessToMenuItems();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
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

        private void questionBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuestionForm questionform = new QuestionForm(Program.currentTestee);            
            FormManager.Instance.LocalizedForms(Program.currentLang);
            questionform.ShowDialog();
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

        //TODO: implement visibility of menu item depends on users role
        private void ProvideAccessToMenuItems()
        {
            if (Program.AsAdmin)
            {
                settingsBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                questionBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else 
            {
                testeesBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                trainingsBarButton.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                adminSettingsBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Lang");
            config.AppSettings.Settings.Add("Lang", Program.currentLang);
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // TODO: uncommit after implementation of authentication
            QuestionForm f = new QuestionForm(Program.currentTestee);
            var timeToStart = Program.currentTestee.UserSetting.TimeOfStart;
            var userTime = new TimeSpan(timeToStart.Hour, timeToStart.Minute, timeToStart.Second);//new TimeSpan(timeToStart.Hour, timeToStart.Minute + i, timeToStart.Second)
            //for (int i = 0; i <= Program.currentTestee.UserSetting.FrequencyOfAsking; i++)
                if (DateTime.Now.TimeOfDay.Hours == Program.currentTestee.UserSetting.TimeOfStart.TimeOfDay.Hours
                    && DateTime.Now.TimeOfDay.Minutes == Program.currentTestee.UserSetting.TimeOfStart.TimeOfDay.Minutes)
                {
                    f.Show();
                    timer.Stop();
                }
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
    }
}