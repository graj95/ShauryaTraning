using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.SundayAssignmant
{
    class sort
    {
        static void Main(string[] args)
        {



            // create and initialize new ArrayList
            ArrayList mylist = new ArrayList();
            mylist.Add("Welcome");
            mylist.Add("to");
            mylist.Add("Shaurya");
            mylist.Add("Technosoft");
            mylist.Add("2");

            // ArrayList before sorting
            Console.WriteLine("ArrayList before sort:");
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            Console.WriteLine("ArrayList after sort:");

           
            mylist.Sort();

            // ArrayList after sort
            foreach (string i in mylist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
