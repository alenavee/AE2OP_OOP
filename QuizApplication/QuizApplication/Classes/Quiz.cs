using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace QuizApplication.Classes
{
    public class Quiz
    {
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Code")]
        public string Code { get; set; }
        [JsonProperty("Date")]
        public DateTime Date { get; set; }

        [JsonProperty("Question")]
        public List<Question> Questions;

        public Quiz()
        {
            
        }
    }
}


