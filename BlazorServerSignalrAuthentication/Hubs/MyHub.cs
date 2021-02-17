using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerSignalrAuthentication.Hubs
{
    //[Authorize]
    public class MyHub : Hub
    {
        public async Task InvokeSomething()
        {
            var httpCtx = Context.GetHttpContext();
            //var name = httpCtx.Request.Headers["NAME"].ToString();
            var name = httpCtx.Request.Headers["USERID"].ToString();
            await Clients.All.SendAsync("ReceiveMessage", name, " invoked this");
        }

    }
}
