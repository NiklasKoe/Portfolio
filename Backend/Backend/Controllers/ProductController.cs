using Backend.Models.DB;
using Backend.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api")]
    [ApiController]
    public class ProductController( RatingContext context ) : ControllerBase
    {

        public RatingContext _db = context;


        [HttpGet("products")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _db.Products.ToListAsync());
        }

        [HttpPost("product")]
        public async Task<IActionResult> Add( [FromBody] CreateOrUpdateProduct product )
        {
            var result = await _db.Products.AddAsync(new Product {
                Name = product.Name,
            });
            await _db.SaveChangesAsync();
            //
            return Ok(result.Entity);
        }
    }
}
