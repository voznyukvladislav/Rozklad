using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rozklad.Migrations
{
    public partial class LanguageColsRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayName_Day_DayId",
                table: "DayName");

            migrationBuilder.DropForeignKey(
                name: "FK_DayName_Languages_LanguageId",
                table: "DayName");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineName_Disciplines_DisciplineId",
                table: "DisciplineName");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineName_Languages_LanguageId",
                table: "DisciplineName");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupName_Group_GroupId",
                table: "GroupName");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupName_Languages_LanguageId",
                table: "GroupName");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_ClassTime_ClassTimeId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Day_DayId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Disciplines_DisciplineId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Group_GroupId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Teachers_TeacherId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Week_WeekId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Week",
                table: "Week");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupName",
                table: "GroupName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Group",
                table: "Group");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisciplineName",
                table: "DisciplineName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DayName",
                table: "DayName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Day",
                table: "Day");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTime",
                table: "ClassTime");

            migrationBuilder.RenameTable(
                name: "Week",
                newName: "Weeks");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameTable(
                name: "GroupName",
                newName: "GroupNames");

            migrationBuilder.RenameTable(
                name: "Group",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "DisciplineName",
                newName: "DisciplineNames");

            migrationBuilder.RenameTable(
                name: "DayName",
                newName: "DayNames");

            migrationBuilder.RenameTable(
                name: "Day",
                newName: "Days");

            migrationBuilder.RenameTable(
                name: "ClassTime",
                newName: "ClassTimes");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "TeacherNames",
                newName: "languageId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_LanguageId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_languageId");

            migrationBuilder.RenameColumn(
                name: "LanguageName",
                table: "Languages",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_WeekId",
                table: "Schedules",
                newName: "IX_Schedules_WeekId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_TeacherId",
                table: "Schedules",
                newName: "IX_Schedules_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_GroupId",
                table: "Schedules",
                newName: "IX_Schedules_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_DisciplineId",
                table: "Schedules",
                newName: "IX_Schedules_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_DayId",
                table: "Schedules",
                newName: "IX_Schedules_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_ClassTimeId",
                table: "Schedules",
                newName: "IX_Schedules_ClassTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupName_LanguageId",
                table: "GroupNames",
                newName: "IX_GroupNames_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupName_GroupId",
                table: "GroupNames",
                newName: "IX_GroupNames_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplineName_LanguageId",
                table: "DisciplineNames",
                newName: "IX_DisciplineNames_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplineName_DisciplineId",
                table: "DisciplineNames",
                newName: "IX_DisciplineNames_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_DayName_LanguageId",
                table: "DayNames",
                newName: "IX_DayNames_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_DayName_DayId",
                table: "DayNames",
                newName: "IX_DayNames_DayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weeks",
                table: "Weeks",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupNames",
                table: "GroupNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisciplineNames",
                table: "DisciplineNames",
                column: "DisciplineNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DayNames",
                table: "DayNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Days",
                table: "Days",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTimes",
                table: "ClassTimes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DayNames_Days_DayId",
                table: "DayNames",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayNames_Languages_LanguageId",
                table: "DayNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineNames_Disciplines_DisciplineId",
                table: "DisciplineNames",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineNames_Languages_LanguageId",
                table: "DisciplineNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupNames_Groups_GroupId",
                table: "GroupNames",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupNames_Languages_LanguageId",
                table: "GroupNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_ClassTimes_ClassTimeId",
                table: "Schedules",
                column: "ClassTimeId",
                principalTable: "ClassTimes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Days_DayId",
                table: "Schedules",
                column: "DayId",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Disciplines_DisciplineId",
                table: "Schedules",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Groups_GroupId",
                table: "Schedules",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Weeks_WeekId",
                table: "Schedules",
                column: "WeekId",
                principalTable: "Weeks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Languages_languageId",
                table: "TeacherNames",
                column: "languageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DayNames_Days_DayId",
                table: "DayNames");

            migrationBuilder.DropForeignKey(
                name: "FK_DayNames_Languages_LanguageId",
                table: "DayNames");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineNames_Disciplines_DisciplineId",
                table: "DisciplineNames");

            migrationBuilder.DropForeignKey(
                name: "FK_DisciplineNames_Languages_LanguageId",
                table: "DisciplineNames");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupNames_Groups_GroupId",
                table: "GroupNames");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupNames_Languages_LanguageId",
                table: "GroupNames");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_ClassTimes_ClassTimeId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Days_DayId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Disciplines_DisciplineId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Groups_GroupId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Teachers_TeacherId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Weeks_WeekId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherNames_Languages_languageId",
                table: "TeacherNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weeks",
                table: "Weeks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupNames",
                table: "GroupNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisciplineNames",
                table: "DisciplineNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Days",
                table: "Days");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DayNames",
                table: "DayNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ClassTimes",
                table: "ClassTimes");

            migrationBuilder.RenameTable(
                name: "Weeks",
                newName: "Week");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Group");

            migrationBuilder.RenameTable(
                name: "GroupNames",
                newName: "GroupName");

            migrationBuilder.RenameTable(
                name: "DisciplineNames",
                newName: "DisciplineName");

            migrationBuilder.RenameTable(
                name: "Days",
                newName: "Day");

            migrationBuilder.RenameTable(
                name: "DayNames",
                newName: "DayName");

            migrationBuilder.RenameTable(
                name: "ClassTimes",
                newName: "ClassTime");

            migrationBuilder.RenameColumn(
                name: "languageId",
                table: "TeacherNames",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_TeacherNames_languageId",
                table: "TeacherNames",
                newName: "IX_TeacherNames_LanguageId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Languages",
                newName: "LanguageName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_WeekId",
                table: "Schedule",
                newName: "IX_Schedule_WeekId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_TeacherId",
                table: "Schedule",
                newName: "IX_Schedule_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_GroupId",
                table: "Schedule",
                newName: "IX_Schedule_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_DisciplineId",
                table: "Schedule",
                newName: "IX_Schedule_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_DayId",
                table: "Schedule",
                newName: "IX_Schedule_DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_ClassTimeId",
                table: "Schedule",
                newName: "IX_Schedule_ClassTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupNames_LanguageId",
                table: "GroupName",
                newName: "IX_GroupName_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_GroupNames_GroupId",
                table: "GroupName",
                newName: "IX_GroupName_GroupId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplineNames_LanguageId",
                table: "DisciplineName",
                newName: "IX_DisciplineName_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_DisciplineNames_DisciplineId",
                table: "DisciplineName",
                newName: "IX_DisciplineName_DisciplineId");

            migrationBuilder.RenameIndex(
                name: "IX_DayNames_LanguageId",
                table: "DayName",
                newName: "IX_DayName_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_DayNames_DayId",
                table: "DayName",
                newName: "IX_DayName_DayId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Week",
                table: "Week",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Group",
                table: "Group",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupName",
                table: "GroupName",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisciplineName",
                table: "DisciplineName",
                column: "DisciplineNameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Day",
                table: "Day",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DayName",
                table: "DayName",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClassTime",
                table: "ClassTime",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DayName_Day_DayId",
                table: "DayName",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DayName_Languages_LanguageId",
                table: "DayName",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineName_Disciplines_DisciplineId",
                table: "DisciplineName",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplineName_Languages_LanguageId",
                table: "DisciplineName",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupName_Group_GroupId",
                table: "GroupName",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupName_Languages_LanguageId",
                table: "GroupName",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_ClassTime_ClassTimeId",
                table: "Schedule",
                column: "ClassTimeId",
                principalTable: "ClassTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Day_DayId",
                table: "Schedule",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Disciplines_DisciplineId",
                table: "Schedule",
                column: "DisciplineId",
                principalTable: "Disciplines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Group_GroupId",
                table: "Schedule",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Teachers_TeacherId",
                table: "Schedule",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Week_WeekId",
                table: "Schedule",
                column: "WeekId",
                principalTable: "Week",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherNames_Languages_LanguageId",
                table: "TeacherNames",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
