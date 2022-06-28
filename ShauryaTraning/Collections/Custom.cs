using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Collections
{
    class Custom
    {
    }
    class Studd : IComparable<Studd>
    {
        int sid;
        string name;
        int percent;

        public int CompareTo(Studd s2)
        {
            return this.name.CompareTo(s2.name);
        }
        public Studd(int sid, string name, int percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }

        public int Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
    }

    class DemoListCustom
    {
        static void Main(string[] args)
        {
            List<Studd> lst = new List<Studd>();
            lst.Add(new Studd(101, "Amit", 89));
            lst.Add(new Studd(102, "Gaurav", 79));
            lst.Add(new Studd(103, "Raj", 99));


            foreach (Studd ob in lst)
            {
                if (ob.Percent > 80)
                    Console.WriteLine(ob);
            }
        }
    }
    class DemoSorted
    {
        static void Main(string[] args)
        {
            SortedList<string, int> ss = new SortedList<string, int>();
            ss.Add("Suraj", 90);
            ss.Add("Gaurav", 91);
            ss.Add("Priyanka", 90);
            ss.Add("Priya", 90);
            ss.Add("Ajinkaya", 90);

            foreach (KeyValuePair<string, int> kv in ss)
            {
                Console.WriteLine(kv.Key + "==>" + kv.Value);
            }

        }
    }
    class Dss2
    {
        static void Main(string[] args)
        {
            SortedList<string, int> s1 = new SortedList<string, int>();
            Console.WriteLine("Amit".CompareTo("Dinesh"));//-1
            Console.WriteLine("Dinesh".CompareTo("Amit"));//1
            Console.WriteLine("Amit".CompareTo("Amit"));//0


            string[] a = { "Amit", "Snehal", "prinyaka", "suraj" };


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i].CompareTo(a[j + 1]) > 0)
                    {
                        //Swap
                    }
                }
            }

        }
    }

    class Dss
    {
        static void Main(string[] args)
        {
            SortedList<Studd, string> s = new SortedList<Studd, string>();
            s.Add(new Studd(1, "Gaurav", 90), "C#");
            s.Add(new Studd(2, "Ravi", 90), "C#");
            s.Add(new Studd(3, "Raj", 90), "C#");

            foreach (KeyValuePair<Studd, string> kv in s)
            {
                Console.WriteLine(kv.Key + "===>" + kv.Value);
            }


        }
    }


    class mySorted : IComparer<StringBuilder>
    {
        public int Compare(StringBuilder s1, StringBuilder s2)
        {
            return s1.ToString().CompareTo(s2.ToString());
        }
    }


    class Dss4
    {
        static void Main(string[] args)
        {
            SortedList<StringBuilder, int> ss = new SortedList<StringBuilder, int>();
            ss.Add(new StringBuilder("Siya"), 90);
            ss.Add(new StringBuilder("Riya"), 90);
        }
    }



    class DemoLinkedList
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(90);
            ll.AddLast(80);
            ll.AddLast(70);
            ll.AddLast(90);
            ll.AddLast(800);
            ll.AddFirst(600);
            LinkedListNode<int> add = ll.Find(90);
            ll.AddAfter(add, 100);
            ll.Remove(90);


            foreach (int d in ll)
            {
                Console.WriteLine(d);
            }

        }
    }
}
