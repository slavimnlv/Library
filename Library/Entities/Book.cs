namespace Library.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public int Count {  get; set; }

        public List<Review> Reviews { get; set; }
        public List<Category> Categories { get; set; }
    }
}
