using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    /*public WeatherForecastController()
    {
        //_logger = logger;
    }*/

    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return new string[] { "Mehdi-1", "Mehdi-3" };
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<string> Get(int id)
    {
        //return "Max Power";
        return "Les Jackson";
    }
}
