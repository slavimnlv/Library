using System.ComponentModel.DataAnnotations;

namespace Library.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
