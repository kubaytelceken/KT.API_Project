using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.HotelProject.DTO.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Room Number")]
        public string RoomNumber { get; set; }
        public string CoverImage { get; set; }
        [Required(ErrorMessage = "Enter Room Price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Enter Room Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Enter Room Bath Count")]
        public string BathCount { get; set; }
        [Required(ErrorMessage = "Enter Room Bed Count")]
        public string BedCount { get; set; }
        public string WiFi { get; set; }
        public string Description { get; set; }
    }
}
