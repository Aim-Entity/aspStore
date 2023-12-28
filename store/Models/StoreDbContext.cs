using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace store.Models
{
	public class StoreDbContext : DbContext
	{
		public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
		{

		}
		public DbSet<Image> Images { get; set; }
		public DbSet<Detail> Details { get; set; }
	}
}
