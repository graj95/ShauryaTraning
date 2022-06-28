using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class UserDefinedException
    {
    }

    public class FitnessTestFailedException : Exception
    {
        public FitnessTestFailedException(string message) : base(message)
        {

        }
    }

    public class Fitness
    {
        int point = 0;
        public void showTemp()
        {
            if (point < 100)
            {
                throw (new FitnessTestFailedException("Player failed the fitness"));
            }
            else
            {
                Console.WriteLine("Player Passed the fitness ");
            }
        }
    }

    class TestFitness
    {
        static void Main(string[] args)
        {
            Fitness f = new Fitness();
            try
            {
                f.showTemp();
            }
            catch (FitnessTestFailedException e)
            {
                Console.WriteLine("user definrd exception :{0}", e.Message);
            }
        }
    }
}
