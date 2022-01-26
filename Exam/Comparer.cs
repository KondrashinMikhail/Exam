using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Comparer : IComparer<IClass>
    {
        public int Compare(IClass x, IClass y) 
        {
            if (x.GetType().Name.Equals(nameof(FirstClass)) && y.GetType().Name.Equals(nameof(SecondClass)))
            {
                return 1;
            }
            else if (y.GetType().Name.Equals(nameof(FirstClass)) && x.GetType().Name.Equals(nameof(SecondClass)))
            {
                return -1;
            }
            return 0;
        }
    }
}
