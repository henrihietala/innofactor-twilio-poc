using System;
using System.Web.Mvc;

namespace BrowserCalls.Web.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Initiate video call with Dashboard-user
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// Initiate a Twilio call to Dashboard-user
        /// </summary>
        /// <returns></returns>
        public ActionResult Caller()
        {
            return View();
        }

    }
}
