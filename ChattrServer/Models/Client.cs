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
        public IAccount Account { get; set; }

        public Client(Socket socket)
        {
            Socket = socket;
        }
    }
}
