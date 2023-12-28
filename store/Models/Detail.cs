using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace store.Models
{
	public class Detail
	{
		[BindNever]
		public int DetailId { get; set; }

		[Required(ErrorMessage = "Please enter the detail name")]
		[Display(Name = "Detail Name")]
		[StringLength(50)]
		public string DetailName { get; set; }

		[Required(ErrorMessage = "Please enter the detail description")]
		[Display(Name = "Detail Description")]
		[StringLength(100)]
		public string DetailDescription { get; set; }
	}
}
