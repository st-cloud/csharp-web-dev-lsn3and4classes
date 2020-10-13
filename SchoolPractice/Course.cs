using System;
using System.Collections.Generic;

namespace SchoolPractice
{
/*with at least three fields. 
Before diving into Visual Studio, try using pen and paper to work through what these might be.
At least one of your fields should be a List or Dictionary,
and you should use your Student class.*/

//Roster (List made of student class)

    public class Course
    {
        public string Name { get; set; }
        public int CourseId { get; set; }
        public int Credits { get; set; }
        public List<Student> Roster { get; set; }

        public Course(string name, int courseId, int credits, List<Student> roster)
        {
            Name = name;
            CourseId = courseId;
            Credits = credits;
            Roster = roster;
        }
    }
}
