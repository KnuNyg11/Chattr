using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using ChattrClient.Models;

namespace ChattrClient.Network
{
    class Client
    {
        public Socket Socket { get; set; }

        public Client()
        {
            Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
        }
        public Client(string authToken)
        {
            Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            //TODO Add sending AuthToken Packet to server
        }
        public Client(string username, string password)
        {
            Socket = new Socket(SocketType.Stream, ProtocolType.Tcp);
            //TODO Add sending Login Packet to server, save AuthToken response for later use
        }
    }
}

/* REGISTER
* c -> s
* string Username
* string Password
* string Email
* 
* s -> c
* ResponseType Response
*/
/* LOGIN
* c -> s
* string Username
* string Password
* 
* s -> c
* ResponseType Response
* string AuthToken
*/

/* CLIENT SEND MESSAGE
* c -> s
* IGroup[] Groups
* string Message
* TimeDate Timestamp
* string AuthToken / IUser Author
* 
* s -> c
* ResponseType Response
*/
/* CLIENT RECEIVE MESSAGE
* s -> c
* ResponseType Response
* IGroup Group
* int MessageID
* string Message
* DateTime Timestamp
* IUser Author
*/

/* CREATE GROUP
* c -> s
* string GroupName
* DateTime Timestamp
* string AuthToken
* 
* s -> c
* ResponseType Response
* string GroupToken
*/
/* JOIN GROUP
* c -> s
* IGroup Group
* string GroupAuth
* string AuthToken
* 
* s -> c
* ResponseType Response
*/
