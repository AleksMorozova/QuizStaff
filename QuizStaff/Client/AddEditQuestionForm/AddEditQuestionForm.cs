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
using DataTransferObject;

namespace Client.AddEditQuestionForm
{
    public partial class AddEditQuestionForm : DevExpress.XtraEditors.XtraForm
    {
        //private readonly AddEditQuestionPresenter presenter;
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(Guid.Empty) { }

        public AddEditQuestionForm(Guid id)
        {
            InitializeComponent();
            mvvmQuestionContext.ViewModelType = typeof(QuestionViewModel);
            model = new QuestionViewModel();
            BindCommand();
            mvvmQuestionContext.SetViewModel(typeof(QuestionViewModel), model);
            model.LoadQuestion(id);
            BindToViewModel();            
        }

        private void BindCommand()
        {
            //Binding command
            mvvmQuestionContext.BindCommand<QuestionViewModel, QuestionDTO>(saveButton, (viewModel, question) => viewModel.SaveQuestion(question), x => Question);
            mvvmQuestionContext.BindCommand<QuestionViewModel>(cancelButton, viewModel => viewModel.Cancel());
        }

        private void BindToViewModel()
        {
            //binding property
            mvvmQuestionContext.SetBinding(questionTextEdit, questionText => questionText.EditValue, "Question.QuestionText");
            mvvmQuestionContext.SetBinding(answersGridControl, answers => answers.DataSource, "Question.Answers");
        }

        public QuestionDTO Question 
        { 
            get
            { 
                return model.Question; 
            }
            set
            {
                model.Question = value;
            }
        }
    
    }
}