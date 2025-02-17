using EF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF02
{
    internal class ITIDbContext2:DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;Database=ITIDb2;Trusted_Connection=true;trustservercertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Department>()
                .HasOne(d=>d.Ins)
                .WithMany(i=>i.Departments)
                .HasForeignKey(d=>d.Ins_ID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Course_Inst>()
                .HasKey(ci => new { ci.Course_ID, ci.inst_ID });
            modelBuilder.Entity<Stud_Course>()
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
    }
}
