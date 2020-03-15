using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos

{
    public class UserForRegisterDto
    {
        // field is required
        [Required]
        public string Username { get; set; }

        // this field is mandatory, and needed password length is minimun 10 chars.
        // field is required
        [Required]
        [StringLength(30, MinimumLength = 10, ErrorMessage = "You'll have to have more chars than 10 in the password")]
        public string Password { get; set; }
    }
}