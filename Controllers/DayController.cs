using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rozklad.Data;
using Rozklad.Models;

namespace Rozklad.Controllers
{
    public class DayController : Controller
    {
        private readonly RozkladDbContext _db;
        public DayController(RozkladDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Day> days = _db.Days
                .Include(names => names.DayNames)
                .ThenInclude(languages => languages.Language)
                .ToList();

            return View(days);
        }

        public IActionResult Add()
        {
            List<Language> languages = _db.Languages
                .ToList();

            return View(languages);
        }
        
        [HttpPost]
        public IActionResult Add(Day day)
        {
            for(int i = 0; i < day.DayNames.Count; i++)
            {
                day.DayNames.ElementAt(i).Language = 
                    (from language in _db.Languages.ToList()
                    where day.DayNames.ElementAt(i).Language.Id == language.Id
                    select language).First();
            }

            _db.Add(day);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Day day)
        {
            for(int i = 0; i < day.DayNames.Count; i++)
            {
                day.DayNames.ElementAt(i).Language = 
                    (from language in _db.Languages.ToList()
                    where day.DayNames.ElementAt(i).Language.Id == language.Id
                    select language).First();
            }

            _db.Update(day);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Day? day = _db.Days
                .Include(names => names.DayNames)
                .ThenInclude(languages => languages.Language)
                .FirstOrDefault(names => names.Id == id);

            if (day == null) return NotFound();
            else
            {
                return View(day);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Day? day = _db.Days
                .Include(names => names.DayNames)
                .FirstOrDefault(names => names.Id == id);

            if (day == null) return NotFound();
            else
            {
                _db.Days.Remove(day);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
