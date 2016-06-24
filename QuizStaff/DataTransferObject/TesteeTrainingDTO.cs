﻿using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeTrainingDTO
    {
        public Guid Id { get; set; }
        public Guid TesteeID { get; set; }
        public Guid TrainingID { get; set; }
        public virtual TesteeDTO Testee { get; set; }
        public virtual TrainingDTO Training { get; set; }

        public static implicit operator TesteeTrainingDTO(TesteeTraining testeeTrainings)
        {
            TesteeTrainingDTO newTesteeTrainings = new TesteeTrainingDTO();
            newTesteeTrainings.Id = testeeTrainings.Id;

            newTesteeTrainings.Training = new TrainingDTO();
            Conversion.CopyProperty(testeeTrainings.Training, newTesteeTrainings.Training);

            return newTesteeTrainings;
        }
    }
}
