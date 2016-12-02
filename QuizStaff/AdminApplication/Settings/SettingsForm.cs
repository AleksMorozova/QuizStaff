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

namespace AdminApplication.Settings
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
        
            checkedComboBoxEdit1.Properties.Items.Add("Monday", false);
            checkedComboBoxEdit1.Properties.Items.Add("Tuesday", true);
            checkedComboBoxEdit1.Properties.Items.Add("Wednesday", false);
            checkedComboBoxEdit1.Properties.Items.Add("Thursday", false);
            checkedComboBoxEdit1.Properties.Items.Add("Friday", false);
            checkedComboBoxEdit1.Properties.Items.Add("Saturday", false); 
            checkedComboBoxEdit1.Properties.Items.Add("Sunday", false);
        }
    }
}