﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class Conversion
    {
        public static void CopyProperty(object from, object to)
        {
            foreach (System.Reflection.PropertyInfo info in from.GetType().GetProperties())
            {
                try
                {
                    if (info.CanWrite)
                    {
                        to.GetType().GetProperty(info.Name).SetValue(to, info.GetValue(from, null), null);
                    }
                }
                catch
                { 
                    //TODO: write to log 
                }
            }
        }

        public static Training ConvertTrainingFromDTO (TrainingDTO currentTraining)
        {
            Training newTraining = new Training();
            Conversion.CopyProperty(currentTraining, newTraining);
            newTraining.Questions = new BindingList<Question>();
            foreach (var q in currentTraining.Questions)
            {
                Question question = new Question();
                Conversion.CopyProperty(q, question);
                question.Answers = new BindingList<Answer>();

                foreach (var a in q.Answers)
                {
                    Answer newA = new Answer();
                    Conversion.CopyProperty(a, newA);
                    question.Answers.Add(newA);
                }
                newTraining.Questions.Add(question);
            }

            return newTraining;
        }

        public static TrainingDTO ConvertTrainingToDTO(Training currentTraining)
        {
            TrainingDTO newTraining = new TrainingDTO();
            Conversion.CopyProperty(currentTraining, newTraining);
            newTraining.Questions = new BindingList<QuestionDTO>();
            foreach (var q in currentTraining.Questions)
            {
                QuestionDTO question = new QuestionDTO();
                Conversion.CopyProperty(q, question);
                question.Answers = new BindingList<AnswerDTO>();

                foreach (var a in q.Answers)
                {
                    AnswerDTO newA = new AnswerDTO();
                    Conversion.CopyProperty(a, newA);
                    question.Answers.Add(newA);
                }
                newTraining.Questions.Add(question);
            }

            return newTraining;
        }
    }
}

