namespace store.Models
{
	public interface IImageRepository
	{
		IEnumerable<Image> AllImages { get; }
		Image? GetImageById(int imageId);
		void AddNewImage(Image model);
	}
}
