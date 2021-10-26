using Microsoft.EntityFrameworkCore;
using System;

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
        public DbSet<UserInfo> UserInfos { get; set; }


        //Generate Test Data
        protected override void OnModelCreating(ModelBuilder builder)
        {

            //User Log in
            builder.Entity<UserInfo>().HasData(
                new UserInfo
                {
                    UserInfoID = 1,
                    Username = "Admin@FlawlessFeedback.com",
                    Password = "FlawlessFeedback!21"
                },
                new UserInfo
                {
                    UserInfoID = 2,
                    Username = "a",
                    Password = "aa"
                });

            //Survey 1 Data
            builder.Entity<Survey>().HasData(
                new Survey
                {
                    SurveyID = 1,
                    SurveyTitle = "Opinions on Green Eggs and Ham",
                    SurveyTopic = "Food",
                    SurveyCreatorName = "Admin@FlawlessFeedback.com",
                    SurveyCreated = DateTime.Now,
                    SurveyVisible = true
                });
            builder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 1,
                    QuestionText = "Do you like green eggs and ham?",
                    SurveyID = 1,
                    QuestionVisible = true
                });
            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 1,
                    OptionText = "Yes",
                    OptionOrder = 1,
                    QuestionID = 1,
                    OptionVisible = true
                },
                new Option
                {
                    OptionID = 2,
                    OptionText = "No",
                    OptionOrder = 2,
                    QuestionID = 1,
                    OptionVisible = true
                });

            //Survey 2 Data
            builder.Entity<Survey>().HasData(
                new Survey
                {
                    SurveyID = 2,
                    SurveyTitle = "Bananas?",
                    SurveyTopic = "Food",
                    SurveyCreatorName = "Admin@FlawlessFeedback.com",
                    SurveyCreated = DateTime.Now,
                    SurveyVisible = true
                });
            builder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 2,
                    QuestionText = "Yay or Ba-nay-nay?",
                    SurveyID = 2,
                    QuestionVisible = true
                });
            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 3,
                    OptionText = "Yay",
                    OptionOrder = 0,
                    QuestionID = 2,
                    OptionVisible = true
                },
                new Option
                {
                    OptionID = 4,
                    OptionText = "Ba-nay-nay",
                    OptionOrder = 0,
                    QuestionID = 2,
                    OptionVisible = true
                });

            //Survey 3 Data
            builder.Entity<Survey>().HasData(
                new Survey
                {
                    SurveyID = 3,
                    SurveyTitle = "House Work",
                    SurveyTopic = "Domestic Duties",
                    SurveyCreatorName = "a",
                    SurveyCreated = DateTime.Now,
                    SurveyVisible = true
                });
            builder.Entity<Question>().HasData(
                new Question
                {
                    QuestionID = 3,
                    QuestionText = "How many hours a week do you contribute to house work?",
                    SurveyID = 3,
                    QuestionVisible = true
                });
            builder.Entity<Option>().HasData(
                new Option
                {
                    OptionID = 5,
                    OptionText = "Less than 1",
                    OptionOrder = 0,
                    QuestionID = 3,
                    OptionVisible = true
                },
                new Option
                {
                    OptionID = 6,
                    OptionText = "More than 1, less than 5",
                    OptionOrder = 1,
                    QuestionID = 3,
                    OptionVisible = true
                },
                new Option
                {
                    OptionID = 7,
                    OptionText = "More than 5",
                    OptionOrder = 2,
                    QuestionID = 3,
                    OptionVisible = true
                });
        }

    }
}
