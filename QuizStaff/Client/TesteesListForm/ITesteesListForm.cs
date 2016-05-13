using System.Collections.Generic;
using DataTransferObject;

namespace Client
{
    public interface ITesteesListForm
    {
        TesteesListPresenter Presenter { get; set; }
        void CloseForm();
        void SetBindings(ICollection<TesteeDTO> testees);
        bool NotifyUnsavedData();
    }
}
