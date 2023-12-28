using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace store.Models
{
	public class Image
	{
		[BindNever]
		public int ImageId { get; set; }

		[Display(Name = "Upload An Image")]
		[Required(ErrorMessage ="Please upload an image")]
		[NotMapped]
		public IFormFile ImageFile { get; set; }
		[BindNever]
		public string? ImageUrl {  get; set; }
	}
}
