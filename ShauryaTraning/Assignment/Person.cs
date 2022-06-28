using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class Person
    {
        int pid;
        string pname;
        Vehicle v;

        public int Pid
        {
            get;
            set;
        }
        public string Pname
        {
            get;
            set;
        }
        public Vehicle V
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Pid = 101;
            p.Pname = "Gaurav";

            Vehicle r = new Vehicle();
            p.v = r;
            p.v.Vid = 102;
            p.v.Vname = "Hero";
            Console.WriteLine(" " + p.Pid + " " + p.Pname);
            Console.WriteLine(" " + p.v.Vid + " " + p.v.Vname);
        }
    }
    class Vehicle
    {
        int vid;
        string vname;
        public int Vid
        {
            get;
            set;
        }
        public string Vname
        {
            get;
            set;
        }



    }
}
