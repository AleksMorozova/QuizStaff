using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class HistoryDTO
    {
        public Guid Id { get; set; }
        public Guid TesteeId { get; set; }
        public Guid QuestionId { get; set; }
        public virtual TesteeDTO Testee { get; set; }
        public virtual QuestionDTO Question { get; set; }
        public virtual DateTime AnsweringDate { get; set; }
        public virtual ICollection<TesteeAnswerDTO> Answers { get; set; }

        public static implicit operator HistoryDTO(History history)
        {
            HistoryDTO newHistory = new HistoryDTO();
            Conversion.CopyProperty(history, newHistory);
            return newHistory;
        }
    }
}
