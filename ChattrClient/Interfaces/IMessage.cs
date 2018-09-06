using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrClient.Interfaces
{
    interface IMessage
    {
        string Message { get; set; }
        DateTime Timestamp { get; set; }
        IUser Author { get; set; }
    }
}
