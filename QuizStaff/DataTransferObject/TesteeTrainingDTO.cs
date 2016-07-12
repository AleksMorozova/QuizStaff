using DomainModel;
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
        public virtual TesteeDTO Testee { get; set; }
        public virtual TrainingDTO Training { get; set; }

        public bool IsActive { get; set; }
        public bool IsSelect { get; set; }

        public static implicit operator TesteeTrainingDTO(TesteeTraining testeeTrainings)
        {
            return Conversion.ConvertTesteeTrainingToDTO(testeeTrainings);
        }
    }
}
