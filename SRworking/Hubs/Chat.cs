using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SRworking.Hubs
{
    public class Chat : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).InvokeAsync("connectionmade", "connection made dude");

            await base.OnConnectedAsync();
        }





        public async Task Send(string message)
        {
            await Clients.All.InvokeAsync("Send",  message);
        }
    }
}
