using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ServicesHolder
    {
        private static Client.ServiceReference.ApplicationServerClient serviceClient;
        private static ServicesHolder serviceHolderObject;
        public Client.ServiceReference.ApplicationServerClient ServiceClient
        {
            get
            {
                if (serviceClient == null)
                    serviceClient = new Client.ServiceReference.ApplicationServerClient();
                return serviceClient;
            }
        }
        private ServicesHolder()
        {
            serviceClient = new Client.ServiceReference.ApplicationServerClient();
        }
        public static ServicesHolder ServiceHolderObject
        {
            get
            {
                if (serviceHolderObject == null)
                    serviceHolderObject = new ServicesHolder();
                return serviceHolderObject;
            }
        }
    }
}
