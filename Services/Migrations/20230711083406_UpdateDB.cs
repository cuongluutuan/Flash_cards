using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class UpdateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerSet",
                table: "CardEntry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AnswerSet",
                table: "CardEntry",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
