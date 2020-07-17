using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Helpers
{
    public static  class Email
    {
        public enum IsValidEmail
        {       
            Empty,
            NotEmail,
            Already,
            Success
        }

        public enum UserRols
        {
            Admin,
            Member
        }
    }
}
