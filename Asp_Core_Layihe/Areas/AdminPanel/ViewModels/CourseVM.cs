using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Areas.AdminPanel.ViewModels
{
    public class CourseVM
    {
        public Course  Course { get; set; }
        public CourseContent CourseContent { get; set; }
        public CourseFeature CourseFeature { get; set; }
    }
}
