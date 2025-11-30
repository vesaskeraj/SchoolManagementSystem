using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using S.M.S.Models;



namespace S.M.S.Repositories
{
       public class ApplicationDbContext : IdentityDbContext
        { 

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            { 
            
            
            }
            public DbSet<ApplicationUser> ApplicationUsers { get; set; }

            public DbSet<Student> Students { get; set; }

            public DbSet<Teacher> Teachers { get; set; }

            public DbSet<Session> YearlySessions { get; set; }

            public DbSet<Grade> Grades { get; set; }

            public DbSet<Enroll> Enrolls { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // AssignGrade → Grade (one-to-many)
            builder.Entity<AssignGrade>()
                .HasOne(x => x.Grade)
                .WithMany(z => z.AssignGrades)
                .HasForeignKey(x => x.GradeId)
                .OnDelete(DeleteBehavior.SetNull);

            // AssignGrade → Teacher (one-to-many)
            builder.Entity<AssignGrade>()
                .HasOne(x => x.Teacher)
                .WithMany(z => z.AssignGrades)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // Enroll → Student (one-to-many)
            builder.Entity<Enroll>()
                .HasOne(x => x.Student)
                .WithMany(z => z.YearlySessions)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.SetNull);

            // Enroll → Session (one-to-many)
            builder.Entity<Enroll>()
                .HasOne(x => x.Session)
                .WithMany(z => z.Enrollment)
                .HasForeignKey(x => x.SessionId)
                .OnDelete(DeleteBehavior.SetNull);

            // Enroll → Grade (one-to-many)
            builder.Entity<Enroll>()
                .HasOne(x => x.Grade)
                .WithMany(z => z.Enrolls)
                .HasForeignKey(x => x.GradeId)
                .OnDelete(DeleteBehavior.SetNull);

            // TeacherSession → Teacher (one-to-many)
            builder.Entity<TeacherSession>()
                .HasOne(x => x.Teacher)
                .WithMany(z => z.TeacherSessions)
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.SetNull);

            // TeacherSession → Session (one-to-many)
            builder.Entity<TeacherSession>()
                .HasOne(x => x.Session)
                .WithMany(z => z.TeacherSessions)
                .HasForeignKey(x => x.SessionId)
                .OnDelete(DeleteBehavior.NoAction);


            base.OnModelCreating(builder);

        }






        }





}
