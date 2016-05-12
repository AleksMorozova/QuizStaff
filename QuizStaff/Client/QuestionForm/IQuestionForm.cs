using System.Collections.Generic;
using DataTransferObject;
using System;

namespace Client
{
    public interface IQuestionForm
    {
        void CreateQuestionControls(QuestionDTO question, IDictionary<Guid, bool> answer, bool multiSelect);
        QuestionPresenter Presenter { get; set; }
        void CloseForm();
        void NotifyNoAnswersChecked();
    }
}
