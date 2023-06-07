using System.ComponentModel.DataAnnotations;

namespace KT.HotelProject.UI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string Password { get; set; }
    }
}
