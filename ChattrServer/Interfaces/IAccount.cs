using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Interfaces
{
    interface IAccount : IUser
    {
        int ID { get; set; }

        //string Username { get; set; }
        string Password { get; set; }
        //string DisplayName { get; set; }

        string AuthToken { get; set; }

        List<IGroup> Groups { get; set; }
        List<IUser> Friends { get; set; }
    }
}
