using Microsoft.AspNetCore.Mvc;
using UdemyActivity1.Models;

namespace UdemyActivity1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student",
                DateOfBirth = new DateTime(1954, 12, 01, 12, 23, 59)
            };

            return View(data);
        }
    }
}
