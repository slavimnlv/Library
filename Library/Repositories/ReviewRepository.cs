using Library.Entities;

namespace Library.Repositories
{
    public class ReviewRepository : BaseRepository<Review>
    {
        public ReviewRepository(LibraryDbContext context) : base(context)
        {
        }

        public void AddImported(Review imported)
        {
            Items.Add(imported);
            Context.SaveChanges();
        }
    }
}
