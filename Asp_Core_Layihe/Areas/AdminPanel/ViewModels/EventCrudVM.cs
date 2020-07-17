using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Areas.AdminPanel.ViewModels
{
    public class EventCrudVM
    {
        public string Image { get; set; }
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string Venue { get; set; }
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }
        public DateTime Date { get; set; }
        public Speaker   Speaker { get; set; }
        public List<Speaker> Speakers { get; set; }
        public IEnumerable<EventToSpeaker> EventToSpeakers { get; set; }
        public EventToSpeaker EventToSpeaker { get; set; }
        public ICollection<Event> Events { get; set; }
        public Event Event { get; set; }
        [NotMapped]
        public IFormFile PhotoEvent { get; set; }

    }
}
