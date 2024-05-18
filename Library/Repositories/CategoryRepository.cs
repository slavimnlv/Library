using Library.Entities;

namespace Library.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
