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
        public String Login
        {
            get
            {
                int index = this.loginTextEdit.Text.Contains(@"\")
                    ? this.loginTextEdit.Text.IndexOf(@"\")
                    : 0;

                return this.loginTextEdit.Text.Contains(@"\")
                    ? this.loginTextEdit.Text.Substring(index + 1, this.loginTextEdit.Text.Length - index - 1)
                    : this.loginTextEdit.Text;
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

        public String Domain
        {
            get
            {
                int index = this.loginTextEdit.Text.Contains(@"\")
                    ? this.loginTextEdit.Text.IndexOf(@"\")
                    : 0;

                return this.loginTextEdit.Text.Contains(@"\") ?
                    this.loginTextEdit.Text.Substring(0, index)
                    : Environment.UserDomainName;
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
            domainLlabel.Text = Environment.UserDomainName;
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

        private void loginTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            int index = this.loginTextEdit.Text.Contains(@"\")
                ? this.loginTextEdit.Text.IndexOf(@"\")
                : 0;

            this.domainLlabel.Text = this.loginTextEdit.Text.Contains(@"\")
                ? this.loginTextEdit.Text.Substring(0, index)
                : Environment.UserDomainName;
        }
    }
}