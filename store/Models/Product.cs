namespace store.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? ShortDescription { get; set; }
		public string? LongDescription { get; set; }
		public decimal Price { get; set; }
		public string ImageThumbnail1 { get; set; }
		public string? ImageThumbnail2 { get; set; }
		public string? ImageThumbnail3 { get; set; }
		public string HeroImage { get; set; }
		public string ProductImage1 { get; set; }
		public string ProductImage2 { get; set; }
		public string ProductImage3 { get; set; }
		public string ProductImage4 { get; set; }
		public bool IsPieOfTheWeek { get; set; }
		public bool InStock { get; set; }
		public int CategoryId { get; set; }
	}
}
