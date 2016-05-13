using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.ClientsForms.LoginForm
{
    public class UserLoginPresenter
    {
            IUserLoginForm view;
            TesteeDTO currentTestee;
        public UserLoginPresenter(IUserLoginForm frm)
        {
            view = frm;
            view.btnLoginClick += Login;
            view.btnCancelClick += Cancel;
        }

        
        private void CombineParams()
        {
            currentTestee = new TesteeDTO();
            currentTestee.Login = view.Login;
            currentTestee.Password = view.Password;
            //todo: add admin value
        }
        
        
        private void Login(object sender, EventArgs e)
        {
            CombineParams();
            string reply;
            reply = ServicesHolder.ServiceClient.LoginTestee(currentTestee);
            MessageBox.Show(reply);
        }

        private void Cancel(object sender, EventArgs e)
        {
            
        }
    }
}
