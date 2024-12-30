using Microsoft.AspNetCore.Mvc;

namespace MVCLab_6.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult contact()
        {
            return View();
        }
    }
}
