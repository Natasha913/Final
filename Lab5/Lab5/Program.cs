using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        
           
        {
                Account a1 = new Account("Natasha", "6789", 90000);
                Account a2 = new Account("Mahn", "5674", 80000);
                Account s1 = new Account("Nahar", "1111", 7700);
                Account s2 = new Account("Natasha", "4545", 50000);

                Transactions t1 = new Transactions(s1, s1, 1000, "send money");
                Transactions t2 = new Transactions(s1, s2, 550, "send money");

                a1.addTransaction(t1, t2);
                a1.showAllTransaction();
                a1.ShowInfo();
                a1.Transfer(s2, 1000);
        }
        
    }
}
