using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API_FantasticFeedback.Models
{
    public class FFAPIContext : DbContext
    {
        public FFAPIContext(DbContextOptions options) : base(options)
        {

        }

        //Build Tables
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Option> Options { get; set; }


        //Generate Data
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Survey>().HasData(
                new Survey
                {
                    SurveyID = 1,
                    SurveyTitle = "Opinions on Green Eggs and Ham - By Sam I Am"
                }
                );
            builder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 1,
                    QuestionText = "Do you like green eggs and ham?",
                    SurveyID = 1
                }
                );
            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 1,
                    OptionText = "Yes",
                    OptionOrder = 1,
                    QuestionID = 1
                });
            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 2,
                    OptionText = "No",
                    OptionOrder = 2,
                    QuestionID = 1
                });
        }

    }
}
