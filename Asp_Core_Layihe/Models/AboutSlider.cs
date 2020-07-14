using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class AboutSlider
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,MinLength(30),MaxLength(350)]
        public string Description { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(50)]
        public string Position { get; set; }
        public string BackgroundImage { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile BackgroundPhoto { get; set; }
    }
}
