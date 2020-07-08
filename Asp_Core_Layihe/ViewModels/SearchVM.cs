using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class SearchVM
    {
        public IEnumerable <Teacher> Teacher { get; set; }
        public IEnumerable<Blog>  Blogs { get; set; }
    }
}
