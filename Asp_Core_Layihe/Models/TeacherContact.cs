using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class TeacherContact
    {
        public int Id { get; set; }
        [Required,StringLength(60)]
        public string Email { get; set; }
        [Required,StringLength(50)]
        public string Phone { get; set; }
        public string SKYPE { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Linkedin { get; set; }
        public virtual Teacher Teacher { get; set; }

    }
}
