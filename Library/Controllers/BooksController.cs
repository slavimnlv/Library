using Library.Repositories;
using Library.ViewModels.Books;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text;

namespace Library.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly BookRepository _bookRepository;
        private readonly CategoryRepository _categoryRepository;

        public BooksController(BookRepository bookRepository, CategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Details(Guid id)
        {
            var book = _bookRepository.GetBookWithDetails(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var book = _bookRepository.GetFirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            var t = _categoryRepository.GetAll(null, null, 1, Int32.MaxValue, c => c.Books);

            var model = new EditVM()
            {
                Id = book.Id,
                Author = book.Author,
                Count = book.Count,
                Title = book.Title,
                Year = book.Year,
                Categories = _categoryRepository
                   .GetAll(null, null, 1, Int32.MaxValue, c => c.Books)
                   .Select(c => new SelectListItem
                   {
                       Value = c.Id.ToString(),
                       Text = c.Name,
                   }).ToList(),
                SelectedCategoriesIds = _categoryRepository
                .GetAll(c => c.Books.Any(b => b.Id == book.Id))
                .Select(c => c.Id)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(EditVM model)
        {
            if (!ModelState.IsValid)
            {
                model.Categories = _categoryRepository
                   .GetAll(null, null, 1, Int32.MaxValue, c => c.Books)
                   .Select(c => new SelectListItem
                   {
                       Value = c.Id.ToString(),
                       Text = c.Name,
                   }).ToList();

                return View(model);
            }

            var book = _bookRepository.GetAll(b => b.Id == model.Id, null, 1, Int32.MaxValue, b => b.Categories).FirstOrDefault();
            if (book == null)
            {
                return NotFound();
            }

            book.Title = model.Title;
            book.Author = model.Author;
            book.Year = model.Year;
            book.Count = model.Count;

            book.Categories.Clear();
            var newCategories = _categoryRepository
                .GetAll(c => model.SelectedCategoriesIds.Contains(c.Id)).ToList();

            foreach (var category in newCategories)
            {
                book.Categories.Add(category);
            }

            _bookRepository.Save(book);

            return RedirectToAction("Details", new { model.Id });
        }

        [HttpPost]
        public IActionResult Delete(Guid bookId)
        {
            var book = _bookRepository.GetFirstOrDefault(b => b.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }

            _bookRepository.Delete(book);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Borrow(Guid bookId)
        {
            var book = _bookRepository.GetFirstOrDefault(c => c.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }

            book.Count--;
            _bookRepository.Save(book);

            return RedirectToAction("Details", new { Id = bookId });
        }

        [HttpPost]
        public IActionResult Return(Guid bookId)
        {
            var book = _bookRepository.GetFirstOrDefault(c => c.Id == bookId);
            if (book == null)
            {
                return NotFound();
            }

            book.Count++;
            _bookRepository.Save(book);

            return RedirectToAction("Details", new { Id = bookId });
        }

        [HttpPost]
        public IActionResult Export()
        {
            var jsonString = _bookRepository.ExportBooksAsJson();

            return File(Encoding.UTF8.GetBytes(jsonString), "application/json", "Export.json");
        }

        [HttpPost]
        public IActionResult Import(IFormFile file)
        {
            if (file == null ||
                file.Length == 0 ||
                Path.GetExtension(file.FileName).ToLower() != ".json")
            {
                //handle error
            }

            try
            {
                _bookRepository.ImportBooks(file);
            }
            catch (Exception ex)
            {
                //handle error
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
