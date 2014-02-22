using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace IPBuddy
{
    class NIC
    {
        public String Name;
        public StaticIP IP;
        public bool DHCPEnabled;

        private string staticCmd = "interface ip set address \"{0}\" static {1} {2} {3}";
        private string dhcpCmd = "interface ip set address \"{0}\" dhcp";

        public override string ToString()
        {
            return this.Name;
        }

        public void SetStaticIP(string ip, string subnetMask, string defaultGateway)
        {
            string cmd = String.Format(this.staticCmd, this.Name, ip, subnetMask, defaultGateway);

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", cmd);
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;

            p.Start();
            p.WaitForExit();
        }

        public void SetDHCP()
        {
            string cmd = String.Format(this.dhcpCmd, this.Name);

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", cmd);
            psi.Verb = "runas";
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo = psi;

            p.Start();
            p.WaitForExit();
        }

        public void ReselectNIC(ComboBox box)
        {
            foreach (Object objnic in box.Items)
            {
                NIC nic = (NIC)objnic;
                if (nic.Name.Equals(this.Name))
                {
                    box.SelectedItem = objnic;
                }
            }
        }

        public static void LoadNICs(ComboBox box)
        {
            box.Items.Clear();

            /** Scan through each NIC interface **/
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                /** Verify it suport IPv4, is operating, and is not a loopback **/
                if (nic.Supports(NetworkInterfaceComponent.IPv4) && nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    NIC newNic = new NIC();
                    StaticIP ip = new StaticIP();

                    newNic.Name = nic.Name;
                    newNic.DHCPEnabled = nic.GetIPProperties().GetIPv4Properties().IsDhcpEnabled;

                    /** We assume the last result is the IPv4 address **/
                    UnicastIPAddressInformation uni = nic.GetIPProperties().UnicastAddresses.LastOrDefault();
                    if (uni != null)
                    {
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

            if (box.Items.Count > 0)
            {
                box.SelectedIndex = 0;
            }
        }
    }
}
