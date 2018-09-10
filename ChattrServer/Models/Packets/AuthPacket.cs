using ChattrServer.Enums;
using ChattrServer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Models.Packets
{
    class AuthPacket : IPacket
    {
        public PacketType Type { get; set; }
        public string Authtoken { get; set; }
    }
}
