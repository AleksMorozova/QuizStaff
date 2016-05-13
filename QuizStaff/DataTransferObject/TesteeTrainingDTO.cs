using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    class TesteeTrainingDTO
    {
        public Guid Id { get; set; }
        public Guid TesteeID { get; set; }
        public Guid TrainingID { get; set; }
        public virtual Testee Testee { get; set; }
        public virtual Training Training { get; set; }

        public static implicit operator TesteeTrainingDTO(TesteeTraining testeeTrainings)
        {
            TesteeTrainingDTO newTesteeTrainings = new TesteeTrainingDTO();
            Conversion.CopyProperty(testeeTrainings, newTesteeTrainings);
            return newTesteeTrainings;
        }
    }
}
