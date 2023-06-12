using AutoMapper;
using KT.HotelProject.Business.Abstract;
using KT.HotelProject.DTO.Dtos.AboutDto;
using KT.HotelProject.Entity.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;
        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult AboutList()
        {
            var roomList = _aboutService.TGetAll();
            return Ok(roomList);
        }

        [HttpPost]
        public IActionResult AddAbout(AboutAddDto roomAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var room = _mapper.Map<About>(roomAddDto);
            _aboutService.TInsert(room);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var room = _aboutService.TGetById(id);
            _aboutService.TDelete(room);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAbout(AboutUpdateDto roomUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var room = _mapper.Map<About>(roomUpdateDto);
            _aboutService.TUpdate(room);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var room = _aboutService.TGetById(id);
            return Ok(room);
        }
    }
}
