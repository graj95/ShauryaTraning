using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class OverloadDemo
    {
        public void Area(float x)
        {
            Console.WriteLine(" the area of the squre is :" + Math.Pow(x, 2) + " sq unit");
        }
        public void Area(float x, float y)
        {
            Console.WriteLine("the area if the rectangle " + x * y + "sq unit");
        }
        public void Area(double x)
        {
            double z = 3.14 * x * x;
            Console.WriteLine("the area of the circle " + z + "sq unit ");
        }
    }
    class Overload
    {
        static void Main(string[] args)
        {
            OverloadDemo ob = new OverloadDemo();
            ob.Area(5);
            ob.Area(11, 13);
            ob.Area(5.6);
        }
    }
}
