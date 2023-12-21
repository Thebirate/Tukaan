using ETukaan.Data;
using ETukaan.Models;
using Microsoft.AspNetCore.Mvc;

namespace ETukaan.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db= db;
        }
        public IActionResult Index()
        {
            List<Category> objectCategory = _db.Categories.ToList();
            return View(objectCategory);
        }
    }
}
