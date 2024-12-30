using Microsoft.AspNetCore.Mvc;

namespace MVCLab_6.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }
    }
}
