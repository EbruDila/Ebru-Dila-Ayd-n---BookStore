using EbruDilaAydın_BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace EbruDilaAydın_BookStore.Controllers
{
	public class CategoryController : Controller
	{
		ApplicationDbContext dbcontext;
		public CategoryController(ApplicationDbContext dbContext)
		{
			this.dbcontext = dbContext;
		}
		public IActionResult Index()
		{
			List<Category> categories = dbcontext.Category.ToList();
			return View(categories);
		}
	}
}
