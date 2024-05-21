using System.ComponentModel.DataAnnotations;

namespace Library.ViewModels.Reviews
{
    public class ReviewCreateVM
    {
        public Guid UserId { get; set; }

        public Guid BookId { get; set; }

        [Required(ErrorMessage = "Required field!")]
        public string Comment { get; set; }

        [Range(1, 5, ErrorMessage = "Assessment must be between 1 and 5.")]
        [Required(ErrorMessage = "Required field!")]
        public string Assessment { get; set; }
    }
}
