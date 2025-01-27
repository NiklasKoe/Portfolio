using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers {

    [Route("api")]
    [ApiController]
    public class OpenAiController : ControllerBase {

        //public async Task<ActionResult> GetAnswer() {
        //    //
        //    ChatClient client = new(model: "gpt-4o", Environment.GetEnvironmentVariable("OPEN_API_KEY"));
        //    //
        //    ChatCompletion completion = client.CompleteChat("Say 'this is a test.'");
        //}
    }
}
