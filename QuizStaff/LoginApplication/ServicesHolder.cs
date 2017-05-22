using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    public class ServicesHolder
    {
        private static LoginApplication.ServiceReference1.ApplicationServerClient serviceClient;
        private static ServicesHolder serviceHolderObject;

        public static LoginApplication.ServiceReference1.ApplicationServerClient ServiceClient
        {
            get
            {
                return (serviceClient != null) ? serviceClient : new LoginApplication.ServiceReference1.ApplicationServerClient();
            }
        }

        private ServicesHolder()
        {
            serviceClient = new LoginApplication.ServiceReference1.ApplicationServerClient();
        }

        public static ServicesHolder ServiceHolderObject
        {
            get
            {
                return (serviceHolderObject != null) ? serviceHolderObject : new ServicesHolder();
            }
        }
    }
}
