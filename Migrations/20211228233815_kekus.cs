using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Migrations
{
    public partial class kekus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "TeacherName",
                columns: table => new
                {
                    TeacherNameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patronymic = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherName", x => x.TeacherNameId);
                    table.ForeignKey(
                        name: "FK_TeacherName_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherName_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherName_LanguageId",
                table: "TeacherName",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherName_TeacherId",
                table: "TeacherName",
                column: "TeacherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeacherName");

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
    }
}
