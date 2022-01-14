using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rozklad.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }        
        public string? Name { get; set; }

        public ICollection<TeacherName> TeacherNames { get; set; }
        public ICollection<DisciplineName> DisciplineNames { get; set; }
        public ICollection<DayName> DayNames { get; set; }
        public ICollection<GroupName> GroupNames { get; set; }

        public Language(string name)
        {
            this.Name = name;
            this.TeacherNames = new List<TeacherName>();
            this.DisciplineNames = new List<DisciplineName>();
            this.DayNames = new List<DayName>();
            this.GroupNames = new List<GroupName>();
        }
        public Language() { }
    }
}
