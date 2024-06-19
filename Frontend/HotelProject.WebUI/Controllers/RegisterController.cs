using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.Register;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View(createNewUserDto);
            }
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,   
                Email = createNewUserDto.Email,
                UserName = createNewUserDto.Username,
                Surname = createNewUserDto.Surname,
                City = createNewUserDto.City,
            };
            var result = await _userManager.CreateAsync(appUser,createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View();
            }
        }
    }
}
