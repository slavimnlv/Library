﻿using Library.Entities;
using Library.ViewModels.Books;
using Library.ViewModels.Categories;
using Library.ViewModels.Reviews;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace Library.Repositories
{
    public class BookRepository : BaseRepository<Book>
    {
        private readonly ReviewRepository _reviewRepository;
        private readonly CategoryRepository _categoryRepository;

        public BookRepository(LibraryDbContext context, ReviewRepository reviewRepository, CategoryRepository categoryRepository)
            : base(context)
        {
            _reviewRepository = reviewRepository;
            _categoryRepository = categoryRepository;
        }

        public DetailsVM? GetBookWithDetails(Guid Id)
        {
            var book = Items
                .Where(b => b.Id == Id)
                .FirstOrDefault();

            if (book == null)
            {
                return null;
            }

            var reviewsForBook = _reviewRepository.GetAll(r => r.BookId == Id, null, 1, 2, r => r.User);
            var booksCategories = _categoryRepository.GetAll(c => c.Books.Any(b => b.Id == Id));

            var bookDetails = new DetailsVM()
            {
                BookId = book.Id,
                Author = book.Author,
                Count = book.Count,
                Title = book.Title,
                Year = book.Year,
                Reviews = reviewsForBook.Select(r => new ReviewVM
                {
                    AuthorName = r.User.Username,
                    Assessment = r.Assessment,
                    Comment = r.Comment
                }).ToList(),
                Categories = booksCategories.Select(c => new CategoryVM
                {
                    Name = c.Name
                }).ToList(),
                NewReview = new ReviewCreateVM()
                {
                    UserId = Guid.Parse("37434f41-8df2-4e41-b575-a07e3ca25fac"),
                    BookId = book.Id,
                }
            };

            return bookDetails;
        }

        public string ExportBooksAsJson()
        {
            var booksAndCategories = Items
                .Include(b => b.Categories)
                .ToList();


            var reviews = _reviewRepository.GetAll();

            var output = booksAndCategories
                .Select(b => new BookImportExportVM()
                {
                    Id = b.Id,
                    Title = b.Title,
                    Author = b.Author,
                    Year = b.Year,
                    Count = b.Count,
                    Categories = b.Categories.Select(c => new CategoryImportExportVM()
                    {
                        Id = c.Id,
                        Name = c.Name
                    }).ToList(),
                    Reviews = reviews
                        .Where(r => r.BookId == b.Id)
                        .Select(r => new ReviewImportExportVM()
                        {
                            Id = r.Id,
                            UserId = r.UserId,
                            BookId = r.BookId,
                            Comment = r.Comment,
                            Assessment = r.Assessment
                        }).ToList()
                })
                .ToList();

            var jsonString = JsonSerializer.Serialize(output, new JsonSerializerOptions
            {
                WriteIndented = true,
            });

            return jsonString;
        }

        public void ImportBooks(IFormFile file)
        {
            using (StreamReader sr = new(file.OpenReadStream()))
            {
                var jsonData = sr.ReadToEnd();
                var items = JsonSerializer.Deserialize<List<BookImportExportVM>>(jsonData);

                if (items.Count == 0)
                {
                    //throwing an error for wrong json format
                }

                foreach (var item in items)
                {
                    var book = new Book()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Author = item.Author,
                        Year = item.Year,
                        Count = item.Count
                    };

                    foreach (var category in item.Categories)
                    {
                        var categoryFromDb = _categoryRepository.GetFirstOrDefault(c => c.Id == category.Id);

                        if (categoryFromDb == null)
                        {
                            var categoryDb = new Category()
                            {
                                Id = category.Id,
                                Name = category.Name,
                            };

                            book.Categories.Add(categoryDb);
                            continue;
                        }

                        book.Categories.Add(categoryFromDb);
                    }

                    Items.Add(book);
                    Context.SaveChanges();

                    foreach (var review in item.Reviews)
                    {
                        _reviewRepository.AddImported(new Review()
                        {
                            Id = review.Id,
                            UserId = review.UserId,
                            BookId = review.BookId,
                            Comment = review.Comment,
                            Assessment = review.Assessment
                        });
                    }
                }
            }
        }
    }
}
