using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class Vol
    {

        void volume(double r)

        {
            double v = 4 / (3 * 22) / 7 * (r * r * r);
            Console.WriteLine("Volume of Spare is " + v);
        }
        void volume(double h, double r)
        {
            double v = (22 / 7) * (r * r) * h;
            Console.WriteLine("Volume of Cylinder is " + v);
        }

        void volume(double l, double b, double h)
        {
            double v = l * b * h;
            Console.WriteLine("Volume of Cube is " + v);
        }

        static void Main(string[] args)
        {
            Vol v = new Vol();
            v.volume(3);
            v.volume(4, 2);
            v.volume(2.5, 3, 4);
            Console.ReadLine();

        }
    }
}
