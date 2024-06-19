using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public IActionResult GetBookingList()
        {
            var values = _bookingService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.Insert(booking);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBooking(Booking booking)
        {
            _bookingService.Delete(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.GetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.Update(booking);
            return Ok();
        }
    }
}
