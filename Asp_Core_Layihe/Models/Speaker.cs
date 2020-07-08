using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(60)]
        public string FullName { get; set; }
        [Required,StringLength(65)]
        public string Position { get; set; }
        public ICollection<EventToSpeaker> EventToSpeakers { get; set; }

    }
}
