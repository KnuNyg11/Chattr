using ChattrServer.Enums;
using ChattrServer.Interfaces;
using ChattrServer.Models;
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

        public void Listen()
        {
            Client client = new Client();
            Socket.BeginReceive(client.Buffer, 0, client.Buffer.Length, SocketFlags.None, PacketHandlerCallback, client);
        }
        
        public void PacketHandlerCallback(IAsyncResult ar)
        {
            Client client = (Client)ar.AsyncState;

            int size = Socket.EndReceive(ar);
            byte[] buffer = client.Buffer;
            client.Buffer = new byte[size];

            Buffer.BlockCopy(buffer, 0, client.Buffer, 0, size);
            PacketType packet = (PacketType)BitConverter.ToInt32(client.Buffer, 0);

            switch(packet)
            {
                case PacketType.None:
                    break;
            }
        }

        public void PingCallback(IPacket packet)
        {

        }

        public void AuthenticateUserCallback(AuthPacket packet)
        {

        }
        public void LoginUserCallback(LoginPacket packet)
        {

        }
        public void RegisterUserCallback(RegisterPacket packet)
        {

        }

        public void MessageCallback(MessagePacket packet)
        {

        }

        public void CreateGroupCallback(CreateGroupPacket packet)
        {

        }
        public void JoinGroupCallback(JoinGroupPacket packet)
        {

        }
    }
}
