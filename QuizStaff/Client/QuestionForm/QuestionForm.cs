using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataTransferObject;
using System.Drawing;

namespace Client
{
    public partial class QuestionForm : DevExpress.XtraEditors.XtraForm, IQuestionForm
    {
        public QuestionPresenter Presenter { get; set; }
        public QuestionForm(QuestionDTO question, TesteeDTO testee)
        {
            InitializeComponent();
            Presenter = new QuestionPresenter(this, question, testee);
            // Send form to bottom right corner of display
            var screen = Screen.FromPoint(this.Location);
            this.Location = new Point(screen.WorkingArea.Right - this.Width, screen.WorkingArea.Bottom - this.Height);

            flow.SetFlowBreak(labelQuestion, true);
        }

        public void CreateQuestionControls(QuestionDTO question, IDictionary<Guid, bool> testeeAnswers, bool multiSelect)
        {
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
                control.AnswerID = answer.ID;
                control.CheckedChanged += (sender, e) => testeeAnswers[control.AnswerID] = control.Checked;
                if (selectFirstRadio && !multiSelect)
                {
                    control.Checked = true;
                    selectFirstRadio = false;
                }
                flow.Controls.Add((control as Control));
                flow.SetFlowBreak((control as Control), true);
            }
        }

        public void NotifyNoAnswersChecked()
        {
            MessageBox.Show("You must select at least 1 answer.");
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Presenter.Send();
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            // Resize form and back it to default size to solve horizontal scroll bug
            Size defaultSize = this.Size;
            this.Size = new Size(3000, defaultSize.Height);
            this.Size = defaultSize;
        }
    }
}