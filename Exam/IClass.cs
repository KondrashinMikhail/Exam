using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    public interface IClass
    {
        string Name { get; }
        string Method();
        string Method(int myNum);

        int this[int index]
        {
            get;
        }
    }
}
