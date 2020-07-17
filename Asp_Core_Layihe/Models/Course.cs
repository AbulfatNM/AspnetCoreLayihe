using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,StringLength(60)]
        public string Title { get; set; }
        [Required,MinLength(30),MaxLength(400)]
        public string Description { get; set; }
        public int CourseFeatureId { get; set; }
        public virtual CourseFeature CourseFeature { get; set; }
        public int CourseContentId { get; set; }
        public virtual CourseContent CourseContent { get; set; }
        [NotMapped]
        public IFormFile CoursePhoto { get; set; }

    }
}
