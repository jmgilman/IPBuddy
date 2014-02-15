using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPBuddy
{
    class NIC
    {
        public String Name;
        public IPAddress IP;
        public bool DHCPEnabled;

        public NIC()
        {
            this.Name = "";
            this.IP = new IPAddress();
            this.DHCPEnabled = false;
        }

        public NIC(String name, IPAddress ipAddress, bool dhcpEnabled)
        {
            this.Name = name;
            this.IP = ipAddress;
            this.DHCPEnabled = dhcpEnabled;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
