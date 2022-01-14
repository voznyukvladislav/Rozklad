using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Migrations
{
    public partial class kekuisius : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherName_Languages_LanguageId",
                table: "TeacherName");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherName_Teachers_TeacherId",
                table: "TeacherName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherName",
                table: "TeacherName");

            migrationBuilder.RenameTable(
                name: "TeacherName",
                newName: "TeacherNames");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherName_TeacherId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherName_LanguageId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherNames",
                table: "TeacherNames",
                column: "TeacherNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Teachers_TeacherId",
                table: "TeacherNames",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Teachers_TeacherId",
                table: "TeacherNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TeacherNames",
                table: "TeacherNames");

            migrationBuilder.RenameTable(
                name: "TeacherNames",
                newName: "TeacherName");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_TeacherId",
                table: "TeacherName",
                newName: "IX_TeacherName_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_LanguageId",
                table: "TeacherName",
                newName: "IX_TeacherName_LanguageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TeacherName",
                table: "TeacherName",
                column: "TeacherNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherName_Languages_LanguageId",
                table: "TeacherName",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherName_Teachers_TeacherId",
                table: "TeacherName",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
