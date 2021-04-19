using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraa
{
    class Human : Animal
    {   public void Earning()
        {
            Console.WriteLine("Can do business");
        }

        public override void Eat()
        {
            Console.WriteLine("Human eat with both hands");
        }

        public override void Sleep()
        {
            Console.WriteLine("Human sleep by lying");
        }

        public override void Walk()
        {
            Console.WriteLine("Human walk by lags");
        }
    }
}
