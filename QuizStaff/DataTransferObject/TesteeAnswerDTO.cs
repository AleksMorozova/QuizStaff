using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class TesteeAnswerDTO
    {
        public Guid Id { get; set; }
        public virtual ICollection<AnswerDTO> Answer { get; set; }

        public static implicit operator TesteeAnswerDTO(TesteeAnswer testeeAnswer)
        {
            TesteeAnswerDTO newTesteeAnswer = new TesteeAnswerDTO();
            Conversion.CopyProperty(testeeAnswer, newTesteeAnswer);
            return newTesteeAnswer;
        }
    }
}
