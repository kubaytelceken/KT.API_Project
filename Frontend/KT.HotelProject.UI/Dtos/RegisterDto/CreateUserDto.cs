using System.ComponentModel.DataAnnotations;

namespace KT.HotelProject.UI.Dtos.RegisterDto
{
    public class CreateUserDto
    {
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Surname")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter Confirm Password")]
        [Compare("Password",ErrorMessage = "passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Please enter Mail")]
        public string Mail { get; set; }

    }
}
