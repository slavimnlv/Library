using Library.Entities;

namespace Library.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
