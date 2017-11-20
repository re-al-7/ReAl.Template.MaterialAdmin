using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReAl.Template.MaterialAdmin.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Index(string app = "")
        {
            if (app != "")
                HttpContext.Session.SetString("currentApp", app);

            ViewBag.ListApp = this.GetAplicaciones();
            ViewBag.ListPages = this.GetPages();
            ViewData["Usuario"] = this.getUserName();

            ViewData["app"] = "Your contact page.";
            ViewData["Message"] = "Your contact page.";            
            return View();
        }
    }
}