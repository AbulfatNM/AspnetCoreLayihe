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
    public class CourseController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;

        public CourseController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
       public IActionResult CourseContent()
        {
            

            ICollection<CourseContent> courseContent = _db.CourseContents.ToList();


            return View(courseContent);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            CourseContent courseFind = _db.CourseContents.Find(id);
            if (courseFind==null)
            {
                return NotFound();
            }
           
            return View(courseFind);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseContent course)
        {
            if (!ModelState.IsValid) return View();
            if (course==null) return NotFound();
            await _db.CourseContents.AddAsync(course);
            await _db.SaveChangesAsync();
            TempData["ContentId"] = course.Id;
            return RedirectToAction("CourseCreate", "Course");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            CourseContent courseContent = await _db.CourseContents.FindAsync(id);
            if (courseContent == null) return NotFound();

            return View(courseContent);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            CourseContent courseContent = await _db.CourseContents.FindAsync(id);
            if (courseContent == null) return NotFound();
            _db.CourseContents.Remove(courseContent);
            await _db.SaveChangesAsync();

            return RedirectToAction("CourseContent", "Course");

        }
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null) return NotFound();
            CourseContent courseContent = await _db.CourseContents.FindAsync(id);
            if (courseContent == null) return NotFound();
            return View(courseContent);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, CourseContent courseContent)
        {
            if (!ModelState.IsValid) return View();
            if (id == null) return NotFound();
            if (courseContent.AboutCourse == null)
            {
                return NotFound();
            }
            bool IsValid = await _db.CourseContents.AnyAsync(c => c.AboutCourse.ToLower() == courseContent.AboutCourse.ToLower());
            if (IsValid)
            {
                ModelState.AddModelError("", "Bu adli content movzuddur !");
                return View();
            }
            CourseContent dbCourseContent = await _db.CourseContents.FindAsync(id);
            dbCourseContent.AboutCourse = courseContent.AboutCourse;
            dbCourseContent.HowToApply = courseContent.HowToApply;
            dbCourseContent.Certification = courseContent.Certification;
            await _db.SaveChangesAsync();
            return RedirectToAction("CourseContent", "Course");

        }
        public IActionResult CourseFeature()
        {

            ICollection<CourseFeature> courseFeature = _db.CourseFeatures.ToList();

            return View(courseFeature);
        }
        public async Task <IActionResult> DetailCourseFature(int? id, CourseFeature courseFeature)
        {
            if (id == null) return NotFound();
               CourseFeature courseFind = await _db.CourseFeatures.FindAsync(id);
            if (courseFind == null)
            {
                return NotFound();
            }

            return View(courseFind);
        }
        public IActionResult CreateCourseFature()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourseFature(CourseFeature course)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (!ModelState.IsValid) return View();
            if (course == null) return NotFound();
            await _db.CourseFeatures.AddAsync(course);
            await _db.SaveChangesAsync();
            TempData["FeatureId"] = course.Id;
            return RedirectToAction("Create", "Course");
        }
        public async Task<IActionResult> DeleteCourseFature(int? id)
        {
            if (id == null) return NotFound();
            CourseFeature courseFeature = await _db.CourseFeatures.FindAsync(id);
            if (courseFeature == null) return NotFound();

            return View(courseFeature);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("DeleteCourseFature")]
        public async Task<IActionResult> DeletePostCourseFature(int? id)
        {
            if (id == null) return NotFound();
            CourseFeature courseFeature = await _db.CourseFeatures.FindAsync(id);
            if (courseFeature == null) return NotFound();
            _db.CourseFeatures.Remove(courseFeature);
            await _db.SaveChangesAsync();
            
            return RedirectToAction("CourseFeature", "Course");
        }

        public async Task<IActionResult> EditCourseFature(int? id)
        {

            if (id == null) return NotFound();
            CourseFeature courseFeature  = await _db.CourseFeatures.FindAsync(id);
            if (courseFeature == null) return NotFound();
            return View(courseFeature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCourseFature(int? id, CourseFeature courseFeature)
        {
            if (!ModelState.IsValid) return View();
            if (id == null) return NotFound();
             CourseFeature dbCourseContent = await _db.CourseFeatures.FindAsync(id);
            
            if (courseFeature == null)
            {
                return NotFound();
            }
            dbCourseContent.Starts = courseFeature.Starts;
            dbCourseContent.Skill_Level = courseFeature.Skill_Level;
            dbCourseContent.Students = courseFeature.Students;
            dbCourseContent.Duration = courseFeature.Duration;
            dbCourseContent.Class_Duration = courseFeature.Class_Duration;
            dbCourseContent.Assesments = courseFeature.Assesments;
            dbCourseContent.Course_Fee = courseFeature.Course_Fee;
            await _db.SaveChangesAsync();
            return RedirectToAction("CourseFeature", "Course");
        }

        public IActionResult Course()
        {


            ICollection<Course> course = _db.Courses.ToList();


            return View(course);
        }

        public IActionResult CourseCreate()
        {
                        
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CourseCreate(Course course)
        {
            //int HomeSliderCount = _db.HomeSliders.Count();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (course.Photo == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!course.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (course.Photo.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }
            int FeauteId = (int)TempData["FeatureId"];
            int CourseId = (int)TempData["ContentId"];

            Course newCourse = _db.Courses.FirstOrDefault();
            course.Image = await course.Photo.SaveImage(_env.WebRootPath, "img/course");
            course.CourseFeatureId = FeauteId;
            course.CourseContentId = CourseId;
            newCourse.Image = course.Image;
            newCourse.Title = course.Title;
            newCourse.Description = course.Description;
            newCourse.CourseContentId = course.CourseContentId;
            newCourse.CourseFeatureId = course.CourseFeatureId;
            await _db.Courses.AddRangeAsync(course);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Course));
        }
    }
}
