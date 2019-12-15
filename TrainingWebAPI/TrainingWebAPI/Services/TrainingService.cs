using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebAPI.Interface;
using TrainingWebAPI.Models;

namespace TrainingWebAPI.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly TrainingDetailsContext _context;
        public TrainingService(TrainingDetailsContext context)
        {
            _context = context;
        }

        public Training AddTraining(Training training)
        {
            var returnValue =_context.Trainings.Add(training);
            int outVal = _context.SaveChanges();
            return returnValue.Entity;
        }

        public IEnumerable<Training> GetAllTrainings()
        {
            return _context.Trainings;
        }

        
    }
}
