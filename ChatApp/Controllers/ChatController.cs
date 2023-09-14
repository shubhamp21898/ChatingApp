using Microsoft.AspNetCore.Mvc;

public class ChatController : Controller
{
    public IActionResult ChatApp()
    {
        return View();
    }
}
