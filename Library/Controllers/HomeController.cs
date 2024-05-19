using Library.Entities;
using Library.Models;
using Library.Repositories;
using Library.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookRepository _bookRepository;
        private readonly CategoryRepository _categoryRepository;

        public HomeController( BookRepository bookRepository, CategoryRepository categoryRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index(HomeVM model)
        {
            model.Page = model.Page <= 0 ? 1 : model.Page;
            model.ItemsPerPage = 10;
            model.PagesCount = (int)Math.Ceiling(_bookRepository.Count() / (double)model.ItemsPerPage);

            model.Categories = _categoryRepository.GetAll();

            Expression<Func<Book, bool>> filter = b =>
            (string.IsNullOrEmpty(model.Title) || b.Title.Contains(model.Title)) &&
            (string.IsNullOrEmpty(model.Author) || b.Author.Contains(model.Author)) &&
            (!model.Year.HasValue || b.Year == model.Year.Value) &&
            (!model.Count.HasValue || b.Count == model.Count.Value) &&
            (!model.CategoryId.HasValue || b.Categories.Any(c => c.Id == model.CategoryId));


            model.Books = _bookRepository.GetAll(filter, i => i.Id, model.Page, model.ItemsPerPage);

            return View(model);
        }


        [HttpGet]
        public IActionResult Create()
        {
            var model = new CreateVM
            {
                Categories = _categoryRepository.GetAll().Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList()
            };
            return View(model);
           
        }

        [HttpPost]
        public IActionResult Create(CreateVM model)
        {

            if (!ModelState.IsValid)
            {
                model.Categories = _categoryRepository.GetAll().Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }).ToList();

                return View(model);
            }

            Book book = new Book();
            book.Title = model.Title;
            book.Author = model.Author;
            book.Year = model.Year;
            book.Count = model.Count;
            book.Categories = new List<Category>();


            if (model.SelectedCategoryIds != null)
            {
                foreach (var categoryId in model.SelectedCategoryIds)
                {
                    var category = _categoryRepository.GetFirstOrDefault(c => c.Id == categoryId);
                    if (category != null)
                    {
                        book.Categories.Add(category);
                    }
                }
            }


            _bookRepository.Save(book);

            return RedirectToAction("Index", "Home");
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


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
