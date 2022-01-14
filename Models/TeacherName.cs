using System.ComponentModel.DataAnnotations;

namespace Rozklad.Models
{
	public class TeacherName
	{
		[Key]
		public int TeacherNameId { get; set; }

		public Teacher Teacher { get; set; }
		public Language Language { get; set; }

		public string? Name { get; set; }
		public string? Surname { get; set; }
		public string? Patronymic { get; set; }

        public TeacherName()
        {

        }

		public string GetFullName()
        {
			return $"{this.Name} {this.Surname} {this.Patronymic}";
        }
	}
}
