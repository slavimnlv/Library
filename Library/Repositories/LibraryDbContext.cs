using Library.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Library.Repositories
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            // Create an admin user if not exists
            //modelBuilder.Entity<ApplicationUser>().HasData(
            //    new ApplicationUser
            //    {
            //        Id = 1,
            //        UserName = "admin",
            //        Email = "admin@example.com",
            //        PasswordHash = HashPassword("Admin@123"), // Ensure proper password hashing
            //        Role = "Admin"
            //    });

          
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.NewGuid(), Name = "Science Fiction" },
                new Category { Id = Guid.NewGuid(), Name = "Fantasy" },
                new Category { Id = Guid.NewGuid(), Name = "Non-Fiction" },
                new Category { Id = Guid.NewGuid(), Name = "Mystery" },
                new Category { Id = Guid.NewGuid(), Name = "Romance" },
                new Category { Id = Guid.NewGuid(), Name = "Thriller" },
                new Category { Id = Guid.NewGuid(), Name = "Historical Fiction" },
                new Category { Id = Guid.NewGuid(), Name = "Biography" },
                new Category { Id = Guid.NewGuid(), Name = "Self - Help" },
                new Category { Id = Guid.NewGuid(), Name = "Young Adult" },
                new Category { Id = Guid.NewGuid(), Name = "Children's Books" },
                new Category { Id = Guid.NewGuid(), Name = "Poetry" },
                new Category { Id = Guid.NewGuid(), Name = "Graphic Novels" },
                new Category { Id = Guid.NewGuid(), Name = "Adventure" }



        );
        }

    }
}
