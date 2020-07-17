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
    public class TeacherController : Controller
    {
        private readonly AppDbContex _db;
        private readonly IHostingEnvironment _env;
        public TeacherController(AppDbContex db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        
        public async Task<IActionResult>  Index()
        {
            ICollection<Teacher> teachers =await  _db.Teachers.ToListAsync();

            return View(teachers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeacherVM createTeacherVM)
        {
           Teacher  teacher = await _db.Teachers.FirstOrDefaultAsync();
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync();
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync();

            if (createTeacherVM.Teacher.PhotoTeacher == null)
            {
                ModelState.AddModelError("", "Zehmet olmasa şəkil seçin !");
                return View();
            }
            if (!createTeacherVM.Teacher.PhotoTeacher.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                return View();
            }
            if (createTeacherVM.Teacher.PhotoTeacher.MaxLenght(500))
            {
                ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                return View();
            }

            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                SkillsTeacher = skillsTeacher,
                TeacherContact = teacherContact
            };
            SkillsTeacher skills_Teacher = createTeacherVM.SkillsTeacher;
            TeacherContact contact = createTeacherVM.TeacherContact;
            teacher = createTeacherVM.Teacher;
            teacher.SkillsTeacher = skills_Teacher;
            teacher.TeacherContact = contact;
            createTeacherVM.Teacher.Image = await createTeacherVM.Teacher.PhotoTeacher.SaveImage(_env.WebRootPath, "img/teacher");
            _db.Teachers.Add(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FindAsync(id);
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync(c => c.Id == teacher.TeacherContactId);
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync(c => c.Id == teacher.SkillsTeacherId);
            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                TeacherContact = teacherContact,
                SkillsTeacher = skillsTeacher
            };

            if (teacherVM == null) return NotFound();
            return View(teacherVM);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FindAsync(id);
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync(c => c.Id == teacher.TeacherContactId);
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync(c => c.Id == teacher.SkillsTeacherId);
            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                TeacherContact = teacherContact,
                SkillsTeacher = skillsTeacher
            };
            if (teacherVM == null) return NotFound();
            return View(teacherVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, TeacherVM teacherEdit)
        {
            Teacher teacher = await _db.Teachers.FindAsync(id);
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync(c => c.Id == teacher.TeacherContactId);
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync(c => c.Id == teacher.SkillsTeacherId);
            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                TeacherContact = teacherContact,
                SkillsTeacher = skillsTeacher
            };

            if (teacherEdit == null) return NotFound();
            if (id == null) return NotFound();

            if (teacherEdit.Teacher.PhotoTeacher != null)
            {
                if (!teacherEdit.Teacher.PhotoTeacher.IsImage())
                {
                    ModelState.AddModelError("Photo", "Zehmet olmasa şəkil formati seçin !");
                    return View();
                }
                if (teacherEdit.Teacher.PhotoTeacher.MaxLenght(500))
                {
                    ModelState.AddModelError("Photo", "Secilen şəkil olcusu maksimum 500kb olmalidi seçin !");
                    return View();
                }
                PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/teacher", teacherVM.Teacher.Image);
                teacherVM.Teacher.Image = await teacherEdit.Teacher.PhotoTeacher.SaveImage(_env.WebRootPath, "img/teacher");
            }
            teacherVM.Teacher.FullName = teacherEdit.Teacher.FullName;
            teacherVM.Teacher.About = teacherEdit.Teacher.About;
            teacherVM.Teacher.DEGREE = teacherEdit.Teacher.DEGREE;
            teacherVM.Teacher.EXPERIENCE = teacherEdit.Teacher.EXPERIENCE;
            teacherVM.Teacher.HOBBIES = teacherEdit.Teacher.HOBBIES;
            teacherVM.Teacher.FACULTY = teacherEdit.Teacher.FACULTY;
            teacherVM.Teacher.Position = teacherEdit.Teacher.Position;
            teacher.TeacherContact.Email = teacherEdit.TeacherContact.Email;
            teacher.TeacherContact.Phone = teacherEdit.TeacherContact.Phone;
            teacher.TeacherContact.Facebook = teacherEdit.TeacherContact.Facebook;
            teacher.TeacherContact.SKYPE = teacherEdit.TeacherContact.SKYPE;
            teacher.TeacherContact.Linkedin = teacherEdit.TeacherContact.Linkedin;
            teacher.TeacherContact.Twitter = teacherEdit.TeacherContact.Twitter;
            teacher.SkillsTeacher.Language = teacherEdit.SkillsTeacher.Language;
            teacher.SkillsTeacher.Team_Leader = teacherEdit.SkillsTeacher.Team_Leader;
            teacher.SkillsTeacher.Development = teacherEdit.SkillsTeacher.Development;
            teacher.SkillsTeacher.Design = teacherEdit.SkillsTeacher.Design;
            teacher.SkillsTeacher.Innovation = teacherEdit.SkillsTeacher.Innovation;
            teacher.SkillsTeacher.Communication = teacherEdit.SkillsTeacher.Communication;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Teacher teacher = await _db.Teachers.FindAsync(id);
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync(c => c.Id == teacher.TeacherContactId);
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync(c => c.Id == teacher.SkillsTeacherId);
          
            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                TeacherContact = teacherContact,
                SkillsTeacher = skillsTeacher
            };

            if (teacherVM == null) return NotFound();
            return View(teacherVM);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();

            Teacher teacher = await _db.Teachers.FindAsync(id);
            TeacherContact teacherContact = await _db.TeacherContacts.FirstOrDefaultAsync(c => c.Id == teacher.TeacherContactId);
            SkillsTeacher skillsTeacher = await _db.SkillsTeachers.FirstOrDefaultAsync(c => c.Id == teacher.SkillsTeacherId);

            TeacherVM teacherVM = new TeacherVM()
            {
                Teacher = teacher,
                TeacherContact = teacherContact,
                SkillsTeacher = skillsTeacher
            };
            if (teacherVM == null) return NotFound();
            PhotoFileDelete.IsDeletePhoto(_env.WebRootPath, "img/teacher", teacherVM.Teacher.Image);
            _db.TeacherContacts.Remove(teacherVM.TeacherContact);
            _db.SkillsTeachers.Remove(teacherVM.SkillsTeacher);
            _db.Teachers.Remove(teacherVM.Teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
