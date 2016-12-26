using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication
{
    public class ServicesHolder
    {
        private static AdminApplication.ServiceReference1.ApplicationServerClient serviceClient;
        private static ServicesHolder serviceHolderObject = new ServicesHolder();
        public static AdminApplication.ServiceReference1.ApplicationServerClient ServiceClient
        {
            get
            {
                return (serviceClient != null) ? serviceClient : new AdminApplication.ServiceReference1.ApplicationServerClient();
            }
        }

        private ServicesHolder()
        {
            serviceClient = new AdminApplication.ServiceReference1.ApplicationServerClient();
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
