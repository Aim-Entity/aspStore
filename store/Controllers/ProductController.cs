using Microsoft.AspNetCore.Mvc;

namespace store.Controllers
{
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
