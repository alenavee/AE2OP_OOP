using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_3
{
    class SMS: Message
    {
        public string To;
        public SMS(string to, string content)
        {
            To = to;
            Content = content;
        }
    }
}
