using System;
using DomainModel;

namespace Client.ClientsForms
{
    public partial class ClientsSetupForm : DevExpress.XtraEditors.XtraForm, IClientSetupForm
    {
        public ClientsSetupForm()
        {
            var presenter = new ClientSetupPresenter(this);
            InitializeComponent();
        }

        public DateTime FrequencyOfAsking
        {
            get
            {
                return timeEditFrequency.Time;
            }
            private set
            {
                timeEditFrequency.Time = value;
            }
        }

        public Int32 QuestionsAmount
        {
            get
            {
                return Convert.ToInt32(spinEditAmount.Value);
            }
            private set
            {
                spinEditAmount.Value = value;
            }
        }
        public void SetSettings(UsersSettings sets)
        {
            FrequencyOfAsking = sets.FrequencyOfAsking;
            QuestionsAmount = sets.AmountOfQuestionsPerDay;
        }

        public event EventHandler ButSaveClick;
        public event EventHandler ButCancelClick;
    }
}