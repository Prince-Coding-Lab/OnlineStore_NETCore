using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        private readonly IConfiguration _config;
        public EfRepository(IConfiguration config)
        {
            _config = config;
        }
        public IDbConnection dbConnection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("MyConnString"));
            }
        }


        public async Task<int> AddAsync(T entity, string sp)
        {

            using (IDbConnection conn = dbConnection)
            {
                conn.Open();
                int res = await conn.ExecuteScalarAsync<int>(sp, param: entity, commandType: CommandType.StoredProcedure);
                conn.Close();
                return res;
            }
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
