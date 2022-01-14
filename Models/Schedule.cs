using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }
        public Day Day { get; set; }
        public Week Week { get; set; }
        public ClassTime ClassTime { get; set; }
        public Teacher Teacher { get; set; }
        public Discipline Discipline { get; set; }
        public Group Group { get; set; }
    }
}
