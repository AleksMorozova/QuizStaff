using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    interface ITesteesListForm
    {
        void Show();
        void SetBindings(List<Testee> testees);
    }
}
