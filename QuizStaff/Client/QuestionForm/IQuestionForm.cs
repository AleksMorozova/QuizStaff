using System.Collections.Generic;
using DataTransferObject;

namespace Client
{
    public interface IQuestionForm
    {
        void CreateQuestionControls(QuestionDTO question, List<bool> answer, bool multiSelect);
        QuestionPresenter Presenter { get; set; }
        void CloseForm();
        void NotifyNoAnswersChecked();
    }
}
