using System.Web.Mvc;

namespace PersonalityAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Result(string choice)
        {
            string result = "";

            switch (choice)
            {
                case "loin":
                    result = "You are brave, confident and natural leader.";
                    break;

                case "ocean":
                    result = "You are calm, peaceful and emotionally balanced.";
                    break;

                case "butterfly":
                    result = "You are creative, artistic and love freedom.";
                    break;

                case "mountain":
                    result = "You are strong, determined and hardworking.";
                    break;

                default:
                    result = "Unique personality detected.";
                    break;
            }

            ViewBag.Result = result;

            return View();
        }
    }
}