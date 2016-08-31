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

        //Timer fields
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int QuestionAmount = 0;
        private DateTime QuestionTime = Program.currentTestee.UserSetting.TimeOfStart;

        public TesteeSettingsForm()
        {
            InitializeComponent();
            Localized(Program.currentLang);
            SetUpComboBox();

            mvvmTesteeSettingsContext.ViewModelType = typeof(TesteeSettingsViewModel);
            model = mvvmTesteeSettingsContext.GetViewModel<TesteeSettingsViewModel>();
            mvvmTesteeSettingsContext.SetViewModel(typeof(TesteeSettingsViewModel), model);

            BindCommands();
            BindToViewModel();

            SetControlAccess(model.UserSetting.CanUserEdit);
            SetUpRangeOfRecurrence(model.UserSetting.Recurrence);

            StartTimer();
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
            hoursSpinEdit.DataBindings.Add("EditValue", inner, "Hours");
            minuteSpinEdit.DataBindings.Add("EditValue", inner, "Minutes");
            secondSpinEdit.DataBindings.Add("EditValue", inner, "Seconds");
            timeOfAskingEditTime.DataBindings.Add("EditValue", inner, "TimeOfStart");
            startDateDateEdit.DataBindings.Add("EditValue", inner, "TimeOfStart");
        }

        private void SetControlAccess(bool canEdit)
        {
            hoursSpinEdit.Enabled = canEdit;
            minuteSpinEdit.Enabled = canEdit;
            secondSpinEdit.Enabled = canEdit;
            startDateDateEdit.Enabled = canEdit;
            timeOfAskingEditTime.Enabled = canEdit;
            withoutEndDateCheckEdit.Enabled = canEdit;
            endAfterCheckEdit.Enabled = canEdit; 
            questionAmountSpinEdit.Enabled = canEdit;
            endDateCheckEdit.Enabled = canEdit;
            endDateDateEdit.Enabled = canEdit;
        }

        private void SetUpRangeOfRecurrence(RecurrenceType type)
        {
            withoutEndDateCheckEdit.Checked = (type == RecurrenceType.WithoutEnding);
            endAfterCheckEdit.Checked = (type == RecurrenceType.WithExactRepeated);
            endDateCheckEdit.Checked = (type == RecurrenceType.WithSpecifiedEndDate);

            if (type != RecurrenceType.WithSpecifiedEndDate)
            {
                endDateDateEdit.EditValue = null;
                endDateDateEdit.Text = null;
            }            
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
            resources.ApplyResources(startTimeLayoutControlItem, "timeOfAskingEditTimeLayoutControlItem", newCultureInfo);
            resources.ApplyResources(recurrenceLayoutControlGroup, "recurrenceLayoutControlGroup", newCultureInfo);
            resources.ApplyResources(questionAmountSpinEditLayoutControlItem, "questionAmountSpinEditLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startDateLayoutControlItem, "startDateLayoutControlItem", newCultureInfo);
            resources.ApplyResources(saveButton, "saveButton", newCultureInfo);
            resources.ApplyResources(cancelButton, "cancelButton", newCultureInfo);
            resources.ApplyResources(languageLayoutControlItem, "languageLayoutControlItem", newCultureInfo);
            resources.ApplyResources(startParametersLabelControl, "startParametersLabelControl", newCultureInfo);

            #region Translate radio group
            string withoutEnding = !String.IsNullOrEmpty(resources.GetString("withoutEndDateCheckEdit.Text", newCultureInfo))
                ? resources.GetString("withoutEndDateCheckEdit.Text", newCultureInfo) : "Without end condition";
            withoutEndDateCheckEdit.Text = withoutEnding;
            string endAfter = !String.IsNullOrEmpty(resources.GetString("endAfterCheckEdit.Text", newCultureInfo))
                ? resources.GetString("endAfterCheckEdit.Text", newCultureInfo) : "End after";
            endAfterCheckEdit.Text = endAfter;
            string endDate = !String.IsNullOrEmpty(resources.GetString("endDateCheckEdit.Text", newCultureInfo))
                ? resources.GetString("endDateCheckEdit.Text", newCultureInfo) : "End date";
            endDateCheckEdit.Text = endDate;
            #endregion

            this.Text = !String.IsNullOrEmpty(resources.GetString("Title", newCultureInfo))
                ? resources.GetString("Title", newCultureInfo) : "Settings";
        }

        //Implement filling of current language into config file 
        private void languageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit cb = sender as ComboBoxEdit;
            if (cb != null)
            {
                LanguageEnum currentLanguage = (LanguageEnum)cb.SelectedItem;
                Localized(LanguageConvert.ConvertFromEnum(currentLanguage));
                Program.currentLang = LanguageConvert.ConvertFromEnum(currentLanguage);
            }
        }

        //Fill langauge comboBox items 
        private void SetUpComboBox() 
        {
            languageComboBoxEdit.Properties.Items.Add(LanguageEnum.English);
            languageComboBoxEdit.Properties.Items.Add(LanguageEnum.Русский);
            int index = languageComboBoxEdit.Properties.Items.IndexOf(LanguageConvert.ConvertToEnum(Program.currentLang));
            languageComboBoxEdit.SelectedIndex = index;
        }

        #region Recurrence type changing
        private void withoutEndDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
                Program.currentTestee.UserSetting.Recurrence = RecurrenceType.WithoutEnding;
            }
        }

        private void endAfterCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                withoutEndDateCheckEdit.Checked = false;
                endDateCheckEdit.Checked = false;
                Program.currentTestee.UserSetting.Recurrence = RecurrenceType.WithExactRepeated;
            }
        }

        private void endDateCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            CheckEdit edit = sender as CheckEdit;
            if (edit.Checked)
            {
                endAfterCheckEdit.Checked = false;
                withoutEndDateCheckEdit.Checked = false;
                Program.currentTestee.UserSetting.Recurrence = RecurrenceType.WithSpecifiedEndDate;
            }
        }
        #endregion
         
        private void endDateDateEdit_EditValueChanged(object sender, EventArgs e)
        {
                DateEdit edit = sender as DateEdit;
                Program.currentTestee.UserSetting.EndDate = (DateTime)edit.EditValue;
        }         

        #region Timer
        private void StartTimer() 
        {
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Program.currentTestee.UserSetting.Recurrence == RecurrenceType.WithExactRepeated 
                && QuestionAmount <= Program.currentTestee.UserSetting.AmountOfQuestionsPerDay)
            {
                AskQuestion();
            }

            else if (Program.currentTestee.UserSetting.Recurrence == RecurrenceType.WithSpecifiedEndDate
                && DateTime.Now != Program.currentTestee.UserSetting.EndDate)
            {
                AskQuestion();
            }

            else if (Program.currentTestee.UserSetting.Recurrence == RecurrenceType.WithoutEnding)
            {
                AskQuestion();
            }
        }

        private bool CheckDateAndTime()
        {
            int currentTime = DateTime.Now.TimeOfDay.Hours*60*60 + DateTime.Now.TimeOfDay.Minutes*60 + DateTime.Now.TimeOfDay.Seconds;
            int askedTime = QuestionTime.Hour * 60 * 60 + QuestionTime.Minute * 60 + QuestionTime.Second;

            return (DateTime.Now.Date.CompareTo(QuestionTime.Date) >= 0 && currentTime >= askedTime);
        }

        private void AskQuestion() 
        {
            if (CheckDateAndTime())
            {
                TesteeQuestionForm questionForm = new TesteeQuestionForm(Program.currentTestee);
                timer.Stop();
                questionForm.ShowDialog();
                timer.Start();
                UpdateTime();
            }
        }

        private void UpdateTime()
        {
            QuestionTime = DateTime.Now;
            QuestionTime = QuestionTime.AddHours(0);
            QuestionTime = QuestionTime.AddMinutes(2);
            QuestionTime = QuestionTime.AddSeconds(0);

            QuestionAmount = (QuestionTime.Date == DateTime.Now.Date)
                ? QuestionAmount + 1
                : 0;
        }
        #endregion
    
        #region Hide and show form from tray
        private void TesteeSettingsForm_Resize(object sender, EventArgs e)
        {
            // проверяем наше окно, и если оно было свернуто, делаем событие        
            if (WindowState == FormWindowState.Minimized)
            {
                HideFormIntoTray();
            }
        }

        private void TesteeSettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideFormIntoTray();
            e.Cancel = true;
        }
  
        private void quizNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowFromTray();
        }  
        
        private void HideFormIntoTray() 
        {
            // Remove application icon from taskbar
            this.ShowInTaskbar = false;  
            
            //Hide TesteeSettingsForm
            this.Hide();
        }

        private void ShowFromTray()
        {
            //Show TesteeSettingsForm with default size 
            this.Show();       
            WindowState = FormWindowState.Normal;
            
            //Display application icon at taskbar
            this.ShowInTaskbar = true;
        }
        #endregion

        #region Tray menu
        private void quizNotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && IsHandleCreated)
                popupMenu.ShowPopup(MousePosition);
        }

        private void exitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Environment.Exit(0);
        }

        private void settingsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFromTray();
        }      
        
        private void aboutBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
        #endregion
    }
}