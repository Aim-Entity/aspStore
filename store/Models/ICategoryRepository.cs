namespace store.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories { get; }
		void AddNewCategory(Category model);
	}
}
