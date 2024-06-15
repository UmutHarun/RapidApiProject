using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult GetRoomList()
        {
            var values = _roomService.GetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.Insert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(Room room) 
        {
            _roomService.Delete(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id) 
        {
            var value = _roomService.GetById(id);
            return Ok(value);
        }   

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.Update(room);
            return Ok();
        }
    }
}
