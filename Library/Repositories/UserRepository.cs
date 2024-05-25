using Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library.Repositories
{
    public class UserRepository : BaseRepository<User>
    {

        public UserRepository(LibraryDbContext context) : base(context)
        {
        }

        public User? GetByUsername(string username)
        {
            IQueryable<User> query = Items;

            query = query.Where(b => b.Username == username);
                
            return query.FirstOrDefault();
           
        }

        public bool IsUsernameTaken(string username)
        {
            return Items.Any(b => b.Username == username);
        }
    }
}
