using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        [Required, StringLength(65),DataType(DataType.Date)]
        
        public string Starts { get; set; }
        [Required, StringLength(50),DataType(DataType.Duration)]
        public string Duration { get; set; }
        [Required, StringLength(50)]
        public string Class_Duration { get; set; }
        public string Skill_Level { get; set; }
        [Required, StringLength(40)]
        public string Language { get; set; }
        [Required]
        public int Students { get; set; }
        [Required]
        public string Assesments { get; set; }
        public double Course_Fee { get; set; }
        public virtual Course Course { get; set; }
    }
}
