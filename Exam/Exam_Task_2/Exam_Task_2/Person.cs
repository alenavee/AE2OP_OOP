using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_Task_2
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Person(string name, int age, string country)
        {
            Name = name;
            Age = age;
            Country = country;
        }
        abstract public void UpdateInfo(string new_info);
    }
}
