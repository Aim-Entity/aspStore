using Microsoft.AspNetCore.Mvc;

namespace store.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
