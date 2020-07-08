using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class EventToSpeaker
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }

    }
}
