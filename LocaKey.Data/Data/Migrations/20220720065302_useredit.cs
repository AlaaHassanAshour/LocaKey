using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.web.Data.Migrations
{
    public partial class useredit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartBaskets_AspNetUsers_UserId1",
                table: "CartBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_CartCookies_AspNetUsers_UserId1",
                table: "CartCookies");

            migrationBuilder.DropIndex(
                name: "IX_CartCookies_UserId1",
                table: "CartCookies");

            migrationBuilder.DropIndex(
                name: "IX_CartBaskets_UserId1",
                table: "CartBaskets");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CartCookies");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "CartBaskets");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CartCookies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "CartBaskets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_CartCookies_UserId",
                table: "CartCookies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CartBaskets_UserId",
                table: "CartBaskets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartBaskets_AspNetUsers_UserId",
                table: "CartBaskets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartCookies_AspNetUsers_UserId",
                table: "CartCookies",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartBaskets_AspNetUsers_UserId",
                table: "CartBaskets");

            migrationBuilder.DropForeignKey(
                name: "FK_CartCookies_AspNetUsers_UserId",
                table: "CartCookies");

            migrationBuilder.DropIndex(
                name: "IX_CartCookies_UserId",
                table: "CartCookies");

            migrationBuilder.DropIndex(
                name: "IX_CartBaskets_UserId",
                table: "CartBaskets");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CartCookies",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CartCookies",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "CartBaskets",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "CartBaskets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartCookies_UserId1",
                table: "CartCookies",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_CartBaskets_UserId1",
                table: "CartBaskets",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CartBaskets_AspNetUsers_UserId1",
                table: "CartBaskets",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartCookies_AspNetUsers_UserId1",
                table: "CartCookies",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
