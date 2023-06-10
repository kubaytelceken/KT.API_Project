using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.UI.ViewComponents.Default
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
