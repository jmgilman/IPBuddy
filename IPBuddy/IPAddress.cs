using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPBuddy
{
    class IPAddress
    {
        public string Address;
        public string SubnetMask;
        public string DefaultGateway;

        public IPAddress()
        {
            this.Address = "";
            this.SubnetMask = "";
            this.DefaultGateway = "";
        }

        public IPAddress(string ipAddress, string subnetMask, string defaultGateway)
        {
            this.Address = ipAddress;
            this.SubnetMask = subnetMask;
            this.DefaultGateway = defaultGateway;
        }
    }
}
