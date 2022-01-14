using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozklad.Data;
using Rozklad.Models;

namespace Rozklad.Controllers
{
	public class TeacherController : Controller
	{
		private readonly RozkladDbContext _db;

		public TeacherController(RozkladDbContext db)
		{
			_db = db;
		}

		public IActionResult Index()
		{
			List<Teacher> teachers = _db.Teachers.ToList();
			for(int i = 0; i < teachers.Count; i++)
            {
				teachers[i].TeacherNames = (from names in _db.TeacherNames.Include(names => names.Language).ToList()
											where names.Teacher.Id == teachers[i].Id
											select names).ToList<TeacherName>();
            }

			return View(teachers);
		}		

		public IActionResult AddForm()
        {
			List<Language> languages = _db.Languages.ToList();
			return View(languages);
        }

		[HttpPost]
		public IActionResult Add(Teacher teacher, int[] languagesId)
		{
			for(int i = 0; i < teacher.TeacherNames.Count; i++)
            {
				teacher.TeacherNames.ElementAt(i).Language = (from languages in _db.Languages.ToList()
															  where languages.Id == languagesId[i]
															  select languages).ToList()[0];
			}

			_db.Teachers.Add(teacher);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
