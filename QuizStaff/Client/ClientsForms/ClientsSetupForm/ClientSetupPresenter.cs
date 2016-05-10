using Client.ServiceReference;
using DataTransferObject;
using System;
using System.Windows.Forms;

namespace Client.ClientsForms
{
    public class ClientSetupPresenter
    {
        IClientSetupForm _view;
        SettingDTO _currentSettings;

        public ClientSetupPresenter(IClientSetupForm _view)
        {
            this._view = _view;
            _currentSettings = ServicesHolder.ServiceClient.GetUsersSettings(new Guid());
            SetSettings(_currentSettings);
            _view.ButSaveClick += Save;
            _view.ButCancelClick += Cancel;
        }

        public void SetSettings(SettingDTO sets)
        {
            _view.FrequencyOfAsking = sets.FrequencyOfAsking;
            _view.TimeOfStart = sets.TimeOfStart;
            _view.QuestionsAmount = sets.AmountOfQuestionsPerDay;
        }
        private void Save(object sender, EventArgs e)
        {
            if(ServicesHolder.ServiceClient.SetUsersSettings(_currentSettings, new Guid()))
            {
                MessageBox.Show("Saved successfully", "Massage", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Data can not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cancel(object sender, EventArgs e)
        {
            _view.ButSaveClick -= Save;
            _view.ButCancelClick -= Cancel;
        }
    }
}
