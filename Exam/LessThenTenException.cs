using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class LessThenTenException : Exception
    {
        public LessThenTenException() : base("less then 10") 
        { }
    }
}
