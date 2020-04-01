using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UsersServices : IUsersService
    {
        private readonly IAsyncRepository<Users> _asyncRepository;
        public UsersServices(IAsyncRepository<Users> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public async Task<DatabaseResponse> CreateUser(Users users)
        {
            int result = await _asyncRepository.AddAsync(users, "spi_Users");
            return new DatabaseResponse { ResponseCode = result, Results = null };
        }
    }
}
