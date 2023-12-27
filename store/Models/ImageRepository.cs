using Microsoft.AspNetCore.Mvc;

namespace store.Models
{
	public class ImageRepository : IImageRepository
	{
		private readonly StoreDbContext _storeDbContext;

		public ImageRepository(StoreDbContext storeDbContext)
		{
			_storeDbContext = storeDbContext;
		}

		public IEnumerable<Image> AllImages
		{
			get
			{
				return _storeDbContext.Images;
			}
		}

		public Image? GetImageById(int imageId)
		{
			return _storeDbContext.Images.FirstOrDefault(i => i.ImageId == imageId);
		}

		public void AddNewImage(Image model)
		{
			var newImage = new Image()
			{
				ImageFile = model.ImageFile,
				ImageUrl = model.ImageUrl
			};

			_storeDbContext.Images.Add(newImage);
			_storeDbContext.SaveChanges();
		}
	}
}
