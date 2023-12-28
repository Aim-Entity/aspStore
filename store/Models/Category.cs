using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace store.Models
{
	public class Category
	{
		[BindNever]
		public int CategoryId { get; set; }

		[Required(ErrorMessage = "Please enter the category name")]
		[Display(Name = "Category Name")]
		[StringLength(50)]
		public string CategoryName { get; set; }
	}
}
