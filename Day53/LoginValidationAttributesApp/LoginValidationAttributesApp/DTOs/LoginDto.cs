using System.ComponentModel.DataAnnotations;

namespace LoginValidationAttributesApp.DTOs
{
    public class LoginDto
    {
        //DataAnnonations...This is serverside validation for the form showing error in client side
        [Required(ErrorMessage = "Server says username is requried")]
        [StringLength(10, ErrorMessage = "server says Maximum lenght is only 10 ")]
        // [ShouldContainRRDInName()]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Server says password is requried")]
        public string UserPassword { get; set; }
    }
}
