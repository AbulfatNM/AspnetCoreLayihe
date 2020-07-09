using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly AppDbContex _db;
        public SubscribeController(AppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> SubscribeEmail(string email)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (string.IsNullOrEmpty(email))
            {
                return PartialView("_SubscribePartial", Email.IsValidEmail.Empty.ToString());
            }
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (!match.Success)
            {
                return PartialView("_SubscribePartial", Email.IsValidEmail.NotEmail.ToString());
            }
            bool hashEmail = await _db.SubscribeMails.AnyAsync(e => e.Email.ToLower() == email.ToLower());
            if (hashEmail)
            {
                return PartialView("_SubscribePartial", Email.IsValidEmail.Already.ToString());
            }
            else
            {
                SubscribeMail mail = new SubscribeMail()
                {
                    Email = email

                };

                _db.SubscribeMails.Add(mail);
                await _db.SaveChangesAsync();
                return PartialView("_SubscribePartial", Email.IsValidEmail.Success.ToString());
            }
        
        
        }
    }
}
