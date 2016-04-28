using System;
using DomainModel;

namespace Client.ClientsForms
{
    public interface IClientSetupForm
    {
        Int32 QuestionsAmount { get; }
        DateTime FrequencyOfAsking { get; }
        void SetSettings(Settings sets);
        event EventHandler ButSaveClick;
        event EventHandler ButCancelClick;
    }
}
