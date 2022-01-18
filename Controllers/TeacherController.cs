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

		[HttpGet]
		public IActionResult EditForm(int? id)
        {
			Teacher? teacher = _db.Teachers.Find(id);
			if (teacher == null) return NotFound();
			else
            {
				teacher.TeacherNames = (from names in _db.TeacherNames.Include(names => names.Language)
									   where names.Teacher.Id == teacher.Id
									   select names).ToList<TeacherName>();

				List<Language> languages = _db.Languages.ToList();
				ViewBag.languages = languages;
				ViewBag.teacher = teacher;

				return View();
			}			
        }

		[HttpDelete]
		public IActionResult Delete(int? id)
        {
			Teacher? teacher = _db.Teachers.Find(id);
			if (teacher == null) return NotFound();
			else
            {
				teacher.TeacherNames = (from names in _db.TeacherNames.Include(teacher => teacher.Teacher)
												 where names.Teacher.Id == teacher.Id
												 select names).ToList();

				_db.Teachers.Remove(teacher);
				_db.SaveChanges();
            }
			return RedirectToAction("Index");
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

		[HttpPost]
		public IActionResult Edit(List<TeacherName> teacherNames, int teacherId, int[] languagesId)
		{
			Teacher? teacher = _db.Teachers.Find(teacherId);
			teacher.TeacherNames = teacherNames;
			if(teacher == null) return NotFound();
			else
            {
				for (int i = 0; i < teacherNames.Count; i++)
				{
					teacher.TeacherNames.ElementAt(i).Language = (from languages in _db.Languages.ToList()
																  where languages.Id == languagesId[i]
																  select languages).ToList()[0];
					_db.TeacherNames.Update(teacher.TeacherNames.ElementAt(i));
				}
			}
			
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
