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
using TesteeApplication.TesteeQuestion;

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
       //     timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Program.UserTime != Program.currentTestee.UserSetting.TimeOfStart)
            {
                Program.SetUpStartTime();
            }

            if (DateTime.Now.TimeOfDay.Hours == Program.AskedTime.Hour 
                && DateTime.Now.TimeOfDay.Minutes == Program.AskedTime.Minute 
                && Program.QuestionAmount <= Program.currentTestee.UserSetting.AmountOfQuestionsPerDay)
            {
                Program.AskedTime = DateTime.Now;
                TesteeQuestionForm questionForm = new TesteeQuestionForm(Program.currentTestee);
                timer.Stop();
                questionForm.Show();
            }
        }
    }
}