using EP_System_Test.Data;
using EP_System_Test.Data.Services;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _service;
        public TeacherController(ITeacherService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allTeachers = await _service.GetAllAsync();
            return View(allTeachers);
        }

        //Get Teacher/Create

        public async Task<IActionResult> Create()
        {
            var teacherDropdownsData = await _service.GetNewTeacherDropdownsvalues();
            ViewBag.School = new SelectList(teacherDropdownsData.Schools, "Id", "School_Name");
            ViewBag.Sports = new SelectList(teacherDropdownsData.Sportss, "Id", "Sport_Name");
            ViewBag.ExtraCurriculars = new SelectList(teacherDropdownsData.ExtraCurriculars, "Id", "Society_Name");
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(NewTeachersVM teacher)
        {
            if (!ModelState.IsValid)
            {
                var teacherDropdownsData = await _service.GetNewTeacherDropdownsvalues();
                ViewBag.School = new SelectList(teacherDropdownsData.Schools, "Id", "School_Name");
                ViewBag.Sports = new SelectList(teacherDropdownsData.Sportss, "Id", "Sport_Name");
                ViewBag.ExtraCurriculars = new SelectList(teacherDropdownsData.ExtraCurriculars, "Id", "Society_Name");

                return View(teacher);
            }
            await _service.AddNewTeacherAsync(teacher);
            return RedirectToAction("Index");
        }

        //Teacher/Details
        public async Task<IActionResult> Details(int id)
        {
            var teacherDetails = await _service.GetTeacherByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        //Get Request Teacher/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var teacherDetails = await _service.GetTeacherByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            // return View(teacherDetails);    
            var response = new NewTeachersVM()
            {
                Id = teacherDetails.Id,
                FirstName = teacherDetails.FirstName,
                LastName = teacherDetails.LastName,
                Address = teacherDetails.Address,
                SchoolId = (int)teacherDetails.SchoolId,
                SportIds = teacherDetails.Teachers_Sports.Select(n => n.SportId).ToList(),
                ExtraCurricularIds = teacherDetails.Teachers_ExtraCurriculars.Select(n => n.ExtraCurricualrId).ToList(),


            };
            var teacherDropdownsData = await _service.GetNewTeacherDropdownsvalues();
            ViewBag.School = new SelectList(teacherDropdownsData.Schools, "Id", "School_Name");
            ViewBag.Sports = new SelectList(teacherDropdownsData.Sportss, "Id", "Sport_Name");
            ViewBag.ExtraCurriculars = new SelectList(teacherDropdownsData.ExtraCurriculars, "Id", "Society_Name");
            return View(response);

        }

        //Post Method of Edit
        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewTeachersVM teacher)
        {
            if (id != teacher.Id) return View("NotFound");
            if (!ModelState.IsValid)
            {
                var teacherDropdownsData = await _service.GetNewTeacherDropdownsvalues();
                ViewBag.School = new SelectList(teacherDropdownsData.Schools, "Id", "School_Name");
                ViewBag.Sports = new SelectList(teacherDropdownsData.Sportss, "Id", "Sport_Name");
                ViewBag.ExtraCurriculars = new SelectList(teacherDropdownsData.ExtraCurriculars, "Id", "Society_Name");
                return View(teacher);
            }
            await _service.UpdateTeacherAsync(teacher);
            return RedirectToAction(nameof(Index));
        }


        //Student/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var studentDetails = await _service.GetTeacherByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            return View(studentDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDetails = await _service.GetTeacherByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}


