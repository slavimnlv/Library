namespace Library.Entities
{
    public class Review : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public string Comment { get; set; }
        public string Assessment { get; set; }
    }
}
