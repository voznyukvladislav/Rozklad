using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }

        public ICollection<TeacherName> TeacherNames { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Teacher()
        {
            //this.TeacherNames = new List<TeacherName>();
            //this.Schedules = new List<Schedule>();

            
        }
    }
}
