using ChattrServer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Interfaces
{
    interface IPacket
    {
        PacketType Type { get; set; }
    }
}
