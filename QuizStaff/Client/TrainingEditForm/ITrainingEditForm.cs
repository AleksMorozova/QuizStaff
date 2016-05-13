using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DevExpress.XtraEditors;
using DataTransferObject;

namespace Client
{
    public interface ITrainingEditForm
    {

        TrainingEditPresenter Presenter { get; set; }
        TextEdit TrainingName{get;}

        void CloseEditing();
        void SetBindings(List<QuestionDTO> questions);
        bool NotifyUnsavedData();
    }
}
