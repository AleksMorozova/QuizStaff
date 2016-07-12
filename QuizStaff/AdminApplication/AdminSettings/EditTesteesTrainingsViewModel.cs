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
        public void SetUpSettings(BindingList<Testee> currentTestees)
        {
            testees = currentTestees;
            Trainigs = new BindingList<TesteeTraining>();

            //TODO: создать список уникальных тренингов
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
