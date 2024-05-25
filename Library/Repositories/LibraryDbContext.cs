using Library.Entities;
using Library.Services;
using Microsoft.EntityFrameworkCore;

namespace Library.Repositories
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }

        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public LibraryDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {

            PasswordService.HashPassword("SuperAdmin123", out string hash, out string salt);

            modelBuilder.Entity<User>().HasData(

                new User
                {
                    Id = Guid.Parse("33587ca1-f612-4eed-bf29-612b392ca62e"),
                    Username = "admin",
                    PasswordHash = hash,
                    PasswordSalt = salt
                }
                );


            modelBuilder.Entity<Category>().HasData(
                new Category { Id = Guid.Parse("604c6170-234b-4eae-a3bc-07103caa06a1"), Name = "Science Fiction" },
                new Category { Id = Guid.Parse("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d"), Name = "Fantasy" },
                new Category { Id = Guid.Parse("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5"), Name = "Non-Fiction" },
                new Category { Id = Guid.Parse("5e60ded5-8916-463c-a394-ceb49dcc2ff0"), Name = "Mystery" },
                new Category { Id = Guid.Parse("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f"), Name = "Romance" },
                new Category { Id = Guid.Parse("3f462fbf-7051-48e5-9344-4d63e8f93177"), Name = "Thriller" },
                new Category { Id = Guid.Parse("a05881d5-cc79-40d1-a0ba-316cfaf2768b"), Name = "Historical Fiction" },
                new Category { Id = Guid.Parse("2190cec8-57b2-432e-8cc7-1713f3921848"), Name = "Biography" },
                new Category { Id = Guid.Parse("d1dc20a5-81ec-42bf-bfb3-98fb8468257a"), Name = "Self - Help" },
                new Category { Id = Guid.Parse("57ce5297-bdd7-4f7a-97b5-daf63201109a"), Name = "Young Adult" },
                new Category { Id = Guid.Parse("25d39c10-8058-42e0-9dfc-65729221468a"), Name = "Children's Books" },
                new Category { Id = Guid.Parse("558407e5-f2ad-4adf-96f7-46cb21f0f9ad"), Name = "Poetry" },
                new Category { Id = Guid.Parse("410f7dd9-2561-49db-8674-58123ed4f966"), Name = "Graphic Novels" },
                new Category { Id = Guid.Parse("7d7f5b15-3643-448e-aff6-81735ec207a8"), Name = "Adventure" }
            );

            //Seed books
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = Guid.Parse("42a0d63a-5e6d-43d6-803d-134638384e92"), Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960, Count = 10 },
                new Book { Id = Guid.Parse("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), Title = "1984", Author = "George Orwell", Year = 1949, Count = 15 },
                new Book { Id = Guid.Parse("3faed062-a4b4-45d1-99f1-65efcc386be3"), Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925, Count = 8 },
                new Book { Id = Guid.Parse("0b671bcc-40eb-441f-a828-e2a6227eccf9"), Title = "Pride and Prejudice", Author = "Jane Austen", Year = 1813, Count = 12 },
                new Book { Id = Guid.Parse("d416e549-54ea-40ce-bc3f-a181339530b8"), Title = "The Catcher in the Rye", Author = "J.D. Salinger", Year = 1951, Count = 9 },
                new Book { Id = Guid.Parse("2366f76a-0349-4fcf-a709-549f2a4800a7"), Title = "The Hobbit", Author = "J.R.R. Tolkien", Year = 1937, Count = 14 },
                new Book { Id = Guid.Parse("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"), Title = "Moby-Dick", Author = "Herman Melville", Year = 1851, Count = 5 },
                new Book { Id = Guid.Parse("53542bb7-8eea-4061-9fb7-33c3df5ce77c"), Title = "War and Peace", Author = "Leo Tolstoy", Year = 1869, Count = 7 },
                new Book { Id = Guid.Parse("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"), Title = "Crime and Punishment", Author = "Fyodor Dostoevsky", Year = 1866, Count = 6 },
                new Book { Id = Guid.Parse("190acb3b-a3da-4850-bb81-3e3b9b549250"), Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", Year = 2011, Count = 11 },
                new Book { Id = Guid.Parse("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"), Title = "Ulysses", Author = "James Joyce", Year = 1922, Count = 4 },
                new Book { Id = Guid.Parse("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"), Title = "The Brothers Karamazov", Author = "Fyodor Dostoevsky", Year = 1880, Count = 8 },
                new Book { Id = Guid.Parse("19ff0e8d-55df-499b-a87c-7e9764d50c72"), Title = "Brave New World", Author = "Aldous Huxley", Year = 1932, Count = 10 }
            );

            //Seed users to make reviews
            PasswordService.HashPassword("user1", out string hashUser1, out string saltUser1);
            PasswordService.HashPassword("user2", out string hashUser2, out string saltUser2);

            Guid user1Id = Guid.Parse("37434f41-8df2-4e41-b575-a07e3ca25fac");
            Guid user2Id = Guid.Parse("413ddc6a-212d-45ab-ae2a-100e8074a24a");

            modelBuilder.Entity<User>().HasData(
                new User { Id = user1Id, Username = "user1", PasswordHash = hashUser1, PasswordSalt = saltUser1 },
                new User { Id = user2Id, Username = "user2", PasswordHash = hashUser2, PasswordSalt = saltUser2 }
            );

            //Seed reviews
            modelBuilder.Entity<Review>().HasData(
                new Review { Id = Guid.Parse("d1aaa52a-67b8-450c-a125-cebe89cc940f"), UserId = user1Id, BookId = Guid.Parse("42a0d63a-5e6d-43d6-803d-134638384e92"), Assessment = "5", Comment = "Best book I have ever read!" },
                new Review { Id = Guid.Parse("cfde827e-df3b-4068-b83b-4cd5b825b9ca"), UserId = user2Id, BookId = Guid.Parse("42a0d63a-5e6d-43d6-803d-134638384e92"), Assessment = "5", Comment = "A masterpiece!" },
                new Review { Id = Guid.Parse("0e43412d-62c3-44ba-a69f-a6cdd73459f9"), UserId = user1Id, BookId = Guid.Parse("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), Assessment = "4", Comment = "A timeless classic!" },
                new Review { Id = Guid.Parse("842b2707-a827-4e79-bd11-596f5109ffda"), UserId = user1Id, BookId = Guid.Parse("3faed062-a4b4-45d1-99f1-65efcc386be3"), Assessment = "4", Comment = "Highly recommend!" },
                new Review { Id = Guid.Parse("a85d779a-843a-4d6d-a19a-b683e09868f7"), UserId = user2Id, BookId = Guid.Parse("3faed062-a4b4-45d1-99f1-65efcc386be3"), Assessment = "4", Comment = "A must-read!" },
                new Review { Id = Guid.Parse("67d85093-28c8-4306-84b2-9b001f1702d2"), UserId = user1Id, BookId = Guid.Parse("0b671bcc-40eb-441f-a828-e2a6227eccf9"), Assessment = "5", Comment = "Amazing!" },
                new Review { Id = Guid.Parse("7e8e49dc-0667-40e3-a55f-93a26db9be8a"), UserId = user2Id, BookId = Guid.Parse("0b671bcc-40eb-441f-a828-e2a6227eccf9"), Assessment = "5", Comment = "Really liked it!" },
                new Review { Id = Guid.Parse("0091eba6-59d9-4c9e-aa26-11c524295c60"), UserId = user2Id, BookId = Guid.Parse("d416e549-54ea-40ce-bc3f-a181339530b8"), Assessment = "5", Comment = "So good!" }
            );

            //Seed BookCategory table
            modelBuilder
                .Entity<Book>()
                .HasMany(b => b.Categories)
                .WithMany(c => c.Books)
                .UsingEntity(bc => bc.HasData(
                    new { BooksId = Guid.Parse("42a0d63a-5e6d-43d6-803d-134638384e92"), CategoriesId = Guid.Parse("a05881d5-cc79-40d1-a0ba-316cfaf2768b") },
                    new { BooksId = Guid.Parse("42a0d63a-5e6d-43d6-803d-134638384e92"), CategoriesId = Guid.Parse("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    new { BooksId = Guid.Parse("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), CategoriesId = Guid.Parse("604c6170-234b-4eae-a3bc-07103caa06a1") },
                    new { BooksId = Guid.Parse("21d6ba4d-0564-43b2-9293-83dd5d4717ba"), CategoriesId = Guid.Parse("3f462fbf-7051-48e5-9344-4d63e8f93177") },
                    new { BooksId = Guid.Parse("3faed062-a4b4-45d1-99f1-65efcc386be3"), CategoriesId = Guid.Parse("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    new { BooksId = Guid.Parse("0b671bcc-40eb-441f-a828-e2a6227eccf9"), CategoriesId = Guid.Parse("efcc8aa6-ef70-431f-a0ff-4769f8b6cd3f") },
                    new { BooksId = Guid.Parse("d416e549-54ea-40ce-bc3f-a181339530b8"), CategoriesId = Guid.Parse("57ce5297-bdd7-4f7a-97b5-daf63201109a") },
                    new { BooksId = Guid.Parse("2366f76a-0349-4fcf-a709-549f2a4800a7"), CategoriesId = Guid.Parse("0f0148d3-67e3-4f84-b1be-3beb0c6dc13d") },
                    new { BooksId = Guid.Parse("2366f76a-0349-4fcf-a709-549f2a4800a7"), CategoriesId = Guid.Parse("7d7f5b15-3643-448e-aff6-81735ec207a8") },
                    new { BooksId = Guid.Parse("91c778a0-100d-4ecb-a047-e9ef7f6e39c2"), CategoriesId = Guid.Parse("7d7f5b15-3643-448e-aff6-81735ec207a8") },
                    new { BooksId = Guid.Parse("53542bb7-8eea-4061-9fb7-33c3df5ce77c"), CategoriesId = Guid.Parse("a05881d5-cc79-40d1-a0ba-316cfaf2768b") },
                    new { BooksId = Guid.Parse("98c15ce1-a358-46ca-a071-eb4b7eac1ba9"), CategoriesId = Guid.Parse("3f462fbf-7051-48e5-9344-4d63e8f93177") },
                    new { BooksId = Guid.Parse("190acb3b-a3da-4850-bb81-3e3b9b549250"), CategoriesId = Guid.Parse("3e8bcc48-e6f5-4cbc-9daf-d87c6092e8d5") },
                    new { BooksId = Guid.Parse("8d50cd9f-6c6e-4a9f-80b3-7af9b859e1a4"), CategoriesId = Guid.Parse("57ce5297-bdd7-4f7a-97b5-daf63201109a") },
                    new { BooksId = Guid.Parse("a4c15cbe-b1e0-4eba-b70b-ad832f7d292d"), CategoriesId = Guid.Parse("57ce5297-bdd7-4f7a-97b5-daf63201109a") },
                    new { BooksId = Guid.Parse("19ff0e8d-55df-499b-a87c-7e9764d50c72"), CategoriesId = Guid.Parse("604c6170-234b-4eae-a3bc-07103caa06a1") }
            ));
        }

    }
}
