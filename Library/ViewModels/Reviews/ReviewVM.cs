using System.ComponentModel;

namespace Library.ViewModels.Reviews
{
    public class ReviewVM
    {
        public string AuthorName { get; set; }

        [DisplayName("Comment: ")]
        public string Comment { get; set; }

        [DisplayName("Assessment: ")]
        public string Assessment { get; set; }
    }
}
