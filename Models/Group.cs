using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }
        public ICollection<GroupName> GroupNames { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Group()
        {
            this.GroupNames = new List<GroupName>();
            this.Schedules = new List<Schedule>();
        }
    }
}
