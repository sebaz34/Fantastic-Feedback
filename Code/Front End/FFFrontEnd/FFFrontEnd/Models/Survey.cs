using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFFrontEnd.Models
{
    public class Survey
    {
        //Primary Key
        public int SurveyID { get; set; }
        
        //Entity Fields
        public string SurveyTitle { get; set; }
        public string SurveyTopic { get; set; }
        public string SurveyCreatorName { get; set; }
        public DateTime SurveyCreated { get; set; }
        public string SurveyComments { get; set; }
        public string SurveyImage { get; set; }

        //Foreign Relationship
        public ICollection<Question> Questions { get; set; }
    }
}
