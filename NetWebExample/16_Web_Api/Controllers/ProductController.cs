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
        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound($"Product with ID {id} not found.");
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("Url deki id ile gövdedeki id aynı olmalıdır");
            }
            context.Entry(product).State = EntityState.Modified;
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                if (!await ProductExists(id))
                {
                    return NotFound("Ürün bulunamadı" + ex.Message);
                }
            }
            return NoContent();//204
        }
        private Task<bool> ProductExists(int id)
            => context.Products.AnyAsync(p => p.Id == id);

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound("Ürün bulunamadı");
            }
            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return NoContent();//204
        }
    }
}
