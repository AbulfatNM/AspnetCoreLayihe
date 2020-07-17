using Asp_Core_Layihe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Layihe.DAL
{
    public class AppDbContex:IdentityDbContext<AppUser>
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
        public DbSet<Bio>Bios  { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet <SubscribeMail>SubscribeMails { get; set; }
        public DbSet<EventToSpeaker> EventToSpeakers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutNotice> AboutNotices { get; set; }
        public DbSet<AboutSlider> AboutSliders { get; set; }
        public DbSet<AboutVideo> AboutVideos { get; set; }
        public DbSet<AboutWelcome> AboutWelcomes { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<Reply> Replies { get; set; }




    }
}
