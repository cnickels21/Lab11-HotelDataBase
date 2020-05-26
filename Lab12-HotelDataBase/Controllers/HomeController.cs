using Microsoft.AspNetCore.Mvc;

namespace Lab12_HotelDataBase.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
