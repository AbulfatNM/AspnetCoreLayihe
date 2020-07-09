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
        [Required,StringLength(150)]
        public DateTime Date { get; set; }
        [Required, MinLength(30),MaxLength(300)]
        public string Description { get; set; }

    }
}
