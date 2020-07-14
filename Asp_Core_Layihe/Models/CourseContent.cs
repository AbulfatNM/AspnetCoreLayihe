using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class CourseContent
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Zəhmət olmasa kurs hakkinda yazin"), MinLength(15,ErrorMessage ="Ən azı 15 hərif yazılmalıdı"),MaxLength(400, ErrorMessage = "Ən çoxu 400 hərif yazılmalıdı")]
        public string AboutCourse { get; set; }
        [MinLength(15, ErrorMessage = "Ən azı 15 hərif yazılmalıdı"), MaxLength(400, ErrorMessage = "Ən çoxu 400 hərif yazılmalıdı")]
        public string HowToApply { get; set; }
        [MinLength(15, ErrorMessage = "Ən azı 15 hərif yazılmalıdı"), MaxLength(400, ErrorMessage = "Ən çoxu 400 hərif yazılmalıdı")]
        public string Certification { get; set; }
        public virtual Course Course { get; set; }

    }
}
