using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Enums;
using ApplicationCore.Extensions;
using ApplicationCore.Interfaces;
using ApplicationCore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Users users)
        {
            DatabaseResponse response = await _usersService.CreateUser(users);

            if (response.ResponseCode == (int)DbReturnValue.CreateSuccess)
            {
                return Ok(new OperationResponse
                {
                    HasSucceeded = true,
                    IsDomainValidationErrors = false,
                    Message = EnumExtensions.GetDescription(DbReturnValue.CreateSuccess),
                    ReturnedObject = response.Results
                });
            }
            else
            {
                return Ok(new OperationResponse
                {
                    HasSucceeded = false,
                    IsDomainValidationErrors = false,
                    Message = EnumExtensions.GetDescription(DbReturnValue.RecordExists),
                    ReturnedObject = response.Results
                });
            }
        }
    }
}