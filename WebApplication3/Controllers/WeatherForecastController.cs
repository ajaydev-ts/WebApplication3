using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers.Models
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> Get()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}
        School school = new School();
        [HttpGet("student")]

        public string Get()
        {
            string JSONresult;
            DataSet ds = new DataSet();
            ds = school.studentgetdata();
            JSONresult = JsonConvert.SerializeObject(ds.Tables[0]);
            return JSONresult;
        }

        [HttpGet("mark")]
        public string markGet(int Id)
        {
            string JSONresult;
            DataSet ds = new DataSet();
            ds = school.markgetdata(Id);
            JSONresult = JsonConvert.SerializeObject(ds.Tables[0]);
            return JSONresult;
        }
        [HttpPost("Student")]
        
        public string student(Student st)
        {
            school.insertStudent(st);
            return "Success";
        }
        [HttpPost("Mark")]
        
        public string mark(Mark mk)
        {
            school.insertMark(mk);
            return "Success";
        }
    
    }
}