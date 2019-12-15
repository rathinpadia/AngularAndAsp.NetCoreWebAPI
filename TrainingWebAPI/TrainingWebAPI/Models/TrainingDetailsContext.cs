using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrainingWebAPI.Models
{
    public class TrainingDetailsContext : DbContext
    {
        public TrainingDetailsContext(DbContextOptions<TrainingDetailsContext> options) : base(options)
        {

        }

        public DbSet<Training> Trainings { get; set; }
    }
}
