using Microsoft.EntityFrameworkCore;
using Rozklad.Models;
namespace Rozklad.Data
{
    public class RozkladDbContext : DbContext
    {
        public DbSet<Language> Languages { get; set; }
        public DbSet<Discipline> Disciplines { get; set; } 
        public DbSet<DisciplineName> DisciplineNames { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherName> TeacherNames { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<DayName> DayNames { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupName> GroupNames { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<ClassTime> ClassTimes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        public RozkladDbContext(DbContextOptions<RozkladDbContext> options)
            : base(options)
        {
        }
    }
}