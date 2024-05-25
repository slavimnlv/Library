using Library.ViewModels.Categories;
using Library.ViewModels.Reviews;

namespace Library.ViewModels.Books
{
    public class BookImportExportVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Count { get; set; }
        public List<CategoryImportExportVM> Categories { get; set; } = new List<CategoryImportExportVM>();
        public List<ReviewImportExportVM> Reviews { get; set; } = new List<ReviewImportExportVM>();
    }
}
