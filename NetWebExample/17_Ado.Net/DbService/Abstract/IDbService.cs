using _17_Ado.Net.Models;
using Microsoft.Data.SqlClient;

namespace _17_Ado.Net.DbService.Abstract
{
    public interface IDbService
    {
        // Update , Delete, Insert işlemleri için kullanılacak metot
        Task<int> ExecuteNonQueryAsync(string query,params SqlParameter[] parameters);
        //Select işlemleri için kullanılacak metot
        Task<List<Students>> ExecuteReaderAsync(string query);
        // Tek bir değer döndüren sorgular için kullanılacak metot
        //Aggregate fuctions (SUM, COUNT, AVG, MIN, MAX) gibi tek bir değer döndüren sorgular için kullanılacak metot
        Task<object?> ExecuteScalarAsync(string query);

    }
}
