using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TrainingDTO
    {
        public Guid Id { get; set; }
        public String TrainingTitle { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<TesteeTraining> TesteeTrainings { get; set; }

        public static implicit operator TrainingDTO(Training training)
        {
            TrainingDTO newTraining = new TrainingDTO();
            Conversion.CopyProperty(training, newTraining);
            return newTraining;
        }
    }
}
