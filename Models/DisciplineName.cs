using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
	public class DisciplineName
	{
		[Key]
		public int DisciplineNameId { get; set; }
		public string Name { get; set; }
		public Discipline Discipline { get; set; }
		public Language Language { get; set; }
	}
}
