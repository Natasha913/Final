using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCal obj = new BasicCal();
            obj.Sum(3, 10);
            obj.Sub(5, 3);
            obj.Muliplication(4 * 3);
            obj.Division(10 / 2);

            ScientificCal s = new ScientificCal();
            s.Sin_value(122.3);
           

        }
    }
}
