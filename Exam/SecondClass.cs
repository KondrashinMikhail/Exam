using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam
{
    class SecondClass : IClass
    {
        Random random = new Random();
        private List<int> list;
        private int size;

        public SecondClass(int size)
        {
            if (size < 10)
                throw new LessThenTenException();
            list = new List<int>();
            this.size = size;

            for (int i = 0; i < size; i++)
            {
                list.Add(random.Next(-10, 10));
            }
        }
        public string Name
        {
            get
            {
                return "SecondClass " + size;
            }
        }
        public string Method()
        {
            return "Какие-то действия со списком";
        }

        public string Method(int myNum)
        {
            return "Какие-то действия со списком включая число";
        }

        int IClass.this[int index]
        {
            get
            {
                try
                {
                    return list.ElementAt(index);
                }
                catch (IndexOutOfRangeException ex) 
                {
                    return 0;
                }
            }
        }
    }
}
