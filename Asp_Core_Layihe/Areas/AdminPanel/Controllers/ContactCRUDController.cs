using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ContactCRUDController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public ContactCRUDController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            ICollection<Contact> contacts = await _db.Contacts.ToListAsync();
            return View(contacts);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            if (!ModelState.IsValid) return View();
            if (contact.ContactPhoto == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!contact.ContactPhoto.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (contact.ContactPhoto.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }

            contact.Image = await contact.ContactPhoto.SaveImage(_env.WebRootPath, "img/contact");
            _db.Contacts.Add(contact);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Contact contactFind = await _db.Contacts.FindAsync(id);
            if (contactFind == null) return NotFound();
            return View(contactFind);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Contact Findcontact = await _db.Contacts.FindAsync(id);
            if (Findcontact == null) return NotFound();
            return View(Findcontact);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Contact contact)
        {
            Contact contactFind = await _db.Contacts.FindAsync(id);

            if (!ModelState.IsValid)
            {
                return View(contactFind);
            }
            if (contact == null) return NotFound();
            if (id == null) return NotFound();
            if (contact.ContactPhoto != null)
            {

                if (!contact.ContactPhoto.IsImage())
                {
                    ModelState.AddModelError("ContactPhoto", "Zehmet olmasa şəkil formati seçin !");
                    return View(contactFind);
                }
                if (contact.ContactPhoto.MaxLenght(200))
                {
                    ModelState.AddModelError("ContactPhoto", "Secilen şəkil olcusu maksimum 200-kb olmalidi seçin !");
                    return View(contactFind);
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/contact", contactFind.Image);
                contactFind.Image = await contact.ContactPhoto.SaveImage(_env.WebRootPath, "img/contact");
            }

            contactFind.Address = contact.Address;
            contactFind.City = contact.City;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Contact contactFind = await _db.Contacts.FindAsync(id);
            if (contactFind == null) return NotFound();

            return View(contactFind);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Contact contactFind = await _db.Contacts.FindAsync(id);
            if (contactFind == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/contact", contactFind.Image);
            _db.Contacts.Remove(contactFind);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
