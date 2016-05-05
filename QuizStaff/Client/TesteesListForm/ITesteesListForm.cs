using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DataTransferObject;
using System.Collections.ObjectModel;

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
