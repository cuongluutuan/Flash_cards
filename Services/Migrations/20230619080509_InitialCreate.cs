using Microsoft.EntityFrameworkCore.Migrations;

namespace Services.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable( 
                name: "CardsCollection",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(512)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardsCollection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CardEntry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardsCollectionId = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(512)", nullable: false),
                    AnswerSet = table.Column<string>(type: "nvarchar(512)", nullable: false),
                    Answer = table.Column<string>(type: "nvarchar(128)", nullable: false),
                    Learned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardEntry_CardsCollection_CardsCollectionId",
                        column: x => x.CardsCollectionId,
                        principalTable: "CardsCollection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardEntry_CardsCollectionId",
                table: "CardEntry",
                column: "CardsCollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardEntry");

            migrationBuilder.DropTable(
                name: "CardsCollection");
        }
    }
}
