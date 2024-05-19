using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public Book? GetBookWithDetails(Guid Id)
        {
            IQueryable<Book> query = Items;

            query = query.Where(b => b.Id == Id);

            query = query.Include(b => b.Reviews);
            query = query.Include(b => b.Categories);

            return query.FirstOrDefault();
        }
    }
}
