using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_2
{
    class Student: Person
    {
        public List<string> Courses { get; set; }

        public Student(string name, int age, string country, List<string> courses)
            : base(name, age, country)
        {
            Courses = courses;
        }
        public override void UpdateInfo(string new_course)
        {
            Courses.Add(new_course);   
        }

    }
}
