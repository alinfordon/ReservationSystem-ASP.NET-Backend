using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations.SqliteMigrations
{
    public partial class InitialCreateLocationDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    locationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    locationName = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.locationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locations");

          
        }
    }
}
