using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.SundayAssignmant
{
    class Specified
    {
          public static void Main()
            {

               
                Hashtable ab = new Hashtable();
                       ab.Add("4", "one");
                       ab.Add("9", "Two");
                       ab.Add("5", "One and Two");
                       ab.Add("2", "Five");

                ICollection c = ab.Keys;

               
                foreach (string str in c)
                    Console.WriteLine(str + ": " + ab[str]);

               ab["56"] = "New Value";

                Console.WriteLine("Updated Values:");

           
                foreach (string str in c)
                    Console.WriteLine(str + ": " + ab[str]);
            }
        
    }
}
