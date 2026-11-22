using _18_Dapper.Data;
using _18_Dapper.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace _18_Dapper.Controllers
{
    public class ProductController(DapperContext context) : Controller
    {

        public async Task <IActionResult> Index()
        {
            const string query="""
                 Select p.ProductId,p.Name,p.CategoryId,p.Price,c.CategoryId,c.Name
                 from Products p join Categories c on p.CategoryId=c.CategoryId
                """;
            using var connection = context.CreateConnection();
            var products = await connection.QueryAsync<Product, Category, Product>(
                query,
                (product, category) =>
                {
                    product.Category = category;
                    return product;
                },
                splitOn: "CategoryId"
                );

            return View(products.ToList());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = await KategoriListesi();
            return View(new Product());
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await KategoriListesi();
                return View(product);
            }
            const string query = "Insert into Products(Name,Price,CategoryId) values(@Name,@Price,@CategoryId)";
            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(query, product);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CreateCategory()
        {
           
            return View(new Category());
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await KategoriListesi();
                return View(product);
            }
            const string query = "Insert into Categories(Name) values(@Name)";
            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(query, product);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var product = await UrunGetir(id);
            if (product is null)
            {
                return NotFound("Ürün bulunamadı");
            }
            ViewBag.Categories = await KategoriListesi();
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await KategoriListesi();
                return View(product);
            }
            const string query = "Update Products set Name=@Name,Price=@Price,CategoryId=@CategoryId where ProductId=@ProductId";
            using var connection = context.CreateConnection();
            var affected = await connection.ExecuteAsync(query, product);
            if (affected == 0)
            {
                return NotFound("Güncellenecek ürün bulunamadı");
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int id)
        {
            var products = await UrunGetir(id);
            return products is null ? NotFound("ürün bulunamadı") : View(products);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var products = await UrunGetir(id);
            return products is null ? NotFound("ürün bulunamadı") : View(products);
        }
        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using var connection = context.CreateConnection();
            var affected = await connection.ExecuteAsync("Delete from Products where ProductId=@Id", new { Id = id });
            ViewBag.Message = affected > 0 ? "Ürün silindi" : "Ürün bulunamadı";
            return View("DeleteResult");
        }
        private async Task<Product?> UrunGetir(int id)
        {
            using var connection = context.CreateConnection();
            return await connection.QuerySingleOrDefaultAsync<Product>(
                "Select * from Products where ProductId=@Id", new { Id = id }
                );
        }
        private async Task<SelectList> KategoriListesi()
        {
            using var connection = context.CreateConnection();
            var categories = await connection.QueryAsync<Category>("Select CategoryId,Name From Categories");
            return new SelectList(categories, nameof(Category.CategoryId), nameof(Category.Name));
        }
    }
}
