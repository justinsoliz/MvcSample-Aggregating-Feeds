using System.Web.Mvc;
using Api;

namespace MvcApplication1.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index() {
            ViewData["Message"] = 
                "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About() {
            return View();
        }

        public ViewResult Feed(){
            var feed = new Feed();
            var model = feed.Stream();
            return View(model);
        }
    }
}
