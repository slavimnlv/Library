using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Library.ViewModels.Users
{
    public class LoginVM
    {
        public Guid Id { get; set; }

        [DisplayName("Username: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Username { get; set; }

        [DisplayName("Password: ")]
        [Required(ErrorMessage = "Required field!")]
        public string Password { get; set; }
    }
}
