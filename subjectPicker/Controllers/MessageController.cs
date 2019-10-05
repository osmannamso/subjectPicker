using Microsoft.AspNetCore.Mvc;

namespace subjectPicker.Controllers
{
    public class MessageController : Controller
    {
        // GET
        public IActionResult ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                ViewData["Message"] = "Message is empty";
            }
            else
            {
                ViewData["Message"] = message;
            }

            // ReSharper disable once Mvc.ViewNotResolved
            return View();
        }
    }
}