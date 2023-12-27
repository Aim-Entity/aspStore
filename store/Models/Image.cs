using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace store.Models
{
	public class Image
	{
		public int ImageId { get; set; }

		[Display(Name = "Upload an image")]
		[Required]
		[NotMapped]
		public IFormFile ImageFile { get; set; }
		public string? ImageUrl {  get; set; }
	}
}
