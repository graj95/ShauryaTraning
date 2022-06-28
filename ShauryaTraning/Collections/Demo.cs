using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.Collections
{
    class DemoArray
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun ");
            al.Add("Mon ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Sat ");
            al.Add("Sun ");
            al.Add("Mon ");
            foreach (object ob in al)
            {
                Console.WriteLine(ob);
            }

        }
    }





    class DemoList1
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(90);
            ll.Add(90);
            ll.Add(90);
            ll.Add(90);
            ll.Add(90);
            ll.Sort();
            ll.Insert(0, 1);
            ll[2] = 22;
            ll.Contains(900);

            foreach (int it in ll)
            {
                Console.WriteLine(it);
            }
        }
    }


    class DemoQueue
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");
            q.Enqueue("D");
            q.Dequeue();

            foreach (string st in q)
            {
                Console.WriteLine(st);
            }
        }
    }


    class DemoStack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("Pinki");
            st.Push("Rinki");
            st.Push("Priya");
            st.Push("Puja");
            st.Peek();

            foreach (string sd in st)
            {
                Console.WriteLine(sd);
            }
            string data = st.Pop();
            Console.WriteLine("Data Removed" + data);

            Console.WriteLine("__________________");
            foreach (string sd in st)
            {
                Console.WriteLine(sd);
            }

            st.Clear();
        }
    }









    class Demo
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d1 = new Dictionary<int, string>();
            d1.Add(101, "Gaurav");
            d1.Add(102, "om");
            d1.Add(103, "rahul");


            d1[102] = "Kavita";


            d1.Remove(103);

            foreach (KeyValuePair<int, string> kv in d1)
            {
                Console.WriteLine(kv.Key + "=>" + kv.Value);
            }
        }
    }
}
