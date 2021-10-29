using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class Email: Message
    {
        public List<string> To = new List<string>();
        public string Subject;
        public string From;
        public void AddRecipient(string email_address)
        {
            To.Add(email_address);
        }
        public Email(string subject, string from, string content)
        {
            Subject = subject;
            From = from;
            Content = content;
        }
    }
}
