using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace IPBuddy
{
    class IPBuddyHelper
    {
        public static void LoadNICs(ComboBox box)
        {
            /** Scan through each NIC interface **/
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                /** Verify it suport IPv4, is operating, and is not a loopback **/
                if (nic.Supports(NetworkInterfaceComponent.IPv4) && nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    NIC newNic = new NIC();
                    IPAddress ip = new IPAddress();

                    newNic.Name = nic.Name;
                    newNic.DHCPEnabled = nic.GetIPProperties().GetIPv4Properties().IsDhcpEnabled;

                    /** We assume the last result is the IPv4 address **/
                    UnicastIPAddressInformation uni = nic.GetIPProperties().UnicastAddresses.LastOrDefault();
                    if (uni != null)
                    {
                        Console.WriteLine("Address: " + uni.Address);
                        Console.WriteLine("Subnet: " + uni.IPv4Mask);
                        ip.Address = uni.Address.ToString();
                        ip.SubnetMask = uni.IPv4Mask.ToString();
                    }

                    /** We assume the first gateway address is the default one **/
                    GatewayIPAddressInformation gate = nic.GetIPProperties().GatewayAddresses.FirstOrDefault();
                    if (gate != null)
                    {
                        ip.DefaultGateway = gate.Address.ToString();
                    }

                    newNic.IP = ip;
                    box.Items.Add(newNic);
                }
            }
        }

        public static XElement IPToXML(IPAddress ip)
        {
            XElement xip = new XElement("IPAddress", new XAttribute("Name", ip.Name));
            XElement address = new XElement("Address");
            XElement subnet = new XElement("SubnetMask");
            XElement gateway = new XElement("DefaultGateway");
            ;
            address.Value = ip.Address;
            subnet.Value = ip.SubnetMask;
            gateway.Value = ip.DefaultGateway;

            xip.Add(address);
            xip.Add(subnet);
            xip.Add(gateway);

            return xip;
        }

        public static XElement SiteToXML(Site site)
        {
            XElement xsite = new XElement("Site", new XAttribute("Name", site.Name));

            if (site.Addresses != null)
            {
                foreach (IPAddress ip in site.Addresses)
                {
                    xsite.Add(IPToXML(ip));
                }
            }

            return xsite;
        }

        public static IPAddress IPFromXML(XElement xip)
        {
            IPAddress ip = new IPAddress();

            ip.Name = xip.Attribute("Name").Value;
            ip.Address = xip.Element("Address").Value;
            ip.SubnetMask = xip.Element("SubnetMask").Value;
            ip.DefaultGateway = xip.Element("DefaultGateway").Value;

            return ip;
        }

        public static Site SiteFromXML(XElement xsite)
        {
            Site site = new Site(xsite.FirstAttribute.Value);

            if (xsite.HasElements)
            {
                foreach (XElement xip in xsite.Elements())
                {
                    site.Addresses.Add(IPFromXML(xip));
                }
            }

            return site;
        }

        public static void ExportToXML(TreeView tree, String fileName)
        {
            TreeNodeCollection sites = tree.Nodes;
            XElement xsites = new XElement("Sites");

            foreach(TreeNode tsite in sites)
            {
                Site site = (Site)tsite.Tag;
                xsites.Add(SiteToXML(site));
            }

            var document = new XDocument(xsites);
            document.Save(fileName);
        }

        public static List<Site> ImportFromXML(String fileName)
        {
            XDocument document = XDocument.Load(fileName);
            List<Site> sites = new List<Site>();

            foreach (XElement xsite in document.Root.Elements())
            {
                sites.Add(SiteFromXML(xsite));
            }

            return sites;
        }
    }
}
