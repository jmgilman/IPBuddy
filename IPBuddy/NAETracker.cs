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
    class NAETracker
    {
        public static string BroadcastMessage = "JCINICT:";
        public static int BroadcastPort = 0x26b6;

        public static void Broadcast()
        {
            byte[] bytes = new byte[NAETracker.BroadcastMessage.Length + 2];
            Encoding.ASCII.GetBytes(NAETracker.BroadcastMessage, 0, NAETracker.BroadcastMessage.Length, bytes, 0);
            BitConverter.GetBytes((ushort)0).CopyTo(bytes, NAETracker.BroadcastMessage.Length);

            System.Net.Sockets.UdpClient client = new System.Net.Sockets.UdpClient();
            System.Net.IPEndPoint groupEP = new System.Net.IPEndPoint(System.Net.IPAddress.Broadcast, NAETracker.BroadcastPort);

            client.Send(bytes, bytes.Length, groupEP);
            client.Close();
        }

        public static void listen()
        {
            // Retrieve the device list from the local machine
            IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

            if (allDevices.Count == 0)
            {
                Console.WriteLine("No interfaces found! Make sure WinPcap is installed.");
                return;
            }

            for (int i = 0; i != allDevices.Count; ++i)
            {
                LivePacketDevice device = allDevices[i];
                Console.Write((i + 1) + ". " + device.Name);
                if (device.Description != null)
                    Console.WriteLine(" (" + device.Description + ")" + " " + device.Addresses[1].ToString());
                else
                    Console.WriteLine(" (No description available)");
            }

            PacketDevice selectedDevice = allDevices[0];
            using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                Console.WriteLine("Listenong on NIC...");
                communicator.SetFilter("udp port 162 || udp port 9911");
                communicator.ReceivePackets(1, PacketHandler);
            }
        }

        private static void PacketHandler(Packet packet)
        {
            Console.WriteLine(packet.Timestamp.ToString("yyyy-MM-dd hh:mm:ss.fff") + " Length: " + packet.Length);
            IpV4Datagram ip = packet.Ethernet.IpV4;
            UdpDatagram udp = ip.Udp;
            Datagram payload = udp.Payload;
            //FormMain.frm.textBox1.Text = System.Text.Encoding.Default.GetString(payload.ToArray());

            int index = 8;
            int count = 0;
            int length = payload.Length;
            byte[] data = payload.ToArray();

            while (index < length)
            {
                if ((index + 2) > length)
                {
                    goto Label_0327;
                }
                MessageFields fields = (MessageFields)data[index];
                Console.WriteLine(fields);

                count = data[++index];
                if ((index + count) > length)
                {
                    goto Label_0327;
                }
                index++;
                switch (fields)
                {
                    case MessageFields.IPV4Address:
                        var ipa = new System.Net.IPAddress((long)BitConverter.ToUInt32(data, index));
                        Console.WriteLine("IP Address: " + ipa.ToString());
                        break;
                    case MessageFields.Name:
                        Console.WriteLine("Name: " + Encoding.ASCII.GetString(data, index, count));
                        break;
                    case MessageFields.MACAddress:
                        Console.WriteLine("MAC : " + data[index].ToString("x2") + ":" + data[index + 1].ToString("x2") + ":" + data[index + 2].ToString("x2") + ":" + data[index + 3].ToString("x2") + ":" + data[index + 4].ToString("x2") + ":" + data[index + 5].ToString("x2"));
                        break;
                    case MessageFields.OSVersion:
                        Console.WriteLine("OS Version: " + Encoding.ASCII.GetString(data, index, count));
                        break;
                    case MessageFields.Message:
                        Console.WriteLine("Message: " + Encoding.ASCII.GetString(data, index, count));
                        break;
                    case MessageFields.ProductCode:
                        Console.WriteLine("Product Code: " + Encoding.ASCII.GetString(data, index, count));
                        break;

                    case MessageFields.BatteryStatus:
                        Console.WriteLine("Battery Status: " + Encoding.ASCII.GetString(data, index, count));
                        break;

                    case MessageFields.NeuronID:
                        Console.WriteLine("Neuron ID: " + data[index].ToString("x2") + ":" + data[index + 1].ToString("x2") + ":" + data[index + 2].ToString("x2") + ":" + data[index + 3].ToString("x2") + ":" + data[index + 4].ToString("x2") + ":" + data[index + 5].ToString("x2"));
                        break;

                    case MessageFields.DHCPEnabled:
                        Console.WriteLine("DHCP Enabled: " + (data[index] == 1));
                        break;

                    case MessageFields.MessageReason:
                        //this.mrReason = (MessageReason)data[index];
                        break;

                    case MessageFields.MSEAVersion:
                        Console.WriteLine("MSEA Version: " + Encoding.ASCII.GetString(data, index, count));
                        break;
                }
                index += count;
            }

        Label_0327:
            return;
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
