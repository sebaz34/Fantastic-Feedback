using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FantasticFeedback.Models
{
    public class Survey
    {
        //Primary Key
        public int SurveyID { get; set; }
        //Entity Fields
        public string SurveyTitle { get; set; }
        //Foreign Relationship
        public ICollection<Question> Questions { get; set; }
    }
}
