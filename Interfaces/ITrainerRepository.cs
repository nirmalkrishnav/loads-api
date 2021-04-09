using System.Collections.Generic;
using Load.Models;

namespace Load.Interfaces
{
    public interface ITrainerRepository
    {
        IEnumerable<Trainer> GetAllTrainers();
        Trainer GetTrainerById(int Id);
    }
}