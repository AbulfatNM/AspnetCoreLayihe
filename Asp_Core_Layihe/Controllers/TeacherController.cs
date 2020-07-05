using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp_Core_Layihe.DAL;
using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task <IActionResult> Details(int id)
        {
           Teacher teachers = await _db.Teachers.FindAsync(id);
            List<TeacherContact> teacherContacts = _db.TeacherContacts.ToList();
            List<SkillsTeacher> skillsTeachers =_db.SkillsTeachers.ToList();

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
    }
}
