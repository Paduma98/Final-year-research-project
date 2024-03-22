using EP_System_Test.Data;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EP_System_Test.Data.Static;
using EP_System_Test.Data.ViewModels;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class SchoolAccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        public SchoolAccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
         public async Task<IActionResult> Users()
        {
            //var users = await _context.Users.ToListAsync();
            //return View(users);
            return View();
        }
        public IActionResult Registeras()
        {
           
            return View();
        }
        public IActionResult Loginas()
        {
            
            return View();
        }

        public IActionResult Login() => View(new LoginVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid) return View(loginVM);
            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("AdminDashboard", "Account");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again!";
                return View(loginVM);
            }
            TempData["Error"] = "Wrong credentials. Please, try again!";
            return View(loginVM);
        }
        public IActionResult Register() => View(new SchoolRegisterVM());
        [HttpPost]
        public async Task<IActionResult> Register(SchoolRegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View(registerVM);
            var user = await _userManager.FindByEmailAsync(registerVM.EmailAddress);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }
            var newUser = new ApplicationUser()
            {
                //FirstName = registerVM.FirstName,
                //LastName = registerVM.LastName,
                SchoolName = registerVM.SchoolName,
                Email = registerVM.EmailAddress,
                UserName = registerVM.EmailAddress
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.School);
            return View("RegisterCompleted");
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("AdminDashboard", "Account");
        }
    }
}
