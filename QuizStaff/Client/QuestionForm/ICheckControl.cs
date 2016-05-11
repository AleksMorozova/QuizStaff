using System;

namespace Client
{
    public interface ICheckControl
    {
        bool Checked { get; set; }
        int Index { get; set; }
        event EventHandler CheckedChanged;
    }
}
