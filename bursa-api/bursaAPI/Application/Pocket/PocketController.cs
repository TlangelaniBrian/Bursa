using bursaAPI.Middleware;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;

namespace bursaAPI.Application.Pocket
{
    [Route("api/[controller]")]
    [ApiController]
    public class PocketController() : ControllerBase
    {
        private const string SuffixSourceName = "pocket";

        [AllowAnonymous]
        [HttpGet("get-pockets")]
        public Task<WrapperResponse> GetPockets()
        {
            var source = $"{SuffixSourceName}-{nameof(GetPockets)}";

            string message;
            if (!ModelState.IsValid)
            {
                message = $"Invalid parameter string type input Try Again";
                return Task.FromResult(ResponseCreation.CreateErrorResponse(source, message));
            }

            message = "Successful Response.";
            var pocketIds = new Collection<int> { 1, 2, 3, 4, 5 };
            return Task.FromResult(ResponseCreation.CreateSuccessResponse(source, pocketIds, message));
        }
    }
}
