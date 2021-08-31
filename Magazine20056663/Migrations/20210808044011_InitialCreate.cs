using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazine20056663.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    magazineID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magazineName = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.magazineID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
