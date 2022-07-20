using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LocaKey.web.Data.Migrations
{
    public partial class updateColum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Arabic",
                table: "language");

            migrationBuilder.DropColumn(
                name: "English",
                table: "language");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "ReplacementRecoveryPolicy",
                newName: "nameFr");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "ReplacementRecoveryPolicy",
                newName: "nameEn");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "privacyPolicy",
                newName: "nameFr");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "privacyPolicy",
                newName: "nameEn");

            migrationBuilder.RenameColumn(
                name: "France",
                table: "language",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Categorys",
                newName: "nameFr");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "About",
                newName: "descriptionFr");

            migrationBuilder.AddColumn<string>(
                name: "descriptionAr",
                table: "ReplacementRecoveryPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionEn",
                table: "ReplacementRecoveryPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionFr",
                table: "ReplacementRecoveryPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nameAr",
                table: "ReplacementRecoveryPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionAr",
                table: "privacyPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionEn",
                table: "privacyPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionFr",
                table: "privacyPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nameAr",
                table: "privacyPolicy",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nameAr",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nameEn",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionAr",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descriptionEn",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "descriptionAr",
                table: "ReplacementRecoveryPolicy");

            migrationBuilder.DropColumn(
                name: "descriptionEn",
                table: "ReplacementRecoveryPolicy");

            migrationBuilder.DropColumn(
                name: "descriptionFr",
                table: "ReplacementRecoveryPolicy");

            migrationBuilder.DropColumn(
                name: "nameAr",
                table: "ReplacementRecoveryPolicy");

            migrationBuilder.DropColumn(
                name: "descriptionAr",
                table: "privacyPolicy");

            migrationBuilder.DropColumn(
                name: "descriptionEn",
                table: "privacyPolicy");

            migrationBuilder.DropColumn(
                name: "descriptionFr",
                table: "privacyPolicy");

            migrationBuilder.DropColumn(
                name: "nameAr",
                table: "privacyPolicy");

            migrationBuilder.DropColumn(
                name: "nameAr",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "nameEn",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "descriptionAr",
                table: "About");

            migrationBuilder.DropColumn(
                name: "descriptionEn",
                table: "About");

            migrationBuilder.RenameColumn(
                name: "nameFr",
                table: "ReplacementRecoveryPolicy",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "nameEn",
                table: "ReplacementRecoveryPolicy",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "nameFr",
                table: "privacyPolicy",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "nameEn",
                table: "privacyPolicy",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Language",
                table: "language",
                newName: "France");

            migrationBuilder.RenameColumn(
                name: "nameFr",
                table: "Categorys",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "descriptionFr",
                table: "About",
                newName: "description");

            migrationBuilder.AddColumn<string>(
                name: "Arabic",
                table: "language",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "English",
                table: "language",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
