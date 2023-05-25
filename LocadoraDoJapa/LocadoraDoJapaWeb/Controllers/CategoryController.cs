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
            //if(obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "O DisplayOrder não pode ser igual ao Nome da categoria");
            //}
            if(ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            //var categoryFromDb = _db.Categories.Find(id);
            Category? categoryFromDb1 = _db.Categories.SingleOrDefault(u => u.CategoryId == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u => u.CategoryId == id).FirstOrDefault();

            if(categoryFromDb1 == null)
            {
                return NotFound();
            }
            return View(categoryFromDb1);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            Console.WriteLine(obj.CategoryId);
            if(ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u => u.CategoryId == id);
            //Category? categoryFromDb2 = _db.Categories.Where(u => u.CategoryId == id).FirstOrDefault();

            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Category? obj = _db.Categories.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
