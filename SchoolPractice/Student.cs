using System;
namespace SchoolPractice
{
    public class Student
    {
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double totalQuality = Gpa * NumberOfCredits;
            double newQuality = grade * courseCredits;
            totalQuality += newQuality;

            NumberOfCredits += courseCredits;
            Gpa = totalQuality / NumberOfCredits;
        }

        public string GetGradeLevel(int credits)
        {
            if (NumberOfCredits >= 90)
            {
                return "Senior";
            }
            else if (NumberOfCredits >= 60)
            {
                return "Junior";
            }
            else if (NumberOfCredits >= 30)
            {
                return "Sophomore";
            }
            else
            {
                return "Freshman";
            }
        }

        public override string ToString()
        {
            return Name + " (Student ID: " + StudentId + ", GPA: " + Gpa + ", Credits: " + NumberOfCredits;
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

            Student s = obj as Student;
            return s.StudentId == StudentId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, StudentId, NumberOfCredits, Gpa);
        }
    }
}
