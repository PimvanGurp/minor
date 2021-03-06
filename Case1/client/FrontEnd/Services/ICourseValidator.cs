﻿using System;

namespace Services
{
    public interface ICourseValidator
    {
        string ValidateTitle(string line);
        string ValidateCode(string line);
        int ValidateDuration(string line);
        DateTime ValidateStartDate(string line);
        string ValidateEmptyLine(string line);
    }
}