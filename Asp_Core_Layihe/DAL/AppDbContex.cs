using Asp_Core_Layihe.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.DAL
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex> options) : base(options)
        {
          
         }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<SkillsTeacher> SkillsTeachers { get; set; }
        public DbSet<TeacherContact> TeacherContacts { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet <CourseContent> CourseContents { get; set; }
        
    }
}
