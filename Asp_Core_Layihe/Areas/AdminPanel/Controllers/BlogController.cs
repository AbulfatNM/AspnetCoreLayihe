using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Asp_Core_Layihe.Areas.AdminPanel.ViewModels;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContex db, IHostingEnvironment env, UserManager<AppUser> userManager)
        {
            _db=db;
            _env = env;
            _userManager = userManager;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<Blog> blogs =await _db.Blogs.ToListAsync();
           
            return View(blogs);
        }
        public IActionResult Create()
        {
            
           ViewBag.Categories = _db.Categories;
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Blog blog)
        {
            ViewBag.Categories = _db.Categories;
            if (blog.PhotoBlog == null)
            {
                ModelState.AddModelError("", "Please choose a photo");
                return View();
            }
            if (!blog.PhotoBlog.IsImage())
            {
                ModelState.AddModelError("", "Please select a picture format!");
                return View();
            }
            if (blog.PhotoBlog.MaxLenght(500))
            {
                ModelState.AddModelError("", "Select the selected image size should be a maximum of 200-kb !");
                return View();
            }
          
                blog.Image = await blog.PhotoBlog.SaveImage(_env.WebRootPath, "img/blog");
                AppUser loginUser = await _userManager.FindByNameAsync(User.Identity.Name);
                if (loginUser == null) return NotFound();
                blog.AppUserId = loginUser.Id;
                _db.Blogs.Add(blog);
                await _db.SaveChangesAsync();
            
                return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Blog blogFind = await _db.Blogs.FindAsync(id);
            Category categoryFind = await _db.Categories.FirstOrDefaultAsync(c=>c.Id==blogFind.CategoryId);
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            BlogCrudVM blogVM = new BlogCrudVM()
            {

                Blog = blogFind,
                Category=categoryFind
            };
            if (appUser==null)
            {
                return View();
            }
            blogFind.AppUserId = appUser.FullName;
            if (blogFind == null) return NotFound();
            return View(blogVM);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Categories = _db.Categories;
          


            if (id == null) return NotFound();
            Blog Findblog = await _db.Blogs.FindAsync(id);
            Category category = _db.Categories.FirstOrDefault(c => c.Id == Findblog.CategoryId);
            ViewBag.CategoriName = category.CategoryName;
           AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (appUser == null)
            {
                return View();
            }
            Findblog.AppUserId = appUser.FullName;
         
            return View(Findblog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Blog blog)
        {
            ViewBag.Categories = _db.Categories;
            Blog blogFind = await _db.Blogs.FindAsync(id);
            if (blog == null) return NotFound();
            if (id == null) return NotFound();
            if (blog.PhotoBlog != null)
            {

                if (!blog.PhotoBlog.IsImage())
                {
                    ModelState.AddModelError("PhotoBlog", "Please select a picture format!");
                    return View(blogFind);
                }
                if (blog.PhotoBlog.MaxLenght(200))
                {
                    ModelState.AddModelError("PhotoBlog", "Select the selected image size should be a maximum of 200-kb !");
                    return View(blogFind);
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/blog", blogFind.Image);
                blogFind.Image = await blog.PhotoBlog.SaveImage(_env.WebRootPath, "img/blog");
            }
       
            blogFind.Title = blog.Title;
            blogFind.Description = blog.Description;
             blogFind.Date = blog.Date;
            blogFind.CategoryId = blog.CategoryId;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
          
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Blog Findblog= await _db.Blogs.FindAsync(id);
            Category category = _db.Categories.FirstOrDefault(c => c.Id == Findblog.CategoryId);
            ViewBag.CategoriName = category.CategoryName;
            if (Findblog == null) return NotFound();

            return View(Findblog);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Blog Findblog = await _db.Blogs.FindAsync(id);
            if (Findblog == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/about", Findblog.Image);
            _db.Blogs.Remove(Findblog);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
