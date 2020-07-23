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
        public IEnumerable<Blog> Blog { get; set; }
        public IEnumerable<AppUser> AppUser { get; set; }
        public Reply Reply { get; set; }
    }
}
