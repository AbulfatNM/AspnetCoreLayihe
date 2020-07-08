using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class BlogVM
    {
        public IEnumerable<Blog> Blogs  { get; set; }
        public Blog Blog { get; set; }
        public AppUser AppUser { get; set; }
        public IEnumerable <Category> Categories { get; set; }
        public IEnumerable<AppUser> AppUsers { get; set; }
    }
}
