using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.Areas.AdminPanel.ViewModels;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Helpers;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asp_Core_Layihe.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class CourseController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public CourseController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public async Task<IActionResult>  Index()
        {
            ICollection<Course> courses = await _db.Courses.ToListAsync();

            return View(courses);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseVM courseCreate)
        {
            Course course =await _db.Courses.FirstOrDefaultAsync();
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync();
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync();

            if (courseCreate.Course.CoursePhoto == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!courseCreate.Course.CoursePhoto.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (courseCreate.Course.CoursePhoto.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }
            
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };
       
            CourseFeature feature = courseCreate.CourseFeature;
            CourseContent content = courseCreate.CourseContent;
            course = courseCreate.Course;
            course.CourseFeature = feature;
            course.CourseContent = content;
            courseCreate.Course.Image = await courseCreate.Course.CoursePhoto.SaveImage(_env.WebRootPath, "img/course");
            _db.Courses.Add(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync(c => c.Id == course.CourseContentId);
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync(c=>c.Id==course.CourseFeatureId);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };
           
            if (courseVM == null) return NotFound();
            return View(courseVM);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync(c => c.Id == course.CourseContentId);
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync(c => c.Id == course.CourseFeatureId);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };
            if (courseVM == null) return NotFound();
            return View(courseVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, CourseVM courseEdit)
        {
            Course course = await _db.Courses.FindAsync(id);
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync(c => c.Id == course.CourseContentId);
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync(c => c.Id == course.CourseFeatureId);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };
         
            if (courseEdit == null) return NotFound();
            if (id == null) return NotFound();
      
            if (courseEdit.Course.CoursePhoto != null)
            {
                if (!courseEdit.Course.CoursePhoto.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                    return View();
                }
                if (courseEdit.Course.CoursePhoto.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                    return View();
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/course", courseVM.Course.Image);
                courseVM.Course.Image = await courseEdit.Course.CoursePhoto.SaveImage(_env.WebRootPath, "img/course");
            }
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            courseVM.Course.Title = courseEdit.Course.Title;
            courseVM.Course.Description = courseEdit.Course.Description;
            courseVM.CourseFeature.Starts = courseEdit.CourseFeature.Starts;
            courseVM.CourseFeature.Duration = courseEdit.CourseFeature.Duration;
            courseVM.CourseFeature.Class_Duration = courseEdit.CourseFeature.Class_Duration;
            courseVM.CourseFeature.Skill_Level = courseEdit.CourseFeature.Skill_Level;
            courseVM.CourseFeature.Language = courseEdit.CourseFeature.Language;
            courseVM.CourseFeature.Students = courseEdit.CourseFeature.Students;
            courseVM.CourseFeature.Assesments = courseEdit.CourseFeature.Assesments;
            courseVM.CourseFeature.Course_Fee = courseEdit.CourseFeature.Course_Fee;
            courseVM.CourseContent.AboutCourse = courseEdit.CourseContent.AboutCourse;
            courseVM.CourseContent.HowToApply = courseEdit.CourseContent.HowToApply;
            courseVM.CourseContent.Certification = courseEdit.CourseContent.Certification;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync(c => c.Id == course.CourseContentId);
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync(c => c.Id == course.CourseFeatureId);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };

            if (courseVM == null) return NotFound();
            return View(courseVM);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            Course course = await _db.Courses.FindAsync(id);
            CourseContent courseContent = await _db.CourseContents.FirstOrDefaultAsync(c => c.Id == course.CourseContentId);
            CourseFeature courseFeature = await _db.CourseFeatures.FirstOrDefaultAsync(c => c.Id == course.CourseFeatureId);
            CourseVM courseVM = new CourseVM()
            {
                Course = course,
                CourseContent = courseContent,
                CourseFeature = courseFeature
            };
            if (courseVM == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/course", courseVM.Course.Image);
            _db.CourseContents.Remove(courseVM.CourseContent);
            _db.CourseFeatures.Remove(courseVM.CourseFeature);
            _db.Courses.Remove(courseVM.Course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
