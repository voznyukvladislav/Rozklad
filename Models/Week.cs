using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class Week
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public Week()
        {
            this.Schedules = new List<Schedule>();
        }
    }
}
