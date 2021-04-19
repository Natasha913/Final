using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraa
{
    abstract class Animal
    {
        public string Name { get; set; }
        public string Age { get; set; }
        abstract public void Eat();

        abstract public void Sleep();

        abstract public void Walk();
        
        public void ShowInfo()
        {
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Age: "+Age);
        }
    }
}
