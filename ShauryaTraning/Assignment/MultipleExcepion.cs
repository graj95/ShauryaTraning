using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class MultipleExcepion
    {
        static void Main(string[] args)
        {
            int[] num = { 8, 17, 24 };
            int[] divisor = { 2, 0, 4 };

            for (int i = 0; i < num.Length; i++)
            {
                try
                {
                    Console.WriteLine("Number :" + num[i]);
                    Console.WriteLine("Divisor: " + divisor[i]);
                    Console.WriteLine("Quotient:" + num[i] / divisor[i]);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("not possible to divide by zero", e);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("index is out range", ex);
                }
            }
        }
    }
}
