using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPBuddy
{
    class Site
    {
        public String Name;
        public List<IPAddress> Addresses;

        public Site(string siteName)
        {
            this.Name = siteName;
            this.Addresses = new List<IPAddress>();
        }

        public void AddIP(IPAddress ip)
        {
            this.Addresses.Add(ip);
        }
    }
}
