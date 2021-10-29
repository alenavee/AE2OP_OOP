using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Email new_email = new Email("Greetings", "abcde@mail.com", "Hello, everyone!");
            new_email.AddRecipient("12345@mail.com");
            new_email.AddRecipient("asdfg@mail.com");
            Console.WriteLine("Email: ");
            new_email.Send();

            SMS new_sms = new SMS("+123456789", "Hello, how are you?");
            Console.WriteLine("SMS: ");
            new_sms.Send();

        }
    }
}
