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
        [MinLength(15),MaxLength(400)]
        public string AboutCourse { get; set; }
        [MinLength(15), MaxLength(400)]
        public string HowToApply { get; set; }
        [MinLength(15), MaxLength(400)]
        public string Certification { get; set; }
        public virtual Course Course { get; set; }

    }
}
