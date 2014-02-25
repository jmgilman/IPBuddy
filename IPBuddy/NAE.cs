using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;

namespace IPBuddy
{
    public class NAE
    {
        public string Name = "";
        public string IPAddress = "";
        public string MAC = "";
        public string OSVersion = "";
        public string MSEAVersion = "";
        public string NeuronID = "";

        public StaticIP StaticIPAddress = new StaticIP();

        private string protocol = "jcilaunchersmp://";

        public void Launch()
        {
            int majorVer = 0;
            if (!String.IsNullOrEmpty(this.MSEAVersion))
            {
                majorVer = Convert.ToInt32(this.MSEAVersion.Split(new char[] { '.' })[0]);
            }

            if (majorVer >= 6)
            {
                String uri = this.protocol + this.IPAddress;
                ProcessStartInfo psi = new ProcessStartInfo();

                psi.UseShellExecute = true;
                psi.FileName = uri;

                Process.Start(psi);
            }
            else
            {
                String uri = "http://" + this.IPAddress + "/metasys";
                Process.Start("IExplore.exe", uri);
            }
        }

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
