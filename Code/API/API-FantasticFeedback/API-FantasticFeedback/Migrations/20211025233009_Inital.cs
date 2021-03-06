using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FantasticFeedback.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Surveys",
                columns: table => new
                {
                    SurveyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyTitle = table.Column<string>(nullable: true),
                    SurveyTopic = table.Column<string>(nullable: true),
                    SurveyCreatorName = table.Column<string>(nullable: true),
                    SurveyCreated = table.Column<DateTime>(nullable: false),
                    SurveyComments = table.Column<string>(nullable: true),
                    SurveyImage = table.Column<string>(nullable: true),
                    SurveyVisible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.SurveyID);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    UserInfoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.UserInfoID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true),
                    QuestionOrder = table.Column<int>(nullable: false),
                    QuestionVisible = table.Column<bool>(nullable: false),
                    SurveyID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                    table.ForeignKey(
                        name: "FK_Questions_Surveys_SurveyID",
                        column: x => x.SurveyID,
                        principalTable: "Surveys",
                        principalColumn: "SurveyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    OptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OptionText = table.Column<string>(nullable: true),
                    OptionOrder = table.Column<int>(nullable: false),
                    OptionVisible = table.Column<bool>(nullable: false),
                    QuestionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.OptionID);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Questions",
                        principalColumn: "QuestionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Surveys",
                columns: new[] { "SurveyID", "SurveyComments", "SurveyCreated", "SurveyCreatorName", "SurveyImage", "SurveyTitle", "SurveyTopic", "SurveyVisible" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2021, 10, 26, 9, 30, 9, 169, DateTimeKind.Local).AddTicks(4834), "Admin@FlawlessFeedback.com", null, "Opinions on Green Eggs and Ham", "Food", true },
                    { 2, null, new DateTime(2021, 10, 26, 9, 30, 9, 170, DateTimeKind.Local).AddTicks(4628), "Admin@FlawlessFeedback.com", null, "Bananas?", "Food", true },
                    { 3, null, new DateTime(2021, 10, 26, 9, 30, 9, 170, DateTimeKind.Local).AddTicks(4749), "a", null, "House Work", "Domestic Duties", true }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "UserInfoID", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "FlawlessFeedback!21", "Admin@FlawlessFeedback.com" },
                    { 2, "aa", "a" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionOrder", "QuestionText", "QuestionVisible", "SurveyID" },
                values: new object[] { 1, 0, "Do you like green eggs and ham?", true, 1 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionOrder", "QuestionText", "QuestionVisible", "SurveyID" },
                values: new object[] { 2, 0, "Yay or Ba-nay-nay?", true, 2 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionOrder", "QuestionText", "QuestionVisible", "SurveyID" },
                values: new object[] { 3, 0, "How many hours a week do you contribute to house work?", true, 3 });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionID", "OptionOrder", "OptionText", "OptionVisible", "QuestionID" },
                values: new object[,]
                {
                    { 1, 1, "Yes", true, 1 },
                    { 2, 2, "No", true, 1 },
                    { 3, 0, "Yay", true, 2 },
                    { 4, 0, "Ba-nay-nay", true, 2 },
                    { 5, 0, "Less than 1", true, 3 },
                    { 6, 1, "More than 1, less than 5", true, 3 },
                    { 7, 2, "More than 5", true, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionID",
                table: "Options",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SurveyID",
                table: "Questions",
                column: "SurveyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
