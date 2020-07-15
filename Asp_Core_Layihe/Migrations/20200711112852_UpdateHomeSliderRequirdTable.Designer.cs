﻿// <auto-generated />
using System;
using Asp_Core_Layihe.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp_Core_Layihe.Migrations
{
    [DbContext(typeof(AppDbContex))]
    [Migration("20200711112852_UpdateHomeSliderRequirdTable")]
    partial class UpdateHomeSliderRequirdTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Asp_Core_Layihe.Models.AboutNotice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasMaxLength(150);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("AboutNotices");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.AboutSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundImage");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(350);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("AboutSliders");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.AboutVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("VideoLink");

                    b.HasKey("Id");

                    b.ToTable("AboutVideos");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.AboutWelcome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Image");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("AboutWelcomes");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Facebook");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Logo")
                        .IsRequired();

                    b.Property<string>("SmalLogoBlack");

                    b.Property<string>("SmalLogoWhite");

                    b.Property<string>("Tiwitter");

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId")
                        .IsRequired();

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Image");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseContentId");

                    b.Property<int>("CourseFeatureId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Id");

                    b.HasIndex("CourseContentId")
                        .IsUnique();

                    b.HasIndex("CourseFeatureId")
                        .IsUnique();

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.CourseContent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCourse")
                        .HasMaxLength(400);

                    b.Property<string>("Certification")
                        .HasMaxLength(400);

                    b.Property<string>("HowToApply")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.CourseFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assesments")
                        .IsRequired();

                    b.Property<string>("Class_Duration")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<double>("Course_Fee");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Skill_Level");

                    b.Property<string>("Starts")
                        .IsRequired()
                        .HasMaxLength(65);

                    b.Property<int>("Students");

                    b.HasKey("Id");

                    b.ToTable("CourseFeatures");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<DateTime>("StartTime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("Venue")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.EventToSpeaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<int>("SpeakerId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventToSpeakers");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.HomeSlider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Image");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("HomeSliders");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.SkillsTeacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Communication");

                    b.Property<int>("Design");

                    b.Property<int>("Development");

                    b.Property<int>("Innovation");

                    b.Property<int>("Language");

                    b.Property<int>("Team_Leader");

                    b.HasKey("Id");

                    b.ToTable("SkillsTeachers");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(65);

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.SubscribeMail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.HasKey("Id");

                    b.ToTable("SubscribeMails");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(350);

                    b.Property<string>("DEGREE")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("EXPERIENCE")
                        .IsRequired()
                        .HasMaxLength(55);

                    b.Property<string>("FACULTY")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("HOBBIES");

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<int>("SkillsTeacherId");

                    b.Property<int>("TeacherContactId");

                    b.HasKey("Id");

                    b.HasIndex("SkillsTeacherId")
                        .IsUnique();

                    b.HasIndex("TeacherContactId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.TeacherContact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<string>("Facebook");

                    b.Property<string>("Linkedin");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("SKYPE");

                    b.Property<string>("Twitter");

                    b.HasKey("Id");

                    b.ToTable("TeacherContacts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Blog", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Course", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.CourseContent", "CourseContent")
                        .WithOne("Course")
                        .HasForeignKey("Asp_Core_Layihe.Models.Course", "CourseContentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Asp_Core_Layihe.Models.CourseFeature", "CourseFeature")
                        .WithOne("Course")
                        .HasForeignKey("Asp_Core_Layihe.Models.Course", "CourseFeatureId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.EventToSpeaker", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.Event", "Event")
                        .WithMany("EventToSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Asp_Core_Layihe.Models.Speaker", "Speaker")
                        .WithMany("EventToSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Asp_Core_Layihe.Models.Teacher", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.SkillsTeacher", "SkillsTeacher")
                        .WithOne("Teacher")
                        .HasForeignKey("Asp_Core_Layihe.Models.Teacher", "SkillsTeacherId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Asp_Core_Layihe.Models.TeacherContact", "TeacherContact")
                        .WithOne("Teacher")
                        .HasForeignKey("Asp_Core_Layihe.Models.Teacher", "TeacherContactId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Asp_Core_Layihe.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Asp_Core_Layihe.Models.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}