namespace store.Models
{
	public class DetailRepository : IDetailRepository
	{
		private readonly StoreDbContext _storeDbContext;

		public DetailRepository(StoreDbContext storeDbContext)
		{
			_storeDbContext = storeDbContext;
		}

		public IEnumerable<Detail> AllDetails
		{
			get
			{
				return _storeDbContext.Details;
			}
		}

		public Detail? GetDetailById(int detailId)
		{
			return _storeDbContext.Details.FirstOrDefault(d => d.DetailId == detailId);
		}

		public void AddNewDetail(Detail model)
		{
			var newDetail = new Detail()
			{
				DetailName = model.DetailName,
				DetailDescription = model.DetailDescription
			};

			_storeDbContext.Details.Add(newDetail);
			_storeDbContext.SaveChanges();
		}
	}
}
