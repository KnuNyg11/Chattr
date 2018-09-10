using ChattrServer.Models.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Network
{
    class Server
    {
        public static Server Instance { get; set; }
        public Socket Socket { get; set; }
        public IPEndPoint EndPoint { get; set; }

        public Server()
        {
            Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }

        public void Init()
        {

        }


        public void PacketCallback(IAsyncResult ar)
        {

        }

        public void AuthenticateUser(AuthPacket packet)
        {

        }
    }
}
