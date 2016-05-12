using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ClientsForms.LoginForm
{
    public interface IUserLoginForm
    {
        String Login { get; set; }
        String Password { get; set; }
        Boolean LoginAsAdmin { get; set; }
        event EventHandler btnLoginClick;
        event EventHandler btnCancelClick;

        UserLoginPresenter Presenter { get; set; }
        
    }
}
