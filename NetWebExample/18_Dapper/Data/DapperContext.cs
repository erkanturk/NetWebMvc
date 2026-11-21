using Microsoft.Data.SqlClient;
using System.Data;

namespace _18_Dapper.Data
{
    public class DapperContext(IConfiguration configuration)
    {
        private readonly string _con = configuration.GetConnectionString("DefaultConnection") ??
            throw new InvalidOperationException("Appsettings.json içinde connection verisi yok");

        public IDbConnection CreateConnection() => new SqlConnection(_con);
    }
}
