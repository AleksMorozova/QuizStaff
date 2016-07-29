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
        private string login;
        public String Login 
        {
            get
            {
                if (this.loginTextEdit.Text.Contains(@"\"))
                {
                    int k = this.loginTextEdit.Text.IndexOf(@"\");
                    login = this.loginTextEdit.Text.Substring(k + 1, this.loginTextEdit.Text.Length - k - 1);

                }
                else
                {
                    login = this.loginTextEdit.Text;
                }
                return login;
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

        private string domain;
        public String Domain
        {
            get
            {
                if (this.loginTextEdit.Text.Contains(@"\"))
                {
                    int k = this.loginTextEdit.Text.IndexOf(@"\");
                    domain = this.loginTextEdit.Text.Substring(0, k);

                }
                else 
                {
                    domain = Environment.UserDomainName;
                }
                
                return domain; 
            }
            set
            {
                this.domainLlabel.Text = value;
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
            resources.ApplyResources(domainLayoutControlItem, "domainLayoutControlItem", newCultureInfo);
            resources.ApplyResources(loginButton, "loginButton", newCultureInfo);
            this.Text = resources.GetString("Title", newCultureInfo);
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            domainLlabel.Text = Environment.UserDomainName;
        }

        private void loginTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (this.loginTextEdit.Text.Contains(@"\"))
            {
                int k = this.loginTextEdit.Text.IndexOf(@"\");
                this.domainLlabel.Text = this.loginTextEdit.Text.Substring(0, k);

            }
            else
            {
                this.domainLlabel.Text = Environment.UserDomainName;
            }
        }
    }
}