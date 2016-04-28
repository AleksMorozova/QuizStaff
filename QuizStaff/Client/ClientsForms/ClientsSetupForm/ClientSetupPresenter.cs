using Client.ServiceReference;
using System;

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
            _view.SetSettings(_server.GetUsersSettings);
            _view.ButSaveClick += Save;
            _view.ButCancelClick += Cancel;
        }

        private void Save(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void Cancel(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
