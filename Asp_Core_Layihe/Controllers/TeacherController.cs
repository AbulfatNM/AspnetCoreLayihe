using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Asp_Core_Layihe.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Asp_Core_Layihe.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContex _db;
        public TeacherController(AppDbContex db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Teacher> teachers = _db.Teachers.ToList();
            List<TeacherContact> teacherContacts = _db.TeacherContacts.ToList();
            if (teacherContacts==null)
            {
                return NotFound();
            }
                return View(teachers);
            
        }
        //[Authorize]
        public async Task <IActionResult> Details(int? id)
        {

           Teacher teachers = await _db.Teachers.FindAsync(id);
            if (teachers == null)
            {
                return NotFound();
            }
            List<TeacherContact> teacherContacts = _db.TeacherContacts.ToList();
            List<SkillsTeacher> skillsTeachers =_db.SkillsTeachers.ToList();
            if (id==null)
            {
                return NotFound();
            }
            if (teacherContacts == null)
            {
                return NotFound();
            }
            if (skillsTeachers==null)
            {
                return NotFound();
            }
            return View(teachers);
        }
        public IActionResult TeacherSerach(string search)
        {
            List<Teacher> teachers = _db.Teachers.Where(t => t.FullName.Contains(search)).OrderByDescending(p => p.Id).Take(5).ToList();

            SearchVM searchVM = new SearchVM()
            {
                Teacher = teachers
            };

            return PartialView("_SearchPartial", searchVM);
        }
    
    }
}
