using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPBuddy
{
    class NAE
    {
        public string Name = "";
        public string IPAddress = "";
        public string MAC = "";
        public string OSVersion = "";
        public string MSEAVersion = "";
        public string NeuronID = "";

        public StaticIP StaticIPAddress = new StaticIP();

        public XElement ToXML()
        {
            XElement xnae = new XElement("NAE", new XAttribute("Name", this.Name));

            xnae.Add(new XElement("IPAddress", this.IPAddress));
            xnae.Add(new XElement("MAC", this.MAC));
            xnae.Add(new XElement("OSVersion", this.OSVersion));
            xnae.Add(new XElement("MSEAVersion", this.MSEAVersion));
            xnae.Add(new XElement("NeuronID", this.NeuronID));
            xnae.Add(this.StaticIPAddress.ToXML());

            return xnae;
        }

        public static NAE FromXML(XElement xnae)
        {
            NAE nae = new NAE { Name = xnae.Attribute("Name").Value, 
                                IPAddress = xnae.Element("IPAddress").Value,
                                MAC = xnae.Element("MAC").Value,
                                OSVersion = xnae.Element("OSVersion").Value,
                                MSEAVersion = xnae.Element("MSEAVersion").Value,
                                NeuronID = xnae.Element("NeuronID").Value, 
                                StaticIPAddress = StaticIP.FromXML(xnae.Element("StaticIP")) };
            return nae;
        }

    }
}
