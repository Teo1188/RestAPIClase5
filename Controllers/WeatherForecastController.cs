using Microsoft.AspNetCore.Mvc;

namespace RestAPIClase5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly List<WeatherForecast> WeatherData = new List<WeatherForecast>();
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // GET: /WeatherForecast
        [HttpGet]
        public ActionResult<IEnumerable<WeatherForecast>> Get()
        {
            return Ok(WeatherData);
        }

        // GET: /WeatherForecast/{id}
        [HttpGet("{id}")]
        public ActionResult<WeatherForecast> GetById(int id)
        {
            var item = WeatherData.FirstOrDefault(w => w.Id == id);
            if (item == null)
            {
                return NotFound(new { message = "Item not found" });
            }
            return Ok(item);
        }

        // POST: /WeatherForecast
        [HttpPost]
        public ActionResult<WeatherForecast> Create([FromBody] WeatherForecast weather)
        {
            // Validar los datos de entrada
            if (weather == null || string.IsNullOrWhiteSpace(weather.Summary))
            {
                return BadRequest(new { message = "Invalid weather data" });
            }

            // Asignar un Id único
            weather.Id = WeatherData.Count > 0 ? WeatherData.Max(w => w.Id) + 1 : 1;

            // Agregar el recurso a la lista
            WeatherData.Add(weather);

            // Retornar el recurso creado con su ubicación
            return CreatedAtAction(nameof(GetById), new { id = weather.Id }, weather);
        }

        // PUT: /WeatherForecast/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] WeatherForecast updatedWeather)
        {
            var existingWeather = WeatherData.FirstOrDefault(w => w.Id == id);
            if (existingWeather == null)
            {
                return NotFound(new { message = "Item not found" });
            }

            existingWeather.Date = updatedWeather.Date;
            existingWeather.TemperatureC = updatedWeather.TemperatureC;
            existingWeather.Summary = updatedWeather.Summary;

            return NoContent();
        }

        // DELETE: /WeatherForecast/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var weatherToDelete = WeatherData.FirstOrDefault(w => w.Id == id);
            if (weatherToDelete == null)
            {
                return NotFound(new { message = "Item not found" });
            }

            WeatherData.Remove(weatherToDelete);
            return NoContent();
        }
    }
}
