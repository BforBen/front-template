using System;
using System.Web.Mvc;

namespace GuildfordBoroughCouncil.Web.FrontTemplateDemo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("~/{mode?}")]
        public ActionResult Index(string Mode = "")
        {
            if (Mode == "legacy")
            {
                ViewData["LegacyMode"] = true;
            }

            return View();
        }

        [HttpGet]
        [Route("~/error/{mode?}")]
        public ActionResult Error(string Mode = "")
        {
            if (Mode == "legacy")
            {
                ViewData["LegacyMode"] = true;
            }

            throw new Exception("Just testing");
        }
    }
}