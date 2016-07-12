using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DomainModel;
using System.ComponentModel;

namespace AdminApplication.AdminSettings
{
    public class EditTesteesTrainingsViewModel
    {
        private BindingList<Testee> testees;
        public BindingList<Testee> Testees
        { 
            get 
            { 
                return testees;
            } 

            set 
            {
              if(testees!=value)
              {
                  testees = value;
                  RaisePropertyChanged("Testees");
              }
            } 
        }

        private BindingList<TesteeTraining> trainigs;
        public BindingList<TesteeTraining> Trainigs
        {
            get
            {
                return trainigs;
            }

            set
            {
                if (trainigs != value)
                {
                    trainigs = value;
                    RaisePropertyChanged("Trainigs");
                }
            }
        }
        private BindingList<TesteeTraining> resultTrainings;
        public void SetUpTrainigs(BindingList<Testee> currentTestees)
        {
            testees = currentTestees;
            Trainigs = new BindingList<TesteeTraining>();
            resultTrainings = new BindingList<TesteeTraining>();

            List<List<TesteeTraining>> everyTesteeTraningsList = new List<List<TesteeTraining>>();

            if (testees.Count > 0)
            {
                // Собрали список тренингов каждого конкретного testee
                foreach (var testee in testees)
                {
                    List<TesteeTraining> currentTesteeTraningList = new List<TesteeTraining>();
                    foreach (var training in testee.Trainings)
                    {
                        currentTesteeTraningList.Add(training);
                    }
                    everyTesteeTraningsList.Add(currentTesteeTraningList);
                }
                
                // Выделяем пересекающиеся у всех testee тренинги
                List<TesteeTraining> firstOfTesteesTrainingsList = everyTesteeTraningsList.First();
                foreach(TesteeTraining training in firstOfTesteesTrainingsList)
                {
                    bool trainingExistInEveryList = true;
                    foreach (var trainingsList in everyTesteeTraningsList)
                    {
                        trainingExistInEveryList = trainingsList.Exists(_=>_.Training == training.Training);
                        if (!trainingExistInEveryList)
                            break;
                    }

                    if(trainingExistInEveryList)
                    {
                        resultTrainings.Add(training);
                    }
                }

                foreach (var training in resultTrainings)
                {
                    Trainigs.Add(training);
                }
            }
        }

        public void SaveSelectChanges()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
