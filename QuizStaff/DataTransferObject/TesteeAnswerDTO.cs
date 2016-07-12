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
        public Guid HistoryID { get; set; }
        public Guid AnswerID { get; set; }
        public virtual HistoryDTO History { get; set; }
        public virtual AnswerDTO Answer { get; set; }

        public static implicit operator TesteeAnswerDTO(TesteeAnswer testeeAnswer)
        {
            TesteeAnswerDTO newTesteeAnswer = Conversion.ConvertTesteeAnswerToDTO(testeeAnswer);
            return newTesteeAnswer;
        }
    }
}
