﻿using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private readonly AppDbContex _db;
        public FooterViewComponent(AppDbContex db)
        {
            _db = db;
        }
        public async Task <IViewComponentResult> InvokeAsync()
        {
            Bio model = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(model));
        }
    }
}
