using EP_System_Test.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students_Sports>().HasKey(sp => new
            {
                sp.StudentId,
                sp.SportsId
            });

            modelBuilder.Entity<Students_Sports>().HasOne(s => s.Student).WithMany(sp => sp.Stu_Sports).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Students_Sports>().HasOne(spor => spor.Sports).WithMany(sp => sp.Student_Sports).HasForeignKey(spr => spr.SportsId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Students_ExtraCurriculars>().HasKey(se => new
            { 
                se.StudentId,
                se.ExtraCurricularId
                
            });

            modelBuilder.Entity<Students_ExtraCurriculars>().HasOne(s => s.Student).WithMany(se => se.StuExtraCurriculars).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Students_ExtraCurriculars>().HasOne(ex => ex.ExtraCurricular).WithMany(ext => ext.Students_Extras).HasForeignKey(ec => ec.ExtraCurricularId).OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<Teacher_ExtraCurriculars>().HasKey(tex => new
            {

                tex.ExtraCurricualrId,
                tex.TeacherId

            });
            modelBuilder.Entity<Teacher_ExtraCurriculars>().HasOne(t => t.Teachers).WithMany(te => te.Teachers_ExtraCurriculars).HasForeignKey(t => t.TeacherId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Teacher_ExtraCurriculars>().HasOne(ex => ex.ExtraCurriculars).WithMany(ext => ext.ExtraCurriculars_Teachers).HasForeignKey(ex => ex.ExtraCurricualrId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Teacher_Sports>().HasKey(tsp => new
            {
                tsp.SportId,
                tsp.TeacherId

            });
            modelBuilder.Entity<Teacher_Sports>().HasOne(t => t.Teachers).WithMany(tsp => tsp.Teachers_Sports).HasForeignKey(t => t.TeacherId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Teacher_Sports>().HasOne(sp => sp.Sports).WithMany(spt => spt.Sports_Teachers).HasForeignKey(s => s.SportId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Student_Teacher>().HasKey(st => new
            {
                st.TeacherId,
                st.StudentId
            });

            modelBuilder.Entity<Student_Teacher>().HasOne(s => s.Students).WithMany(st => st.Students_Teachers).HasForeignKey(s => s.StudentId).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Student_Teacher>().HasOne(t => t.Teacher).WithMany(ts => ts.Teachers_Students).HasForeignKey(t => t.TeacherId).OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Students> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<ExtraCurricular> ExtraCurricualrs { get; set; }
        public DbSet<School> School { get; set; }
        public DbSet<Students_Sports> Student_Sport { get; set; }
        public DbSet<Students_ExtraCurriculars> Student_ExtraCurricular { get; set; }
        public DbSet<Teacher_Sports> Teachers_Sports { get; set; }
        public DbSet<Teacher_ExtraCurriculars> Teachers_ExtraCurricualrs { get; set; }
        public DbSet<Student_Teacher> Students_Teachers { get; set; }
        public DbSet<Post> Post { get;set; }

    }
}
