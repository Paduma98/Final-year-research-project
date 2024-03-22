using EP_System_Test.Data.Services;
using EP_System_Test.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EP_System_Test.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _service;

        public PostController(IPostService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allPosts = await _service.GetAllAsync();
            return View(allPosts);
        }

        //GET: producers/details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var postDetails = await _service.GetByIdAsync(id);
            if (postDetails == null) return View("NotFound");
            return View(postDetails);
        }

        //GET: producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Description,Title")] Post post)
        {
            if (!ModelState.IsValid) return View(post);

            await _service.AddAsync(post);
            return RedirectToAction(nameof(Index));
        }

        //GET: producers/edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var postDetails = await _service.GetByIdAsync(id);
            if (postDetails == null) return View("NotFound");
            return View(postDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Title")] Post post)
        {
            if (!ModelState.IsValid) return View(post);

            if (id == post.Id)
            {
                await _service.UpdateAsync(id, post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }

        //GET: producers/delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var postDetails = await _service.GetByIdAsync(id);
            if (postDetails == null) return View("NotFound");
            return View(postDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var postDetails = await _service.GetByIdAsync(id);
            if (postDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
