using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    public class ChatAppController : Controller
    {
        public IActionResult ChatApp()
        {
            return View();
        }
    }
}
