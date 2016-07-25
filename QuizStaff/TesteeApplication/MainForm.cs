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
using TesteeApplication.TesteeSettings;
using System.Configuration;

namespace TesteeApplication
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        System.Windows.Forms.Timer timer = Program.Timer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.GetTestee(Authorization.AuthorizedTesteeName);
            TesteeSettingsForm newMDIChild = new TesteeSettingsForm();
            newMDIChild.Text = "Settings";
            newMDIChild.WindowState = FormWindowState.Maximized;
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(System.Windows.Forms.Application.ExecutablePath);
            config.AppSettings.Settings.Remove("Lang");
            config.AppSettings.Settings.Add("Lang", Program.currentLang);
            config.Save(ConfigurationSaveMode.Modified);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            QuestionForm f = new QuestionForm(Program.currentTestee);
            var timeToStart = Program.currentTestee.UserSetting.TimeOfStart;
            var userTime = new TimeSpan(timeToStart.Hour, timeToStart.Minute, timeToStart.Second);

            var aditionalHours = (Program.currentTestee.UserSetting.FrequencyOfAsking > 60) 
                ? Program.currentTestee.UserSetting.FrequencyOfAsking / 60 
                : 0;

            var aditionalMinits = (Program.currentTestee.UserSetting.FrequencyOfAsking > 60)
                ? Program.currentTestee.UserSetting.FrequencyOfAsking % 60
                : Program.currentTestee.UserSetting.FrequencyOfAsking;

            for (int i = 0; i <= Program.currentTestee.UserSetting.FrequencyOfAsking; i ++)
                if (DateTime.Now.TimeOfDay.Hours == Program.currentTestee.UserSetting.TimeOfStart.TimeOfDay.Hours + i * aditionalHours
                    && DateTime.Now.TimeOfDay.Minutes == Program.currentTestee.UserSetting.TimeOfStart.TimeOfDay.Minutes + i * aditionalMinits)
                {       
                    timer.Interval = Program.currentTestee.UserSetting.FrequencyOfAsking * 60000;
                    f.Show();
                }
        }
    }
}