using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
        [MinLength(30),MaxLength(250)]
        public string Description { get; set; }
        public string Facebook { get; set; }
        public string Tiwitter { get; set; }
        public string Linkedin { get; set; }

    }
}
