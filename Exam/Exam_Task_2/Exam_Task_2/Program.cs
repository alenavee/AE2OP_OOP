using System;
using System.Collections.Generic;

namespace Exam_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = new List<string> { "Math", "Computer Science", "English" };
            Student student = new Student("John Smith", 20, "Geramny", courses);
            Professor professor = new Professor("Sam Nelson", 43, "France", "Humanities");

            Console.WriteLine("Student's courses: ");
            foreach (var c in student.Courses)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nProfessor's department: ");
            Console.WriteLine(professor.Department);

            Console.WriteLine("\nAfter Update");
            student.UpdateInfo("Operating Systems");
            professor.UpdateInfo("History");
            Console.WriteLine("Student's courses: ");
            foreach (var c in student.Courses)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("\nProfessor's department: ");
            Console.WriteLine(professor.Department);

        }
    }
}
