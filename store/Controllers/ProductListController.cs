using Microsoft.AspNetCore.Mvc;

namespace store.Controllers
{
	public class ProductListController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
