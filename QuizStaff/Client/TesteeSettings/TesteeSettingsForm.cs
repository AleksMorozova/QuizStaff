using System;
using DomainModel;

namespace Client.TesteeSettings
{
    public partial class TesteeSettingsForm : DevExpress.XtraEditors.XtraForm, IClientSetupForm
    {
        public TesteeSettingsForm()
        {
            InitializeComponent();
            var presenter = new ClientSetupPresenter(this);
        }

        public DateTime TimeOfStart
        {
            get
            {
                return (DateTime)timeEditTimeOfStart.EditValue;
            }
            set
            {
                timeEditTimeOfStart.EditValue = value;
            }
        }
        public int FrequencyOfAsking
        {
            get
            {
                return Convert.ToInt32(spinEditFrequency.Value);
            }
            set
            {
                spinEditFrequency.Value = value;
            }
        }

        public Int32 QuestionsAmount
        {
            get
            {
                return Convert.ToInt32(spinEditAmount.Value);
            }
            set
            {
                spinEditAmount.Value = value;
            }
        }


        public event EventHandler ButSaveClick;
        public event EventHandler ButCancelClick;

        private void butCancel_Click(object sender, EventArgs e)
        {
            if (ButCancelClick != null) ButCancelClick(this, EventArgs.Empty);
            Close();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (ButSaveClick != null) ButSaveClick(this, EventArgs.Empty);
        }
    }
}