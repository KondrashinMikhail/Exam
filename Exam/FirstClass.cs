using System;

namespace Exam
{
    class FirstClass : IClass
    {
        Random random = new Random();
        private int[] array;
        private int size;
        public FirstClass(int size) 
        {
            if (size < 10)
                throw new LessThenTenException();
            this.size = size;
            array = new int[size];
            for (int i = 0; i < size; i++) 
            {
                array[i] = random.Next(-10, 10);
            }
        }

        public string Name 
        {
            get 
            {
                return "FirstClass " + size;
            }
        }

        public string Method()
        {
            return "Какие-то действия с массивлм";
        }

        public string Method(int myNum)
        {
            return "Какие-то действия с массивом включая число";
        }
        int IClass.this[int index] 
        {
            get
            {
                try
                {
                    return array[index];
                }
                catch (IndexOutOfRangeException ex)
                {
                    return 0;
                }
            }
        }
    }
}
