namespace Library.ViewModels.Reviews
{
    public class ReviewImportExportVM
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
        public string Comment { get; set; }
        public string Assessment { get; set; }
    }
}
