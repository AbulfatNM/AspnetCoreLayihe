﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Asp_Core_Layihe.Controllers
{
   
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContex _db;
        public BlogController(UserManager<AppUser> userManager,AppDbContex db)
        {
            _userManager = userManager;
            _db = db;

        }
        public IActionResult Index(int? page)
        {
            //ViewBag.Page = page;
            //ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count()/6);
            List<AppUser> users = _userManager.Users.ToList();
            List<Blog> blog = _db.Blogs.Take(6).ToList();
            
            BlogVM blogVM = new BlogVM()
            {
                Blogs = blog,
                AppUsers = users
            };
          
            return View(blogVM);
        }
        public async Task<IActionResult>  Detail(int id)
        {
            Blog blog = await _db.Blogs.FindAsync(id);

            return View(blog);
        }

    }
}