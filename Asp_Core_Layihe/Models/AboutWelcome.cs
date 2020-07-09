using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class AboutWelcome
    {
        public int Id { get; set; }

        [Required,StringLength(150)]
        public string Title { get; set; }

        [Required, MinLength(150)]
        public string Description { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
        
    }
}
