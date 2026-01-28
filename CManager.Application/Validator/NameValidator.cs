using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Application.Validator
{
    public static class NameValidator
    {
        public static bool IsValid(string name, int minLenght = 2)
        {
            return !string.IsNullOrWhiteSpace(name) && name.Trim().Length >= minLenght;
        }
    }
}