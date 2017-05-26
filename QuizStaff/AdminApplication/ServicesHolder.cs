using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication
{
    public class ServicesHolder
    {
        private static AdminApplication.ServiceReference.ApplicationServerClient serviceClient
            = new AdminApplication.ServiceReference.ApplicationServerClient();

        public static AdminApplication.ServiceReference.ApplicationServerClient ServiceClient
        {
            get =>(serviceClient != null) 
                ? serviceClient 
                : new AdminApplication.ServiceReference.ApplicationServerClient();
        }
    }
}
