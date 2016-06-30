﻿using DataTransferObject;
using DomainModel;
using System;

namespace Client
{
    public interface ICheckControl
    {
        bool Checked { get; set; }
        Guid AnswerID { get; set; }
        AnswerDTO Answer { get; set; }
        event EventHandler CheckedChanged;
    }
}
