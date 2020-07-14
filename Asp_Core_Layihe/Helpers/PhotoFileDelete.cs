using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.Helpers
{
    
    public static class PhotoFileDelete
    {
        public static void IsDeletePhoto(string root, string folder,string image)
        {
            string filePath = Path.Combine(root, folder, image);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }
        }
      
}
}
