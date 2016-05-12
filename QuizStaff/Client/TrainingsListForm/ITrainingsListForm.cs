using System.Collections.Generic;
using DataTransferObject;

namespace Client
{
    public interface ITrainingsListForm
    {
        TrainingListPresenter presenter { get; set; }
        void SetBindings(ICollection<TrainingDTO> trainingList);
        
    }
}

