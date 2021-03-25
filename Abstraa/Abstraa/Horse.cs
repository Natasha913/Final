using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraa
{
    class Horse:Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Horse eat with mouth");
        }

        public override void Sleep()
        {
            Console.WriteLine("Horse sleep by standing");
        }

        public override void Walk()
        {
            Console.WriteLine("Horse walk by lags");
        }
    }
}
