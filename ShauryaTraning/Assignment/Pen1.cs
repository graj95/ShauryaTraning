using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class Pen1
    {

        string color, brand;
        int capLenght;

        public Refill r;

        public int Caplength
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public Refill R
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            Pen1 b = new Pen1();
            b.Color = "Blue";
            b.Brand = "Skybag";
            b.Caplength = 2;
            Refill p = new Refill();
            b.r = p;
            b.r.Inkcolor = "Black";
            b.r.Length = 3;
            b.r.N = new Nib();
            b.r.N.Ntype = "Plastic";
            Console.WriteLine(" " + b.Color);
            Console.WriteLine(" " + b.Brand);
            Console.WriteLine(" " + b.Caplength);
            Console.WriteLine(" " + b.r.Inkcolor);
            Console.WriteLine(" " + b.r.Length);
            Console.WriteLine(" " + b.r.N.Ntype);
            Console.WriteLine(" " + b.r.N.Width);

        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        public Nib n;

        public string Inkcolor
        {
            get;
            set;
        }
        public int Length
        {
            get;
            set;
        }
        public Nib N
        {
            get;
            set;
        }
    }

    class Nib
    {
        string ntype;
        int width;
        public string Ntype
        {
            get;
            set;
        }
        public int Width
        {
            get;
            set;
        }


    }

}
