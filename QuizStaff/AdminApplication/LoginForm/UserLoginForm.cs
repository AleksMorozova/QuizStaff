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
using DataTransferObject;
using System.Globalization;

namespace AdminApplication.LoginForm
{
    public partial class UserLoginForm : DevExpress.XtraEditors.XtraForm
    {
        private TesteeDTO currentUser;

        public String Login 
        {
            get
            { 
                return this.loginTextEdit.Text; 
            }
            set
            { 
                this.loginTextEdit.Text = value; 
            }
        }

        public String Password 
        {
            get
            { 
                return this.passwordTextEdit.Text;
            }
            set
            { 
                this.passwordTextEdit.Text = value;
            }
        }

        public UserLoginForm()
        {
            InitializeComponent();
            Localized(System.Configuration.ConfigurationManager.AppSettings["Lang"]);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(UserLoginForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(loginLayoutControlItem, "loginLayoutControlItem", newCultureInfo);
            resources.ApplyResources(passwordLayoutControlItem, "passwordLayoutControlItem", newCultureInfo);
            resources.ApplyResources(loginButton, "loginButton", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }
    }
}