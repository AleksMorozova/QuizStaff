using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Client.AddEditTesteeForm
{
    public class AddEditTesteePresenter
    {
        private AddEditTestee currentForm;
        private Testee currentTestee;
        public AddEditTesteePresenter(AddEditTestee form)
        {
            this.currentForm = form;
        }

        public AddEditTesteePresenter(AddEditTestee form, Guid testeeID) : this(form)
        {
            currentTestee = GetTesteeByID(testeeID);
        }

        private Testee GetTesteeByID(Guid testeeID)
        {
            ServicesHolder.ServiceClient.GetTesteeByID(testeeID);
            return new Testee();
        }
    }
}
