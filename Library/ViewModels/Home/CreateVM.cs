using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Library.ViewModels.Home
{
    public class CreateVM
    {
        [DisplayName("Title: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Title { get; set; }

        [DisplayName("Author: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Author { get; set; }

        [DisplayName("Year: ")]
        [Required(ErrorMessage = "Required field!")]
        [Range(0, 2024, ErrorMessage = "Year must be between 0 and 2024.")]
        public int Year { get; set; }

        [DisplayName("Count: ")]
        [Required(ErrorMessage = "Required field!")]
        [Range(0, int.MaxValue, ErrorMessage = "Count must be 0 or greater.")]
        public int Count { get; set; }

        public List<Guid> SelectedCategoryIds { get; set; } = new List<Guid>();
        public IEnumerable<SelectListItem>? Categories { get; set; }
    }
}
