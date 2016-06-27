using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTransferObject;
using System.Drawing;
using Client.TesteeQuestion;
using System.Globalization;
using System.ComponentModel;

namespace Client
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm, ILocalized
    {
        private Dictionary<Guid, bool> answers = new Dictionary<Guid,bool>();
        private TesteeQuestionViewModel model;

        public QuestionForm(TesteeDTO testee)
        {
            InitializeComponent();
            mvvmQuestionContext.ViewModelType = typeof(TesteeQuestionViewModel);
            BindCommands();
            model = mvvmQuestionContext.GetViewModel<TesteeQuestionViewModel>();
            mvvmQuestionContext.SetViewModel(typeof(TesteeQuestionViewModel), model);
            model.LoadQuestionForTestee(Program.currentTestee);
            CreateQuestionControls(model.question);

            // Send form to bottom right corner of display
            SetWindowsPosition();
        }
     
        private void BindCommands()
        {
            mvvmQuestionContext.BindCommand<TesteeQuestionViewModel, Dictionary<Guid, bool>>(buttonSend,
                (x, currentTraining) => x.SaveTesteeAnswer(currentTraining), x => answers);
        }
       
        private void SetWindowsPosition()
        {
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);

            flow.SetFlowBreak(labelQuestion, true);
        }

        public void CreateQuestionControls(QuestionDTO question)
        {
            var multiSelect = model.MultiSelect;
            labelQuestion.DataBindings.Add("Text", question, "QuestionText");
            bool selectFirstRadio = true;
            foreach (var answer in question.Answers)
            {
                ICheckControl control;
                if (multiSelect)
                {
                    control = new WrappingCheckBox();
                }
                else
                {
                    control = new WrappingRadioButton();
                }
                (control as Control).DataBindings.Add("Text", answer, "AnswerText");
                control.AnswerID = answer.Id;
                control.CheckedChanged += (sender, e) => this.answers[control.AnswerID] = control.Checked;
                if (selectFirstRadio && !multiSelect)
                {
                    control.Checked = true;
                    selectFirstRadio = false;
                }
                flow.Controls.Add((control as Control));
                flow.SetFlowBreak((control as Control), true);
            }
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            // Resize form and back it to default size to solve horizontal scroll bug
            Size defaultSize = this.Size;
            this.Size = new Size(3000, defaultSize.Height);
            this.Size = defaultSize;
        }
        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(QuestionForm));
            CultureInfo newCultureInfo = new CultureInfo(language);
            resources.ApplyResources(buttonSend, "buttonSend", newCultureInfo);           
        }
    }
}