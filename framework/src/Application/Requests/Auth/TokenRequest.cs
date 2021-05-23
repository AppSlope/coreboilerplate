using System.ComponentModel.DataAnnotations;

namespace CoreBoilerplate.Application.Requests.Auth
{
    public class TokenRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}