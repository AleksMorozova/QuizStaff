using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication
{
    public class ServicesHolder
    {
        private static AdminApplication.ServiceReference2.ApplicationServerClient serviceClient;
        private static ServicesHolder serviceHolderObject = new ServicesHolder();
        public static AdminApplication.ServiceReference2.ApplicationServerClient ServiceClient
        {
            get
            {
                return (serviceClient != null) ? serviceClient : new AdminApplication.ServiceReference2.ApplicationServerClient();
            }
        }

        private ServicesHolder()
        {
            serviceClient = new AdminApplication.ServiceReference2.ApplicationServerClient();
        }

        public static ServicesHolder ServiceHolderObject
        {
            get
            {
                return serviceHolderObject;
            }
        }
    }
}
