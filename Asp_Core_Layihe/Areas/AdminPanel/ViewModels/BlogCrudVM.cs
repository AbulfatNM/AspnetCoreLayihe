using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Areas.AdminPanel.ViewModels
{
    public class BlogCrudVM
    {
        public Blog  Blog { get; set; }
        public  Category Category { get; set; }
    }
}
