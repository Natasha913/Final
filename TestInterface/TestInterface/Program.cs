using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
          
               
                {
                    Account a1 = new Overdraft("Mahi", "32567", 4400, 4320);
                    Account a2 = new Current("Natasha", "77861", 342000);
                    Account a3 = new Savings("Shima", "78767", 770000);

                    a2.ShowInfo();
                 // a1.deposit(6600);
                    a3.withdraw(21000);


                }
            
        }

    }
}

