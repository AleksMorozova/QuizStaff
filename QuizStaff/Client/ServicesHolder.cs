using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class ServicesHolder
    {
        public static Client.ServiceReference.ApplicationServerClient serviceClient
            = new Client.ServiceReference.ApplicationServerClient();
        private static ServicesHolder singleton;
        private ServicesHolder() { }
        public static ServicesHolder getInstance()
        {
            if (singleton != null)
                singleton = new ServicesHolder();
            return singleton;
        }
    }
}
