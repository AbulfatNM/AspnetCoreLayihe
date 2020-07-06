using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(60)]
        public string Title { get; set; }
        [Required, MinLength(30), MaxLength(400)]
        public string Description { get; set; }
    }
}
