using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.web.Data.Migrations
{
    public partial class usersdf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cofiermpassword",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cofiermpassword",
                table: "AspNetUsers");
        }
    }
}
