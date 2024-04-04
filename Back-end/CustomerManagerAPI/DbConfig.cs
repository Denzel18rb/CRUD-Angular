using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CustomerManagerAPI.Infrastructure
{
    public class DbConfig
    {
        public static IDbConnection GetConnection(IConfiguration configuration)
        {
            return new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
    }
}
