using Microsoft.AspNetCore.Mvc;

namespace subjectPicker.Controllers
{
    public class MainController : Controller
    {
        // GET
        public IActionResult Index()
        {
            // ReSharper disable once Mvc.ViewNotResolved
            return View();
        }
    }
}