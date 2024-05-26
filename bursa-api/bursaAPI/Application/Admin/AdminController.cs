using bursaAPI.Middleware;
using bursaAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace bursaAPI.Application.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController(IBursaService dbService) : ControllerBase
    {
        private const string SuffixSourceName = "admin";

        [AllowAnonymous]
        [HttpPost("create-user")]
        public Task<WrapperResponse> CreateUser([FromBody] SystemUser user)
        {
            var source = $"{SuffixSourceName}-{nameof(CreateUser)}";
            var message = string.Empty;
            if (!ModelState.IsValid)
            {
                message = "Invalid Input Body Try Again";
                return Task.FromResult(ResponseCreation.CreateErrorResponse(source, message));
            }

            var createUserSuccessfully = new SystemUser(dbService).CreateNewUser(user);
            if (createUserSuccessfully > 0)
            {
                return Task.FromResult(ResponseCreation.CreateErrorResponse(source, message));
            }

            return Task.FromResult(ResponseCreation.CreateSuccessResponse(source, null, message, HttpStatusCode.Accepted));
        }
    }
}
