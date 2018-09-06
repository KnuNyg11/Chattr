using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrClient.Interfaces
{
    interface IUser
    {
        string Username { get; set; }
        string DisplayName { get; set; }
    }
}
