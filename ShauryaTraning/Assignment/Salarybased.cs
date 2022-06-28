using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    abstract class Teacher
    {
        public int Tid;
        public string Tname;
        public int Mobileno;


        public abstract void salary();

        public Teacher()
        {

        }


    }



    class Hourlybased : Teacher
    {
        int rate_per_hrs, hrs;
        Hourlybased(int rate_per_hrs, int hrs)
        {
            this.rate_per_hrs = rate_per_hrs;
            this.hrs = hrs;
        }
        public override void salary()
        {

            Console.WriteLine("Salary: 3 CTC");

        }
        void display()
        {
            Console.WriteLine("Teacher ID: ", Tid);
            Console.WriteLine("Mobile: ", Mobileno);
            Console.WriteLine("Name: ", Tname);


            Console.WriteLine("Rate per Hour: ");
            Console.WriteLine("Hour: ");
        }

        class Salarybased : Teacher
        {
            int sal;
            public override void salary()
            {

                Console.WriteLine("Salary: 3 CTC");

            }
            Salarybased(int sal)
            {
                this.sal = sal;
            }

            static void Main(string[] args)
            {

                Salarybased obj = new Salarybased(900000);
                obj.salary();
                Hourlybased h = new Hourlybased(700, 1);
                h.display();

                Console.ReadLine();
            }



        }

    }
}
