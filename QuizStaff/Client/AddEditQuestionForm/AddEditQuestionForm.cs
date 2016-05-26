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
        private QuestionViewModel model;

        public AddEditQuestionForm()
            : this(new QuestionDTO()) { }

        public AddEditQuestionForm(QuestionDTO question)
        {
            InitializeComponent();
            mvvmQuestionContext.ViewModelType = typeof(QuestionViewModel);
            BindCommand();
            model = new QuestionViewModel();
            mvvmQuestionContext.SetViewModel(typeof(QuestionViewModel), model);
            model.Question = question;
            BindToViewModel();     
        }

        private void BindCommand()
        {
            mvvmQuestionContext.BindCommand<QuestionViewModel>(saveButton, viewModel => viewModel.Save());
        }

        private void BindToViewModel()
        {
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