﻿// <auto-generated />
using System;
using API_FantasticFeedback.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API_FantasticFeedback.Migrations
{
    [DbContext(typeof(FFAPIContext))]
    [Migration("20211017233920_Including User Log In Info")]
    partial class IncludingUserLogInInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API_FantasticFeedback.Models.Option", b =>
                {
                    b.Property<int>("OptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OptionOrder")
                        .HasColumnType("int");

                    b.Property<string>("OptionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OptionVisible")
                        .HasColumnType("bit");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("OptionID");

                    b.HasIndex("QuestionID");

                    b.ToTable("Options");

                    b.HasData(
                        new
                        {
                            OptionID = 1,
                            OptionOrder = 1,
                            OptionText = "Yes",
                            OptionVisible = true,
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 2,
                            OptionOrder = 2,
                            OptionText = "No",
                            OptionVisible = true,
                            QuestionID = 1
                        },
                        new
                        {
                            OptionID = 3,
                            OptionOrder = 0,
                            OptionText = "Yay",
                            OptionVisible = true,
                            QuestionID = 2
                        },
                        new
                        {
                            OptionID = 4,
                            OptionOrder = 0,
                            OptionText = "Ba-nay-nay",
                            OptionVisible = true,
                            QuestionID = 2
                        });
                });

            modelBuilder.Entity("API_FantasticFeedback.Models.Question", b =>
                {
                    b.Property<int>("QuestionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("QuestionOrder")
                        .HasColumnType("int");

                    b.Property<string>("QuestionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("QuestionVisible")
                        .HasColumnType("bit");

                    b.Property<int>("SurveyID")
                        .HasColumnType("int");

                    b.HasKey("QuestionID");

                    b.HasIndex("SurveyID");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionID = 1,
                            QuestionOrder = 0,
                            QuestionText = "Do you like green eggs and ham?",
                            QuestionVisible = true,
                            SurveyID = 1
                        },
                        new
                        {
                            QuestionID = 2,
                            QuestionOrder = 0,
                            QuestionText = "Yay or Ba-nay-nay?",
                            QuestionVisible = true,
                            SurveyID = 2
                        });
                });

            modelBuilder.Entity("API_FantasticFeedback.Models.Survey", b =>
                {
                    b.Property<int>("SurveyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SurveyComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SurveyCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("SurveyCreatorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveyTopic")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SurveyVisible")
                        .HasColumnType("bit");

                    b.HasKey("SurveyID");

                    b.ToTable("Surveys");

                    b.HasData(
                        new
                        {
                            SurveyID = 1,
                            SurveyCreated = new DateTime(2021, 10, 18, 9, 39, 19, 798, DateTimeKind.Local).AddTicks(3733),
                            SurveyCreatorName = "Sam I Am",
                            SurveyTitle = "Opinions on Green Eggs and Ham",
                            SurveyTopic = "Food",
                            SurveyVisible = true
                        },
                        new
                        {
                            SurveyID = 2,
                            SurveyCreated = new DateTime(2021, 10, 18, 9, 39, 19, 799, DateTimeKind.Local).AddTicks(7185),
                            SurveyCreatorName = "The Committee for Bananas who wear Pyjamas",
                            SurveyTitle = "Bananas?",
                            SurveyTopic = "Food",
                            SurveyVisible = true
                        });
                });

            modelBuilder.Entity("API_FantasticFeedback.Models.UserInfo", b =>
                {
                    b.Property<int>("UserInfoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserInfoID");

                    b.ToTable("UserInfos");

                    b.HasData(
                        new
                        {
                            UserInfoID = 1,
                            Password = "aa",
                            Username = "a"
                        });
                });

            modelBuilder.Entity("API_FantasticFeedback.Models.Option", b =>
                {
                    b.HasOne("API_FantasticFeedback.Models.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API_FantasticFeedback.Models.Question", b =>
                {
                    b.HasOne("API_FantasticFeedback.Models.Survey", "Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
