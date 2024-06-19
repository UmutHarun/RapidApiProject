using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult GetAboutUsList()
        {
            var values = _aboutUsService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.Insert(aboutUs);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.Delete(aboutUs);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var value = _aboutUsService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.Update(aboutUs);
            return Ok();
        }
    }
}
