using _16_Web_Api.DataContext;
using _16_Web_Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _16_Web_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ProductController(ProductContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var totalCount = await context.Products.CountAsync();
            var products = await context.Products
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
            Response.Headers.Append("X-Total-Count", totalCount.ToString());
            Response.Headers.Append("X-Page", page.ToString());
            Response.Headers.Append("X-PageSize", pageSize.ToString());
            return Ok(products);
        }
    }
}
