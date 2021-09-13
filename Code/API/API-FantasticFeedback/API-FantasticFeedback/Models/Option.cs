using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_FantasticFeedback.Models
{
    public class Option
    {
        //Primary Key
        public int OptionID { get; set; }
        //Entity Fields
        public string OptionText { get; set; }
        //Foreign Relationship
        public Question Question { get; set; }
    }
}
