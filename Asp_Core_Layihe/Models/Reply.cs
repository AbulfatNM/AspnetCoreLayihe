using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Models
{
    public class Reply
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Subject { get; set; }
        [Required]
        public string Massage { get; set; }
    }
}
