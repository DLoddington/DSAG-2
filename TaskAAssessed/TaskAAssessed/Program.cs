using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAAssessed.Classes;

namespace TaskAAssessed
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            students[0] = new Student("David Davidson", 1000, 25);
            students[1] = new Student("Wesley Willis", 1001, 22);
            students[2] = new Student("Anne Boleyn", 1002, 20);
            students[3] = new Student("M R James", 1003, 31);
            students[4] = new Student("Edgar Poe", 1004, 45);
            students[5] = new Student("H P Lovecraft", 1005, 25);
            students[6] = new Student("Jeff Goldblum", 1006, 66);
            students[7] = new Student("Fred Durst", 1007, 51);
            students[8] = new Student("Daniel Smith", 1008, 35);
            students[9] = new Student("Queen Liz", 1009, 95);
            foreach(Student s in students) // do foreach
            {
                Console.WriteLine(s.GetInfo());
            }
            Console.ReadKey();
        }
    }
}
