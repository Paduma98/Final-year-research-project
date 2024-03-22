using Microsoft.AspNetCore.Mvc;

namespace EP_System_Test.Controllers
{
    public class Test : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
