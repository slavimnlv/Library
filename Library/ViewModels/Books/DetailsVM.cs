using Library.ViewModels.Categories;
using Library.ViewModels.Reviews;
using System.ComponentModel;

namespace Library.ViewModels.Books
{
    public class DetailsVM
    {
        public Guid BookId { get; set; }

        [DisplayName("Title: ")]
        public string Title { get; set; }

        [DisplayName("Author: ")]
        public string Author { get; set; }

        [DisplayName("Year: ")]
        public int Year { get; set; }

        [DisplayName("Currently available: ")]
        public int Count { get; set; }

        [DisplayName("Reviews: ")]
        public List<ReviewVM> Reviews { get; set; } = new List<ReviewVM>();

        [DisplayName("Categories: ")]
        public List<CategoryVM> Categories { get; set; } = new List<CategoryVM>();

        public ReviewCreateVM NewReview { get; set; }
    }
}
