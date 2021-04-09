using Microsoft.AspNetCore.Mvc;
using Load.Models;
using System.Collections.Generic;
using Load.Interfaces;

namespace Load.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        private ITrainerRepository _trainerRepo;

        public TrainersController(
            ITrainerRepository trainerRepo)
        {
            _trainerRepo = trainerRepo;
        }

        //GET api/trainers/
        [HttpGet]
        public ActionResult<IEnumerable<Trainer>> Trainer()
        {
            var result = _trainerRepo.GetAllTrainers();
            return Ok(result);
        }
        
        //GET api/trainers/10
        [HttpGet("{id}")]
        public ActionResult<Trainer> GetTrainerById(int id)
        {
            var result = _trainerRepo.GetTrainerById(id);
            return Ok(result);
        }
    }
}
