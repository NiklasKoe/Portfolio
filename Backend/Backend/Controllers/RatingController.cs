using Backend.Models.DB;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class RatingController( RatingContext context ) : ControllerBase
    {

        public RatingContext _db = context;


        [HttpGet("ratings")]
        public async Task<ActionResult<List<RatingListEntry>>> Get()
        {
            //
            var result = await _db.Ratings.Select(x => new RatingListEntry {
                ProductName = _db.Products.FirstOrDefault(z => z.Id == x.ProductId).Name,
                ProviderName = _db.Providers.FirstOrDefault(z => z.Id == x.ProviderId).Name,
                RatingId = x.Id,
                Value = x.Value,
            }).ToListAsync();
            //
            return Ok(result);
        }

        [HttpPost("rating")]
        public async Task<IActionResult> Add( [FromBody] CreateOrUpdateRating rating )
        {
            var result = await _db.Ratings.AddAsync(new Rating {
                Value = rating.Value,
                ProductId = rating.ProductId,
                ProviderId = rating.ProviderId,
            });
            await _db.SaveChangesAsync();
            //
            return Ok(result.Entity);
        }



    }
}
