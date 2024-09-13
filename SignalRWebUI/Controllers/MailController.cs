using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
