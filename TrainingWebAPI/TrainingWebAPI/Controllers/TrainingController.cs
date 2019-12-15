using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrainingWebAPI.Interface;
using TrainingWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TrainingWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TrainingController : Controller
    {
        private readonly ITrainingService _trainingService;
        public TrainingController(ITrainingService trainingService)
        {
            _trainingService = trainingService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Training> Get()
        {
            return _trainingService.GetAllTrainings();
        }

        // POST: api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Training training)
        {
            _trainingService.AddTraining(training);

            return Ok(training);
        }

    }
}
