using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ShauryaTraning.SundayAssignmant
{
    class DuplicatedArray
    {
        static void Main(string[] args)
        {
            ArrayList  al = new ArrayList();
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


            foreach(object ob in al)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
