using Academy.Api.Models;
using Academy.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Academy.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _service;

        public HomeController(IUserService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Booking()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Booking(User model)
        {
            if(ModelState.IsValid)
            {
                var result = await _service.InsertAsync(model);

                return RedirectToAction("Result");
            }
            return View(model);
        }
    }
}
