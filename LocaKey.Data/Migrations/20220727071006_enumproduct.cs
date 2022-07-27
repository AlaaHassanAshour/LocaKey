using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.Data.Migrations
{
    public partial class enumproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "type",
                table: "Products");
        }
    }
}
