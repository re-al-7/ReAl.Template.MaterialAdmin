using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Test.CoreMvc.Dal.Entidades;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Test.CoreMvc.Controllers
{
    [Authorize]
    public class DashboardController : BaseController
    {
        // GET: Dashboard
        public ActionResult Index(string app = "")
        {
            if (app != "")
                HttpContext.Session.SetString("currentApp", app);

            ViewBag.ListApp = this.getAplicaciones();
            ViewBag.ListPages = this.getPages();
            ViewData["Usuario"] = this.getUserName();

            ViewData["app"] = "Your contact page.";
            ViewData["Message"] = "Your contact page.";            
            return View();
        }
    }
}