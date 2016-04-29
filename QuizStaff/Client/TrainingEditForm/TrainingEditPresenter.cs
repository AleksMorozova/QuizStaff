using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
using DomainModel;
using System.Windows.Forms;

namespace Client
{
    public class TrainingEditPresenter
    {
        public ITrainingEditForm Form { get; set; }
        private IApplicationServer server;

        private List<Question> questions = new List<Question>();
        // Becomes true when "Save" button on "Edit testee" form is pressed
        public bool DataChanged { get; set; }
        private Training training;

        public TrainingEditPresenter(ITrainingEditForm form, Training training)
        {
            this.server = new ApplicationServer();
            this.Form = form;
            this.Form.Presenter = this;
            this.training = training;

            //TODO: MB binding?
            this.Form.TrainingName.Text = training.TrainingTitle;
            
            this.LoadQuestions();
        }

        public void LoadQuestions()
        {
            
                this.questions = server.GetTrainingQuestions(training);
                this.Form.SetBindings(this.questions);
                this.DataChanged = false;
        }
        

        public void SaveQuestions()
        {
            this.server.SaveAllQuestions(training, this.questions);
            this.DataChanged = false;
            // TODO notify user that data saved succesfully
            MessageBox.Show("Saved");
        }
        public void Close()
        {
                this.Form.CloseEditing();
        }
        public void EditQuestion(Question question)
        {
            // TODO invoke new "Edit testee" form with testee's data in fields
            MessageBox.Show("Edit question " + question.QuestionText);
        }
        public void AddQuestion()
        {
            // TODO invoke new "Edit testee" form with blank fields
            MessageBox.Show("Add question");
        }
    }
}
