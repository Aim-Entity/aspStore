namespace store.Models
{
	public interface IDetailRepository
	{
		IEnumerable<Detail> AllDetails { get; }
		Detail? GetDetailById(int detailId);
		void AddNewDetail(Detail model);
	}
}
