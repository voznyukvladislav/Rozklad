using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
    public class GroupName
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Group Group { get; set; }
        public Language Language { get; set; }
    }
}
