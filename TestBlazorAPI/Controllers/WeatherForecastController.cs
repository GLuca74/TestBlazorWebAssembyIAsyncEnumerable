using Microsoft.AspNetCore.Mvc;

namespace TestBlazorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public async IAsyncEnumerable<int> Get()
        {
            for (int i = 0; i < 1000000; i++)
            {
                yield return i;
            }
        }
    }
}