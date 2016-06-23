using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication
{
    class ServicesHolder
    {
        private static AdminApplication.ServiceReference.ApplicationServerClient serviceClient;
        private static ServicesHolder serviceHolderObject;
        public static AdminApplication.ServiceReference.ApplicationServerClient ServiceClient
        {
            get
            {
                if (serviceClient == null)
                    serviceClient = new AdminApplication.ServiceReference.ApplicationServerClient();
                return serviceClient;
            }
        }
        private ServicesHolder()
        {
            serviceClient = new AdminApplication.ServiceReference.ApplicationServerClient();
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
