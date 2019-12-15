using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingWebAPI.Models;

namespace TrainingWebAPI.Interface
{
    public interface ITrainingService
    {
        IEnumerable<Training> GetAllTrainings();
        Training AddTraining(Training training);
    }
}
