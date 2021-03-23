using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Cow c = new Cow();
            c.Eat();
            c.Sleep();
            c.Walk();

            Human h = new Human();
            h.Eat();
            h.Sleep();
            h.Walk();

            Horse hr = new Horse();
            hr.Eat();
            hr.Sleep();
            hr.Walk();

        }
    }
}
