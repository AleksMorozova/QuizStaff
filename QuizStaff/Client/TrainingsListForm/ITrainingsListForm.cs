using System;
using System.Collections.Generic;
using DomainModel;

namespace Client
{
    public interface ITrainingsListForm
    {
        TrainingListPresenter presenter { get; set; }
        void SetBindings(List<Training> trainingList);
        
    }
}

