using bursaAPI.Middleware;
using bursaAPI.Modals;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bursaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private const string SuffixSourceName = "bursa";

        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

        public WeatherForecastController()
        {

        }

        [HttpGet("get-weather")]
        [AllowAnonymous]
        public async Task<WrapperResponse> Get()
        {
            var message = string.Empty;
            var source = $"{SuffixSourceName}-weather";

            var results = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = 55,
                Summary = Summaries[1]
            }).ToList();

            message = "Successfully loaded weather";
            return await Task.FromResult(ResponseCreation.CreateSuccessResponse(source, results, message)).ConfigureAwait(true);
        }
    }
}
