using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class ClassTime
    {
        [Key]
        public int Id { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ClassTime()
        {
            this.Schedules = new List<Schedule>();
        }
    }
}