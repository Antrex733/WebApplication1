using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication11.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherforecastServices _weatherforecastServices;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherforecastServices weatherforecastServices)
        {
            _logger = logger;
            _weatherforecastServices = weatherforecastServices;
        }

        [HttpPost("generate")]
        public ActionResult<IEnumerable<WeatherForecast>> Cw([FromQuery] int Rezultatow, [FromBody] Temperatura temp)
        {

            if (Rezultatow < 0 || temp.min > temp.max)
                return BadRequest();

            var result = _weatherforecastServices.Get(Rezultatow, temp.min, temp.max);
            return StatusCode(200, result);
        }
        
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var result = _weatherforecastServices.Get();
            return result;
        }

    }
}