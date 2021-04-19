using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class CasScientific : BasicCal, IScientificCal

    {
        CasScientific()
        {

        }
        public int Absolute(int x)
        {
            int a = Math.Abs(x);
            Console.WriteLine("Absolute value of {0} is {1} is ",x ,a);
            return a;
           
        }

       

      
        public double Sin_value(double angle)
        {

            double s = Math_Sin(angle);
            Console.WriteLine("Angle value  {0} is {1}", angle, s);
            return s;
        }

        private double Math_Sin(double angle)
        {
            throw new NotImplementedException();
        }

        public double X_to_power_y(double x, double y)
        {
            double pow = Math.Pow(x, y);
            Console.WriteLine("The resoult of {0}*{1} is : {2}", x, y, pow);
            return pow;
           
        }

      
    }
}
