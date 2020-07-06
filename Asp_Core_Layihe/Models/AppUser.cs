using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class AppUser:IdentityUser
    {
        [Required,StringLength(150)]
        public string FullName { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
