﻿// <auto-generated />
using Asp_Core_Layihe.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Asp_Core_Layihe.Migrations
{
    [DbContext(typeof(AppDbContex))]
    [Migration("20200705125049_CreateCourseTable")]
    partial class CreateCourseTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("courseContents");
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
#pragma warning restore 612, 618
        }
    }
}
