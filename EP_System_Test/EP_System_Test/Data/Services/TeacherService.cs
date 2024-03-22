using EP_System_Test.Data.Base;
using EP_System_Test.Data.ViewModels;
using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class TeacherService : EntityBaseRepository<Teacher>,ITeacherService
    {
        private readonly AppDbContext _context;
        public TeacherService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewTeacherAsync(NewTeachersVM data)
        {
            var newTeacher = new Teacher()
            {
                FirstName = data.FirstName, 
                LastName = data.LastName,
                Grade_Teaching = data.Grade_Teaching,
                Address =  data.Address,
                SchoolId = data.SchoolId
            };
            await _context.AddAsync(newTeacher);
            await _context.SaveChangesAsync();


            //Add Teacher Sports
            foreach (var sportId in data.SportIds)
            {
                var newTeacherSports = new Teacher_Sports()
                {
                    TeacherId = newTeacher.Id,
                    SportId = sportId
                };
                await _context.Teachers_Sports.AddAsync(newTeacherSports);
            }
            //Add Teacher Extra
            foreach (var extraId in data.ExtraCurricularIds)
            {
                var newStudentExtra = new Teacher_ExtraCurriculars()
                {
                   TeacherId = newTeacher.Id,
                   ExtraCurricualrId = extraId
                };
                await _context.Teachers_ExtraCurricualrs.AddAsync(newStudentExtra);
            }

            await _context.SaveChangesAsync();

        }

        public async Task<NewTeacherDropdownsVM> GetNewTeacherDropdownsvalues()
        {
            var respose = new NewTeacherDropdownsVM()
            {
                Schools = await _context.School.OrderBy(s => s.School_Name).ToListAsync(),
                Sportss = await _context.Sports.OrderBy(spt => spt.Sport_Name).ToListAsync(),
                ExtraCurriculars = await _context.ExtraCurricualrs.OrderBy(ext => ext.Society_Name).ToListAsync()

            };
            return respose;

        }

    
        public async Task<Teacher> GetTeacherByIdAsync(int id)
        {
            var teacherDetails = await _context.Teacher
                .Include(s => s.School)
                .Include(ext => ext.Teachers_ExtraCurriculars).ThenInclude(e => e.ExtraCurriculars)
                .Include(spt => spt.Teachers_Sports).ThenInclude(s => s.Sports)
                .FirstOrDefaultAsync(n => n.Id == id);
            return teacherDetails;
        }

   
        public async Task UpdateTeacherAsync(NewTeachersVM data)
        {
            var dbTeacher = await _context.Teacher.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbTeacher != null)
            {
                dbTeacher.FirstName = data.FirstName;
                dbTeacher.LastName = data.LastName;
                dbTeacher.Address = data.Address;
                dbTeacher.Grade_Teaching = data.Grade_Teaching;
                dbTeacher.SchoolId = data.SchoolId;

                await _context.SaveChangesAsync();
            }
            //Remove Existing Sports
            var existingTeacherDb = _context.Teachers_Sports.Where(n => n.TeacherId == data.Id).ToList();
            _context.Teachers_Sports.RemoveRange(existingTeacherDb);
            await _context.SaveChangesAsync();

            //Add Teacher Sports
            foreach (var sportId in data.SportIds)
            {
                var newTeacherSports = new Teacher_Sports()
                {
                    TeacherId = data.Id,
                    SportId = sportId
                };
                await _context.Teachers_Sports.AddAsync(newTeacherSports);
            }

            //Remove Existing Teacher Extra

            foreach (var extraId in data.ExtraCurricularIds)
            {
                var newStudentExtra = new Teacher_ExtraCurriculars()
                {
                    TeacherId = data.Id,
                    ExtraCurricualrId = extraId
                };
                await _context.Teachers_ExtraCurricualrs.AddAsync(newStudentExtra);
            }

            await _context.SaveChangesAsync();

            var exsitingExtraDb = _context.Teachers_ExtraCurricualrs.Where(n => n.TeacherId == data.Id).ToList();
            _context.Teachers_ExtraCurricualrs.RemoveRange(exsitingExtraDb);
            await _context.SaveChangesAsync();

            //Add Teacher Extras

      

            //Remove Existing Student Extra Curricualrs
            var existingExtraDb = _context.Student_ExtraCurricular.Where(n => n.StudentId == data.Id).ToList();
            _context.Student_ExtraCurricular.RemoveRange(existingExtraDb);
            await _context.SaveChangesAsync();

            //Add Student Extra Curricualrs

            //foreach(var extraId in data.ExtraCurricularIds)
            //{
            //    var newStudentExtra = new Students_ExtraCurriculars()
            //    {
            //        StudentId = data.Id,
            //        ExtraCurricularId = extraId

            //    };
            //    await _context.Student_ExtraCurricular.AddAsync(newStudentExtra);
            //}

            await _context.SaveChangesAsync();
        }
    }
}
