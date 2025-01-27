using Microsoft.AspNetCore.SignalR;

namespace Backend
{
    public class BroadcastHub : Hub<IMessageHubClient>
    {

        //public async Task NewMessage( string message ) =>
        //    await Clients.All.SendAsync(message);


        public async Task SendOffersToUser( List<string> message )
        {
            await Clients.All.SendOffersToUser(message);
        }

        public async Task SendMessageToChatroom( Message msg )
        {
            await Clients.All.SendMessageToChatroom(msg);
        }
    }
}
