using Microsoft.AspNetCore.Mvc;

namespace SampleWebEmployee.Controllers
{
    public class WeatherForcastController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
