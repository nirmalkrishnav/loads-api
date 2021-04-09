using System.Collections.Generic;

namespace Load.Models
{

    public class Trainer : Person
    {
        public List<Trainee> Trainees { get; set; }
    }
}
