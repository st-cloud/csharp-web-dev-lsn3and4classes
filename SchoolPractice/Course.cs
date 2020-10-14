using System;
using System.Collections.Generic;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> EnrolledStudents { get; set; }

        public Course(string topic, Teacher instructor, List<Student> enrolledStudents)
        {
            Topic = topic;
            Instructor = instructor;
            this.EnrolledStudents = enrolledStudents;
        }

        public override string ToString()
        {
            return "Course Details - Subject: " + Topic + ", Instructor: " + Instructor.FirstName + " " + Instructor.LastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Course c = obj as Course;
            return c.Topic == Topic && c.Instructor == Instructor;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Topic, Instructor, EnrolledStudents);
        }
    }
}
