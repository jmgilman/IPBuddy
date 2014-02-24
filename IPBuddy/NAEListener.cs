using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Core;

namespace IPBuddy
{
    public class NAEListener
    {
        private PacketDevice device;
        private String filter = "udp port 162 || udp port 9911";

        public NAEListener(PacketDevice device)
        {
            this.device = device;
        }

        public void listen()
        {
            using (PacketCommunicator communicator = this.device.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                communicator.SetFilter(this.filter);
                communicator.ReceivePackets(0, NAEHandler.PacketHandler);
            }
        }
    }
}
