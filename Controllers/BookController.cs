using EbruDilaAydın_BookStore.Data;
using Microsoft.AspNetCore.Mvc;

namespace EbruDilaAydın_BookStore.Controllers
{
	public class BookController : Controller
	{
		ApplicationDbContext dbcontext;
		public BookController(ApplicationDbContext dbContext)
		{
			this.dbcontext = dbContext;
		}
		public IActionResult Index()
		{
			List<Book> book = dbcontext.Books.ToList();
			return View(book);
		
		}
	}
}
