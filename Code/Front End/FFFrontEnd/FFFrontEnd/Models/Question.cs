using System.Collections.Generic;

namespace API_FantasticFeedback.Models
{
    public class Question
    {
        //Primary Key
        public int QuestionID { get; set; }
        
        //Entity Fields
        public string QuestionText { get; set; }
        public int QuestionOrder { get; set; }
        public bool QuestionVisible { get; set; } = true;
        public int SurveyID { get; set; }

        //Foreign Relationship
        public Survey Survey { get; set; }
        public ICollection<Option> Options { get; set; }
    }
}
