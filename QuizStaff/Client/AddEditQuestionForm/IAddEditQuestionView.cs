using DataTransferObject;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.AddEditQuestionForm
{
    public interface IAddEditQuestionView
    {
        QuestionDTO Question { get; set; }
    }
}
