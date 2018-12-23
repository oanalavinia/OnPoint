﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Models
{
    public abstract class IObject
    {
        DateTime Date { get; set; }
        int Number { get; set; }
        ICollection<Student> AttendingList { get; set; }
        string Description { get; set; }
        ICollection<string> FilePathList { get; set; }
        ICollection<Question> QuestionList { get; set; }
    }
}
