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

        public string TrainingTitle { get; set; }

        public BindingList<QuestionDTO> Questions { get; set; }

        public BindingList<TesteeTrainingDTO> TesteeTrainings { get; set; }

        public static implicit operator TrainingDTO(Training training)
        {
            TrainingDTO newTraining = new TrainingDTO();
            newTraining.Questions = new BindingList<QuestionDTO>();
            if (training != null)
            {
                Conversion.CopyProperty(training, newTraining);

                foreach (var q in training.Questions)
                {
                    newTraining.Questions.Add((QuestionDTO)q);


                    //Question question = new Question();
                    //Conversion.CopyProperty(q, question);
                    //question.Answers = new BindingList<Answer>();

                    //foreach (var a in q.Answers)
                    //{
                    //    Answer newA = new Answer();
                    //    Conversion.CopyProperty(a, newA);
                    //    question.Answers.Add(newA);
                    //}
                    //newTraining.Questions.Add(question);

                }

            }
            return newTraining;
        }

    }
}
