using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            ViewBag.Page = page;
            ViewBag.PageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 6);
            List<AppUser> users = _userManager.Users.ToList();
          
            if (page==null)
            {
                List<Blog> blog = _db.Blogs.Take(6).ToList();

                BlogVM blogVM = new BlogVM()
                {
                    Blogs = blog,
                    AppUsers = users
                };
                return View(blogVM);
            }
            else
            {
                List<Blog> blog = _db.Blogs.Skip((int)(page-1)*6).Take(6).ToList();

                BlogVM blogVM = new BlogVM()
                {
                    Blogs = blog,
                    AppUsers = users
                };
                return View(blogVM);
            }
          
            
        }
        public async Task<IActionResult>   Detail(int id)
        {

            Blog blog = await _db.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            List<Blog> blogs = _db.Blogs.Take(3).ToList();
            List<Category> category = _db.Categories.ToList();
            List<AppUser> appUser = await _userManager.Users.ToListAsync();
            BlogVM blogVM = new BlogVM()
            {
                Blog=blog,
                Blogs=blogs,
                Categories = category,
                AppUsers =appUser

            };
            return View(blogVM);
        }
        public  IActionResult BlogSearch(string search)
        {
            List<Blog> blogs = _db.Blogs.Where(b => b.Title.Contains(search)).OrderByDescending(b => b.Id).Take(2).ToList();
            SearchVM searchVM = new SearchVM()
            {
                Blogs = blogs
            };
            return PartialView("_SearchPartial", searchVM);
        }

    }
}
