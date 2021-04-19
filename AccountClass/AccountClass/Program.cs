using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingAccount("Natasha", "300000", 50000);
            Account a2 = new CurrentAccount("Natasha", "300002", 50000);

            // a1.Withdraw(49550);
            //a2.Withdraw(49550);

            Account[] accounts = new Account[10];
            accounts [0] = a1;
            accounts[1] = a2;

            accounts[0].Withdraw(49500);  // same 



        }
    }
}
