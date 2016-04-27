using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Server;

namespace Client
{
    public class TesteesListPresenter
    {
        public ITesteesListForm Form { get; private set; }
        private IApplicationServer server;
        private List<Testee> testees = new List<Testee>();

        public TesteesListPresenter(ITesteesListForm form)
        {
            this.server = new ApplicationServer();
            this.testees = server.GetAllTestees();

            this.Form = form;
            this.Form.Presenter = this;
            this.Form.SetBindings(this.testees);
        }

        public void Show()
        {
            this.Form.Show();
        }
    }
    
}
