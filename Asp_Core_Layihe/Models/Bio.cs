using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
        public string SmalLogoWhite { get; set; }
        public string SmalLogoBlack { get; set; }

        [MinLength(30),MaxLength(250)]
        public string Description { get; set; }
        [DataType(DataType.Url)]
        public string Facebook { get; set; }
        [DataType(DataType.Url)]
        public string Tiwitter { get; set; }
        [DataType(DataType.Url)]
        public string Linkedin { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped]
        public IFormFile PhotoSmalLogoBlack { get; set; }
        [NotMapped]
        public IFormFile PhotoSmalLogoWhite { get; set; }
        


    }
}
