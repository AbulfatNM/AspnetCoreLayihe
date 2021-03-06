﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Core_Layihe.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager; 
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            AppUser newUser = new AppUser()
            {
                Email = register.Email,
                UserName = register.UserName,
                FullName = register.FullName,

            };
            IdentityResult identityResult = await _userManager.CreateAsync(newUser,register.Password); 
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(newUser, Email.UserRols.Member.ToString());
            await _signInManager.SignInAsync(newUser, true);

            return RedirectToAction("Index", "Home");
        }
        public async Task <IActionResult> LogOut()
        {
          await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
     public async Task<IActionResult> LogIn(LoginVM login)
        {
            if (!ModelState.IsValid) return View(login);

            AppUser logiUser = await _userManager.FindByEmailAsync(login.Email);
            if (logiUser == null)
            {
                ModelState.AddModelError("", "Daxil edilən email və ya parol səhvdir !!! ");
                return View(login);
            }
            var signinResult = await _signInManager.PasswordSignInAsync(logiUser, login.Password, false, true);
            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "Daxil edilən email və ya parol səhvdir !!! ");
                return View(login);
            }
            if (logiUser.IsDelete == true)
            {
                ModelState.AddModelError("", "Sizin hesabiniz silinmişdir !!");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }
        public async Task CreateRole()
        {
            if (!await _roleManager.RoleExistsAsync(Email.UserRols.Admin.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Email.UserRols.Admin.ToString()));
            }
            if (!await _roleManager.RoleExistsAsync(Email.UserRols.Member.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(Email.UserRols.Member.ToString()));
            }
           
        }
    }
 
}
