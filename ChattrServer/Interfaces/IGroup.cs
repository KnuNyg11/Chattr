using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Interfaces
{
    interface IGroup
    {
        int Id { get; set; }
        string Name { get; set; }
        List<IUser> Users { get; set; }
        List<IMessage> Messages { get; set; }
    }
}
