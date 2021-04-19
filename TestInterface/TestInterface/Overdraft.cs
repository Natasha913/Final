using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
        class Overdraft : Account, BasicBankingInterface
        {
            public int limit { get; set; }

            public Overdraft() { }
            public Overdraft(string accName, string accNo, double balance, int limit) : base(accName, accNo, balance)
            {
                this.limit = limit;
            }

            public override void deposit(int amount)
            {
                Balance += amount;
                Console.WriteLine("Deposited:  {0} ", amount);

            }

            public override void withdraw(int amount)
            {
                if (amount <= Balance + limit)
                {
                    Balance -= amount;
                    Console.WriteLine("Withdraw: {0} ", amount);

                }
                else
                {
                    Console.WriteLine("Insufficient balance");
                }

            }
        }
}



