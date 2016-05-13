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

namespace Client.AddEditTesteeForm
{
    public partial class AddEditTestee : DevExpress.XtraEditors.XtraForm, IAddEditTesteeForm
    {
        public AddEditTesteePresenter Presenter { get; set; }
        public AddEditTestee()
        {
            InitializeComponent();
            this.Presenter = new AddEditTesteePresenter(this);
        }

        public AddEditTestee(Guid testeeID)
        {
            InitializeComponent();
            this.Presenter = new AddEditTesteePresenter(this, testeeID);
        }
    }
}