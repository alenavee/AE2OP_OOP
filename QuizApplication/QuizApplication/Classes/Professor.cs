using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication.Classes
{
    class Professor: User
    {
        public Professor(string login, string password, string firstName, string lastName, int role = 1)
            : base(login, password, firstName, lastName, role)
        {
            
        }

    }
}
