using System;

namespace Client.ClientsForms
{
    public interface IClientSetupForm
    {
        Int32 QuestionsAmount { get; set; }
        Int32 FrequencyOfAsking { get; set; }
        DateTime TimeOfStart { get; set; }
        event EventHandler ButSaveClick;
        event EventHandler ButCancelClick;
    }
}
