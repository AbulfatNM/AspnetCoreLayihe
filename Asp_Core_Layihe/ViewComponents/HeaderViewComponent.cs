using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly AppDbContex _db;
        public HeaderViewComponent(AppDbContex db)
        {
            _db = db;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
