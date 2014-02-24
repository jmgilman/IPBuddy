using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

namespace IPBuddy
{
    class NAEHandler
    {
        public static string BroadcastMessage = "JCINICT:";
        public static int BroadcastPort = 0x26b6;

        public static frmListener listenFrm = new frmListener();
        public static frmMain mainFrm;

        public static void Initialize()
        {
            NAEHandler.listenFrm = new frmListener();
            NAEHandler.listenFrm.mainFrm = NAEHandler.mainFrm;
        }
        public static void Broadcast()
        {
            byte[] bytes = new byte[NAEHandler.BroadcastMessage.Length + 2];
            Encoding.ASCII.GetBytes(NAEHandler.BroadcastMessage, 0, NAEHandler.BroadcastMessage.Length, bytes, 0);
            BitConverter.GetBytes((ushort)0).CopyTo(bytes, NAEHandler.BroadcastMessage.Length);

            System.Net.Sockets.UdpClient client = new System.Net.Sockets.UdpClient();
            System.Net.IPEndPoint groupEP = new System.Net.IPEndPoint(System.Net.IPAddress.Broadcast, NAEHandler.BroadcastPort);

            client.Send(bytes, bytes.Length, groupEP);
            client.Close();
        }

        public static void PacketHandler(Packet packet)
        {
            Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " Length: " + packet.Length);

            IpV4Datagram ip = packet.Ethernet.IpV4;
            UdpDatagram udp = ip.Udp;
            Datagram payload = udp.Payload;

            byte[] data = payload.ToArray();
            NAE nae = NAEHandler.parseNAEFromPacket(data);
            String msg = nae.Name + " reported online.";

            NAEHandler.listenFrm.Invoke(NAEHandler.listenFrm.AddNAEDelegate, new object[] { nae });

            if (NAEHandler.mainFrm.notifyIcon.Visible == true)
            {
                NAEHandler.mainFrm.notifyIcon.BalloonTipText = msg;
                NAEHandler.mainFrm.notifyIcon.ShowBalloonTip(500);
            }
            else
            {
                NAEHandler.mainFrm.notifyIcon.Visible = true;
                NAEHandler.mainFrm.notifyIcon.BalloonTipText = msg;
                NAEHandler.mainFrm.notifyIcon.ShowBalloonTip(500);
                System.Threading.Thread.Sleep(3000);
                NAEHandler.mainFrm.notifyIcon.Visible = false;
            }
        }

        private static NAE parseNAEFromPacket(byte[] packet)
        {
            int index = 8;
            int count = 0;
            int length = packet.Length;
            NAE nae = new NAE();

            while (index < length)
            {
                if ((index + 2) > length)
                {
                    goto Finish;
                }

                MessageFields fields = (MessageFields)packet[index];
                count = packet[++index];

                if ((index + count) > length)
                {
                    goto Finish;
                }

                index++;
                switch (fields)
                {
                    case MessageFields.IPV4Address:
                        var ipa = new System.Net.IPAddress((long)BitConverter.ToUInt32(packet, index));
                        nae.IPAddress = ipa.ToString();
                        break;
                    case MessageFields.Name:
                        nae.Name = Encoding.ASCII.GetString(packet, index, count);
                        break;
                    case MessageFields.MACAddress:
                        nae.MAC = packet[index].ToString("x2") + ":" + packet[index + 1].ToString("x2") + ":" + packet[index + 2].ToString("x2") + ":" + packet[index + 3].ToString("x2") + ":" + packet[index + 4].ToString("x2") + ":" + packet[index + 5].ToString("x2");
                        break;
                    case MessageFields.OSVersion:
                        nae.OSVersion = Encoding.ASCII.GetString(packet, index, count);
                        break;
                    case MessageFields.Message:
                        // Future: Console.WriteLine("Message: " + Encoding.ASCII.GetString(packet, index, count));
                        break;
                    case MessageFields.ProductCode:
                        // Future: Console.WriteLine("Product Code: " + Encoding.ASCII.GetString(packet, index, count));
                        break;
                    case MessageFields.BatteryStatus:
                        //Future: Console.WriteLine("Battery Status: " + Encoding.ASCII.GetString(packet, index, count));
                        break;
                    case MessageFields.NeuronID:
                        nae.NeuronID = packet[index].ToString("x2") + ":" + packet[index + 1].ToString("x2") + ":" + packet[index + 2].ToString("x2") + ":" + packet[index + 3].ToString("x2") + ":" + packet[index + 4].ToString("x2") + ":" + packet[index + 5].ToString("x2");
                        break;
                    case MessageFields.DHCPEnabled:
                        //Future: Console.WriteLine("DHCP Enabled: " + (packet[index] == 1));
                        break;
                    case MessageFields.MessageReason:
                        //Future
                        break;
                    case MessageFields.MSEAVersion:
                        nae.MSEAVersion = Encoding.ASCII.GetString(packet, index, count);
                        break;
                }
                index += count;
            }

        Finish:
            return nae;
        }

        protected enum MessageFields : byte
        {
            BatteryStatus = 6,
            DHCPEnabled = 8,
            IPV4Address = 0,
            MACAddress = 2,
            Message = 4,
            MessageReason = 9,
            MSEAVersion = 10,
            Name = 1,
            NeuronID = 7,
            OSVersion = 3,
            ProductCode = 5
        }
    }
}
