using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace EbruDilaAydın_BookStore.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public DbSet<Book> Books { get; set; }
		public DbSet<Publisher> Publisher { get; set; }
		public DbSet<Category> Category { get; set; }
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}