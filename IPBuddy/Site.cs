using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace IPBuddy
{
    class Site
    {
        public String Name = "";
        public List<NAE> NAEs = new List<NAE>();

        public XElement ToXML()
        {
            XElement xsite = new XElement("Site", new XAttribute("Name", this.Name));
            XElement xnaes = new XElement("NAEs");

            if (this.NAEs != null)
            {
                foreach (NAE nae in this.NAEs)
                {
                    xnaes.Add(nae.ToXML());
                }
            }

            xsite.Add(xnaes);
            return xsite;
        }

        public static Site FromXML(XElement xsite)
        {
            List<NAE> naes = new List<NAE>();
            foreach (XElement xnae in xsite.Element("NAEs").Elements())
            {
                naes.Add(NAE.FromXML(xnae));
            }

            Site site = new Site {Name = xsite.Attribute("Name").Value,
                                  NAEs = naes };

            return site;
        }
    }
}
