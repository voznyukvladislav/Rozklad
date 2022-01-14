using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
	public class Discipline
	{
		[Key]
		public int Id { get; set; }
		public ICollection<DisciplineName> DisciplineNames { get; set; }
		public ICollection<Schedule> Schedules { get; set; }

        public Discipline()
        {
			this.DisciplineNames = new List<DisciplineName>();
			this.Schedules = new List<Schedule>();
		}
	}
}
