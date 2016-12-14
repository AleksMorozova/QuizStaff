using DomainModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TrainingDTO
    {
        public Guid Id { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdditional { get; set; }

        public string TrainingTitle { get; set; }

        public BindingList<QuestionDTO> Questions { get; set; }

        public BindingList<TesteeTrainingDTO> TesteeTrainings { get; set; }

        public static implicit operator TrainingDTO(Training training)
        {
            TrainingDTO newTraining = Conversion.ConvertTrainingToDTO(training);

            return newTraining;
        }

    }
}
