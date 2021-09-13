using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FantasticFeedback.Models
{
    public class Question
    {
        //Primary Key
        public int QuestionID { get; set; }
        //Entity Fields
        public string QuestionText { get; set; }
        //Foreign Relationship
        public ICollection<Survey> Survey { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
