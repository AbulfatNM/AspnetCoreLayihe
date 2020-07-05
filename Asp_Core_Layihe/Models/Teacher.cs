using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string FullName { get; set; }
        [Required]
        public string Image { get; set; }
        [Required,MinLength(30),MaxLength(350)]
        public string About { get; set; }
        [Required,StringLength(70)]
        public string Position{ get; set; }
        [Required,StringLength(50)]
        public string DEGREE { get; set; }
        [Required,StringLength(55)]
        public string EXPERIENCE { get; set; }
        public string HOBBIES { get; set; }
        [Required,StringLength(60)]
        public string FACULTY { get; set; }
        public int SkillsTeacherId { get; set; }
        public virtual SkillsTeacher SkillsTeacher { get; set; }
        public int TeacherContactId { get; set; }
        public virtual TeacherContact  TeacherContact{ get; set; }


    }
}
