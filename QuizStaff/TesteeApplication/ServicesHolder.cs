using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteeApplication
{
    public class ServicesHolder
    {
        private static TesteeApplication.ServiceReference.ApplicationServerClient serviceClient 
            = new TesteeApplication.ServiceReference.ApplicationServerClient();
        
        public static ServiceReference.ApplicationServerClient ServiceClient
        {
            get => serviceClient != null 
                ? serviceClient
                : new TesteeApplication.ServiceReference.ApplicationServerClient();
        }
    }
}
