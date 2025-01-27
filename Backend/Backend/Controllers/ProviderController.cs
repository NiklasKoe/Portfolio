using Backend.Models.DB;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProviderController( RatingContext context ) : ControllerBase
    {

        public RatingContext _db = context;


        [HttpGet("providers")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Providers.ToListAsync());
        }

        [HttpPost("providers")]
        public async Task<IActionResult> Add( [FromBody] CreateOrUpdateProvider provider )
        {
            var result = await _db.Providers.AddAsync(new Provider {
                Name = provider.Name
            });
            await _db.SaveChangesAsync();
            //
            return Ok(result.Entity);
        }

    }
}
