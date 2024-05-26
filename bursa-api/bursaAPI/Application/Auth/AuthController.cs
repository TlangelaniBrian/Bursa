using bursaAPI.Middleware;
using bursaAPI.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bursaAPI.Application.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private const string SuffixSourceName = "jwt-auth";

        [AllowAnonymous]
        [HttpGet("generate-token")]
        public Task<WrapperResponse> GenerateToken(string applicationId)
        {
            var source = $"{SuffixSourceName}-{nameof(GenerateToken)}";

            string message;
            if (!ModelState.IsValid)
            {
                message = $"Invalid parameter string type input: {applicationId} Try Again";

                return Task.FromResult(ResponseCreation.CreateErrorResponse(source, message));
            }

            var tokens = new Token
            {
                JwtToken = "token",
                JwtTokenExpiryDate = DateTime.Now.AddDays(12),
                JwtRefreshToken = "refresh token",
                JwtRefreshExpiryDate = DateTime.Now.AddDays(11)
            };
            message = "Successfully created a JWT token AND JWT refresh token.";
            return Task.FromResult(ResponseCreation.CreateSuccessResponse(source, tokens, message));
        }

    }
}
