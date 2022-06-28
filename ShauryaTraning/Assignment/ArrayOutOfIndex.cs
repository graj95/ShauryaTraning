using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class ArrayOutOfIndex
    {
        public void calculate()
        {
            int diffe = 0;
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    diffe = diffe - num[i];
                }
                Console.WriteLine("the differaance of the array is:" + diffe);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


    class Demo
    {
        static void Main(string[] args)
        {
            ArrayOutOfIndex ax = new ArrayOutOfIndex();
            ax.calculate();
        }
    }
}

