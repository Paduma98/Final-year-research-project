using EP_System_Test.Data;
using EP_System_Test.Data.Services;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class ExtraCurricularController : Controller
    {
        private readonly IExtraCurricularService _extraCurricularService;
        public ExtraCurricularController(IExtraCurricularService extraCurricularService)
        {
                _extraCurricularService = extraCurricularService;
        }

        public async Task<IActionResult> Index()
        {
            var allExtras = await _extraCurricularService.GetAll();
            return View(allExtras);

        }

        //Create Get method

        public IActionResult Create()
        {
            return View();
        }

        //Post

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Society_Name")] ExtraCurricular extra)
        {
            if (!ModelState.IsValid)
            {
                return View(extra);
            }

            _extraCurricularService.Add(extra);
            return RedirectToAction("Index");
        }
    }
}
