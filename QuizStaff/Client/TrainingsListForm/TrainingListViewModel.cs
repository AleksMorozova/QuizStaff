using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.TrainingsListForm
{
    public class TrainingListViewModel
    {
        public List<TrainingDTO> Trainings = new List<TrainingDTO>();

        public void LoadAllTrainings()
        {
            this.Trainings.AddRange(ServicesHolder.ServiceClient.GetAllTrainings());
        }
    }
}
