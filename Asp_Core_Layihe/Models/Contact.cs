using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required,StringLength(60)]
        public string Address { get; set; }
        [Required,StringLength(40)]
        public string City { get; set; }
        public string  Image { get; set; }
    }
}
