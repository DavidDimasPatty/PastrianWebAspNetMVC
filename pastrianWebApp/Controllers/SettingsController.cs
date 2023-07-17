using pastrianWebApp.Models;
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
       
        private  webServiceUser _webService = new webServiceUser();

        [HttpGet]
        public ActionResult Settings()
        {
            return View(_webService.Get());
        }
    }
}