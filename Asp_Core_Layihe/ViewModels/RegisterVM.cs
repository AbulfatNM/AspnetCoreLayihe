using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewModels
{
    public class RegisterVM
    {
        [Required,StringLength(150)]
        public string FullName { get; set; }

        [Required,StringLength(50)]
        public string UserName { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,Compare(nameof(Password)) ,DataType(DataType.Password)]
        public string CheckPassword { get; set; }
    }
}
