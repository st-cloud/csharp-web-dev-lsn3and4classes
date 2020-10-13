using System;

namespace SchoolPractice
{
    class Program
    {

    //instantiate the Student class using yourself as the student.
    //NumberOfCredits: give yourself 1 for this class
    //GPA of 4.0 because you are a C# superstar!

        public static void Main(string[] args)
        {
            // TODO: Instantiate your objects and test your exercise solutions with print statements here.
            Student me = new Student("Grace Brown", 43, 1, 4.0);

            Console.WriteLine(me.Gpa);

            Console.ReadLine();
        }
    }
}
