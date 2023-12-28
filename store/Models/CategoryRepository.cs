namespace store.Models
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly StoreDbContext _storeDbContext;

		public CategoryRepository(StoreDbContext storeDbContext)
		{
			_storeDbContext = storeDbContext;
		}

		public IEnumerable<Category> AllCategories
		{
			get
			{
				return _storeDbContext.Categories;
			}
		}

		public void AddNewCategory(Category model)
		{
			var newCategory = new Category() { 
				CategoryName = model.CategoryName
			};

			_storeDbContext.Categories.Add(newCategory);
			_storeDbContext.SaveChanges();
		}
	}
}
