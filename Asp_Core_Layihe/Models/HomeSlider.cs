using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [MinLength(30),MaxLength(300)]
        public string Description { get; set; }
        public string Image { get; set; }
    }
}
