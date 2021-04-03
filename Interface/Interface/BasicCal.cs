using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IBasicCal
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
        int Multiplication(int x, int y);
        double Division(int x, int y);
    }
}
