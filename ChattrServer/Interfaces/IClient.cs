using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Interfaces
{
    interface IClient
    {
        Socket Socket { get; set; }
        IAccount Account { get; set; }
    }
}
