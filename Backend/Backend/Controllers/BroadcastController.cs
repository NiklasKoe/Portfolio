using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BroadcastController : ControllerBase
    {
        private IHubContext<BroadcastHub, IMessageHubClient> messageHub;

        public BroadcastController( IHubContext<BroadcastHub, IMessageHubClient> messageHub )
        {
            this.messageHub = messageHub;
        }

        [HttpPost("productoffers")]
        public string Get()
        {
            List<string> offers = new List<string>();
            offers.Add("20% Off on IPhone 12");
            offers.Add("15% Off on HP Pavillion");
            offers.Add("25% Off on Samsung Smart TV");
            messageHub.Clients.All.SendOffersToUser(offers);
            return "Offers sent successfully to all users";
        }


        [HttpPost("sendMessage")]
        public string Send( [FromBody] Message msg )
        {
            messageHub.Clients.All.SendMessageToChatroom(msg);
            return "sent message";
        }


    }
}
