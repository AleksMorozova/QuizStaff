using Client.ServiceReference;
using DomainModel;
using System;
using System.Windows.Forms;

namespace Client.ClientsForms
{
    public class ClientSetupPresenter
    {
        IClientSetupForm _view;
        IApplicationServer _server;

        public ClientSetupPresenter(IClientSetupForm _view)
        {
            this._view = _view;
            _server = ServicesHolder.ServiceClient;
            _view.SetSettings(_server.GetUsersSettings());
            _view.ButSaveClick += Save;
            _view.ButCancelClick += Cancel;
        }

        private void Save(object sender, EventArgs e)
        {
            if(_server.SetUsersSettings(new Settings(_view.QuestionsAmount,
                _view.FrequencyOfAsking)))
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
