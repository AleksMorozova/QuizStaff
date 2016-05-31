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
using System.Globalization;

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
            var formSets = new ClientsForms.ClientsSetupForm();
            formSets.ShowDialog();
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
            TrainingsListForm.TrainingListForm trainingsform = new TrainingsListForm.TrainingListForm();
            FormManager.Instance.OpenChildForm(trainingsform, "Trainings");
            FormManager.childForms.Add(trainingsform);

            //TrainingEditForm f = new TrainingEditForm(new TrainingDTO() { TrainingTitle = "Test training", Id=System.Guid.Parse( "0cf1aca7-e3dc-47fa-96b6-55db96495545") });
            //FormManager.Instance.OpenChildForm(f, "Training :");
        }

        private void loginBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new ClientsForms.LoginForm.UserLoginForm();
            f.ShowDialog();
        }

        private void questionBarButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            var f = new QuestionForm(new TesteeDTO() { Id = Guid.NewGuid() });
            f.ShowDialog();
        }

        private void Localized(string language) 
        {
            var resources = new ComponentResourceManager(typeof(MainForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(testeesBarButton, "testeesBarButton", newCultureInfo);
            resources.ApplyResources(trainingsBarButton, "trainingsBarButton", newCultureInfo);
            resources.ApplyResources(settingsBarButton, "settingsBarButton", newCultureInfo);
            resources.ApplyResources(languageBarSubItem, "languageBarSubItem", newCultureInfo);
            resources.ApplyResources(russianBarButtonItem, "russianBarButtonItem", newCultureInfo);
            resources.ApplyResources(englishBarButtonItem, "englishBarButtonItem", newCultureInfo);
        }

        private void russianBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("ru-RU");
            Localized("ru-RU");
        }

        private void englishBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormManager.Instance.LocalizedForms("en-US");
            Localized("en-US");
        }
    }
}