using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student me = new Student("Grace Brown", 43, 1, 4.0);
            Student they = new Student("Grace Brown", 44);

            List<Student> us = new List<Student> { me, they };
            List<Student> yo = new List<Student> { me };

            Teacher cindy = new Teacher("Cindy-Lou", "Who", "Science", 4);
            Teacher grinch = new Teacher("The", "Grinch", "Psychology", 21);

            Course class1 = new Course("Biology 101", cindy, us);
            Course class2 = new Course("Biology 101", cindy, yo);

            //Console.WriteLine(me.ToString());
            //Console.WriteLine(me.GetGradeLevel(me.NumberOfCredits));
            //Console.WriteLine(they.Equals(me));

            //Console.WriteLine(class1.ToString());
            //Console.WriteLine(class1.Equals(class2));

            //Console.ReadLine();
        }
    }
}
