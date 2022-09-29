using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstateName",
                table: "Houses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EstateName",
                table: "Houses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
