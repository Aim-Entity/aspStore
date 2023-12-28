using Microsoft.AspNetCore.Mvc;
using store.Models;

namespace store.Controllers
{
	public class AdminController : Controller
	{
		private readonly IImageRepository _imageRepository;
		private readonly IDetailRepository _detailRepository;
		private readonly ICategoryRepository _categoryRepository;
		private readonly IWebHostEnvironment _webHostEnvironment;

		public AdminController(IImageRepository imageRepository, IWebHostEnvironment webHostEnvironment, IDetailRepository detailRepository)
		{
			_imageRepository = imageRepository;
			_webHostEnvironment = webHostEnvironment;
			_detailRepository = detailRepository;
		}

		public IActionResult ErrorPage()
		{
			return View();
		}

		public IActionResult ImageForm()
		{
			return View();
		}

		public IActionResult DetailForm()
		{
			return View();
		}

		public IActionResult CategoryForm()
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
			return RedirectToAction("ErrorPage");
		}

		[HttpPost]
		public IActionResult CreateDetail(Detail detail)
		{
            if (ModelState.IsValid)
			{
				_detailRepository.AddNewDetail(detail);
				return RedirectToAction("DetailForm");
			}
			return RedirectToAction("ErrorPage");
		}

		[HttpPost]
		public IActionResult CreateCategory(Category category)
		{
			if (ModelState.IsValid)
			{
				_categoryRepository.AddNewCategory(category);
				return RedirectToAction("CategoryForm");
			}
			return RedirectToAction("ErrorPage");
		}
	}
}
