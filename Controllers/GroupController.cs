using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozklad.Data;
using Rozklad.Models;

namespace Rozklad.Controllers
{
	public class GroupController : Controller
	{
		private readonly RozkladDbContext _db;
        public GroupController(RozkladDbContext db)
        {
			_db = db;
        }

		public IActionResult Index()
		{
			List<Group> groups = _db.Groups.Include(names => names.GroupNames)
				.ThenInclude(names => names.Language).ToList();

			return View(groups);
		}

		public IActionResult AddForm()
		{
			List<Language> languages = _db.Languages.ToList();
			return View(languages);
        }

		[HttpGet]
		public IActionResult EditForm(int? id)
        {
			Group? group = _db.Groups
				.Include(names => names.GroupNames)
				.ThenInclude(names => names.Language)
				.FirstOrDefault(names => names.Id == id);

			if (group == null) return NotFound();
			else
            {
				return View(group);
            }
        }

		[HttpPost]
		public IActionResult Add(Group group)
        {
			for(int i = 0; i < group.GroupNames.Count; i++)
            {
				group.GroupNames.ElementAt(i).Language = (from language in _db.Languages.ToList()
														  where language.Id == @group.GroupNames.ElementAt(i).Language.Id
														  select language).First();
            }

			_db.Groups.Add(group);
			_db.SaveChanges();

			return RedirectToAction("Index");

        }

		[HttpPost]
		public IActionResult Edit(Group group)
        {
			/*group = _db.Groups
				.Include(group => group.GroupNames)
				.ThenInclude(group => group.Language)
				.ThenInclude(group => group.Id)
				.FirstOrDefault(group => group.Id == group.Id);*/

			for(int i = 0; i < group.GroupNames.Count; i++)
            {
				group.GroupNames.ElementAt(i).Language = (from language in _db.Languages.ToList()
														  where language.Id == @group.GroupNames.ElementAt(i).Language.Id
														  select language).First();
				group.GroupNames.ElementAt(i).Group = group;
			}

			_db.Groups.Update(group);
			_db.SaveChanges();

			int kek = 0;

			return RedirectToAction("Index");
        }

		[HttpDelete]
		public IActionResult Delete(int? id)
        {
			Group? group = _db.Groups
				.Include(names => names.GroupNames)
				.ThenInclude(languages => languages.Language)
				.FirstOrDefault(gr => gr.Id == id);

			if (group == null) return NotFound();
			else
            {
				_db.Groups.Remove(group);
				_db.SaveChanges();
            }

			return RedirectToAction("Index");
        }
	}
}
