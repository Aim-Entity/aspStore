namespace store.Models
{
	public class Product
	{
		public int ProductId { get; set; }
		public string Name { get; set; } = string.Empty;
		public string? ShortDescription { get; set; }
		public string? LongDescription { get; set; }
		public decimal Price { get; set; }
		public List<Image> Thumbnails { get; set; }
		public string HeroImage { get; set; }
		public List<Image> ProductImages { get; set; }
		public bool IsPieOfTheWeek { get; set; }
		public bool InStock { get; set; }
		public int CategoryId { get; set; }
	}
}
