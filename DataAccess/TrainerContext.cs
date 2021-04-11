using Load.Models;
using Microsoft.EntityFrameworkCore;

namespace Load.DataAccess
{
    public class TrainerContext : DbContext
    {
        public TrainerContext(DbContextOptions<TrainerContext> opt) : base(opt)
        {

        }

        public DbSet<Trainer> Trainers { get; set; }
    }
}