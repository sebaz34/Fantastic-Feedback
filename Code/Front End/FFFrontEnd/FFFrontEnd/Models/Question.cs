using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFFrontEnd.Models
{
    public class Question
    {
        //Primary Key
        public int QuestionID { get; set; }
        
        //Entity Fields
        public string QuestionText { get; set; }
        public int QuestionOrder { get; set; }
        public int SurveyID { get; set; }

        //Foreign Relationship
        public Survey Survey { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
