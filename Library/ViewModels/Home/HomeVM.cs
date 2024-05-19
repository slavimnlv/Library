using Library.Entities;

namespace Library.ViewModels.Home
{
    public class HomeVM
    {
        public List<Book> Books { get; set; }
        public int Page { get; set; }   
        public int ItemsPerPage { get; set; }
        public int PagesCount { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int? Year { get; set; }
        public int? Count { get; set; }
        public List<Category>? Categories { get; set; }
        public Guid? CategoryId { get; set; }
    }
}
