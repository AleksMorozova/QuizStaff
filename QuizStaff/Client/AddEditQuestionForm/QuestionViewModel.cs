using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.AddEditQuestionForm
{
    public class QuestionViewModel
    {
        public QuestionDTO Question { get; set; }
        public bool execute = false;

        public void Save()
        {
            //TODO: Validation and set execute to true or false
        }

        public bool CanDoSomething()
        {
            return execute;
        }
    }
}
