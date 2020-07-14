using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class HomeSlider
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Boş buraxıla bilməz"), StringLength(150)]
        public string Title { get; set; }

        [Required(ErrorMessage ="Boş buraxıla bilməz"),MinLength(30,ErrorMessage ="Ən azı 30 hərif daxil etməlisiz"),MaxLength(300)]
        public string Description { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
