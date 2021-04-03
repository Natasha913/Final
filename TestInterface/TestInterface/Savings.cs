using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Savings:Account, BasicBankingInterface
    {

            public Savings(string AccName, string AccNo, double balance) : base(AccName, AccNo, balance) 
        {
        }

            override public void deposit(int amount)
            {
                Balance += amount;
                Console.WriteLine("Deposited : {0}", amount);
            }

            override public void withdraw(int amount)
            {
                if (amount <= Balance * 1.02)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdraw :  {0} ", amount);

                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }
            }
    }
}


