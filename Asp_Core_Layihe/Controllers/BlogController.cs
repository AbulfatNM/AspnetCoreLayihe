using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<IActionResult>   Detail(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }

            Blog blog = await _db.Blogs.FirstOrDefaultAsync(b => b.Id == id);
            if (blog==null)
            {
                return NotFound();
            }
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Detail")]
        public IActionResult CourseReapley(BlogVM massage)
        {
            if (!ModelState.IsValid) return View();
            Reply reply = new Reply
            {
                Name = massage.Reply.Name,
                Email = massage.Reply.Email,
                Massage = massage.Reply.Massage,
                Subject = massage.Reply.Subject

            };
           
            _db.Replies.Add(reply);
            _db.SaveChanges();
            return RedirectToAction(nameof(Detail));
        }
    }
}
