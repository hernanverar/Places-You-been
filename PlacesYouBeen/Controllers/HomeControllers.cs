using Microsoft.AspNetCore.Mvc;

namespace PlacesYouBeen.Controllers
{
    public class PlacesYouBeen : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}