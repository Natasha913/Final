using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraa
{
    class Cow : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cow eats with mouth");
        }

        public override void Sleep()
        {
            Console.WriteLine("sleep by lying");
        }

        public override void Walk()
        {
            Console.WriteLine("WAlk by 4 lags");
        }
    }
}
