using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class HomeVM
    {
        public ICollection<HomeSlider>  HomeSliders { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<AboutNotice> AboutNotices { get; set; }
        public ICollection<Event> Events { get; set; }
        public AboutSlider AboutSliders { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public AboutWelcome AboutWelcome { get; set; }
        public AboutVideo AboutVideo { get; set; }
        public ICollection <AppUser> AppUser { get; set; }
        public Bio Bio { get; set; }

    }
}
