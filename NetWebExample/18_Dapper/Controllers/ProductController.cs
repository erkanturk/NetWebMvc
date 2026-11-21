using _18_Dapper.Data;
using _18_Dapper.Models;
using Dapper;
using Microsoft.AspNetCore.Mvc;

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
    }
}
