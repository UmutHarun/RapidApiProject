using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Login
{
    public class LoginUserDto
    {
        [Required(ErrorMessage = "Please Enter a Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please Enter a Password")]
        public string Password { get; set; }
    }
}
