using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApplication
{
    public class ServicesHolder
    {
        private static LoginApplication.ServiceReference.ApplicationServerClient serviceClient 
            = new LoginApplication.ServiceReference.ApplicationServerClient();

        public static LoginApplication.ServiceReference.ApplicationServerClient ServiceClient
        {
            get => (serviceClient != null) ?
                serviceClient :
                new LoginApplication.ServiceReference.ApplicationServerClient();
                      
        }
    }
}
