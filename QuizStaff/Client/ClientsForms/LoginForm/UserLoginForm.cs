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

namespace Client.ClientsForms.LoginForm
{
    public partial class UserLoginForm : DevExpress.XtraEditors.XtraForm, IUserLoginForm
    {
        public UserLoginPresenter Presenter { get; set; }
        public String Login {
            get
            { return this.loginTextEdit.Text; }
            set
            { this.loginTextEdit.Text = value; }
        }
        public String Password {
            get
            { return this.passwordTextEdit.Text; }
            set
            { this.passwordTextEdit.Text = value; }
        }
        public Boolean LoginAsAdmin
        {
            get
            { return this.asAdminBox.Checked; }
            set
            { this.asAdminBox.Checked = value; }
        }
        public event EventHandler btnLoginClick;
        public event EventHandler btnCancelClick;


        public UserLoginForm()
        {
            InitializeComponent();
            Presenter = new UserLoginPresenter(this);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (btnLoginClick != null) btnLoginClick(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (btnCancelClick != null) btnCancelClick(this, EventArgs.Empty);
            Close();
        }
    }
}