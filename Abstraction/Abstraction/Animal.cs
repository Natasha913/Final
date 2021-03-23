using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Animal
    {
         public void Eat()
        {
            Console.WriteLine("Animal eats with 2 hands.");
        }
        public void Sleep ()
        {
            Console.WriteLine("Animal sleeps by lying");
        }
        public void Walk ()
        {
            Console.WriteLine("Animal walks with two legs.");
        }
    }
}
