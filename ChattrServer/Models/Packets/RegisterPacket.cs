using ChattrServer.Enums;
using ChattrServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Models.Packets
{
    class RegisterPacket : IPacket
    {
        public PacketType Type { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
