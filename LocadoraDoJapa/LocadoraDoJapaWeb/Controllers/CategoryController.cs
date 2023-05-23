using LocadoraDoJapaWeb.Data;
using LocadoraDoJapaWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraDoJapaWeb.Controllers
{
    public class CategoryController : Controller
    {
        //linha abaixo é um implementação do .NetCore diferente do Legacy
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            return View();
        }

    }
}
