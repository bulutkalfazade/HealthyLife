using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    public class GirisYapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        } 
    }
}
