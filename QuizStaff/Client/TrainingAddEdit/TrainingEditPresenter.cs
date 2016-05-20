using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
using DomainModel;
using System.Windows.Forms;
using DataTransferObject;

namespace Client
{
    public class TrainingEditPresenter
    {
        public ITrainingEditForm Form { get; set; }
        private Client.ServiceReference.ApplicationServerClient server;

        private List<QuestionDTO> questions = new List<QuestionDTO>();
        // Becomes true when "Save" button on "Edit testee" form is pressed
        public bool DataChanged { get; set; }
        
        private TrainingDTO training;

        public TrainingEditPresenter(ITrainingEditForm form)
        {
            this.server = ServicesHolder.ServiceClient;
            this.Form = form;
            this.Form.Presenter = this;
        }

        public void LoadTraining(TrainingDTO training)
        {
            this.training = training;
            this.training.Questions.Add(new QuestionDTO() { QuestionText = "asfraesw"});
            //TODO: MB binding?
            this.Form.TrainingName.Text = training.TrainingTitle;
            this.LoadQuestions();
        }
        
        public void LoadQuestions()
        {
                this.questions = server.GetTrainingQuestions(training).ToList();
                this.Form.SetBindings(this.questions);
                this.DataChanged = false;
        }
        
        public void SaveQuestions()
        {
            //this.server.SaveAllQuestions(training, this.questions);
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
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm(new Guid());
            questionForm.ShowDialog();
        }

        public void AddQuestion()
        {
            AddEditQuestionForm.AddEditQuestionForm questionForm = new AddEditQuestionForm.AddEditQuestionForm();
            questionForm.ShowDialog();
            this.training.Questions.Add(questionForm.Question);
        }
    }
}
