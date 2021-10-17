namespace FFFrontEnd.Models
{
    public class Option
    {
        //Primary Key
        public int OptionID { get; set; }
        
        //Entity Fields
        public string OptionText { get; set; }
        public int OptionOrder { get; set; }
        public bool OptionVisible { get; set; } = true;
        public int QuestionID { get; set; }


        //Foreign Relationship
        public Question Question { get; set; }
    }
}
