using Microsoft.AspNetCore.Mvc;

namespace DMS_API.Controllers
{
    public class DonorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
