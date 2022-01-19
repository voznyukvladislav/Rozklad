using Microsoft.AspNetCore.Mvc;
using Rozklad.Data;
using Rozklad.Models;

namespace Rozklad.Controllers
{
    public class WeekController : Controller
    {
        private readonly RozkladDbContext _db;
        public WeekController(RozkladDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Week> weeks = _db.Weeks.ToList();

            return View(weeks);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Week? week = _db.Weeks.Find(id);
            if (week == null) return NotFound();
            else
            {
                return View(week);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            Week? week = _db.Weeks.Find(id);
            if (week == null) return NotFound();
            else
            {
                _db.Weeks.Remove(week);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Week week)
        {
            _db.Weeks.Add(week);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Week week)
        {
            _db.Weeks.Update(week);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
        
    }
}
