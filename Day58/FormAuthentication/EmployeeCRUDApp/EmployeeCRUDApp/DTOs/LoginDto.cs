using System.ComponentModel.DataAnnotations;

namespace LoginValidationAttributesApp.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }= "";

        [Required(ErrorMessage = "Password is required")]
        public string UserPassword { get; set; } = "";
    }
}
