using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class Multiple_Catch
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter Two number");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                c = a / b;

                Console.WriteLine("C =" + c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("secound numner should not be Zero" + e);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("enter only integer number " + ex);
            }
        }
    }
}
