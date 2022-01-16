using Microsoft.AspNetCore.Mvc;
using Rozklad.Data;

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
            return View();
        }

        public IActionResult AddForm()
        {
            return View();
        }        
    }
}
