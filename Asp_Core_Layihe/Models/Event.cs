using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(150)]
        public string Title { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public string Venue { get; set; }
        [Required,MinLength(30)]
        public string Description { get; set; }
        public ICollection<EventToSpeaker> EventToSpeakers { get; set; }

    }
}
