using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrServer.Enums
{
    enum ResponseType
    {
        //General
        UNKNOWN = -1,
        NONE = 0,
        ERROR = 1,
        OK = 2,
        SUCCESS = 3,
        
        //User Authentication
        AUTHORIZED = 10,
        UNAUTHORIZED = 11,

        //Misc
        MESSAGE = 20
    }
}
