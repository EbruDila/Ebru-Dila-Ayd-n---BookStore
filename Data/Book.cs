using static System.Reflection.Metadata.BlobBuilder;
using System.ComponentModel.DataAnnotations;

namespace EbruDilaAydın_BookStore.Data
{
	public class Book
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(200)]
		public string Name { get; set; }
		public Decimal Price { get; set; }
		public int PageCount { get; set; }
		public DateTime PublishTime { get; set; }
		public int PublisherId { get; set; }
		public virtual Publisher Publisher { get; set; }
		public static int CategoryID { get; set; }
		public virtual Category Category { get; set; }
	}
	public class Publisher
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public virtual List<Book> Books { get; set; }
	}

	public class Category
	{

		public int Id { get; set; }
		[MaxLength(30)]
		public string Name { get; set; }
		public virtual List<Book> Books { get; set; }

	}
}

