using Asp_Core_Layihe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class AboutVM
    {
        public AboutWelcome  AboutWelcome { get; set; }
        public ICollection<Teacher>  Teachers { get; set; }
        public AboutVideo AboutVideo { get; set; }
        public ICollection<AboutNotice> AboutNotices { get; set; }
        public AboutSlider AboutSlider { get; set; }
        public Bio Bio { get; set; }
    }
}
