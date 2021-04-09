using System.Collections.Generic;
using Load.Models;
using Load.Interfaces;


namespace Load.DataAccess
{
    public class MockTrainerRepo : ITrainerRepository
    {
        public IEnumerable<Trainer> GetAllTrainers()
        {
            return new List<Trainer> {
                new Trainer {
                Id = 1,
                FirstName = "Nirmal",
                LastName = "K",
                Gender = 1,
                Phone = null,
                Trainees = new List<Trainee>(),
                Email = "nirmal@load.com",
            }
        };
    }

        public Trainer GetTrainerById(int Id)
        {
            return new Trainer()
            {
                Id = 1,
                FirstName = "Nirmal",
                LastName = "K",
                Gender = 1,
                Phone = null,
                Trainees = new List<Trainee>(),
                Email = "nirmal@load.com",
            };
        }

    }
}