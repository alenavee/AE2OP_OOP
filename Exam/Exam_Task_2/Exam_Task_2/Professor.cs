using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_2
{
    class Professor: Person
    {
        public string Department { get; set; }

        public Professor(string name, int age, string country, string department)
            : base(name, age, country)
        {
            Department = department;
        }
        public override void UpdateInfo(string new_department)
        {
            Department = new_department;
        }
    }
}
