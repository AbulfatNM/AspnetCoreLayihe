using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa boş buraxmayın"),StringLength(60,ErrorMessage ="Maksimum 60 hərf daxil edə bilərsiz")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa boş buraxmayın"), StringLength(40,ErrorMessage = "Maksimum 40 hərf daxil edə bilərsiz")]
        public string City { get; set; }
        public string  Image { get; set; }
        [NotMapped]
        public IFormFile ContactPhoto { get; set; }
    }
}
