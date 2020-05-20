using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoR.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public void SendMessage(string who, string message)
        {
            string name = Context.User.Identity.Name;

            Clients.Group(who).SendAsync(name + ": " + message);
        }

        public override Task OnConnectedAsync()
        {
            string name = Context.User.Identity.Name;

            Groups.AddToGroupAsync(Context.ConnectionId, name);

            return base.OnConnectedAsync();
        }
    }
}