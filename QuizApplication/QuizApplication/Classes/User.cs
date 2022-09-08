using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplication.Classes
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("role")]
        public int Role { get; set; }
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        public User(string login, string password,  string firstName, string lastName, int role)
        {
            Login = login;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

    }
}
