using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using CustomerManagerAPI.Models;

namespace CustomerManagerAPI.Repositories
{
    public class CustomerRepository
    {
        private readonly IDbConnection _db;

        public CustomerRepository(IDbConnection db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _db.QueryAsync<Customer>("EXEC GetAllCustomers");
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _db.QueryFirstOrDefaultAsync<Customer>("EXEC GetCustomerById @Id", new { Id = id });
        }

        public async Task<int> CreateCustomer(Customer customer)
        {
            const string sql = @"EXEC InsertCustomer @Name, @Email, @Phone";
            return await _db.ExecuteScalarAsync<int>(sql, customer);
        }

        public async Task<bool> UpdateCustomer(Customer customer)
        {
            const string sql = @"EXEC UpdateCustomer @Id, @Name, @Email, @Phone";
            var rowsAffected = await _db.ExecuteAsync(sql, customer);
            return rowsAffected > 0;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            const string sql = @"EXEC DeleteCustomer @Id";
            var rowsAffected = await _db.ExecuteAsync(sql, new { Id = id });
            return rowsAffected > 0;
        }
    }
}
