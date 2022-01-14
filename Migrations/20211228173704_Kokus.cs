using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Migrations
{
    public partial class Kokus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherNames");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Teachers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Patronymic",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_LanguageId",
                table: "Teachers",
                column: "LanguageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Languages_LanguageId",
                table: "Teachers",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Languages_LanguageId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_LanguageId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Patronymic",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Teachers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "TeacherId");

            migrationBuilder.CreateTable(
                name: "TeacherNames",
                columns: table => new
                {
                    TeacherNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherNames", x => x.TeacherNameId);
                    table.ForeignKey(
                        name: "FK_TeacherNames_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherNames_LanguageId",
                table: "TeacherNames",
                column: "LanguageId");
        }
    }
}
