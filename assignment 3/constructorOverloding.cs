using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        String name;
        String enrollment;
        String branch;

        public Student(string name, string enrollment) : this(name)
        {
            this.enrollment = enrollment;
        }

        public Student(string name)
        {
            this.name = name;
        }


        public Student(string name, string enrollment, string branch)
        {
            this.name = name;
            this.enrollment = enrollment;
            this.branch = branch;
        }

        public override string ToString()
        {
            return name + " " +enrollment ; 

        }
    }

    class MainClass
    {
        public static void Main()
        {
            Student s1 = new Student("rockey");
            Student s2 = new Student("perfect", "164895004");
            Student s3 = new Student("nick", "13324443", "ce");

            Console.WriteLine(s2.ToString());
			Console.WriteLine(s3.ToString());
        }
    }
}
