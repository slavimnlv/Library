using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Library.ViewModels.Books
{
    public class EditVM
    {
        public Guid Id { get; set; }

        [DisplayName("Title: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Title { get; set; }

        [DisplayName("Author: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Author { get; set; }

        [DisplayName("Year: ")]
        [Required(ErrorMessage = "Required field!")]
        public int Year { get; set; }

        [DisplayName("Count: ")]
        [Range(0, int.MaxValue, ErrorMessage = "Count must be 0 or greater.")]
        [Required(ErrorMessage = "Required field!")]
        public int Count { get; set; }

        public IEnumerable<Guid> SelectedCategoriesIds { get; set; } = new List<Guid>();

        public List<SelectListItem>? Categories { get; set; }
    }
}
