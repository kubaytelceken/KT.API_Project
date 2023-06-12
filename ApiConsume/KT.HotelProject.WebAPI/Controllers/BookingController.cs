using KT.HotelProject.Business.Abstract;
using KT.HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _service;

        public BookingController(IBookingService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var bookingList = _service.TGetAll();
            return Ok(bookingList);
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _service.TInsert(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var booking = _service.TGetById(id);
            _service.TDelete(booking);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _service.TUpdate(booking);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var booking = _service.TGetById(id);
            return Ok(booking);
        }
    }
}
