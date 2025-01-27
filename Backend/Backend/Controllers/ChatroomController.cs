using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class ChatroomController : ControllerBase
    {

        public List<Chatroom> Chatrooms = new();


        [HttpPost("chatroom")]
        public async Task<IActionResult> CreateChatroom( [FromBody] Chatroom cr )
        {
            cr.Id = Guid.NewGuid().ToString();
            Chatrooms.Add(cr);
            return Ok(cr);
        }
    }
}
