using Microsoft.EntityFrameworkCore.Migrations;

namespace Baraja_RubindeCelis.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Baraja",
                columns: table => new
                {
                    IdNaipe = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    NombreNaipe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LinkNaipe = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baraja", x => x.IdNaipe);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baraja");
        }
    }
}
