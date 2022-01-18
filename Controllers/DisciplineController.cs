using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozklad.Data;
using Rozklad.Models;

namespace Rozklad.Controllers
{
	public class DisciplineController : Controller
	{
		private readonly RozkladDbContext _db;

		public DisciplineController(RozkladDbContext db)
		{
			this._db = db;
		}

		public IActionResult Index()
		{
			List<Discipline> disciplines = _db.Disciplines.ToList();
			for(int i = 0; i < disciplines.Count; i++)
			{
				disciplines[i].DisciplineNames = (from names in _db.DisciplineNames.Include(names => names.Language).ToList()
												  where names.Discipline.Id == disciplines[i].Id
												  select names).ToList<DisciplineName>();			
			}			

			return View(disciplines);
		}

		public IActionResult AddForm()
		{
			List<Language> languages = _db.Languages.ToList();
			return View(languages);
		} 

		[HttpGet]
		public IActionResult EditForm(int? id)
		{
			Discipline? discipline = _db.Disciplines.Find(id);
			if (discipline == null) return NotFound();
			else
            {
				discipline.DisciplineNames = (from names in _db.DisciplineNames.Include(names => names.Language)
											  where names.Discipline.Id == discipline.Id
											  select names).ToList();

				List<Language> languages = _db.Languages.ToList();

				ViewBag.discipline = discipline;
				ViewBag.languages = languages;

				return View();
			}
		}

		[HttpDelete]
		public IActionResult Delete(int? id)
		{
			Discipline? discipline = _db.Disciplines.Find(id);
			if (discipline == null) return NotFound();
			else
            {
				discipline.DisciplineNames = (from names in _db.DisciplineNames.Include(discipline => discipline.Discipline)
											  where names.Discipline.Id == discipline.Id
											  select names).ToList();

				_db.Disciplines.Remove(discipline);
				_db.SaveChanges();
            }

			return RedirectToAction("Index");
		}
			
		[HttpPost]
		public IActionResult Add(Discipline discipline, int[] languagesId)
		{
			for(int i = 0; i < languagesId.Length; i++)
			{
				discipline.DisciplineNames.ElementAt(i).Language = (from language in _db.Languages.ToList()
																	where language.Id == languagesId[i]
																	select language).ToList()[0];
			}

			_db.Disciplines.Add(discipline);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}

		[HttpPost]
		public IActionResult Edit(Discipline discipline)
		{
			for(int i = 0; i < discipline.DisciplineNames.Count; i++)
            {
				discipline.DisciplineNames.ElementAt(i).Language = (from language in _db.Languages.ToList()
																	where language.Id == discipline.DisciplineNames.ElementAt(i).Language.Id
																	select language).First();
            }

			_db.Update(discipline);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
	}
}
