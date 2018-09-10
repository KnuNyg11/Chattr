using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Enums
{
    enum PacketType
    {
        Unknown = -1,
        None = 0,
        Ping = 1,

        Authentication = 10,
        Login = 11,
        Register = 12,

        Message = 20,

        CreateGroup = 30,
        JoinGroup = 31
    }
}
