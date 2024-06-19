using HotelProject.WebUI.Dtos.Booking;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult AddBooking()
        {
            return PartialView();
        }

        public async Task<IActionResult> AddBooking(AddBookingDto addBookingDto)
        {
            return View();
        }
    }
}
