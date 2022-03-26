using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Oop.Class08.InheritanceApp
{
    public class BaseService
    {
        protected bool ValidateInteger(int num)
        {
            return true;
        }

        protected bool ValidateString(string str)
        {
            return true;
        }
        // all the validations bellow
    }
}
