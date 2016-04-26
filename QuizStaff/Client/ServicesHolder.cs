using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class ServicesHolder
    {
        public static Client.ServiceReference.ApplicationServerClient serviceClient
            = new Client.ServiceReference.ApplicationServerClient();
    }
}
