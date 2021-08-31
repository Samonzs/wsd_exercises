using Microsoft.EntityFrameworkCore.Migrations;

namespace Magazine20056663.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    customerID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    familyName = table.Column<string>(nullable: true),
                    givenName = table.Column<string>(nullable: true),
                    dateOfBirth = table.Column<string>(nullable: true),
                    emailAddress = table.Column<string>(nullable: true),
                    mobileNumber = table.Column<string>(nullable: true),
                    postalCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.customerID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
