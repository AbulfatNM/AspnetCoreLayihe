using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class SkillsTeacher
    {
        public int Id { get; set; }

        public int Language { get; set; } = 0;

        public int Team_Leader { get; set; } = 0;

        public int Development { get; set; } = 0;

        public int Design { get; set; } = 0;

        public int Innovation { get; set; } = 0;

        public int Communication { get; set; } = 0;
        public virtual Teacher Teacher { get; set; }
    }
}
