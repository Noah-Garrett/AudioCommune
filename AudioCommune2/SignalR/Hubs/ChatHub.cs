using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AudioCommune2.ViewModels;
using AudioCommune2.Models;
using AudioCommune2.Data;
using System.Data.SqlClient;
using System.Data;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private AudioCommuneDbContext context;

        public ChatHub(AudioCommuneDbContext dbcontext)
        {
            context = dbcontext;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

            Message newMessage = new Message
            {
                //USERID WILL NEED TO BE AN INT ONCE WE HAVE A RELIABLE WAY TO USER CREATE/PERSIST
                //AND HAVE A FUNCTIONING USER DEETS.

                //fething great. db doesnt want to drop. at some point update message userID to a string,
                //set userid to user.

                UserID = 1,
                Text = message,
                ServerID = 1,


            };
            context.Messages.Add(newMessage);
            context.SaveChanges();

        }
    }
}