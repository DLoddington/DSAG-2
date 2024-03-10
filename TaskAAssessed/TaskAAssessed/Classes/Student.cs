using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAAssessed.Classes
{
    class Student
    {
        private string name;
        private int id;
        private int age;

        public Student(String name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string GetInfo()
        {
            return "The students name is " + name + ", their ID number is " + id + " and they are " + age + " years old.";
        }
    }
}
