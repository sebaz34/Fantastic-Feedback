using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_FantasticFeedback.Migrations
{
    public partial class IncludingUserLogInInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 1,
                column: "SurveyCreated",
                value: new DateTime(2021, 10, 18, 9, 39, 19, 798, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 2,
                column: "SurveyCreated",
                value: new DateTime(2021, 10, 18, 9, 39, 19, 799, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "UserInfoID", "Password", "Username" },
                values: new object[] { 1, "aa", "a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 1,
                column: "SurveyCreated",
                value: new DateTime(2021, 10, 16, 15, 0, 9, 433, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Surveys",
                keyColumn: "SurveyID",
                keyValue: 2,
                column: "SurveyCreated",
                value: new DateTime(2021, 10, 16, 15, 0, 9, 435, DateTimeKind.Local).AddTicks(999));
        }
    }
}
