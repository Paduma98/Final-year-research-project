using EP_System_Test.Data;
using EP_System_Test.Data.Services;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;

        }
        public async Task<IActionResult> Index()
        {
            var allStudents = await _service.GetAllAsync(n => n.School);
            return View(allStudents);
        }

        //Get Students/Create

        public async Task<IActionResult> Create()
        {
            //ViewData["Welcome"] = "Welcome !";
            //ViewBag.Description = "Description";
            var studentDropdownsData = await _service.GetNewStudentDropdownsvalues();
            ViewBag.School = new SelectList(studentDropdownsData.Schools, "Id", "School_Name");
            ViewBag.Teacher = new SelectList(studentDropdownsData.Teachers, "Id", "FirstName");
            ViewBag.Sports = new SelectList(studentDropdownsData.Sport, "Id", "Sport_Name");
            //ViewBag.ExtraCurriculars = new SelectList(studentDropdownsData.ExtraCurriculars, "Id", "Society_Name");
            //ViewBag.Extras = new SelectList(studentDropdownsData.Extra, "Id", "Society_Name");

            return View();
        }

        //Post Students/Create

        [HttpPost]
        //public async Task<IActionResult> Create([Bind("FirstName,Last_Name,Address,Stu_Grade")] Students student)
        public async Task<IActionResult> Create(NewStudentsVM student)
        {
            if (!ModelState.IsValid)
            {
                var studentDropdownsData = await _service.GetNewStudentDropdownsvalues();
                ViewBag.School = new SelectList(studentDropdownsData.Schools, "Id", "School_Name");
                ViewBag.Teacher = new SelectList(studentDropdownsData.Teachers, "Id", "FirstName");
                ViewBag.Sports = new SelectList(studentDropdownsData.Sport, "Id", "Sport_Name");
                //ViewBag.ExtraCurriculars = new SelectList(studentDropdownsData.ExtraCurriculars, "Id", "Society_Name");
                //ViewBag.Extras = new SelectList(studentDropdownsData.Extra, "Id", "Society_Name");


                return View(student);
            }
            await _service.AddNewStudentAsync(student);
            return RedirectToAction(nameof(Index));

        }

        //Get Request Student/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var studentDetails = await _service.GetStudentByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        //Get Request Student/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var studentDetails = await _service.GetStudentByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            //return View(studentDetails);

            var response = new NewStudentsVM()
            {
                Id = studentDetails.Id,
                FirstName = studentDetails.FirstName,
                Last_Name = studentDetails.Last_Name,
                Address = studentDetails.Address,
                Stu_Grade = studentDetails.Stu_Grade,
                SchoolId = (int)studentDetails.SchoolId,
                SportIds = studentDetails.Stu_Sports.Select(n => n.SportsId).ToList(),
                //ExtraCurricularIds = studentDetails.StuExtraCurriculars.Select(n => n.ExtraCurricularId).ToList(),
                TeacherId = studentDetails.Students_Teachers.Select(n => n.TeacherId).ToList(),

            };

            var studentDropdownsData = await _service.GetNewStudentDropdownsvalues();
            ViewBag.School = new SelectList(studentDropdownsData.Schools, "Id", "School_Name");
            ViewBag.Teacher = new SelectList(studentDropdownsData.Teachers, "Id", "FirstName");
            ViewBag.Sports = new SelectList(studentDropdownsData.Sport, "Id", "Sport_Name");
            //ViewBag.Extras = new SelectList(studentDropdownsData.Extra, "Id", "Society_Name");


            return View(response);
        
        }

        //Post Method of Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewStudentsVM student)
        {
            if (id != student.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                var studentDropdownsData = await _service.GetNewStudentDropdownsvalues();
                ViewBag.School = new SelectList(studentDropdownsData.Schools, "Id", "School_Name");
                ViewBag.Teacher = new SelectList(studentDropdownsData.Teachers, "Id", "FirstName");
                ViewBag.Sports = new SelectList(studentDropdownsData.Sport, "Id", "Sport_Name");
                //ViewBag.Extras = new SelectList(studentDropdownsData.Extra, "Id", "Society_Name");
                return View(student);
            }
            await _service.UpdateStudentAsync(student);
            return RedirectToAction(nameof(Index));
        }


        //Student/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var studentDetails = await _service.GetStudentByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            return View(studentDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDetails = await _service.GetStudentByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
