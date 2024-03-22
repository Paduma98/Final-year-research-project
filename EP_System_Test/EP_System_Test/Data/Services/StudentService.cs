using EP_System_Test.Data.Base;
using EP_System_Test.Data.ViewModels;
using EP_System_Test.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Data.Services
{
    public class StudentService : EntityBaseRepository<Students>, IStudentService
    {
        private readonly AppDbContext _context;
        public StudentService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Students> GetStudentByIdAsync(int id)
        {
            var studentDetails = await _context.Student
                .Include(s => s.School)
                .Include(st => st.Students_Teachers).ThenInclude(t => t.Teacher)
                .Include(spt => spt.Stu_Sports).ThenInclude(sp => sp.Sports)
                .Include(scr => scr.StuExtraCurriculars).ThenInclude(extr => extr.ExtraCurricular)
                .FirstOrDefaultAsync(n => n.Id == id);
            return studentDetails;
        }

        public async Task<NewStudentDropdownsVM> GetNewStudentDropdownsvalues()
        {
            var response = new NewStudentDropdownsVM()
            {
                Teachers = await _context.Teacher.OrderBy(t => t.FirstName).ToListAsync(),
                Schools = await _context.School.OrderBy(s => s.School_Name).ToListAsync(),
                Sport = await _context.Sports.OrderBy(spt => spt.Sport_Name).ToListAsync()
            };

            return response;
        }
        public async Task AddNewStudentAsync(NewStudentsVM data)
        {
            var newStudent = new Students()
            {
                FirstName = data.FirstName,
                Last_Name = data.Last_Name,
                Stu_Grade = data.Stu_Grade,
                Address = data.Address,
                SchoolId = data.SchoolId


            };
            await _context.Student.AddAsync(newStudent);
            await _context.SaveChangesAsync();


            //Add Teacher Students
            foreach (var teacherId in data.TeacherId)
            {
                var newStudentTeacher = new Student_Teacher()
                {
                    StudentId = newStudent.Id,
                    TeacherId = teacherId
                };
                await _context.Students_Teachers.AddAsync(newStudentTeacher);
            }
            //Add Student Sports
            foreach (var sportId in data.SportIds)
            {
                var newStudentSport = new Students_Sports()
                {
                    StudentId = newStudent.Id,
                    SportsId = sportId
                };
                await _context.Student_Sport.AddAsync(newStudentSport);
            }

            //Add Student Extra Curricualr Activities
           //foreach(var extraId in data.ExtraCurricularIds)
           //{
           //    var newStudentExtra = new Students_ExtraCurriculars()
           //     {
           //         StudentId = newStudent.Id,
           //         ExtraCurricularId = extraId
           //     };
           //     await _context.Student_ExtraCurricular.AddAsync(newStudentExtra);
           // }

            await _context.SaveChangesAsync();
        }
        public async Task UpdateStudentAsync(NewStudentsVM data)
        {
            var dbStudents = await _context.Student.FirstOrDefaultAsync(n => n.Id == data.Id);
            if(dbStudents != null)
            {
                dbStudents.FirstName = data.FirstName;
                dbStudents.Last_Name = data.Last_Name;
                dbStudents.Address = data.Address;
                dbStudents.Stu_Grade= data.Stu_Grade;
                dbStudents.SchoolId = data.SchoolId;

                await _context.SaveChangesAsync();
            }
            //Remove Existing Teachers
            var existingTeacherDb = _context.Students_Teachers.Where(n => n.StudentId == data.Id).ToList();
            _context.Students_Teachers.RemoveRange(existingTeacherDb);
            await _context.SaveChangesAsync();

            //Add Student Teachers
            foreach (var teacherId in data.TeacherId)
            {
                var newStudentTeacher = new Student_Teacher()
                {
                    StudentId = data.Id,
                    TeacherId = teacherId
                };
                await _context.Students_Teachers.AddAsync(newStudentTeacher);
            }

            //Remove Existing Student Sports

            var exsitingSporstDb = _context.Student_Sport.Where(n => n.StudentId == data.Id).ToList();
            _context.Student_Sport.RemoveRange(exsitingSporstDb);
            await _context.SaveChangesAsync();  

            //Add Student Sports

            foreach(var sportId in data.SportIds)
            {
                var newStudentSport = new Students_Sports()
                {
                    StudentId = data.Id,
                    SportsId = sportId
                };
                await _context.Student_Sport.AddAsync(newStudentSport);
            }

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
