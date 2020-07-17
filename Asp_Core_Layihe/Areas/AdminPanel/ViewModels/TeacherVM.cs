using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Areas.AdminPanel.ViewModels
{
    public class TeacherVM
    {
        public Teacher Teacher { get; set; }
        public SkillsTeacher  SkillsTeacher{ get; set; }
        public TeacherContact TeacherContact { get; set; }
    }
}
