using EbruDilaAydın_BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace EbruDilaAydın_BookStore.Controllers
{
	public class PublisherController : Controller
	{
		ApplicationDbContext dbcontext;
		public PublisherController(ApplicationDbContext dbContext) 
		{
			this.dbcontext = dbContext;
		}
		public IActionResult Index()
		{
			List<Publisher> publishers = dbcontext.Publisher.ToList();
			return View(publishers);
		}
		
		public IActionResult Detail(int id) 
		{
			Publisher publisher = dbcontext.Publisher.Find(id);
			if (publisher == null) { return NotFound(); }
			return View();
		}
	}
}
