using DataTransferObject;
using DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApplication.Settings
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private ApplicationSettings applicationSettings;
        public ApplicationSettings ApplicationSettings
        {
            get
            {
                return applicationSettings;
            }
            set
            {
                if (applicationSettings != value)
                {
                    applicationSettings = value;
                    RaisePropertyChanged("TimeOfUpdating");
                    RaisePropertyChanged("LMSReportFileName");
                    RaisePropertyChanged("TrainingsQuestionsPath");
                    RaisePropertyChanged("AdditionalQuestionsPath");
                    RaisePropertyChanged("Days");
                    RaisePropertyChanged("LMSReportPath");
                }
            }
        }

        public BindingList<DaysOfUpdate> Days
        {
            get
            {
                return ApplicationSettings.Days;
            }
            set
            {
                if (ApplicationSettings.Days != value)
                {
                    ApplicationSettings.Days = value;
                    RaisePropertyChanged("Days");
                }
            }
        }

        public DateTime TimeOfUpdating
        {
            get
            {
                return ApplicationSettings.TimeOfUpdating;
            }
            set
            {
                if (ApplicationSettings.TimeOfUpdating != value)
                {
                    ApplicationSettings.TimeOfUpdating = value;
                    RaisePropertyChanged("TimeOfUpdating");
                }
            }
        }

        public string LMSReportFileName
        {
            get
            {
                return ApplicationSettings.LMSReportFileName;
            }
            set
            {
                if (ApplicationSettings.LMSReportFileName != value)
                {
                    ApplicationSettings.LMSReportFileName = value;
                    RaisePropertyChanged("LMSReportFileName");
                }
            }
        }

        public string LMSReportPath
        {
            get
            {
                return ApplicationSettings.LMSReportPath;
            }
            set
            {
                if (ApplicationSettings.LMSReportPath != value)
                {
                    ApplicationSettings.LMSReportPath = value;
                    RaisePropertyChanged("LMSReportPath");
                }
            }
        }

        public string TrainingsQuestionsPath
        {
            get
            {
                return ApplicationSettings.TrainingsQuestionsPath;
            }
            set
            {
                if (ApplicationSettings.TrainingsQuestionsPath != value)
                {
                    ApplicationSettings.TrainingsQuestionsPath = value;
                    RaisePropertyChanged("TrainingsQuestionsPath");
                }
            }
        }

        public string AdditionalQuestionsPath
        {
            get
            {
                return ApplicationSettings.AdditionalQuestionsPath;
            }
            set
            {
                if (ApplicationSettings.AdditionalQuestionsPath != value)
                {
                    ApplicationSettings.AdditionalQuestionsPath = value;
                    RaisePropertyChanged("AdditionalQuestionsPath");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        protected virtual void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        public void SetUpViewModel()
        {
            var readSettings = ServicesHolder.ServiceClient.GetSettings();
            ApplicationSettings = Conversion.ConvertApplicationSettingsFromDTO(readSettings);
         }

        public void Save()
        {
            if (ApplicationSettings != null)
            {
                if (this.ApplicationSettings.Id == Guid.Empty)
                {
                    var savedSettings = ServicesHolder.ServiceClient.SaveApplicationSettings(Conversion.ConvertApplicationSettingsToDTO(this.ApplicationSettings));
                    this.ApplicationSettings = Conversion.ConvertApplicationSettingsFromDTO(savedSettings);
                }
                else
                {
                    var updateSettings = ServicesHolder.ServiceClient.UpdateApplicationSettings(Conversion.ConvertApplicationSettingsToDTO(this.ApplicationSettings));
                    this.ApplicationSettings = Conversion.ConvertApplicationSettingsFromDTO(updateSettings);
                }
            }
        }
    }
}
