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

namespace Client.AdminSettings
{
    public partial class AdminSettingsForm : DevExpress.XtraEditors.XtraForm
    {
        private AdminSettingsViewModel model;

        public AdminSettingsForm()
        {
            InitializeComponent();

            mvvmAdminSettingsContext.ViewModelType = typeof(AdminSettingsViewModel);
            BindCommands();
            model = new AdminSettingsViewModel();
            mvvmAdminSettingsContext.SetViewModel(typeof(AdminSettingsViewModel), model);
            model.GetAllTestees();
            BindToViewModel();
        }

        private void BindCommands()
        {

        }

        private void BindToViewModel()
        {      
            mvvmAdminSettingsContext.SetBinding(testeeListGridControl, testee => testee.DataSource, "Testees");
            mvvmAdminSettingsContext.SetBinding(frequencySpinEdit, frequency => frequency.EditValue, "FrequencyOfAsking");
            mvvmAdminSettingsContext.SetBinding(questionAmountTextEdit, amount => amount.EditValue, "AmountOfQuestionsPerDay");
            mvvmAdminSettingsContext.SetBinding(timeOfAskingEditTime, time => time.EditValue, "TimeOfStart");
        }
    }
}