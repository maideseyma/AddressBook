using System.ComponentModel.DataAnnotations;

namespace AddressBookPL.Models
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(50,MinimumLength =2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required]
        // regular expression yazılmalı
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 10)]
        // regular expression yazılmalı
        public string Phone { get; set; }
        public DateTime? Birthdate { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }
    }
}
