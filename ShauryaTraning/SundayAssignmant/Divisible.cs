using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.SundayAssignmant
{
    class Divisible
    {
        static void Main(string[] args)
        {
            Hashtable n = new Hashtable();
            n.Add(1, "One"); 
            n.Add(2, "Two");
            n.Add(3, "Three");
            n.Add(4, "Four");
            n.Add(5, "Five");
            n.Add(6, "Six");
            n.Add(7, "Seven");
            n.Add(8, "Eight");
            n.Add(9, "Nine");
            n.Add(10, "Ten");
            foreach (DictionaryEntry de in n)
            {

               
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            }

             foreach(DictionaryEntry e in n)
            {
                
            }
           
            
                
            
        }
    }
}
