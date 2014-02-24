using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPBuddy
{
    public class StaticIP
    {
        public string Address = "";
        public string SubnetMask = "";
        public string DefaultGateway = "";

        public XElement ToXML()
        {
            XElement xip = new XElement("StaticIP");

            XElement address = new XElement("Address");
            XElement subnet = new XElement("SubnetMask");
            XElement gateway = new XElement("DefaultGateway");

            address.Value = this.Address;
            subnet.Value = this.SubnetMask;
            gateway.Value = this.DefaultGateway;

            xip.Add(address);
            xip.Add(subnet);
            xip.Add(gateway);

            return xip;
        }

        public static StaticIP FromXML(XElement xip)
        {
            StaticIP ip = new StaticIP { Address = xip.Element("Address").Value,
                                         SubnetMask = xip.Element("SubnetMask").Value,
                                         DefaultGateway = xip.Element("DefaultGateway").Value };
            return ip;
        }

        public static bool IsIPv4(string value)
        {
            var quads = value.Split('.');
            if (!(quads.Length == 4)) return false;

            foreach (var quad in quads)
            {
                int q;
                if (!Int32.TryParse(quad, out q)
                    || !q.ToString().Length.Equals(quad.Length)
                    || q < 0
                    || q > 255) { return false; }
            }

            return true;
        }

    }

    
}
