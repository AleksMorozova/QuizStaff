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
        public MainForm()
        {
            InitializeComponent();
        }

        private void settingsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            config.AppSettings.Settings.Add("Lang", Program.СurrentLang);
            config.Save(ConfigurationSaveMode.Modified);
        }
    }
}