using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, MinLength(80)]
        public string Description { get; set; }
        public DateTime Date { get; set; } = System.DateTime.Now;
        [Required]
        public string AppUserId { get; set; }
        public int CategoryId { get; set; }
         public virtual Category Category { get; set; }
    }
}
