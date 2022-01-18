using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class DayName
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public Day Day { get; set; }
        public Language Language { get; set; }
    }
}
