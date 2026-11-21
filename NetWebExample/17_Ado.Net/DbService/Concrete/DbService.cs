using _17_Ado.Net.DbService.Abstract;
using _17_Ado.Net.Models;
using Microsoft.Data.SqlClient;

namespace _17_Ado.Net.DbService.Concrete
{
    public class DbService(IConfiguration configuration) : IDbService
    {
        private readonly string _con = configuration.GetConnectionString("DefaultConnection")??
            throw new InvalidOperationException("appsettings.json içinde DefaultConnection stringi bulunamadı.");
        public async Task<int> ExecuteNonQueryAsync(string query, params SqlParameter[] parameters)
        {
            await using var connection = new SqlConnection(_con);
            await using var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(parameters);
            await connection.OpenAsync();
            return await command.ExecuteNonQueryAsync();
        }

        public async Task<List<Students>> ExecuteReaderAsync(string query)
        {
            var result = new List<Students>();
            await using var connection = new SqlConnection(_con);
            await using var command = new SqlCommand(query, connection);
            await connection.OpenAsync();
            await using var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                result.Add(new Students
                {
                    Id =(int)reader["Id"],
                    FirstName = reader["FirstName"] as string??string.Empty,
                    LastName = reader["LastName"] as string??string.Empty,
                    Age = reader["Age"] as int? ?? 0
                });
            }
            return result;
        }

        public async Task<object?> ExecuteScalarAsync(string query)
        {
           await using var connection = new SqlConnection(_con);
            await using var command = new SqlCommand(query, connection);
            await connection.OpenAsync();
            return await command.ExecuteScalarAsync();
        }
    }
}
