using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student : Person
    {
        public float Cgpa { get; set; }

        public int Credit { get; set; }

        public Student()
        {

        }
        public Student(string name, string id, string dob, float cgpa, int credit, int age): base (name,id,dob,age)
        {
            Cgpa = cgpa;
            Credit = credit;
        }

       

        new public void ShowInfo() 
        {
            base.ShowInfo(); // by base call prnt cnstrctr
            Console.WriteLine("Cgpa: " + Cgpa);
            Console.WriteLine("Credit: " + Credit);
        }
        public void Demo()
        {

        }
       override public void VotingEligibility()
        {
            if (Age >= 18 && Cgpa > 3.00 )
            {
                Console.WriteLine("You can cast vot");
            }
            else
            {
                Console.WriteLine("You can not cast vot for cgpa");
            }
        }

    }
}
