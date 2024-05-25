using Library.Entities;
using Library.Repositories;
using Library.ViewModels.Reviews;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    [Authorize]
    public class ReviewsController : Controller
    {
        private readonly ReviewRepository _reviewRepository;

        public ReviewsController(ReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpPost]
        public IActionResult Create(ReviewCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Details", "Books", new { Id = model.BookId });
            }

            var review = new Review()
            {
                UserId = model.UserId,
                BookId = model.BookId,
                Comment = model.Comment,
                Assessment = model.Assessment
            };

            _reviewRepository.Save(review);

            return RedirectToAction("Details", "Books", new { Id = model.BookId });
        }
    }
}
