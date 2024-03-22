using EP_System_Test.Data;
using EP_System_Test.Data.Services;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService _service;
        public SchoolController(ISchoolService service)
        {
            _service = service;
        }

        //public IActionResult Index()
        //{
        //    var data = _service.GetAll();
        //    return View(data);
        //}
        public async Task<IActionResult> Index()
        {
            var allSchools = await _service.GetAllAsync();
            return View(allSchools);
        }

        //Get Schools/Create
        public IActionResult Create()
        {
            return View();
        }


        //Http Post Method
        [HttpPost]
        public async Task<IActionResult> Create([Bind("School_Name,Principl_Name,Address,City")] School school)
        {
            if (!ModelState.IsValid)
            {
                return View(school);
            }
            await _service.AddAsync(school);
            return RedirectToAction(nameof(Index));
        }

        //Get request School/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var schoolDetails = await _service.GetByIdAsync(id);
            if (schoolDetails == null) return View("Not Found");
            return View(schoolDetails);

        }

        //Get: School/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var schoolDetails = await _service.GetByIdAsync(id);
            if (schoolDetails == null) return View("NotFound");
            return View(schoolDetails);
        }
        [HttpPost]

        public async Task<IActionResult> Edit(int id, [Bind("Id,School_Name,Principl_Name,Address,City")] School school)
        {
            if (!ModelState.IsValid)
            {
                return View(school);
            }
            await _service.UpdateAsync(id, school);
            return RedirectToAction(nameof(Index));

        }

        //Get School/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var allSchools = await _service.GetByIdAsync(id);
            if (allSchools == null) return View("NotFound");
            return View(allSchools);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var schoolDetails = await _service.GetByIdAsync(id);
            if (schoolDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));


        }

    }
}
