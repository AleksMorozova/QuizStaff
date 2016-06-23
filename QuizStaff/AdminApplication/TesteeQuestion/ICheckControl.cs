using System;

namespace AdminApplication
{
    public interface ICheckControl
    {
        bool Checked { get; set; }
        Guid AnswerID { get; set; }
        event EventHandler CheckedChanged;
    }
}
