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
			Language language = _db.Languages.Find(languageId);
			return View(language);
        }

		[HttpPost]
		public IActionResult Add(Language language)
		{
			_db.Languages.AddAsync(language);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpDelete]
		public IActionResult Delete(int? languageId)
		{
			if(languageId == null)
            {
				return RedirectToAction("Index");
			}

			var language = _db.Languages.Find(languageId);
			if (language == null)
            {

            } else
            {
				_db.Languages.Remove(_db.Languages.Find(languageId));
				_db.SaveChanges();
			}			

			return RedirectToAction("Index");
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