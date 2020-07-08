using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Core_Layihe.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContex _db;
        public ContactController(AppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Contact> contact = _db.Contacts.ToList();
            return View(contact);
        }
    }
}
