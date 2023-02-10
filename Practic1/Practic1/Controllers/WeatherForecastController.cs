using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Practic1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static List<string> Summaries = new()
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<string> Get()
        {
            return Summaries;
        }
        [HttpGet("Введите значения для сортировки")]
        public IActionResult GetAll(int? strategy)
        {
            try
            {
                var z = Summaries;
                if (strategy == null)
                {
                    Summaries = z;
                }
                if (strategy == 1)
                {
                    z = Summaries;
                    Summaries.Sort();
                }
                if (strategy == -1)
                {
                    z = Summaries;
                    Summaries.Sort();
                    Summaries.Reverse();
                }
                
                return Ok();
            }
            catch
            {
                return BadRequest("Некорректное значение параметра sortStrategy");
            }

        }
        [HttpPost]
        public IActionResult Add(string name)
        {
            Summaries.Add(name);
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(int index)
        {
            try
            {
                Summaries.RemoveAt(index);
                return Ok();
            }
            catch
            {
                return BadRequest("Введен неверный индекс!");
            }
        }
        
        [HttpPut]
        public IActionResult Update(int index, string name)
        {
            try
            {
                Summaries[index] = name;
                return Ok();
            }
            catch
            {
                return BadRequest("Введен неверный индекс!");
            }
        }
        [HttpGet("Индекс")]
        public string Get(int index)
        {
            try
            {
                return Summaries[index];
            }
            catch
            {
                return "Введен неверный индекс!";
            }
        }
        [HttpGet("Имя")]
        public int Get(string find_by_name)
        {

            return Summaries.Count(x => x == find_by_name);
        }
    }
}