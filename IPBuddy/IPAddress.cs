using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPBuddy
{
    class IPAddress
    {
        public string Name;
        public string Address;
        public string SubnetMask;
        public string DefaultGateway;

        public IPAddress()
        {
            this.Name = "";
            this.Address = "";
            this.SubnetMask = "";
            this.DefaultGateway = "";
        }

        public IPAddress(string name, string ipAddress, string subnetMask, string defaultGateway)
        {
            this.Name = name;
            this.Address = ipAddress;
            this.SubnetMask = subnetMask;
            this.DefaultGateway = defaultGateway;
        }
    }
}
