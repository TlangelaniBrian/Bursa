using bursaAPI.Middleware;
using bursaDAL;
using bursaDAL.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace bursaAPI.Application.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController(BursaContext bursaContex) : ControllerBase
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

            user.Name = "Brian";
            return Task.FromResult(ResponseCreation.CreateSuccessResponse(source, user, message, HttpStatusCode.Accepted));
        }

        [AllowAnonymous]
        [HttpGet("get-users")]
        public Task<WrapperResponse> GetUsers([FromBody] string userId)
        {
            var source = $"{SuffixSourceName}-{nameof(GetUsers)}";
            var message = string.Empty;

            var students = bursaContex.Users
                .Include(r => r.Role)
                .Where(s => s.RoleId == Constants.StudentRoleId)
                .AsNoTrackingWithIdentityResolution()
                .ToList();

            return Task.FromResult(ResponseCreation.CreateSuccessResponse(source, students, message, HttpStatusCode.Accepted));
        }

    }
}
