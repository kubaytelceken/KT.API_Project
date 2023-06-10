using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
