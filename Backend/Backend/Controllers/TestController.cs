using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly string STR_INCOMPLETE = "<strong>Note</strong>: In upcoming versions, theming architecture will be redesigned to utilize CSS variables instead of " +
            "SCSS variables in a backward compatible way for a dynamic approach. In addition, a new <strong>Unstyled</strong> mode will be provided as an alternative to the " +
            "default styling so that CSS libraries like Tailwind or Bootstrap can be used to style the components. This work is planned to be completed in Q3 2023. </p>";

        [HttpGet("website")]
        public async Task<ActionResult> GetWebsiteContent()
        {
            //
            using var client = new HttpClient();
            //
            var content = await client.GetStringAsync("https://primeng.org/theming");
            //
            if (!content.Contains(STR_INCOMPLETE)) {
                return Ok("Take a look, something happend!");
            }
            //
            return Ok("still not ready");
        }


        [HttpGet("media")]
        public async Task<ActionResult> GetMediaContent()
        {
            using var client = new HttpClient();
            //
            using var file = await client.GetStreamAsync("https://www.youtube.com/990b720e-2f64-4d22-844f-68a242ac90dd").ConfigureAwait(false);
            using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);
            var result = memoryStream.ToArray();

            //
            return Ok(result);
            //

        }



    }
}
