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
        public virtual Testee Testee { get; set; }
        public virtual Question Question { get; set; }
        public virtual DateTime AnsweringDate { get; set; }
        public virtual ICollection<TesteeAnswer> Answers { get; set; }

        public static implicit operator HistoryDTO(History history)
        {
            HistoryDTO newHistory = new HistoryDTO();
            Conversion.CopyProperty(history, newHistory);
            return newHistory;
        }
    }
}
