using System;
using System.Collections.Generic;

namespace API_FantasticFeedback.Models
{
    public class Survey
    {
        //Primary Key
        public int? SurveyID { get; set; }
        
        //Entity Fields
        public string SurveyTitle { get; set; }
        public string SurveyTopic { get; set; }
        public string SurveyCreatorName { get; set; }
        public DateTime? SurveyCreated { get; set; }
        public string SurveyComments { get; set; }
        public string SurveyImage { get; set; }
        public bool SurveyVisible { get; set; } = true;

        //Foreign Relationship
        public ICollection<Question> Questions { get; set; }
    }
}
