using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_WF
{
    class Student
    {
        public string FirstName;
        public string LastName;
        public int Semester;
        public string StudentInfo
        {
            get { return LastName + ", " + FirstName + " - " + Semester; }
        }

        public void GoToNextSemester()
        {
            if (Semester < 12){ 
            Semester++;
            }
            
        }

        public Student(string last_name, string first_name, int semester)
        {
            LastName = last_name;
            FirstName = first_name;
            Semester = semester;
        }
    }
}
