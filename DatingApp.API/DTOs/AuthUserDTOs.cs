using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class AuthUserDTOs
    {
        [Required]
        [MaxLength(256)]
        public string Username { get; set; }

        [Required]
        [MaxLength(256)]
        public string Password { get; set; }
    }
    public class UserTokenDto
    {
        public string Username { get; set; }

        public string Token { get; set; }
    }
}