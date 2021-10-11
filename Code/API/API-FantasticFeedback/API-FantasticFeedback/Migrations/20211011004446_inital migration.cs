using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FantasticFeedback.Migrations
{
    public partial class initalmigration : Migration
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
                    SurveyImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Surveys", x => x.SurveyID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(nullable: true),
                    QuestionOrder = table.Column<int>(nullable: false),
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
                columns: new[] { "SurveyID", "SurveyComments", "SurveyCreated", "SurveyCreatorName", "SurveyImage", "SurveyTitle", "SurveyTopic" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Opinions on Green Eggs and Ham - By Sam I Am", null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "QuestionID", "QuestionOrder", "QuestionText", "SurveyID" },
                values: new object[] { 1, 0, "Do you like green eggs and ham?", 1 });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionID", "OptionOrder", "OptionText", "QuestionID" },
                values: new object[] { 1, 1, "Yes", 1 });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "OptionID", "OptionOrder", "OptionText", "QuestionID" },
                values: new object[] { 2, 2, "No", 1 });

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
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Surveys");
        }
    }
}
