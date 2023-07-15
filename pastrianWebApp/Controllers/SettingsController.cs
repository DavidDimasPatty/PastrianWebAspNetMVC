using pastrianWebApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pastrianWebApp.Controllers
{
  
    public class SettingsController : Controller
    {
        private readonly webService webService= new webService();

        [HttpGet]
        public ActionResult Settings()
        {
            return View(webService.Get());
        }
    }
}