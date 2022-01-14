using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
	public class Day
	{
		[Key]
		public int Id { get; set; }
		public ICollection<DayName> DayNames { get; set;}
		public ICollection<Schedule> Schedules { get; set; }
		public Day()
		{
			this.DayNames = new List<DayName>();
			this.Schedules = new List<Schedule>();
		}
	}
}
