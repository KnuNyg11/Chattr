using ChattrClient.Interfaces;
using ChattrClient.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChattrClient.Models
{
    class ChattrUser : IUser
    {
        public bool IsAdmin { get; set; }

        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string AuthToken { get; set; }

        public List<IUser> Friends { get; set; }
        public List<uint> Groups { get; set; }

        public Client Client { get; set; }

        public ChattrUser()
        {
            Client = new Client();
        }

        public void SendMessage(string message)
        {
            //TODO Add networking to send message to server
            //Psuedo: Network.SendMessage(AuthToken, message);
        }
        public void SendMessage(string message, List<IUser> users)
        {
            //TODO Add networking to send message to friends in server
            //Psuedo: Network.SendMessage(AuthToken, string, List<IUser>);
        }
    }
}
