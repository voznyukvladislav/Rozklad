using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozklad.Data;
using Rozklad.Models;
using System.Text.Json.Nodes;

namespace Rozklad.Controllers
{
	public class LanguageController : Controller
	{
		private readonly RozkladDbContext _db;
		public LanguageController(RozkladDbContext db)
		{
			this._db = db;
		}
		public async Task<IActionResult> Index()
		{
			List<Language> languages = await Task.Run(() => _db.Languages.ToListAsync());
			return View(languages);
		}
		public IActionResult AddForm()
        {
			return View();
        }

		[HttpGet]
		public IActionResult EditForm(int? languageId)
        {
			Language? language = _db.Languages.Find(languageId);
			if (language == null) return NotFound();
			else return View(language);
        }

		[HttpPost]
		public IActionResult Add(Language language)
		{
			_db.Languages.Add(language);
			_db.SaveChanges();

			// Adding empty names for new language
			Language? lastLanguage = _db.Languages.OrderByDescending(id => id.Id).FirstOrDefault();

			List<Teacher> teachers = _db.Teachers.ToList();
			foreach(Teacher t in teachers)
            {
				TeacherName tName = new TeacherName() { Teacher = t, Language = lastLanguage, Name = null, Surname = null, Patronymic = null };
				_db.TeacherNames.Add(tName);
				_db.SaveChanges();
            }

			return RedirectToAction("Index");
		}

		[HttpDelete]
		public IActionResult Delete(int? id)
		{
			Language? language = _db.Languages.Find(id);
			if (language == null)
            {
				return NotFound();
            } else
            {
				_db.Languages.Remove(language);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
		}

		[HttpPost]
		public IActionResult Edit(Language language)
		{
			_db.Languages.Update(language);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}