using _17_Ado.Net.DbService.Abstract;
using _17_Ado.Net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace _17_Ado.Net.Controllers
{
    public class HomeController(IDbService dbService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddData()
        {
            const string query= "insert into Students(FirstName,LastName,Age) values('Erkan','Türk','32')";
            await dbService.ExecuteNonQueryAsync(query);
            return RedirectToAction("GetData");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddDataSecure(Students students)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));

            }
            const string query = "insert into Students(FirstName,LastName,Age) values(@FirstName,@LastName,@Age)";
            await dbService.ExecuteNonQueryAsync(query,
              new SqlParameter("@FirstName", students.FirstName),
               new SqlParameter("@LastName", students.LastName),
                new SqlParameter("@Age", students.Age));
            return RedirectToAction("GetData");
        }
        public async Task<IActionResult> GetData()
        {
           var students = await dbService.ExecuteReaderAsync("select * from Students");
            return View(students);
        }
        public async Task<IActionResult> GetDataCount()
        {
            var count = await dbService.ExecuteScalarAsync("Select Count(*) from Students");
            return View(count);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateDataSecure(Students students)
        {
            const string query = "Update Students set FirstName=@FirstName,LastName=@LastName,Age=@Age where Id=@Id";
            await dbService.ExecuteNonQueryAsync(query,
                new SqlParameter("@FirstName",students.FirstName),
                new SqlParameter("@LastName",students.LastName),
                new SqlParameter("@Age",students.Age),
                new SqlParameter("@Id",students.Id)
                );
            return RedirectToAction(nameof(GetData));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteDataSecure(int id)
        {
            const string query = "Delete from students where Id=@Id";
            await dbService.ExecuteNonQueryAsync(query, new SqlParameter("@Id", id));
            return RedirectToAction(nameof(GetData));
            
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
