using System.ComponentModel;

namespace Library.ViewModels.Reviews
{
    public class ReviewVM
    {
        [DisplayName("Comment: ")]
        public string Comment { get; set; }

        [DisplayName("Assessment: ")]
        public string Assessment { get; set; }
    }
}
