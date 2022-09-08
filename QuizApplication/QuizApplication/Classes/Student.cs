using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication.Classes
{
    public class Student: User
    {
        public Student(string login, string password, string firstName, string lastName, int role = 0)
            : base(login, password,firstName, lastName, role)
        {
            
        }
    }
}
