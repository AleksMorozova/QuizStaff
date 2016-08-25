using System;
using DomainModel;
using System.Globalization;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TesteeApplication.TesteeQuestion;

namespace TesteeApplication.TesteeSettings
{
    public partial class TesteeSettingsForm : DevExpress.XtraEditors.XtraForm//, ILocalized
    {
        private TesteeSettingsViewModel model;
        private bool wasShow = true;
        System.Windows.Forms.Timer timer = Program.Timer;

        public TesteeSettingsForm()
        {
            InitializeComponent();
            Localized(Program.currentLang);
            SetUpComboBox();

            mvvmTesteeSettingsContext.ViewModelType = typeof(TesteeSettingsViewModel);
            model = mvvmTesteeSettingsContext.GetViewModel<TesteeSettingsViewModel>();
            mvvmTesteeSettingsContext.SetViewModel(typeof(TesteeSettingsViewModel), model);

            BindCommands();
            SetControlAccess(model.UserSetting.CanUserEdit);
            BindToViewModel();
        }

        private void BindCommands()
        {
            mvvmTesteeSettingsContext.BindCommand<TesteeSettingsViewModel>(saveButton, setting => setting.Save());
            mvvmTesteeSettingsContext.BindCommand<TesteeSettingsViewModel>(cancelButton, setting => setting.Cancel());
        }

        private void BindToViewModel()
        {
            //TODO: Rewrite binding to mvvmTesteeSettingsContext bindings
            var inner = new BindingSource { DataSource = model.UserSetting };
            questionAmountSpinEdit.DataBindings.Add("EditValue", inner, "AmountOfQuestionsPerDay");
            hoursSpinEdit.DataBindings.Add("EditValue", inner, "FrequencyOfAsking");
            timeOfAskingEditTime.DataBindings.Add("EditValue", inner, "TimeOfStart");
        }

        private void SetControlAccess(bool canEdit)
        {
            questionAmountSpinEdit.Enabled = canEdit;
            hoursSpinEdit.Enabled = canEdit;
            timeOfAskingEditTime.Enabled = canEdit;
        }

        public void Localized(string language)
        {
            var resources = new ComponentResourceManager(typeof(TesteeSettingsForm));
            CultureInfo newCultureInfo = new CultureInfo(language);

            resources.ApplyResources(languageLayoutControlGroup, "languageLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(intervalIayoutControlGroup, "intervalIayoutControlGroup", newCultureInfo);
            resources.ApplyResources(intervalLabelControl, "intervalLabelControl", newCultureInfo);
            resources.ApplyResources(hoursEditLayoutControlItem, "hoursEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(minuteLayoutControlItem, "minuteLayoutControlItem", newCultureInfo);
            resources.ApplyResources(secondLayoutControlItem, "secondLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startLayoutControlGroup, "startLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(timeOfAskingEditTimeLayoutControlItem, "timeOfAskingEditTimeLayoutControlItem", newCultureInfo);
            resources.ApplyResources(recurrenceLayoutControlGroup, "recurrenceLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(endAfterCheckEdit, "endAfterCheckEdit", newCultureInfo);
            resources.ApplyResources(withoutEndDateCheckEdit, "withoutEndDateCheckEdit", newCultureInfo);
            resources.ApplyResources(endDateCheckEdit, "endDateCheckEdit", newCultureInfo);
            resources.ApplyResources(startDateLayoutControlItem, "startDateLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(languageLayoutControlItem, "languageLayoutControlItem", newCultureInfo);

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }

        private void languageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;

            if (cb != null)
            {
                string currentLanguage = cb.SelectedItem as string;
                Localized(currentLanguage);
                //FormManager.Instance.LocalizedForms(currentLanguage);
                Program.currentLang = currentLanguage;
            }
        }

        private void SetUpComboBox() 
        {
            languageComboBoxEdit.Properties.Items.Add("en-US");
            languageComboBoxEdit.Properties.Items.Add("ru-RU");
            int index = languageComboBoxEdit.Properties.Items.IndexOf(Program.currentLang);
            languageComboBoxEdit.SelectedIndex = index;
        }

        private void withoutEndDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
            }
        }

        private void endAfterCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                withoutEndDateCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
            }
        }

        private void endDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                withoutEndDateCheckEdit.Checked = false;
            }
        }

        private void quizNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            wasShow = false;
            // делаем нашу иконку скрытой
            quizNotifyIcon.Visible = false;
            // возвращаем отображение окна в панели
            this.ShowInTaskbar = true;
            //разворачиваем окно
            WindowState = FormWindowState.Normal;
        }

        private void TesteeSettingsForm_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                // прячем наше окно из панели
                this.ShowInTaskbar = false;
                // делаем нашу иконку в трее активной
                quizNotifyIcon.Visible = true;
            }

            if (wasShow)
            {
                this.Hide();
            }
           
        }

        private void TesteeSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // прячем наше окно из панели
            this.ShowInTaskbar = false;
            // делаем нашу иконку в трее активной
            quizNotifyIcon.Visible = true;

            this.Hide();
            e.Cancel = true;
        }

        private void TesteeSettingsForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (Program.UserTime != Program.currentTestee.UserSetting.TimeOfStart)
            {
                Program.SetUpStartTime();
            }

            if (DateTime.Now.TimeOfDay.Hours == Program.AskedTime.Hour
                && DateTime.Now.TimeOfDay.Minutes == Program.AskedTime.Minute
                && Program.QuestionAmount <= Program.currentTestee.UserSetting.AmountOfQuestionsPerDay)
            {
                Program.AskedTime = DateTime.Now;
                TesteeQuestionForm questionForm = new TesteeQuestionForm(Program.currentTestee);
                timer.Stop();
                questionForm.Show();
            }
        }
    }
}