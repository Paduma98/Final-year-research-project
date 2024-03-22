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
    public class SportsController : Controller
    {
        private readonly ISportService _service;

            public SportsController(ISportService service)
        {
            _service   = service;
        }
        public async Task<IActionResult> Index()
        {
            var allSports = await _service.GetAll();
            return View(allSports);
            
        }

        //Create Get method

        public IActionResult Create()
        {
            return View();
        }

        //Post

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Sport_Name")]Sports sports)
        {
            if (!ModelState.IsValid)
            {
                return View(sports);
            }
            _service.Add(sports);
            return RedirectToAction("Index");
        }
    }
}
