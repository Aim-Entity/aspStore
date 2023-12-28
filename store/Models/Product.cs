namespace store.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; } = string.Empty;
		public string ShortDescription { get; set; }
		public string? LongDescription { get; set; }
		public decimal Price { get; set; }
		public List<Image> Thumbnails { get; set; }
		public string HeroImage { get; set; }
		public List<Image> ProductImages { get; set; }
		public List<Detail> ProductDetails { get; set; }
		public int Stock { get; set; }
		public decimal? Rating { get; set; }
		public int? RatingCount { get; set; } = 0;
		public string? Size { get; set; }
		public List<string>? Tags { get; set; }
		public bool? NewArrival { get; set; }
		public List<Category> Categories { get; set; }
	}
}
