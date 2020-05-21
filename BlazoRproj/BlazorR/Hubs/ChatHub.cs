using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace BlazoR.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IHttpContextAccessor _accessor;
        public ChatHub(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }
        public async Task SendMessage(string message)
        {
            string user = _accessor.HttpContext.User.Identity.Name;

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