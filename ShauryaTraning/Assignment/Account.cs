using System;
using System.Collections.Generic;
using System.Text;

namespace ShauryaTraning.Assignment
{
    class Account
    {
        long acno;
        string name;
        long balance;



        public long Acno
        {
            set { acno = value; }
            get { return acno; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public long Balance
        {
            set { balance = value; }
            get { return balance; }
        }

        public Account()
        {
            Console.WriteLine("this is default constructor");
        }

        public Account(long acno, string name, long balance)
        {
            this.Acno = acno;
            this.Name = name;
            this.Balance = balance;
        }

        public void DepositeAmount()
        {
            Console.WriteLine("Enter amount to deposited");
            int amount = int.Parse(Console.ReadLine());
            balance = balance + amount;
            Console.WriteLine("Amount deposited" + balance);
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter amount Withdrow");
            int amount = int.Parse(Console.ReadLine());
            if (amount > balance)
            {
                Console.WriteLine("sufficent Balance");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine("After Withdrow :" + balance);
            }

        }

        public void CheckBalance()
        {
            Console.WriteLine("Balance :" + balance);
        }

        static void Main(string[] args)
        {
            Account ac = new Account();
            Account a = new Account(1051000468, "Gaurav", 153400);
            a.DepositeAmount();
            a.Withdraw();
            a.CheckBalance();




        }
    }
}
