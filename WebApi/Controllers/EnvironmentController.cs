using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnvironmentController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private IConfiguration Configuration;

        public EnvironmentController(ILogger<WeatherForecastController> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        [HttpGet]
        public String Get()
        {
            var myKeyValue = Configuration["Environment"];

            return myKeyValue;
        }
    }
}
