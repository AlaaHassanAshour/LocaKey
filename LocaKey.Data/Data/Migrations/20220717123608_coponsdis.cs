using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.web.Data.Migrations
{
    public partial class coponsdis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "discountType",
                table: "Coupons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "discountType",
                table: "Coupons");
        }
    }
}
