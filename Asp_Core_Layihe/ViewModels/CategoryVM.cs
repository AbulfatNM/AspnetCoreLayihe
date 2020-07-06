using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class CategoryVM
    {
        public Course Course { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
