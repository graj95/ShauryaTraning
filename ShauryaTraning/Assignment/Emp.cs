using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class InvalidPasswordException : SystemException
    {
        public InvalidPasswordException(string msg) : base(msg)
        {

        }


    }
    class Emp
    {

        static string nm, pass;



        public string Password
        {
            set
            {
                if (pass.Length < 5)
                    throw new InvalidPasswordException("Invalid Input");
                Console.WriteLine(pass);


            }
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Enter name");
            nm = Console.ReadLine();
            Console.WriteLine("Enter Pass");

            pass = Console.ReadLine();

            Emp e1 = new Emp();
            try
            {
                e1.Password = " ";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }

        }




    }
}
