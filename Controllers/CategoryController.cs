using Microsoft.AspNetCore.Mvc;
using Project01.Data;
using Project01.Models;

namespace Project01.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _Db;
        public CategoryController(ApplicationDbContext db)
        {
            _Db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _Db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Add()
        {
            return View();
        }

        //sending data to db
        [HttpPost]
        public IActionResult Add(Category obj)
        {
            _Db.Categories.Add(obj);
            _Db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
