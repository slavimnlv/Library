using Library.Entities;

namespace Library.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
