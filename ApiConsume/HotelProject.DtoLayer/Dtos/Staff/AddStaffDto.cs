using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.Dtos.Staff
{
    public class AddStaffDto
    {
        [Required(ErrorMessage = "Please Enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Title")]
        public string Title { get; set; }

        public string SocialMedia1 { get; set; }

        public string SocialMedia2 { get; set; }

        public string SocialMedia3 { get; set; }
    }
}
