using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.Service
{
    public class AddServiceDto
    {
        [Required(ErrorMessage = "Please Enter Service Icon")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
