//using EnergyAPI.DateCalcBusinessObjects;
//using EnergyAPI.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace EnergyAPI.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private readonly IEnergyCalcBO energy;

//        private static readonly string[] Summaries = new[]
//        {
//            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//        };

//        private readonly ILogger<WeatherForecastController> _logger;

//        public WeatherForecastController(ILogger<WeatherForecastController> logger, IEnergyCalcBO _energy)
//        {
//            _logger = logger;
//            this.energy = _energy;
//        }

//        [HttpGet]
//        public IEnumerable<WeatherForecast> Get()
//        {
//            var rng = new Random();
//            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//            {
//                Date = DateTime.Now.AddDays(index),
//                TemperatureC = rng.Next(-20, 55),
//                Summary = Summaries[rng.Next(Summaries.Length)]
//            })
//            .ToArray();
//        }

//        [HttpPost]
//        public EnergyModel UpdateData(EnergyModel model)
//        {
//            //IList<EnergyModel> listModels = null;

//            if (this.energy.CalculateWeekEnd(model.EnergySellingDate))
//            {
//                model.EnergySellingPrise = model.EnergySellingPrise / 10;
//            }
//            TextWriter writer;
//            using (writer = new StreamWriter(@"C:\Temp.json", append: true))
//            {
//                writer.WriteLine(JsonConvert.SerializeObject(model));
//            }

//            //Read data from json file

//            return model;
//        }
//    }
//}
