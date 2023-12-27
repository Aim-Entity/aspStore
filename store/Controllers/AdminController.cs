using Microsoft.AspNetCore.Mvc;
using store.Models;

namespace store.Controllers
{
	public class AdminController : Controller
	{
		private readonly IImageRepository _imageRepository;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public AdminController(IImageRepository imageRepository, IWebHostEnvironment webHostEnvironment)
		{
			_imageRepository = imageRepository;
			_webHostEnvironment = webHostEnvironment;
		}

		public IActionResult ImageForm()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreateImage(Image image)
		{
			
			if (ModelState.IsValid)
			{
				if (image.ImageFile != null)
				{
					string folder = "media\\uploads\\";
					string fileName = Guid.NewGuid().ToString() + "_" + image.ImageFile.FileName;
					folder += fileName;
					string serverFolder = Path.Combine(_webHostEnvironment.WebRootPath, folder);

					image.ImageFile.CopyTo(new FileStream(serverFolder, FileMode.Create));
					image.ImageUrl = serverFolder;
				}

				_imageRepository.AddNewImage(image);
				return RedirectToAction("ImageForm");
			}
			return View();
		}
	}
}
