﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazoR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            string user = Context.User.Identity.Name;

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        //public async Task SendChatMessage(string who, string message)
        //{
        //    string name = Context.User.Identity.Name;

        //    await Clients.Group(who).SendAsync("ReceiveMessage", name, message);
        //}

        //public async Task JoinInGroup()
        //{
        //    string name = Context.User.Identity.Name;

        //    if (name == "admin@gmail.com")
        //    {
        //        await Groups.AddToGroupAsync(Context.ConnectionId, "admin");
        //    }

        //}

        //public override Task OnConnectedAsync()
        //{
        //    string name = Context.User.Identity.Name;

        //    Groups.AddToGroupAsync(Context.ConnectionId, name);
        //    return base.OnConnectedAsync();
        //}
    }
}