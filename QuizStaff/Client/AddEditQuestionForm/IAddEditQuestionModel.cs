using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AddEditQuestionForm
{
    public interface IAddEditQuestionModel
    {
        string Question { get; set; }
        List<AnswerDTO> Answers { get; set; }
    }
}
