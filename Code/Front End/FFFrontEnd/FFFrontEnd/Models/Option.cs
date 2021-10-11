using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FFFrontEnd.Models
{
    public class Option
    {
        //Primary Key
        public int OptionID { get; set; }
        
        //Entity Fields
        public string OptionText { get; set; }
        public int OptionOrder { get; set; }
        public int QuestionID { get; set; }

        //Foreign Relationship
        public Question Question { get; set; }
    }
}
