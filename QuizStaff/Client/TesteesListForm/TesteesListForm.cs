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
using DomainModel;

namespace Client
{
    public partial class TesteesListForm : DevExpress.XtraEditors.XtraForm, ITesteesListForm
    {
        public TesteesListPresenter Presenter { get; set; }
        public TesteesListForm()
        {
            InitializeComponent();
        }
        public void SetBindings(List<Testee> testees)
        {
            gridTestees.DataSource = testees;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }
    }

    

}