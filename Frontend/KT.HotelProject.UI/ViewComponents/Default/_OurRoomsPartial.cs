using Microsoft.AspNetCore.Mvc;

namespace KT.HotelProject.UI.ViewComponents.Default
{
    public class _OurRoomsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
