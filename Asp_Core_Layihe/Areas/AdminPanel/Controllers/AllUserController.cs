using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.Areas.AdminPanel.ViewModels;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AllUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public AllUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> appUsers = await _userManager.Users.ToListAsync();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (AppUser user in appUsers)
            {
                UserVM userVM = new UserVM
                {
                    FullName = user.FullName,
                    UserName = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user))[0],
                    IsDelete = user.IsDelete
                };
                userVMs.Add(userVM);
            }
              return View(userVMs);
        }
        public IActionResult ChangeRols()
        {

            return View();
        }
        [HttpPost]
        [Area("AdminPanel")]
        public async Task<IActionResult> ChangeRols(string email, string rolname)
        {

            AppUser user = await _userManager.FindByEmailAsync(email);
            string oldRole = (await _userManager.GetRolesAsync(user))[0];

            if (rolname != oldRole)
            {
                await _userManager.RemoveFromRoleAsync(user, oldRole);
                await _userManager.AddToRoleAsync(user, rolname);
            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> RemoveUser(string email)
        {
            AppUser userEmail = await _userManager.FindByEmailAsync(email);
            userEmail.IsDelete = true;
            await _userManager.UpdateAsync(userEmail);
            return RedirectToAction(nameof(Index));
        }

    }

}
    

