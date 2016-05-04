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
using DevExpress.XtraBars;
using Client.ClientsForms;

namespace Client
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void testBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Form f = new Form(); 
            var f = new ClientsSetupForm();
            FormManager.Instance.OpenChildForm(f, "Test");
        }

        private void testeesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TesteesListForm f = new TesteesListForm();
            FormManager.Instance.OpenChildForm(f, "Testees");
        }
    }
}