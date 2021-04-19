using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        delegate void Calc(int a, int b);

        public static void Add(int a, int b)
        {
             Console.WriteLine("Sum is :" + (a+b));
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Sub is :" + (a - b));
        }
        static void Main(string[] args)
        {

            int a = 24, b = 22;
            //Add(a, b); or calculator(a, b); same

            Calc calculator = Add;
            calculator(a, b);

             calculator  += Sub;
            calculator(4,2);
        }
    }
}
