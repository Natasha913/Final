﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student

    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public float cgpa;
        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public string department;

        public string Department

        {
            get { return department; }
            set { department = value; }
        }
        public Student () { }
        public Student (string name, string id, float cgpa)
        {
            this.name = name;
            this.id = id;
            this. cgpa = cgpa;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Id : " + id);
            Console.WriteLine("Cgpa : " + cgpa);
        }
    }
}
