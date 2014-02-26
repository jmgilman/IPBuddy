using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.RegularExpressions;

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

        public static StaticIP GenerateStatic(String naeIP)
        {
            string[] parts = naeIP.Split(new char[] { '.' });
            string lastOctet = parts[parts.Length - 1];
            string baseIP = String.Join(".", parts, 0, parts.Length - 1);

            string ip = baseIP + "." + (Convert.ToInt32(lastOctet) + 1).ToString();
            string subnet = "255.255.255.0";
            string gateway = baseIP + ".1";

            return new StaticIP() { Address = ip, SubnetMask = subnet, DefaultGateway = gateway };
        }

        public static bool IsIPv4(string ip)
        {
            System.Net.IPAddress address;
            if (System.Net.IPAddress.TryParse(ip, out address))
            {
                if (address.ToString().CompareTo(ip) == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }

    
}
