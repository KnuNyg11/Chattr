using ChattrServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Models
{
    class Client : IClient
    {
        public Socket Socket { get; set; }
        public byte[] Buffer { get; set; }

        public IAccount Account { get; set; }

        public Client()
        {
            Buffer = new byte[2048];
        }
        public Client(Socket socket)
        {
            Socket = socket;
            Buffer = new byte[2048];
        }
    }
}
