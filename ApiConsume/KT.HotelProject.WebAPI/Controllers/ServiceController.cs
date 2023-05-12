using KT.HotelProject.Business.Abstract;
using KT.HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _service;

        public ServiceController(IServiceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult ServiceList()
        {
            var serviceList = _service.TGetAll();
            return Ok(serviceList);
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _service.TInsert(service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteService(int id)
        {
            var service = _service.TGetById(id);
            _service.TDelete(service);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateService(Service service)
        {
            _service.TUpdate(service);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetService(int id)
        {
            var service = _service.TGetById(id);
            return Ok(service);
        }
    }
}
