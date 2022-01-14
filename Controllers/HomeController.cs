using Microsoft.AspNetCore.Mvc;
using Rozklad.Data;
using Rozklad.Models;
using System.Diagnostics;

namespace Rozklad.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RozkladDbContext _db;

        public HomeController(ILogger<HomeController> logger, RozkladDbContext db)
        {
            _db = db;
            _logger = logger;
        }

        public IActionResult Index()
        {            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}