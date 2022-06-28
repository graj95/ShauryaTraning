using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    interface Icecream
    {
        void eat();
    }

    interface Juice
    {
        void drink();
    }
    class Mastani : Icecream, Juice
    {
        public void eat()
        {
            global::System.Console.WriteLine("Ice Eat");
        }
        public void drink()
        {
            global::System.Console.WriteLine("Juice Drink");
        }

    }
    class IcecreamPorlour
    {
        static void Main(string[] args)
        {
            Mastani m = new Mastani();
            m.drink();
            m.eat();
        }
    }
}
