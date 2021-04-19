using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Natasha", "898", "21-04-1998",4.00f,147,20) ;
                s1.ShowInfo();

            Console.WriteLine("____________________________");


            Person p = new Person("Mahin", "777","21-04-1998",20);
            p.ShowInfo();

            Console.WriteLine("____________________________");

            Person p2 = new Student ("Karim", "334", "22-03-1999",3.4f,130,17); // ref prsn cls r creat ints child cls
            p2.ShowInfo();

            Console.WriteLine("____________________________");

           Student s2 = new Student("Natasha", "898", "21-04-1998", 2.00f, 147, 20);
           s2.VotingEligibility();

            Person p3 = new Student("Natasha", "898", "21-04-1998", 2.00f, 147, 20);
            p3.VotingEligibility();
        }

    }
}
