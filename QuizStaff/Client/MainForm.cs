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
using DomainModel;
using DataTransferObject;

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
            Form f = new Form(); 
            FormManager.Instance.OpenChildForm(f, "Test");
        }

        private void testeesBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            TesteesListForm f = new TesteesListForm();
            FormManager.Instance.OpenChildForm(f, "Testees");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void trainingsBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            // TODO : Add TrainingsListForm to choose training with it
            TrainingEditForm f = new TrainingEditForm(new TrainingDTO() { TrainingTitle = "Test training", Id=System.Guid.Parse( "0cf1aca7-e3dc-47fa-96b6-55db96495545") });
            FormManager.Instance.OpenChildForm(f, "Training :");
        }
    }
}