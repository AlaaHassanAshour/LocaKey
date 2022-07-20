using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.web.Data.Migrations
{
    public partial class cartedit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "availableQuantity",
                table: "CartCookies");

            migrationBuilder.DropColumn(
                name: "availableQuantity",
                table: "CartBaskets");

            migrationBuilder.RenameColumn(
                name: "quantitySold",
                table: "CartCookies",
                newName: "totalprice");

            migrationBuilder.RenameColumn(
                name: "quantitySold",
                table: "CartBaskets",
                newName: "totalprice");

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpTime",
                table: "CartCookies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PickUpTime",
                table: "CartBaskets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PickUpTime",
                table: "CartCookies");

            migrationBuilder.DropColumn(
                name: "PickUpTime",
                table: "CartBaskets");

            migrationBuilder.RenameColumn(
                name: "totalprice",
                table: "CartCookies",
                newName: "quantitySold");

            migrationBuilder.RenameColumn(
                name: "totalprice",
                table: "CartBaskets",
                newName: "quantitySold");

            migrationBuilder.AddColumn<int>(
                name: "availableQuantity",
                table: "CartCookies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "availableQuantity",
                table: "CartBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
