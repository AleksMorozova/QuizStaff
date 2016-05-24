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
        private BindingList<QuestionDTO> questions;
        public TrainingDTO() 
        {
            questions = new BindingList<QuestionDTO>();
        }
        public Guid Id { get; set; }
        public String TrainingTitle { get; set; }
        public BindingList<QuestionDTO> Questions { get { return questions; } set { questions = value; } }
        public ICollection<TesteeTrainingDTO> TesteeTrainings { get; set; }

        public static implicit operator TrainingDTO(Training training)
        {
            TrainingDTO newTraining = new TrainingDTO();
            Conversion.CopyProperty(training, newTraining);
            if (training.Questions.Count()>0)
            {
                foreach (var q in training.Questions)
                newTraining.Questions.Add((QuestionDTO)q);
            }
            return newTraining;
        }
    }
}
