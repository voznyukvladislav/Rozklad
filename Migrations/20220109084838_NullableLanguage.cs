using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Migrations
{
    public partial class NullableLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Languages_languageId",
                table: "TeacherNames");

            migrationBuilder.RenameColumn(
                name: "languageId",
                table: "TeacherNames",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_languageId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_LanguageId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "TeacherNames",
                newName: "languageId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_LanguageId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_languageId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Languages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Languages_languageId",
                table: "TeacherNames",
                column: "languageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
