using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class AboutNotice
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa tarixi daxil edin"),DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Zəhmət olmasa mətni daxil edin"), MinLength(30,ErrorMessage ="Ən azı 30 hərf daxil edin"),MaxLength(300, ErrorMessage = "Ən çoxu 300 hərf daxil edin")]
        public string Description { get; set; }

    }
}
