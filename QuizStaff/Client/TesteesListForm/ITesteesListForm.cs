using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DataTransferObject;

namespace Client
{
    public interface ITesteesListForm
    {
        TesteesListPresenter Presenter { get; set; }
        void Close();
        void SetBindings(List<TesteeDTO> testees);
        bool NotifyUnsavedData();
    }
}
